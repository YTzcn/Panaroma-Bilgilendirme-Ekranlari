using Microsoft.AspNetCore.Mvc;
using Panaroma.Bussiness.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.WebApi.Controllers
{
    [Route("Teacher")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _TeacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _TeacherService = teacherService;
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Teacher teacher)
        {
            try
            {
                _TeacherService.Add(teacher);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
                throw;
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                return Json(_TeacherService.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetById(int Id)
        {
            try
            {
                return Json(_TeacherService.GetById(Id));
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [Route("Update")]
        [HttpPut]
        public ActionResult Update(Teacher teacher)
        {
            try
            {
                _TeacherService.Update(teacher);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }
        [Route("Delete")]
        [HttpDelete]
        public ActionResult Delete(Teacher teacher)
        {
            try
            {
                _TeacherService.Delete(teacher);
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
