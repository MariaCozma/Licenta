using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Licenta.Models;
using Licenta.Models.Dtos;

namespace Licenta.App_Start
{
    public class MappingProfile: Profile
    { 
        public MappingProfile()
        { 
            //Domain to Dto 
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Book, BookDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            //Dto To Domain
            Mapper.CreateMap<CustomerDto, Customer>() 
            .ForMember(c => c.Id, opt => opt.Ignore());
           
            Mapper.CreateMap<BookDto, Book>()
           .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}