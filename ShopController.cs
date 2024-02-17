using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Online.Course
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopSer;

        public ShopController(IShopService shop)
        {
            _shopSer = shop;
        }

        [HttpPost]
        public string Create(ShopsDTO shps)
        {
            string? res = _shopSer.Create(shps);
            return res;
        }
        [HttpGet]
        public Shops GetById(int id)
        {
            Shops? x = _shopSer.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Shops> GetAll()
        {
            IEnumerable<Shops>? x = _shopSer.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            string? x = _shopSer.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, ShopsDTO shops)
        {
            string? x = _shopSer.Update(id, shops);
            return x;
        }
    }
}