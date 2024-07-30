using WebAPI.Model;

namespace WebAPI.Interface
{
    public interface IPropertTypeRepository
    {
        Task<IEnumerable<PropertyType>> GetPropertyTypesAsync();
    }
}
