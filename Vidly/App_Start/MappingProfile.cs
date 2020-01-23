using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.Membership, opt => opt.Ignore());

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore())
                .ForMember(m => m.Genre, opt => opt.Ignore());

            CreateMap<Membership, MembershipDto>();
            CreateMap<Genre, GenreDto>();
        }
    }
}