using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DTO.DTOs.WriterDtos;
using WriterManagementWebAPI.Entities.Concrete;
using WriterManagementWebAPI.WebApi.CustomFiles;
using WriterManagementWebAPI.WebApi.Enums;
using WriterManagementWebAPI.WebApi.Models;

namespace WriterManagementWebAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : BaseController
    {
        private readonly IWriterService _writerService;
        private readonly IMapper _mapper;
        public WritersController(IWriterService writerService, IMapper mapper)
        {
            _writerService = writerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int totalPage, int activePage = 1)
        {

            return Ok(_mapper.Map<List<WriterListDto>>(await _writerService.GetAllWriterPagination(totalPage, activePage)));
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Writer>))]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<WriterListDto>(await _writerService.FindByIdAsync(id)));
        }

        [HttpPost]
        [ValidModel]
        public async Task<IActionResult> Create([FromForm] WriterAddModel writerAddModel)
        {
            var uploadModel = await UploadFileAsync(writerAddModel.Image, "image/jpeg");
            if (uploadModel.UploadState == UploadState.Success)
            {
                writerAddModel.WriterImagePath = uploadModel.NewName;
                await _writerService.AddAsync(_mapper.Map<Writer>(writerAddModel));
                return Created("", writerAddModel);
            }
            else if (uploadModel.UploadState == UploadState.NotExist)
            {
                await _writerService.AddAsync(_mapper.Map<Writer>(writerAddModel));
                return Created("", writerAddModel);
            }
            else
            {
                return BadRequest(uploadModel.ErrorMessage);
            }

        }


        [HttpPut("{id}")]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Writer>))]
        public async Task<IActionResult> Update(int id, [FromForm] WriterUpdateModel writerUpdateModel)
        {
            if (id != writerUpdateModel.WriterID)
                return BadRequest("geçersiz id");

            var uploadModel = await UploadFileAsync(writerUpdateModel.Image, "image/jpeg");

            if (uploadModel.UploadState == UploadState.Success)
            {
                var updatedWriter = await _writerService.FindByIdAsync(writerUpdateModel.WriterID);

                updatedWriter.WriterName = writerUpdateModel.WriterName;
                updatedWriter.WriterSurname = writerUpdateModel.WriterSurname;
                updatedWriter.WriterAbout = writerUpdateModel.WriterAbout;
                updatedWriter.WriterMail = writerUpdateModel.WriterMail;
                updatedWriter.WriterImagePath = uploadModel.NewName;



                await _writerService.UpdateAsync(updatedWriter);
                return NoContent();
            }
            else if (uploadModel.UploadState == UploadState.NotExist)
            {
                var updatedWriter = await _writerService.FindByIdAsync(writerUpdateModel.WriterID);
                updatedWriter.WriterName = writerUpdateModel.WriterName;
                updatedWriter.WriterSurname = writerUpdateModel.WriterSurname;
                updatedWriter.WriterAbout = writerUpdateModel.WriterAbout;
                updatedWriter.WriterMail = writerUpdateModel.WriterMail;

                await _writerService.UpdateAsync(updatedWriter);
                return NoContent();
            }
            else
            {
                return BadRequest(uploadModel.ErrorMessage);
            }
        }



        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Writer>))]
        public async Task<IActionResult> Delete(int id)
        {
           
            var deger = _mapper.Map<Writer>(await _writerService.FindByIdAsync(id));
            deger.WriterStatus = false;
            await _writerService.RemoveAsync(deger);
            return NoContent();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Search([FromQuery] string s)
        {
            return Ok(_mapper.Map<List<WriterListDto>>(await _writerService.SearchAsync(s)));
        }
    }
}
