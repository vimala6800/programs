using BulkyBook.DataAccess.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ProjectDetail = new ProjectDetailRepository(_db);
            ProjectManager = new ProjectManagerRepository(_db);
            Project = new ProjectRepository(_db);
            Customer = new CustomerRepository(_db);
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType {  get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company {  get; private set; }

        public IShoppingCartRepository ShoppingCart {  get; private set; }

        public IApplicationUserRepository ApplicationUser {  get; private set; }
        public IOrderHeaderRepository OrderHeader {  get; private set; }
        public IOrderDetailRepository OrderDetail {  get; private set; }

        public ICustomerRepository Customer { get; set; }

        public IProjectRepository Project { get; set; }
        public IProjectDetailRepository ProjectDetail { get; set; }

        public IProjectManagerRepository ProjectManager { get; set; }
        public object Customers => throw new NotImplementedException();
        
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
