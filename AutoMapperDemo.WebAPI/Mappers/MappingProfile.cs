using AutoMapper;
using AutoMapperDemo.WebAPI.Dto;
using AutoMapperDemo.WebAPI.Model;

namespace AutoMapperDemo.WebAPI.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
           // CreateMap<StudentDto, Student>()
           //.ForMember(dest => dest.StudentId, opt => opt.Ignore()); // Ignoring Id during create operation

           // CreateMap<StudentDto, Student>()
           //     .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.)); // Include Id during update operation
        }
    }
}
