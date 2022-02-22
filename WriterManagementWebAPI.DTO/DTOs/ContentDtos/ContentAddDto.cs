using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.ContentDtos
{
    public class ContentAddDto : IDto
    {
        public string ContentValue { get; set; }
        public int HeadingID { get; set; }
        public int? WriterID { get; set; }
    }
}
