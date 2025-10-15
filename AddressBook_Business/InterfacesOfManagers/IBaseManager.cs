
using AddressBook_Entity.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.InterfacesOfManagers
{
    public interface IBaseManager<Tentitytable, TviewModel, Tprimarykey>
    {
        //select * from :Herkesi getirsin  
        //select * from where: bazılarını getirsin

        //select * from where Id= : bir tanesini getirsin


        public IDataResult<List<TviewModel>> GetAllData();
        public IDataResult<List<TviewModel>>  GetSomeData(Expression<Func<TviewModel, bool>> whereFilter);
        public IDataResult<TviewModel> GetById(Tprimarykey Id);


        public IDataResult<List<TviewModel>>  GetAllData(string[] joinTableNames);
        public IDataResult<List<TviewModel>> GetSomeData(Expression<Func<TviewModel, bool>> whereFilter, string[] joinTableNames);

        //insert into
        //public IResult Add(TviewModel model);
        public IDataResult<TviewModel> Add(TviewModel model);

        //update 
        //public IResult Update(TviewModel model);
        public IDataResult<TviewModel> Update(TviewModel model);


        //delete 
        public IResult Delete(TviewModel model);
    }
}
