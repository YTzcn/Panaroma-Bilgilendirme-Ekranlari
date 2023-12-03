using Microsoft.AspNetCore.Mvc;
using Panaroma.Bussiness.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.WebApi.Controllers
{
    [Route("Image")]
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                return Json(_imageService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetAll(int Id)
        {
            try
            {
                return Json(_imageService.GetImage(Id));
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Image image)
        {
            try
            {
                _imageService.Add(image);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Image image)
        {
            try
            {
                _imageService.Update(image);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(Image image)
        {
            try
            {
                _imageService.Delete(image);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
