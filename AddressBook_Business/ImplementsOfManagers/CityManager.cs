using AddressBook_Business.InterfacesOfManagers;
using AddressBook_DataAccess.ContextInfo;
using AddressBook_Entity.Entities;
using AddressBook_Entity.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.ImplementsOfManagers
{
    public class CityManager :BaseManager<City,CityDTO,byte>
        ,ICityManager //icityManager kalıtım tamamen UI katmanında DI yapmak için
    {
        public CityManager(AddressBookContext ctx, IMapper map) : base(ctx, map)
        {

        }
        public CityManager(AddressBookContext ctx, IMapper map, string baskaParametre) : base(ctx, map)
        {

        }
        public CityManager(AddressBookContext ctx, IMapper map, string baskaParametre, bool b2, decimal b3) : base(ctx, map)
        {

        }
    }
}
