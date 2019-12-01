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
    public class Category3Service : ICategory3Service
    {
        private readonly ICategory3Repository Category3;
    private readonly IMapper _mapper;

    public Category3Service(ICategory3Repository reposity, IMapper mapper)
    {
        Category3 = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Category3Model model)
    {
        Category3.Create(_mapper.Map<Category3Entity>(model));
        await Category3.SaveAsync();
    }

    public async Task DeleteAsync(Category3Model model)
    {
        Category3.Delete(_mapper.Map<Category3Entity>(model));
        await Category3.SaveAsync();
    }

    public async Task<IEnumerable<Category3Model>> GetAllAsync()
        => _mapper.Map<IEnumerable<Category3Model>>(await Category3.GetAllAsync());

    public async Task<Category3Model> GetByIDAsync(Guid? id)
        => _mapper.Map<Category3Model>(await Category3.GetByIDAsync(id));

    public async Task UpdateAsync(Category3Model model)
    {
        Category3.Update(_mapper.Map<Category3Entity>(model));
        await Category3.SaveAsync();
    }
}