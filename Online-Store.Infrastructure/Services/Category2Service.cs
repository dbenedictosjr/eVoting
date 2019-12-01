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
    public class Category2Service : ICategory2Service
    {
        private readonly ICategory2Repository Category2;
    private readonly IMapper _mapper;

    public Category2Service(ICategory2Repository reposity, IMapper mapper)
    {
        Category2 = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(Category2Model model)
    {
        Category2.Create(_mapper.Map<Category2Entity>(model));
        await Category2.SaveAsync();
    }

    public async Task DeleteAsync(Category2Model model)
    {
        Category2.Delete(_mapper.Map<Category2Entity>(model));
        await Category2.SaveAsync();
    }

    public async Task<IEnumerable<Category2Model>> GetAllAsync()
        => _mapper.Map<IEnumerable<Category2Model>>(await Category2.GetAllAsync());

    public async Task<Category2Model> GetByIDAsync(Guid? id)
        => _mapper.Map<Category2Model>(await Category2.GetByIDAsync(id));

    public async Task UpdateAsync(Category2Model model)
    {
        Category2.Update(_mapper.Map<Category2Entity>(model));
        await Category2.SaveAsync();
    }
}