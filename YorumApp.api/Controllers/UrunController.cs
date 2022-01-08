using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoruApp.core.Dtos;
using SoruApp.core.Entities;
using SoruApp.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YorumApp.api.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UrunController : CustomBaseController
    {
        private readonly IServiceGeneric<Urun, UrunDto> _urunService;
        public UrunController(IServiceGeneric<Urun, UrunDto> urunService)
        {
            _urunService = urunService;
    }
        [HttpGet]
        public async Task<IActionResult> UrunleriGetir()
        {
            return ActionResultInstance(await _urunService.GetAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> UrunuGetir([FromQuery] int id)
        {
            return ActionResultInstance(await _urunService.GetByIdAsync(id));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddUrun(UrunDto urun)
        {
            return ActionResultInstance(await _urunService.AddAsync(urun));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UrunDto urunDto)
        {
            return ActionResultInstance(await _urunService.Update(urunDto, urunDto.Id));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUrun(int id)
        {
            return ActionResultInstance(await _urunService.Remove(id));
        }
    }
}
