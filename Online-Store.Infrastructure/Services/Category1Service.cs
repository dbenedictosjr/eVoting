﻿using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Online_Store.Infrastructure.Services
{ }
    public class Category1Service : ICategory1Service
    {
        private readonly ICategory1Repository Category1;
    private readonly IMapper _mapper;

    public Category1Service(ICategory1Repository reposity, IMapper mapper)
    {
        Category1 = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Category1Model model)
    {
        Category1.Create(_mapper.Map<Category1Entity>(model));
        await Category1.SaveAsync();
    }

    public async Task DeleteAsync(Category1Model model)
    {
        Category1.Delete(_mapper.Map<Category1Entity>(model));
        await Category1.SaveAsync();
    }

    public async Task<IEnumerable<Category1Model>> GetAllAsync()
        => _mapper.Map<IEnumerable<Category1Model>>(await Category1.GetAllAsync());

    public async Task<Category1Model> GetByIDAsync(Guid? id)
        => _mapper.Map<Category1Model>(await Category1.GetByIDAsync(id));

    public async Task UpdateAsync(Category1Model model)
    {
        Category1.Update(_mapper.Map<Category1Entity>(model));
        await Category1.SaveAsync();
    }
}