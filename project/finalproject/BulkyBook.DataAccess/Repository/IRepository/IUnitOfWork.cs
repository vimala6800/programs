using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {  get; }
        ICoverTypeRepository CoverType {  get; }
        IProductRepository Product { get; }
        ICompanyRepository Company {  get; }
        IShoppingCartRepository ShoppingCart {  get; }
        IApplicationUserRepository ApplicationUser {  get; }
        IOrderDetailRepository OrderDetail {  get; }
        IOrderHeaderRepository OrderHeader {  get; }
        ICustomerRepository Customer { get; }

        IProjectRepository Project { get; }

        IProjectManagerRepository ProjectManager { get; }   

        IProjectDetailRepository ProjectDetail { get; }
        object Customers { get; }

        void Save();
    }
}
