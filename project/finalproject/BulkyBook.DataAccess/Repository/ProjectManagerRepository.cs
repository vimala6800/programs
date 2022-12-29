using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
	//internal class ProjectManagerRepository
	//{
	//}
    public class ProjectManagerRepository : Repository<ProjectManager>, IProjectManagerRepository
    {
        private ApplicationDbContext _db;

        public ProjectManagerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ProjectManager obj)
        {
            _db.ProjectManagers.Update(obj);
        }
    }
}
