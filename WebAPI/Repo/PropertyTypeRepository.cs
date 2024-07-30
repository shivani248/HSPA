using Microsoft.EntityFrameworkCore;
using WebAPI.Interface;
using WebAPI.Model;

namespace WebAPI.Repo
{
    public class PropertyTypeRepository : IPropertTypeRepository
    {
        private readonly DataContext dc;

        public PropertyTypeRepository(DataContext dc)
        {
            this.dc = dc;
        }
        public async Task<IEnumerable<PropertyType>> GetPropertyTypesAsync()
        {
            return await dc.PropertyTypes.ToListAsync();
        }
    }
}
