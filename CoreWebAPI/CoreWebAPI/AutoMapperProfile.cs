using AutoMapper;
using CoreWebAPI.DTO;
using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI
{
    public class AutoMapperProfile : Profile
    {
        //When the application starts it will initialize AutoMapper and then AutoMapper scans all assemblies & 
        //look for classes that inherit from the Profile class 
        //and load their mapping configurations.

        public AutoMapperProfile()
        {
            //CreateMap<source, destination>()
            CreateMap<StudentDTO, Student>();
            CreateMap<StudentNewDTO, Student>()
                .ForMember(dest=> dest.City, opt => opt.MapFrom(src => src.CurrentCity))
                .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age>18? true : false));
            CreateMap<AddressDTO, Address>();
        }
    }
}
