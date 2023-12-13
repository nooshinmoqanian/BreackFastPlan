﻿using Shared.DTO;

namespace DataAccess.Repositories
{
    public interface IRepositories<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByNameAsync(string name);
        Task<T> GetByTokenAsync(string token);
        Task<IEnumerable<T>> GetAllAsync();
        Task<Result> CreateAsync(T entity);
        Task<Result> UpdateAsync(T entity);
        Task<Result> DeleteAsync(int id);
    }
}
