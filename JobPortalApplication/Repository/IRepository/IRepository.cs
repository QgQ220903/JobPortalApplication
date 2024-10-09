﻿using JobPortalApplication.Models;
using System.Linq.Expressions;

namespace JobPortalApplication.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        IEnumerable<T> GetAll_WSET(Expression<Func<T, bool>> filter, string? includeProperties = null);

        IEnumerable<T> GetListTrue(Expression<Func<T, bool>> filter);
    }
}
