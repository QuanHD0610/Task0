﻿using Core.Models;


namespace Core.Contract.Repository_Contract
{
    public interface ITaskRepository
    {
        Task<IEnumerable<CongViec>> GetAllAsync();
        Task<CongViec?> GetByIdAsync(int id);
        Task<CongViec> AddAsync(CongViec congViec);
        Task<CongViec?> UpdateAsync(CongViec congViec);
        Task<bool> DeleteAsync(int id);
    }
}