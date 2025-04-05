using AutoMapper;
using SalesPilotCRM.Application.Features.Users.Commands.CreateUser;
using SalesPilotCRM.Domain.Entities;

namespace SalesPilotCRM.Application.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
