using System.Collections.Generic;
namespace Project{
    public interface IRepo<T>{
        List<T> List();
        T GetId(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}