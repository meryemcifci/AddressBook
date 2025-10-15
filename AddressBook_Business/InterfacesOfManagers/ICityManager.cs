
using AddressBook_Entity.Entities;
using AddressBook_Entity.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.InterfacesOfManagers
{
    public interface ICityManager:IBaseManager<City,CityDTO,byte>
    { 

    }
}
