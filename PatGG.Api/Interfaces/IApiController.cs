using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PatGG.Api.Interfaces
{
    public interface IApiController<T>
    {
        Task<IActionResult> Get();
        Task<IActionResult> Get(Guid id);
        Task<IActionResult> Put(T obj);
        Task<IActionResult> Patch(T obj);
        Task<IActionResult> Delete(Guid id);
    }
}
