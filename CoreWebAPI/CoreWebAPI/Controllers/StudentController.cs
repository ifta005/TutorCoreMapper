using AutoMapper;
using CoreWebAPI.DTO;
using CoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /*
        [HttpGet]
        public Student Get()
        {            
            StudentDTO obj = new StudentDTO()
            {
                Name = "UDATAO",
                Age = 22,
                City = "Dhaka"
            };

            //We haven't registered it in ServiceCollection. 
            //AddAutoMapper() method in your ConfigureServices takes care of all of this for you.

            return _mapper.Map<Student>(obj);
        }
        */

        [HttpGet]
        public Student GetStudentInfo()
        {
            StudentNewDTO obj = new StudentNewDTO()
            {
                Name = "UDATAO",
                Age = 22,
                CurrentCity = "Khulna",
                Address = new AddressDTO()
                {
                    State = "IL",
                    Country = "US"
                }
            };

            //We haven't registered it in ServiceCollection. 
            //AddAutoMapper() method in your ConfigureServices takes care of all of this for you.

            return _mapper.Map<Student>(obj);
        }
    }
}
