using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        VeiculoRepository repository = new VeiculoRepository();
        [HttpGet]
        public ActionResult get()
        {
            return Ok(repository.getAll());
        }

        [Authorize]
        [HttpPost]
        public ActionResult add(Veiculos veiculo)
        {
            try
            {
                repository.add(veiculo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
