using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.Membership, opt => opt.Ignore());

            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());


            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();

            CreateMap<Membership, MembershipDto>();
        }
    }
}