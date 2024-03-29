﻿using AutoMapper;
using AutoMapperDemo.WebAPI.Dto;
using AutoMapperDemo.WebAPI.Model;

namespace AutoMapperDemo.WebAPI.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
        }
    }
}
