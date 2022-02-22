using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.CategoryDtos;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class CategoryUpdateValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(I => I.CategoryID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
            RuleFor(I => I.CategoryName).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}
