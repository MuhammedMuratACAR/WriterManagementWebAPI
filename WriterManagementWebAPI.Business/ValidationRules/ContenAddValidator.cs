using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.DTOs.ContentDtos;
using WriterManagementWebAPI.Entities.Concrete;

namespace WriterManagementWebAPI.Business.ValidationRules
{
    public class ContenAddValidator : AbstractValidator<ContentAddDto>
    {
        public ContenAddValidator()
        {
            RuleFor(I => I.ContentValue).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(I => I.HeadingID).InclusiveBetween(0, int.MaxValue).WithMessage("ID alanı boş geçilemez");
        }
      
    }
}
