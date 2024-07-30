
using WebAPI.Interface;

namespace WebAPI.Interfaces
{
    public interface InterfaceUnitofWork
    { 
        InterfaceCityRepository CityRepository {get ;}

        IUserRepository UserRepository { get; }

        IPropertyRepository PropertyRepository { get; }

        IPropertTypeRepository PropertyTypeRepository { get; }

        IFurnishingTypeRepository FurnishingTypeRepository { get; }
        Task<bool> SaveAsync();
     }
}