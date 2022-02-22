using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.HeadingDtos
{
    public class HeadingAddDto : IDto
    {
        public string HeadingName { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
    }
}
