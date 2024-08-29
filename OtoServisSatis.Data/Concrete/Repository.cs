using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;
using System.Linq.Expressions;

namespace OtoServisSatis.Data.Concrete
{
    //GENERİC REPOSİTORY PATTERN DESIGN
    //Repository, arayüzde tanımlanan metotların nasıl uygulnması gerektiğini tanımlar.
    public class Repository<T> :IRepository<T> where T : class, IEntitiy, new() // parametresiz bir kurucuya (constructor) sahip olmalıdır. Bu, T'nin new T() gibi bir çağrıyla oluşturulabileceği anlamına gelir.
    {
        internal DataBaseContext _context;
        internal DbSet<T> _dbSet;


        //Alttaki iki yapıcı method(const)
       
        public Repository(DataBaseContext context)
        {
            _context = context;
            _dbSet= _context.Set<T>();
        }


        //CRUD İŞLEMLERİ
        public void Add(T entity)//gelen veritabanını ekler
        {
          _context.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity); //await kullanmazsanız, bu metot çağrısının sonucunu beklemeden bir sonraki satıra geçilir. 
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);  //IRepository'de id döndüğü için burda return kullandık!
        }

        public async Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);//expression koşuluna uyan ilk öğeyi bulur ve döndürür. Eğer böyle bir öğe bulunamazsa, null döndürülür.
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList(); //önce expression'a göre filtreyi uygular daha sonra ToList'çevirip, geri döndürür.
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
           _context.Update(entity);
        }
    }
}
