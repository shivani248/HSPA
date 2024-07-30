using WebAPI.Data.Repo;
using WebAPI.Interface;
using WebAPI.Interfaces;
using WebAPI.Repo;

namespace WebAPI
{
    public class UnitOfWork : InterfaceUnitofWork
    {
          private readonly DataContext dc;

        public UnitOfWork(DataContext dc) {
             this.dc = dc;}

        public InterfaceCityRepository CityRepository => 
        new CityRepo(dc);

        public IUserRepository UserRepository =>
            new UserRepository(dc);

        public IPropertyRepository PropertyRepository =>
            new PropertyRepository(dc); //it will instatiate new PropertyRepository

 



        public IFurnishingTypeRepository FurnishingTypeRepository =>
            new FurnishingTypeRepository(dc);

        public IPropertTypeRepository PropertyTypeRepository =>
            new PropertyTypeRepository(dc);

        //public IPropertTypeRepository PropertyTypeRepository => throw new NotImplementedException();

        public async Task<bool> SaveAsync() 
        {
          return await dc.SaveChangesAsync()>0;
        }
    }
}