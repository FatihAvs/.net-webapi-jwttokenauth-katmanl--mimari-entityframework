using AutoMapper;
using SoruApp.core.Dtos;
using SoruApp.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruApp.service
{
    public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<UserAppDto, UserApp>().ReverseMap();
            CreateMap<UrunDto, Urun>().ReverseMap();
            CreateMap<YorumDto, Yorum>().ReverseMap();
            CreateMap<KategoriDto, Kategori>().ReverseMap();


        }
    }
}
