using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WriterManagementWebAPI.DTO.DTOs.CategoryDtos;
using WriterManagementWebAPI.DTO.DTOs.ContentDtos;
using WriterManagementWebAPI.DTO.DTOs.HeadingDtos;
using WriterManagementWebAPI.DTO.DTOs.WriterDtos;
using WriterManagementWebAPI.Entities.Concrete;
using WriterManagementWebAPI.WebApi.Models;

namespace WriterManagementWebAPI.WebApi.Mapper.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

            CreateMap<ContentListDto, Content>();
            CreateMap<Content, ContentListDto>();

            CreateMap<ContentAddDto, Content>();
            CreateMap<Content, ContentAddDto>();

            CreateMap<ContentUpdateDto, Content>();
            CreateMap<Content, ContentUpdateDto>();    

            CreateMap<HeadingListDto, Heading>();
            CreateMap<Heading, HeadingListDto>();

            CreateMap<HeadingAddDto, Heading>();
            CreateMap<Heading, HeadingAddDto>();

            CreateMap<HeadingUpdateDto, Heading>();
            CreateMap<Heading, HeadingUpdateDto>();
         
            CreateMap<WriterListDto, Writer>();
            CreateMap<Writer, WriterListDto>();

            CreateMap<WriterAddModel, Writer>();
            CreateMap<Writer, WriterAddModel>();

            CreateMap<WriterUpdateModel, Writer>();
            CreateMap<Writer, WriterUpdateModel>();

        }
    }
}
