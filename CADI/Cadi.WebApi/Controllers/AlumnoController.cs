using Cadi.Models;
using Cadi.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using Microsoft.Extensions.Logging;

namespace Cadi.WebApi.Controllers
{

    [Route("api/Alumno")]
    public class AlumnoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AlumnoController> _logger;
        public AlumnoController(IUnitOfWork unitOfWork,ILogger<AlumnoController> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
           
        }
        [HttpGet]
        [Route("GetById")]

        public IActionResult GetById(string id)
        {
            return Ok(_unitOfWork.Alumno.GetById(id));
        }
        [HttpGet]
        [Route("GetByGroup")]
        public IActionResult GetByGroup(int id)
        {
            return Ok(_unitOfWork.AsistenciaAlumno.GetList());
        }

        [HttpGet]
        [Route("GetGroups")]
        public IActionResult GetGroups()
        {
            try
            {
                _logger.LogInformation("Iniciando getgroups");
                return Ok(_unitOfWork.GrupoDetail.GetList());
            }
            catch (Exception e)
            {

                _logger.LogError(e.Message);
                return null;
            }
           
        }

        //[HttpPost]
        //[Route("InsertAlumno")]
        //public IActionResult InsertALumno(alumno alumno1)
        //{
        //    //TODO: Hacerlo bien, solo agregar alumno si agrego tutor bien
        //    if (!ModelState.IsValid) return BadRequest();
        //    Ok(_unitOfWork.Tutor.Insert(tutor));
        //    return Ok(_unitOfWork.Alumno.Insert(alumno1));
                
        //}

        //[HttpGet]
        //[Route("{id:int}")]

        //public IActionResult GetByGroup(int id)
        //{
        //    return Ok(_unitOfWork.Alumno.GetById(id));
        //}
    }
}
