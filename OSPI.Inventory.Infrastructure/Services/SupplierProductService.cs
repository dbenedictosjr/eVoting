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
    public class SupplierProductService : ISupplierProductService
    {
        private readonly ISupplierProductRepository SupplierProduct;
    private readonly IMapper _mapper;

    public SupplierProductService(ISupplierProductRepository reposity, IMapper mapper)
    {
        SupplierProduct = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SupplierProductModel model)
    {
        SupplierProduct.Create(_mapper.Map<SupplierProductEntity>(model));
        await SupplierProduct.SaveAsync();
    }

    public async Task DeleteAsync(SupplierProductModel model)
    {
        SupplierProduct.Delete(_mapper.Map<SupplierProductEntity>(model));
        await SupplierProduct.SaveAsync();
    }

    public async Task<IEnumerable<SupplierProductModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SupplierProductModel>>(await SupplierProduct.GetAllAsync());

    public async Task<SupplierProductModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SupplierProductModel>(await SupplierProduct.GetByIDAsync(id));

    public async Task UpdateAsync(SupplierProductModel model)
    {
        SupplierProduct.Update(_mapper.Map<SupplierProductEntity>(model));
        await SupplierProduct.SaveAsync();
    }
}