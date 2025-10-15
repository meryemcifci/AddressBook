
using AddressBook_Business.InterfacesOfManagers;
using AddressBook_DataAccess.ContextInfo;
using AddressBook_Entity.ResultModels;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Business.ImplementsOfManagers
{
    public class BaseManager<Tentitytable, TviewModel, Tprimarykey> : IBaseManager<Tentitytable, TviewModel, Tprimarykey> where Tentitytable : class, new()
        where TviewModel : class, new()
    {
        private AddressBookContext _ctx;
        private IMapper _mapper;
       
        public BaseManager(AddressBookContext mycontext, IMapper mapper) //DI
        {
            _ctx = mycontext;
            _mapper = mapper;
        }
        public IDataResult<TviewModel> Add(TviewModel model)
        {
            try
            {
                //dönüşümü nasıl yapıcaz? AUTOMAPPER
                var data = _mapper.Map<Tentitytable>(model);

                _ctx.Set<Tentitytable>().Add(data); // sqldeki tabloya eklendiğinden artık id prop dolu
                if (_ctx.SaveChanges() > 0)
                {
                    return new DataResult<TviewModel>("Eklendi!", true, _mapper.Map<TviewModel>(data));
                }
                else
                {
                    var result = new DataResult<TviewModel>();
                    result.IsSuccess = false;
                    result.Message = "Ekleme başarısız!";

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IResult Delete(TviewModel model)
        {
            try
            {
                //dönüşümü nasıl yapıcaz? AUTOMAPPER
                var data = _mapper.Map<Tentitytable>(model);

                _ctx.Set<Tentitytable>().Remove(data);
                if (_ctx.SaveChanges() > 0)
                {
                    return new Result(true, "SİLİNDİ!");
                }
                else
                {
                    return new Result(false, "SİLME İŞLEMİ BAŞARISIZDIR!");

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<List<TviewModel>> GetAllData()
        {
            try
            {
                //select * from tablo
                var data = _ctx.Set<Tentitytable>().ToList();
                var data_list = _mapper.Map<List<TviewModel>>(data);
                return new DataResult<List<TviewModel>>($"{data_list.Count} adet veri geldi!", true, data_list);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<List<TviewModel>> GetAllData(string[] joinTableNames)
        {
            try
            {
                //select * from tablo
                var query = _ctx.Set<Tentitytable>().AsQueryable();


                foreach (var item in joinTableNames)
                {
                    query = query.Include(item);//inner join Tbl2
                }
                var data_list = _mapper.Map<List<TviewModel>>(query);
                return new DataResult<List<TviewModel>>($"{data_list.Count} adet veri geldi!", true, data_list);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TviewModel> GetById(Tprimarykey Id)
        {
            var data = _ctx.Set<Tentitytable>().Find(Id);
            return new DataResult<TviewModel>("",true,_mapper.Map<TviewModel>(data));
        }

        

        public IDataResult<List<TviewModel>> GetSomeData(Expression<Func<TviewModel, bool>> whereFilter)
        {
            try
            {
                //select * from tablo where conditions
                var filter = _mapper.MapExpression<Expression<Func<TviewModel, bool>>, Expression<Func<Tentitytable, bool>>>(whereFilter);

                var dataquery = _ctx.Set<Tentitytable>().Where(filter).ToList();

                return new DataResult<List<TviewModel>>($"",true,_mapper.Map<List<TviewModel>>(dataquery));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<List<TviewModel>> GetSomeData(Expression<Func<TviewModel, bool>> whereFilter, string[] joinTableNames)
        {
            try
            {
                //select * from tablo where conditions
                var filter = _mapper.MapExpression<Expression<Func<TviewModel, bool>>, Expression<Func<Tentitytable, bool>>>(whereFilter);
                var query = _ctx.Set<Tentitytable>().Where(filter).AsQueryable();

                foreach (var item in joinTableNames)
                {
                    query = query.Include(item);//inner join Tbl2
                }

                return new DataResult<List<TviewModel>>($"", true, _mapper.Map<List<TviewModel>>(query));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TviewModel> Update(TviewModel model)
        {
            try
            {
                //dönüşümü nasıl yapıcaz? AUTOMAPPER
                var data = _mapper.Map<Tentitytable>(model);

                _ctx.Set<Tentitytable>().Update(data); // sqldeki tabloya güncellediğinden propların güncel halini göndermeliyim
                if (_ctx.SaveChanges() > 0)
                {
                    return new DataResult<TviewModel>("Eklendi!", true, _mapper.Map<TviewModel>(data));
                }
                else
                {
                    var result = new DataResult<TviewModel>();
                    result.IsSuccess = false;
                    result.Message = "Ekleme başarısız!";

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
