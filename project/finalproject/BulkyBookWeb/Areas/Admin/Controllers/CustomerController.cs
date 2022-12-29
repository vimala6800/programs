using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;



namespace BulkyBookWeb.Controllers;
[Area("Admin")]
[Authorize(Roles = SD.Role_Admin)]
public class CustomerController : Controller
{
    private readonly IUnitOfWork _unitOfWork;



    public CustomerController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }



    public IActionResult Index()
    {
        IEnumerable<Customer> objCustomerList = _unitOfWork.Customer.GetAll();
        return View(objCustomerList);
    }



    //GET
    public IActionResult Create()
    {
        return View();
    }



    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Customer obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Customer.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "Customer created successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }



    //GET
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        //var categoryFromDb = _db.Categories.Find(id);
        var customerFromDbFirst = _unitOfWork.Customer.GetFirstOrDefault(u => u.Id == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);



        if (customerFromDbFirst == null)
        {
            return NotFound();
        }



        return View(customerFromDbFirst);
    }



    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Customer obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.Customer.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "Customer updated successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }



    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        //var categoryFromDb = _db.Categories.Find(id);
        var customerFromDbFirst = _unitOfWork.Customer.GetFirstOrDefault(u => u.Id == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);



        if (customerFromDbFirst == null)
        {
            return NotFound();
        }



        return View(customerFromDbFirst);
    }



    //POST
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int? id)
    {
        var obj = _unitOfWork.Customer.GetFirstOrDefault(u => u.Id == id);
        if (obj == null)
        {
            return NotFound();
        }



        _unitOfWork.Customer.Remove(obj);
        _unitOfWork.Save();
        TempData["success"] = "Customer deleted successfully";
        return RedirectToAction("Index");



    }
}