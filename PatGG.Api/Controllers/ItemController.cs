using Microsoft.AspNetCore.Mvc;
using PatGG.Core.Entities;
using PatGG.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace PatGG.Api.Controllers
{
    public class ItemController : ApiController<IItem>
    {
        private readonly IItemRepository<IItem> _itemRepository;

        public ItemController
        (
            IItemRepository<IItem> itemRepository
        )
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            var items = await _itemRepository.Retrieve();
            return Json(items);
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var item = await _itemRepository.Retrieve(id);
            return Json(item);
        }

        [HttpPut]
        public override async Task<IActionResult> Put([FromBody] IItem item)
        {
            await _itemRepository.Create(item);
            return Json(item);
        }

        [HttpPatch]
        public override async Task<IActionResult> Patch([FromBody] IItem item)
        {
            await _itemRepository.Update(item);
            return Json(item);
        }

        [HttpDelete]
        public override async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _itemRepository.Delete(id);
            return Json(null);
        }
    }
}
