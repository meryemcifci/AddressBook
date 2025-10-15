
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
    public class DistrictManager:BaseManager<District, DistrictDTO,int>, IDistrictManager
    {
        public DistrictManager(IMapper mapper, AddressBookContext contxt):base(contxt,mapper) 
        {
            
        }
    }
}
