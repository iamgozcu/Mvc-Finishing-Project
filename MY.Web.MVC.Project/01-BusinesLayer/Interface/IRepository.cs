using System.Collections.Generic;

namespace _01_BusinesLayer.Interface
{
    public interface IRepository<T> where T : class
    {
        T SelectById(int id);
        List<T> GetAll();
        void Insert(T data);
        void Delete(T data);
        void Update(T data);
    }
}
