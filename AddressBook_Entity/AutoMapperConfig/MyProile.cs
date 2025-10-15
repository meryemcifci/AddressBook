
using AddressBook_Entity.Entities;
using AddressBook_Entity.Identity_Entities;
using AddressBook_Entity.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.AutoMapperConfig
{
    public class MyProile:Profile
    {
        public MyProile()
        {
            CreateMap<City,CityDTO>().ReverseMap();
            //CreateMap<CityDTO, City>();

            CreateMap<District,DistrictDTO>().ReverseMap();
            CreateMap<Neighborhood,NeighborhoodDTO>().ReverseMap();
            CreateMap<UserAddress,UserAddressDTO>().ReverseMap();
            CreateMap<MyUser,MyUserDTO>().ReverseMap();


        }
    }
}
