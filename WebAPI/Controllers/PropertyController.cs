using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Dtos;
using WebAPI.Interface;
using WebAPI.Interfaces;
using WebAPI.Model;
using WebAPI.Srervices;

namespace WebAPI.Controllers
{
    public class PropertyController : BaseController
    {
        private readonly InterfaceUnitofWork uow;
        private readonly IMapper mapper;
        private readonly IphotoService photoService;

        public PropertyController(InterfaceUnitofWork uow, IMapper mapper, IphotoService photoService)
        {
            this.uow = uow;
            this.mapper = mapper;
            this.photoService = photoService;
        }

        [HttpGet("list/{sellRent}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPropertyList(int sellRent)
        {
            var properties = await uow.PropertyRepository.GetPropertiesAsync(sellRent);
            // Assuming 'properties' is directly serializable, you can return it directly
            var propertyListDTO = mapper.Map<IEnumerable<PropertyListDto>>(properties);
            return Ok(propertyListDTO);
        }

        //property/detail/1
        [HttpGet("detail/{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPropertyDetail(int id)
        {
            var property = await uow.PropertyRepository.GetPropertyDetailAsync(id);
            var propertyDTO = mapper.Map<PropertyDetailDto>(property);
            return Ok(propertyDTO);
        }

        [HttpPost("add")]
        [Authorize]
        public async Task<IActionResult> AddProperty(PropertyDto propertydto)
        {
            var property = mapper.Map<Property>(propertydto);

            var userId = GetUserId();
            property.PostedBy = userId;
            property.LastUpdatedBy = userId;
            //property.PostedBy = 1;
            //property.CarpetArea = 230;
            //property.Address = "street no.2 india";
            //property.FloorNo = 2;
            //property.TotalFloors = 3;
            //property.Security = 420;
            //property.Gated = true;
            //property.Maintenance = 220;
            //property.Age = 2;
            //property.PostedOn = new DateTime();
            //////property.EstPossessionOn = new DateTime();>>
            //property.LastUpdatedBy = 1;
            //property.LastUpdateOn = new DateTime();
            uow.PropertyRepository.AddProperty(property);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        [HttpPost("add/photo/{propId}")]
        [Authorize]
        public async Task<ActionResult<PhotoDto>> AddPropertyPhoto(IFormFile file, int propId)
        {
            var result = await photoService.UploadPhotoAsync(file);
            //var result = await photoService.UploadPhotoAsync(file);
            if (result.Error != null)
                return BadRequest(result.Error.Message);

            var property = await uow.PropertyRepository.GetPropertyByIdAsync(propId);

            var photo = new Photo
            {
                ImageUrl = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            if(property.Photos.Count == 0)
            {
                photo.IsPrimary = true;
            }
            property.Photos.Add(photo);
            if (await uow.SaveAsync()) return mapper.Map<PhotoDto>(photo);

            return BadRequest("Some problem occured in uploading the photo , Please retry !");
            //    var userId = GetUserId();

            //    var property = await uow.PropertyRepository.GetPropertyByIdAsync(propId);

            //    if (property.PostedBy != userId)
            //        return BadRequest("You are not authorised to upload photo for this property");

            //    var photo = new Photo
            //    {
            //        ImageUrl = result.SecureUrl.AbsoluteUri,
            //        PublicId = result.PublicId
            //    };
            //    if (property.Photos.Count == 0)
            //    {
            //        photo.IsPrimary = true;
            //    }

            //    property.Photos.Add(photo);
            //    if (await uow.SaveAsync()) return mapper.Map<PhotoDto>(photo);

            //    return BadRequest("Some problem occured in uploading photo..");
            //}

        }

        //property/set-primary-photo/42/jl0sdfl20sdf2s
        [HttpPost("set-primary-photo/{propId}/{photoPublicId}")]
        [Authorize]
        public async Task<IActionResult> SetPrimaryPhoto(int propId, string photoPublicId)
        {
            var userId = GetUserId();

            var property = await uow.PropertyRepository.GetPropertyByIdAsync(propId);

            if (property.PostedBy != userId)
                return BadRequest("You are not authorised to change the photo");

            if (property == null || property.PostedBy != userId)
                return BadRequest("No such property or photo exists");

            var photo = property.Photos.FirstOrDefault(p => p.PublicId == photoPublicId);

            if (photo == null)
                return BadRequest("No such property or photo exists");

            if (photo.IsPrimary)
                return BadRequest("This is already a primary photo");


            var currentPrimary = property.Photos.FirstOrDefault(p => p.IsPrimary);
            if (currentPrimary != null) currentPrimary.IsPrimary = false;
            photo.IsPrimary = true;

            if (await uow.SaveAsync()) return NoContent();

            return BadRequest("Failed to set primary photo");
        }

        [HttpDelete("delete-photo/{propId}/{photoPublicId}")]
        [Authorize]
        public async Task<IActionResult> DeletePhoto(int propId, string photoPublicId)
        {
            //var userId = GetUserId();

            var property = await uow.PropertyRepository.GetPropertyByIdAsync(propId);

            //if (property.PostedBy != userId)
            //    return BadRequest("You are not authorised to delete the photo");

            //if (property == null || property.PostedBy != userId)
            //    return BadRequest("No such property or photo exists");

            var photo = property.Photos.FirstOrDefault(p => p.PublicId == photoPublicId);

            if (photo == null)
                return BadRequest("No such property or photo exists");

            if (photo.IsPrimary)
                return BadRequest("You can not delete primary photo");

            if (photo.PublicId != null)
            {
                var result = await photoService.DeletePhotoAsync(photo.PublicId);
                if (result.Error != null) return BadRequest(result.Error.Message);
            }

            property.Photos.Remove(photo);

            if (await uow.SaveAsync()) return Ok();

            return BadRequest("Failed to delete photo");
        }



    }
}