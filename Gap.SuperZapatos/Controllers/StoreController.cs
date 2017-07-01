using Gap.Entities.Stores;
using Gap.Stores.Services;
using Gap.SuperZapatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gap.SuperZapatos.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        
        [HttpPost]
        public ActionResult Create(StoreModel model)
        {
            var store = new Store();
            _storeService.Create(store);
            
            return Ok();
        }
    }
}