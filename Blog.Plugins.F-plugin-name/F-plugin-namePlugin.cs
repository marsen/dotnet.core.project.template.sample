using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Marsen.Blog.Models.Requests.Payments;
using Marsen.Blog.Models.Response.Payments;
using Marsen.Blog.Plugins.Interfaces;

namespace Marsen.Blog.Plugins.(C-plugin-name)
{
    public class (C-plugin-name)Plugin : IMiddlewarePlugin
    {
        public Task<PayEntity> Pay(Request request)
        {
            var result = new Task<PayEntity>(() => new PayEntity
            {
                ReturnMessage = "(C-plugin-name) Pay"
            });
            
            result.RunSynchronously();
            return result;
        }

        public Task<RefundEntity> Refund(Request request)
        {
            var result = new Task<RefundEntity>(()=>new RefundEntity
            {
                ReturnMessage = "(C-plugin-name) Return"
            });

            result.RunSynchronously();
            return result;
        }
    }
}
