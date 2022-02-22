using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WriterManagementWebAPI.Business.Interfaces;
using WriterManagementWebAPI.DTO.DTOs.ContentDtos;
using WriterManagementWebAPI.Entities.Concrete;
using WriterManagementWebAPI.WebApi.CustomFiles;

namespace WriterManagementWebAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IContentService _contentService;

        public ContentsController(IContentService contentService, IMapper mapper)
        {
            _mapper = mapper;
            _contentService = contentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<ContentListDto>>(await _contentService.GetAllAsync()));
        }
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Content>))]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ContentListDto>(await _contentService.FindByIdAsync(id)));
        }

        [HttpPost]
        [ValidModel]
        public async Task<IActionResult> Create([FromForm] ContentAddDto contentAdd)
        {
            await _contentService.AddAsync(_mapper.Map<Content>(contentAdd));
            return Created("", contentAdd);
        }

        [HttpPut("{id}")]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Content>))]
        public async Task<IActionResult> Update(int id, [FromForm] ContentUpdateDto contentUpdateDto)
        {
            if (id != contentUpdateDto.ContentID)
                return BadRequest("geçersiz id");
            await _contentService.UpdateAsync(_mapper.Map<Content>(contentUpdateDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Content>))]
        public async Task<IActionResult> Delete(int id)
        {
            var deger = _mapper.Map<Content>(await _contentService.FindByIdAsync(id));
            deger.ContentStatus = false;
            await _contentService.RemoveAsync(deger);
            return NoContent();
        }
    }
}
