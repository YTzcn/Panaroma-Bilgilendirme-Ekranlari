using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Panaroma.Bussiness.Abstract;
using Panaroma.DataAccess.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.WebApi.Controllers
{
    [ApiController]
    [Route("Place")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _placeService;
        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Place place)
        {
            try
            {
                _placeService.Add(place);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Json(_placeService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int Id)
        {
            try
            {
                return Json(_placeService.Get(Id));
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Place place)
        {
            try
            {
                _placeService.Update(place);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(Place place)
        {
            try
            {
                _placeService.Delete(place);
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
