using AutoMapper;
using Library.DAL.Entityes;
using System.Diagnostics.Eventing.Reader;
using Library.BLL.Model;

namespace Library.PL.WebApi.Configuration
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {

            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Category,CategoryModel>().ReverseMap();
            CreateMap<Author, AuthorModel>().ReverseMap();
                
        }
    }
}
