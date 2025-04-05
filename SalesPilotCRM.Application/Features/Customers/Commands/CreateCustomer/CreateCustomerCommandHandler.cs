using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPilotCRM.Application.Common.Enums;
using SalesPilotCRM.Application.Common.Models;
using SalesPilotCRM.Application.Interfaces;
using SalesPilotCRM.Domain.Entities;

namespace SalesPilotCRM.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result<CreateCustomerResponse>>
    {
        private readonly IAppWriteDbContext _context;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(IAppWriteDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<CreateCustomerResponse>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {

            var exists = await _context.Customers
                .AnyAsync(c => c.Email == request.CustomerDto.Email, cancellationToken);

            if (exists)
            {
                return Result<CreateCustomerResponse>.Fail("A customer with this email already exists", ResultStatus.Conflict);
            }


            var entity = _mapper.Map<Customer>(request.CustomerDto);
            entity.CreatedAt = DateTime.UtcNow;
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            var response = new CreateCustomerResponse
            {
                CustomerId = entity.Id
            };
            return Result<CreateCustomerResponse>.Ok(response, "Customer Created Succeffuly");


        }
    }
}
