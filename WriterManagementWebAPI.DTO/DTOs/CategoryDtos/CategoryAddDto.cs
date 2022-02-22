using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto:IDto
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        
    }
}
