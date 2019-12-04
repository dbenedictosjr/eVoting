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
    public class ShiftService : IShiftService
    {
        private readonly IShiftRepository Shift;
    private readonly IMapper _mapper;

    public ShiftService(IShiftRepository reposity, IMapper mapper)
    {
        Shift = reposity;
        _mapper = mapper;

    }

    public async Task CreateAsync(ShiftModel model)
    {
        Shift.Create(_mapper.Map<ShiftEntity>(model));
        await Shift.SaveAsync();
    }

    public async Task DeleteAsync(ShiftModel model)
    {
        Shift.Delete(_mapper.Map<ShiftEntity>(model));
        await Shift.SaveAsync();
    }

    public async Task<IEnumerable<ShiftModel>> GetAllAsync()
        => _mapper.Map<IEnumerable<ShiftModel>>(await Shift.GetAllAsync());

    public async Task<ShiftModel> GetByIDAsync(Guid? id)
        => _mapper.Map<ShiftModel>(await Shift.GetByIDAsync(id));

    public async Task UpdateAsync(ShiftModel model)
    {
        Shift.Update(_mapper.Map<ShiftEntity>(model));
        await Shift.SaveAsync();
    }
}