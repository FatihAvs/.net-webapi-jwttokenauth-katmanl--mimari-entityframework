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
    public class CategoryController : CustomBaseController
    {
        private readonly IServiceGeneric<Kategori, KategoriDto> _categoryService;
        public CategoryController(IServiceGeneric<Kategori, KategoriDto> categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> KategorileriGetir()
        {
            return ActionResultInstance(await _categoryService.GetAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> KategoriyiGetir([FromQuery] int id)
        {
            return ActionResultInstance(await _categoryService.GetByIdAsync(id));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddKategori(KategoriDto kategori)
        {
            return ActionResultInstance(await _categoryService.AddAsync(kategori));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateKategori(KategoriDto kategori)
        {
            return ActionResultInstance(await _categoryService.Update(kategori, kategori.Id));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKategori(int id)
        {
            return ActionResultInstance(await _categoryService.Remove(id));
        }
    }
}
