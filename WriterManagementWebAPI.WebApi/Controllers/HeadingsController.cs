using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DTO.DTOs.HeadingDtos;
using WriterManagementWebAPI.Entities.Concrete;
using WriterManagementWebAPI.WebApi.CustomFiles;

namespace WriterManagementWebAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeadingsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHeadingService _headingService;

        public HeadingsController(IHeadingService headingService, IMapper mapper)
        {
            _mapper = mapper;
            _headingService = headingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<HeadingListDto>>(await _headingService.GetAllTableAsync()));
        }
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Heading>))]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<HeadingListDto>(await _headingService.FindByIdAsync(id)));
        }


        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Heading>))]
        public async Task<IActionResult> GetAllByWriterId(int id)
        {
            return Ok(_mapper.Map<List<HeadingListDto>>(await _headingService.GetAllByWriterIdAsync(id)));
        }

        [HttpPost]
        [ValidModel]
        public async Task<IActionResult> Create([FromForm] HeadingAddDto headingAddDto)
        {
            await _headingService.AddAsync(_mapper.Map<Heading>(headingAddDto));
            return Created("", headingAddDto);
        }

        [HttpPut("{id}")]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Heading>))]
        public async Task<IActionResult> Update(int id, [FromForm]  HeadingUpdateDto headingUpdateDto)
        {
            if (id != headingUpdateDto.HeadingID)
                return BadRequest("geçersiz id");
            await _headingService.UpdateAsync(_mapper.Map<Heading>(headingUpdateDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Heading>))]
        public async Task<IActionResult> Delete(int id)
        {
            var deger = _mapper.Map<Heading>(await _headingService.FindByIdAsync(id));
            deger.HeadingStatus = false;
            await _headingService.RemoveAsync(deger);
            return NoContent();
        }
    }
}
