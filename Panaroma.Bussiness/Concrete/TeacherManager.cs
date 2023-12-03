using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Bussiness.Abstract;
using Panaroma.DataAccess.Abstract;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherDal _teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }
        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public Teacher GetById(int Id)
        {
            return _teacherDal.Get(x => x.Id == Id);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetList();
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }


    }
}
