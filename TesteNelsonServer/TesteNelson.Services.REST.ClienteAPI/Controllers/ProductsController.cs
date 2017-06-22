using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteNelson.Domain;
using TesteNelson.Infra.Data.Context;

namespace TesteNelson.Services.REST.ClienteAPI.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        TesteNelsonContext db = new TesteNelsonContext();

        [HttpGet]
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(ListarTodos());
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return db.Produtos.ToList();
        }
        
    }
}
