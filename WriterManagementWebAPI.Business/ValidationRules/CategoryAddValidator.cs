using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.CategoryDtos;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class CategoryAddValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.CategoryName).NotEmpty().WithMessage("Kategori Ad alanı boş geçilemez");
        }
    }
}
