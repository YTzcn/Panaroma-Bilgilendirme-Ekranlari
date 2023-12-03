using Microsoft.AspNetCore.Mvc;
using Panaroma.Bussiness.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.WebApi.Controllers
{
    [ApiController]
    [Route("/Corporation")]
    public class CorporationController : Controller
    {
        private readonly ICorporationService _corporationService;
        public CorporationController(ICorporationService corporationService)
        {
            _corporationService = corporationService;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                return Json(_corporationService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(int id)
        {
            try
            {
                return Json(_corporationService.GetById(id));
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult Add(Corporation corporation)
        {
            try
            {
                _corporationService.Add(corporation);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {

                throw;
            }
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public ActionResult Delete(Corporation corporation)
        {
            try
            {
                _corporationService.Delete(corporation);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Corporation corporation)
        {
            try
            {
                _corporationService.Update(corporation);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
