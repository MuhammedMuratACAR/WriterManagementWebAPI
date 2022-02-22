using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.HeadingDtos;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class HeadingAddValidator : AbstractValidator<HeadingAddDto>
    {
        public HeadingAddValidator()
        {
            RuleFor(I => I.HeadingName).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(I => I.CategoryID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
            RuleFor(I => I.WriterID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
        }

    }
}
