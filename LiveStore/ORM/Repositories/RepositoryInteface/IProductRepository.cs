﻿using LiveStore.Data.Model;

namespace LiveStore.ORM.Repositories;

public interface IProductRepository
{
    Task<Product> GetById(int id);
    Task<IEnumerable<Product>> GetAllByCategoryId(int id);
    Task<IEnumerable<Product>> GetAll();
    Task<Product?> FindById(int id);
    Task Add(Product product);
    Task Update(Product product);
    Task Remove(Product product);
}