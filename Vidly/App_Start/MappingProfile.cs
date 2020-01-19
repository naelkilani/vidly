using AutoMapper;
using Vidly.Models;
using Vidly.ModelsDtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();

            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>();
        }
    }
}