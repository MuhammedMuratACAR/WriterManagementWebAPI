using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.ContentDtos
{
    public class ContentUpdateDto : IDto
    {
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        public int HeadingID { get; set; }
        public int? WriterID { get; set; }
    }
}
