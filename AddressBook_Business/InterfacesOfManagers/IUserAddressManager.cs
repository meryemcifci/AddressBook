using AddressBook_Entity.Entities;
using AddressBook_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.InterfacesOfManagers
{
    public interface IUserAddressManager:IBaseManager<UserAddress,UserAddressDTO,int>
    {
    }
}
