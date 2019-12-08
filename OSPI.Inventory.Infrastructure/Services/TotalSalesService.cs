using OSPI.Inventory.Domain.Entities;
using OSPI.Inventory.Domain.Interfaces;
using OSPI.Inventory.Infrastructure.Interfaces;
using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace OSPI.Inventory.Infrastructure.Services
{ }
    public class TotalSalesService : ITotalSalesService
    {
        private readonly ITotalSalesRepository TotalSales;
    private readonly IMapper _mapper;

    public TotalSalesService(ITotalSalesRepository reposity, IMapper mapper)
    {
        TotalSales = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(TotalSalesModel model)
    {
        TotalSales.Create(_mapper.Map<TotalSalesEntity>(model));
        await TotalSales.SaveAsync();
    }

    public async Task DeleteAsync(TotalSalesModel model)
    {
        TotalSales.Delete(_mapper.Map<TotalSalesEntity>(model));
        await TotalSales.SaveAsync();
    }

    public async Task<IEnumerable<TotalSalesModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<TotalSalesModel>>(await TotalSales.GetAllAsync());

    public async Task<TotalSalesModel> GetByIDAsync(Guid? id)
        => _mapper.Map<TotalSalesModel>(await TotalSales.GetByIDAsync(id));

    public async Task UpdateAsync(TotalSalesModel model)
    {
        TotalSales.Update(_mapper.Map<TotalSalesEntity>(model));
        await TotalSales.SaveAsync();
    }
}