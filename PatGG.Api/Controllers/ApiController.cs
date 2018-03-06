using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatGG.Api.Interfaces;

namespace PatGG.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public abstract class ApiController<T> : Controller, IApiController<T>
    {
        public abstract Task<IActionResult> Delete(Guid id);

        public abstract Task<IActionResult> Get();

        public abstract Task<IActionResult> Get(Guid id);

        public abstract Task<IActionResult> Patch(T obj);

        public abstract Task<IActionResult> Put(T obj);
    }
}
