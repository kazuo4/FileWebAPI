using System.Collections.Generic;

namespace FileWebAPI.Repositories
{
    public interface IRepository<T>
    {
        void AddFile(T item); // create
        IEnumerable<T> GetAll(); // Read All
        T GetFile(string id); // Read specific file (using string fileName)
        void UpdateFile(T item); // update 
        void DeleteFile(T item); // delete

    }
}