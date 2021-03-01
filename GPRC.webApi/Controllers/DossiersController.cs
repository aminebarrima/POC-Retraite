using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GPRC.core.application.InputPort;
using GPRC.core.domaine.Entities;
using GPRC.webApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GPRC.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DossiersController : ControllerBase
    {
        private readonly IGenericCommandAsync<Dossier> _DossierGenericServices;
        private readonly IMapper _mapper;
        public DossiersController(IGenericCommandAsync<Dossier> DossierGenericServices, IMapper mapper)
        {
            _DossierGenericServices = DossierGenericServices;
            _mapper = mapper;
        }

        // POST api/<DossierController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DossierModel _DossierModel)
        {
            var DossierEntity = _mapper.Map<Dossier>(_DossierModel);
            var newDossierResult = await _DossierGenericServices.AddAsync(DossierEntity);

            if (newDossierResult is null)
            {

                return BadRequest();
              }

            return Ok(newDossierResult);
        }

        // GET api/<DossierController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var DossierResult = await _DossierGenericServices.GetByIdAsync(id);

            if (DossierResult is null)
            {

                return BadRequest();
            }

            return Ok(DossierResult);
        }
    }
}
