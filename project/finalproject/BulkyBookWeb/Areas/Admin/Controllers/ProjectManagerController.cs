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
public class ProjectManagerController : Controller
{
    private readonly IUnitOfWork _unitOfWork;





    public ProjectManagerController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }





    public IActionResult Index()
    {
        IEnumerable<ProjectManager> objProjectManagerList = _unitOfWork.ProjectManager.GetAll();
        return View(objProjectManagerList);
    }





    //GET
    public IActionResult Create()
    {
        return View();
    }





    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ProjectManager obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.ProjectManager.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "ProjectManager created successfully";
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
        var ProjectManagerFromDbFirst = _unitOfWork.ProjectManager.GetFirstOrDefault(u => u.PMId == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);





        if (ProjectManagerFromDbFirst == null)
        {
            return NotFound();
        }





        return View(ProjectManagerFromDbFirst);
    }





    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(ProjectManager obj)
    {

        if (ModelState.IsValid)
        {
            _unitOfWork.ProjectManager.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "ProjectManager updated successfully";
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
        var ProjectManagerFromDbFirst = _unitOfWork.ProjectManager.GetFirstOrDefault(u => u.PMId == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);





        if (ProjectManagerFromDbFirst == null)
        {
            return NotFound();
        }





        return View(ProjectManagerFromDbFirst);
    }





    //POST
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int? id)
    {
        var obj = _unitOfWork.ProjectManager.GetFirstOrDefault(u => u.PMId == id);
        if (obj == null)
        {
            return NotFound();
        }





        _unitOfWork.ProjectManager.Remove(obj);
        _unitOfWork.Save();
        TempData["success"] = "ProjectManager deleted successfully";
        return RedirectToAction("Index");





    }
}