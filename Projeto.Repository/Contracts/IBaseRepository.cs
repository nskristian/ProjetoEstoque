using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
