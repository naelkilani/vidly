using AutoMapper;
using Vidly.Models;
using Vidly.ModelsDtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<Customer, CustomerDto>();

            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<Movie, MovieDto>();
        }
    }
}