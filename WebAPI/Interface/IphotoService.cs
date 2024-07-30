using CloudinaryDotNet.Actions;

namespace WebAPI.Interface
{
    public interface IphotoService
    {
        Task<ImageUploadResult> UploadPhotoAsync(IFormFile photo);

        //will add onre more method for deleting the photo
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
