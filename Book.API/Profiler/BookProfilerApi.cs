using AutoMapper;
using Book.API.Models;
using Book.DAL.Entities;
using Book.DTO.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book.API.Profiler
{
    public class BookProfilerApi : Profile
    {
        public BookProfilerApi()
        {
            CreateMap<BookRequest, BooksGitDTO>().ReverseMap();
        }
    }
}
