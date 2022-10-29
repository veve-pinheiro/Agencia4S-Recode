//Veronica Pinheiro
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace 4ESTACOES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Model.Destinos> GetTodosDestinos()
        {
            Model.DAL dal = new Model.DAL();

            List<Model.Destinos> lst = dal.GetTodosDestinos();
            

            return lst;
        }

    /*
    [HttpGet("{estado}")]
    public Model.Destinos GetDestinos(string nome)
    {
        Model.Destinos d = GetTodosDestinos().Where(x => x.Nome.Contains(nome)).FirstOrDefault();
        if(d==null)
        {
            d = new Model.Destinos()
            {
                Estado = "NÃO ENCONTRADO"
            };
        }
        return d;
    }*/

    [HttpGet("{estado}")]
        public IEnumerable<Model.Destinos> GetDestinosFiltro(string nome)
        {
            var lst = GetTodosDestinos().Where(x => x.Estado.Contains(nome)).ToList();
            return lst;
        }

    }
}
