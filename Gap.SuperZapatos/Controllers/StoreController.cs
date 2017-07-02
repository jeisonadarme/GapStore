using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gap.Entities.Stores;
using Gap.Stores.Services;
using Gap.SuperZapatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gap.SuperZapatos.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreService _storeService;

        private readonly IMapper _mapper;
        
        public StoreController(IStoreService storeService, IMapper mapper)
        {
            _storeService = storeService;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<ActionResult> Create([FromBody]StoreModel model)
        {
            var store = _mapper.Map<StoreModel, Store>(model);
            await _storeService.Insert(store);
            return Ok(new
            {
                Success = true
            });
        }

        //("services/stores")
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _storeService.GetAll();
            var stores = _mapper.Map<IEnumerable<Store>, IEnumerable<StoreModel>>(result);

            return Ok(new
            {
                Success = true,
                TotalElements = result.Count(),
                Stores = stores
            });
        }
    }
}