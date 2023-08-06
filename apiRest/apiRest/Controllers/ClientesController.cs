using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {

        private readonly ILogger<ClientesController> _logger;
        private readonly ApplicationDbContext _applicationContext;
        public ClientesController(ILogger<ClientesController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationContext = applicationDbContext;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _applicationContext.Clientes.ToList();
        }
    }
}
