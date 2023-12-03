using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaroma.Entities.Concrete;

namespace Panaroma.Bussiness.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        Teacher GetById(int Id);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
    }
}
