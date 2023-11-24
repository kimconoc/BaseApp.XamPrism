using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApp.XamPrism.Models.BaseModel
{
    public class ResponseBase<T>
    {
        public T Data { get; set; }
        public int Code { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
    }
}
