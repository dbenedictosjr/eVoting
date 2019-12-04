using Online_Store.Domain.Entities;
using Online_Store.Domain.Interfaces;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace Online_Store.Infrastructure.Services
{ }
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository Supplier;
    private readonly IMapper _mapper;

    public SupplierService(ISupplierRepository reposity, IMapper mapper)
    {
        Supplier = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(SupplierModel model)
    {
        Supplier.Create(_mapper.Map<SupplierEntity>(model));
        await Supplier.SaveAsync();
    }

    public async Task DeleteAsync(SupplierModel model)
    {
        Supplier.Delete(_mapper.Map<SupplierEntity>(model));
        await Supplier.SaveAsync();
    }

    public async Task<IEnumerable<SupplierModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<SupplierModel>>(await Supplier.GetAllAsync());

    public async Task<SupplierModel> GetByIDAsync(Guid? id)
        => _mapper.Map<SupplierModel>(await Supplier.GetByIDAsync(id));

    public async Task UpdateAsync(SupplierModel model)
    {
        Supplier.Update(_mapper.Map<SupplierEntity>(model));
        await Supplier.SaveAsync();
    }
}