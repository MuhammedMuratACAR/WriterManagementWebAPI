using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.HeadingDtos;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class HeadingUpdateValidator:AbstractValidator<HeadingUpdateDto>
    {
        public HeadingUpdateValidator()
        {
            RuleFor(I => I.HeadingID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
            RuleFor(I => I.HeadingName).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(I => I.CategoryID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
            RuleFor(I => I.WriterID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
        }
    }
}
