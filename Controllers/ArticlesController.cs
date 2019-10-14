using EfCoreTransactionTest.Api.Business;
using EfCoreTransactionTest.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreTransactionTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleBusiness _articleBusiness;
        public ArticlesController(IArticleBusiness articleBusiness)
        {
            _articleBusiness = articleBusiness;
        }

        [HttpPost]
        public ActionResult Add([FromBody]Article article)
        {
            return Ok();
        }
    }
}