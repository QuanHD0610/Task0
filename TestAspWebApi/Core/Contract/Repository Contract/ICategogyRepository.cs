﻿using Core.DTO.Categorydto;
using Core.Models;


namespace Core.Contract.Repository_Contract
{
    public interface ICategogyRepository
    {

        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category?> GetByIdAsync(int id);
        Task<Category> CreatAsycn(Category category);
        Task<Category?> UpdateAsycn(int id, CategoryUpdateRequest categoryUpdateRequest);
        Task<Category?> DeleteAsycn(int id);
    }
}
