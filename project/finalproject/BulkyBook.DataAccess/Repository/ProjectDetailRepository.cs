using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    //internal class ProjectDetailRepository
    //{
    //}
    public class ProjectDetailRepository : Repository<ProjectDetail>, IProjectDetailRepository
    {
        private ApplicationDbContext _db;

        public ProjectDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ProjectDetail obj)
        {
            var objFromDb = _db.ProjectDetails.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ProjectId = obj.ProjectId;
                objFromDb.CustomerId = obj.CustomerId;
                objFromDb.JobTitle = obj.JobTitle;
                objFromDb.SkillSet = obj.SkillSet;
                objFromDb.Experience = obj.Experience;
                objFromDb.NumberOfMonths = obj.NumberOfMonths;
                objFromDb.StartDate = obj.StartDate;
                objFromDb.EndDate = obj.EndDate;
                objFromDb.NumberOfResources = obj.NumberOfResources;
                objFromDb.MQuote = obj.MQuote;
                objFromDb.TQuote = obj.TQuote;

                //objFromDb.CoverTypeId = obj.CoverTypeId;

            }
        }
    }
}

