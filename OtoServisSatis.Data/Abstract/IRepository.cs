using System.Linq.Expressions;

namespace OtoServisSatis.Data.Abstract
{
    public interface IRepository<T> where T : class {
        //IRepository(arayüz),  neyin yapılmasını gerektiğini tanımlar.
        //TEMEL CRUD İŞLEMLERİ
        //Repository^nin tüm veritabanı class'ları için çalışabilmesi için <T> YAZDIK! ve T'nin bir claa olması için bir şart koşulu yazdık.
        
        List<T> GetAll();
        // aşağıdaki Lamda expression
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression); //listelenen kaydı özel sorgularla getirir.
        T Find(int  id); //id ile eşleşen kaydı getirir.

        //SENKRON METOTLAR
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Save(); //veritabanına bu değişiklikleri işleyeceğimiz metot

        //ASENKRON METOTLAR (.NetCore' da çok hızlı işlem yapmamızı sağlar.
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task<int> SaveAsync();



    }
}
