using System;
using System.Collections.Generic;
using System.Text;
using WriterManagementWebAPI.DTO.Interfaces;

namespace WriterManagementWebAPI.DTO.DTOs.HeadingDtos
{
    public class HeadingListDto : IDto
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }

    }
}
