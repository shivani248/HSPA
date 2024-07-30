using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Dtos;

namespace WebAPI.Controllers
{
    public interface IPropertyController
    {
        Task<IActionResult> AddProperty(PropertyDto propertydto);
        Task<IActionResult> GetPropertyDetail(int id);
        Task<IActionResult> GetPropertyList(int sellRent);
    }
}