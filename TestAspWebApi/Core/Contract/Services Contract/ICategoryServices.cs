﻿using Core.DTO.Categorydto;
using Core.Models;



namespace Core.Contract.Services_Contract
{
    public interface ICategoryServices
    {
        public Task<IEnumerable<Category>> GetAllCategories();
        public Task<Category?> GetCategoryById(int id);
        public Task<bool> DeleteCategory(int id);
        public Task<bool> UpdateCategory(int id, CategoryUpdateRequest categoryUpdaterequest);
        public Task<bool> CreateCategory(Category category);
    }
}
