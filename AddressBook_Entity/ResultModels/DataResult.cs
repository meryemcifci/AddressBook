using DocumentFormat.OpenXml.Office2010.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.ResultModels
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult()
        {
            
        }
        public DataResult(string message, bool success, T data)
        {
            Data = data;
            Message = message;
            IsSuccess=success;  
        }
        public T Data { get; set; }
        public bool IsSuccess {  get; set; }
        public string Message { get; set; }
    }
}
