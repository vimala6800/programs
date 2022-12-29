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
	
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private ApplicationDbContext _db;

        public ProjectRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Project obj)
        {
            var objFromDb = _db.Projects.FirstOrDefault(u => u.PId == obj.PId);
            if (objFromDb != null)
            {
                objFromDb.CustomerId = obj.CustomerId;
               // objFromDb.Customer = obj.Customer;
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.StartDate = obj.StartDate;
                objFromDb.EndDate = obj.EndDate;
                //objFromDb.ProjectManager= obj.ProjectManager;
                objFromDb.ProjectManagerId = obj.ProjectManagerId;
                objFromDb.ProposalSubmissionDate = obj.ProposalSubmissionDate;
                objFromDb.Status = obj.Status;
            }
        }
    }
}
