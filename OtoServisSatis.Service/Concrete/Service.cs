using OtoServisSatis.Entities;
using OtoServisSatis.Service.Abstract;
using OtoServisSatis.Data;
using OtoServisSatis.Data.Concrete;

namespace OtoServisSatis.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntitiy, new()
    {
        public Service(DataBaseContext context) : base(context)
        {


        }

       
    }
}

    

