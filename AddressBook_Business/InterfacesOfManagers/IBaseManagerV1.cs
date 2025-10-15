using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.InterfacesOfManagers
{
   public interface IBaseManagerV1<Tentitytable, TviewModel,Tprimarykey>
   {
        //select * from :Herkesi getirsin  
        //select * from where: bazılarını getirsin

        //select * from where Id= : bir tanesini getirsin


        public List<TviewModel> GetAllData();
        public List<TviewModel> GetSomeData(Expression<Func<TviewModel,bool>> whereFilter);
        public TviewModel GetById(Tprimarykey Id);


        public List<TviewModel> GetAllData(string[] joinTableNames);
        public List<TviewModel> GetSomeData(Expression<Func<TviewModel, bool>> whereFilter, string[] joinTableNames);
        public TviewModel GetById(Tprimarykey Id, string[] joinTableNames);

        //insert into
        public bool Add(TviewModel model);

        //update 
        public bool Update(TviewModel model);


        //delete 
        public bool Delete(TviewModel model);


    }
}
