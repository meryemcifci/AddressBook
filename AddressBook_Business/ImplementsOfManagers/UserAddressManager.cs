
using AddressBook_Business.InterfacesOfManagers;
using AddressBook_DataAccess.ContextInfo;
using AddressBook_Entity.Entities;
using AddressBook_Entity.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.ImplementsOfManagers
{
    public class UserAddressManager:BaseManager<UserAddress, UserAddressDTO,int>, IUserAddressManager
    {
        public UserAddressManager(AddressBookContext mycontext, IMapper mapper):base(mycontext, mapper) 
        {
            
        }
    }
}
