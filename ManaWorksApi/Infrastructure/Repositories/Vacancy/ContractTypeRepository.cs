using ManaWorksApi.Application.Dtos.ContractTypes;
using ManaWorksApi.Application.Extensions.ContractTypes;
using ManaWorksApi.Application.Interfaces;
using ManaWorksApi.Domain.Entities;
using ManaWorksApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManaWorksApi.Infrastructure.Repositories;

public class ContractTypeRepository : IContractTypeRepository
{
    private readonly AppDbContext _context;

    public ContractTypeRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<ContractType>> GetContractTypes(CancellationToken cancellationToken)
    {
        return await _context.contracttypes.ToListAsync(cancellationToken);
    }

    public async Task<ContractType?> GetContractTypesByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.contracttypes.FindAsync(id, cancellationToken);
    }

    public async Task<ContractType> AddAsync(CreateContractTypeDto? contractType, CancellationToken cancellationToken)
    {
        _context.contracttypes.Add(contractType.ToCreateEntity());
        await _context.SaveChangesAsync(cancellationToken);
        return contractType.ToCreateEntity();
    }
}