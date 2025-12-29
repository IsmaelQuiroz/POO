using Microsoft.AspNetCore.Mvc;
using WebApi.InyeccionDeDependencias.Loggers;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //public class ValuesController : Controller
    public class ValuesController : ControllerBase
    {
        private readonly IMilogger logger;

        public ValuesController(IMilogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //var logger = new LoggerConsola();
            logger.Log("Obteniendo un arreglo de valores");
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) {
            //var logger = new LoggerConsola();
            logger.Log("Obteniendo un solo valor");
            return "value";
        }
    }
}
