using System.Collections.Generic;
using System.Linq;
using FileWebAPI.Models;

namespace FileWebAPI.Repositories
{
    public class Repository : IRepository<MyFile>
    {
        private readonly List<MyFile> _files = new List<MyFile>();
        public void AddFile(MyFile file)
        {
            if (_files.Any(f => f.FileName == file.FileName))
            {
                return;
            }
            else
            {
                _files.Add(file);
            }
        }

        public IEnumerable<MyFile> GetAll()
        {
            return _files;
        }
        public MyFile GetFile(string fileName)
        {
            var existing = _files.FirstOrDefault(f => f.FileName == fileName);
            if (existing != null)
            {
                return existing;
            }
            return null; 
        }
        public void UpdateFile(MyFile file)
        {
            var existing = GetFile(file.FileName);
            if (existing != null)
            {
                existing.FileValue = file.FileValue;
            }
        }
        public void DeleteFile(MyFile file)
        {
            var existing = GetFile(file.FileName);
            if (existing != null)
            {
                _files.Remove(existing);
            }
        }

    }
}