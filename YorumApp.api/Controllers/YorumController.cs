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
    public class YorumController : CustomBaseController
    {
        private readonly IServiceGeneric<Yorum, YorumDto> _yorumService;
        public YorumController(IServiceGeneric<Yorum, YorumDto> yorumService)
        {
            _yorumService = yorumService;
        }
        [HttpGet]
        public async Task<IActionResult> YorumlariGetir()
        {
            return ActionResultInstance(await _yorumService.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddYorum(YorumDto yorum)
        {
            return ActionResultInstance(await _yorumService.AddAsync(yorum));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateYorum(YorumDto yorum)
        {
            return ActionResultInstance(await _yorumService.Update(yorum, yorum.Id));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYorum(int id)
        {
            return ActionResultInstance(await _yorumService.Remove(id));
        }
    }
}
