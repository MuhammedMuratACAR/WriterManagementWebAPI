using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.Business.Concrete;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.Business.ValidationRules;
using WriterManagementWebAPI.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using WriterManagementWebAPI.DataAccess.Interfaces;
using WriterManagementWebAPI.DTO.DTOs.CategoryDtos;
using WriterManagementWebAPI.DTO.DTOs.ContentDtos;
using WriterManagementWebAPI.DTO.DTOs.HeadingDtos;

namespace WriterManagementWebAPI.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IContentService, ContentManager>();
            services.AddScoped<IContentDal, EfContentRepository>();

            services.AddScoped<IHeadingService, HeadingManager>();
            services.AddScoped<IHeadingDal, EfHeadingRepository>();

            services.AddScoped<IWriterService, WriterManager>();
            services.AddScoped<IWriterDal, EfWriterRepository>();

       
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();

            services.AddTransient<IValidator<ContentAddDto>, ContenAddValidator>();
            services.AddTransient<IValidator<ContentUpdateDto>, ContentUpdateValidator>();

            services.AddTransient<IValidator<HeadingAddDto>, HeadingAddValidator>();
            services.AddTransient<IValidator<HeadingUpdateDto>, HeadingUpdateValidator>();
        }
    }
}
