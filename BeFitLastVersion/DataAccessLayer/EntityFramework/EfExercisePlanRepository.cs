using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfExercisePlanRepository : GenericRepository<ExerciseProgram>, IExerciseProgramDal
    {
        public List<ExerciseProgram> GetExerciseProgramsByUserId(int userId)
        {
            using (var context = new Context())
            {
                return context.ExercisePrograms
                    .Include(ep => ep.UserExercisePrograms)
                    .Where(ep => ep.UserExercisePrograms.Any(uep => uep.UserID == userId))
                    .ToList();
            }
        }
    }
}
