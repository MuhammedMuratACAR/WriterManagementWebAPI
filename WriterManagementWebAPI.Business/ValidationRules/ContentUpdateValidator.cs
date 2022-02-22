using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.ContentDtos;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class ContentUpdateValidator:AbstractValidator<ContentUpdateDto>
    {
        public ContentUpdateValidator()
        {
            RuleFor(I => I.ContentID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
            RuleFor(I => I.ContentValue).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(I => I.ContentDate).NotEmpty().WithMessage("Tarih alanı boş geçilemez");
            RuleFor(I => I.HeadingID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
         

        }
    }
}
