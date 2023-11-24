using BaseApp.XamPrism.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.XamPrism.ServiceProvider.Interface
{
    public interface IProvider : IDisposable
    {
        Task<ResponseBase<TResult>> GetAsync<TResult>(string uri, string token = "");
        Task<ResponseBase<TResult>> PostAsync<TRequest, TResult>(string uri, TRequest data, string token = "");
        Task<ResponseBase<TResult>> PutAsync<TRequest, TResult>(string uri, TRequest data, string token = "");
        Task<ResponseBase<bool>> DeleteAsync(string uri, string token = "");
    }
}
