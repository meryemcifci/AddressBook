using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Entity.ResultModels
{
    public class Result : IResult
    {
        public Result()
        {

        }
        public Result(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
