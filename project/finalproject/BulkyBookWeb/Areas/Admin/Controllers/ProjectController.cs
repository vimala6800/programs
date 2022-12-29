using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.ObjectModelRemoting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;



namespace BulkyBookWeb.Controllers;
[Area("Admin")]
[Authorize(Roles = SD.Role_Admin)]
public class ProjectController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;




    public ProjectController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _hostEnvironment = hostEnvironment;
    }



    public IActionResult Index()
    {
        return View();
    }



    //GET
    public IActionResult Upsert(int? pId)
    {
        ProjectVM projectVM = new()
        {
            Project = new(),
            CustomerList = _unitOfWork.Customer.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }),
            ProjectManagerList = _unitOfWork.ProjectManager.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.PMId.ToString()
            }),
        };



        if (pId == null || pId == 0)
        {
            //create product
            //ViewBag.CategoryList = CategoryList;
            //ViewData["CoverTypeList"] = CoverTypeList;
            return View(projectVM);
        }
        else
        {
            projectVM.Project = _unitOfWork.Project.GetFirstOrDefault(u => u.PId == pId);
            return View(projectVM);



            //update product
        }




    }



    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Upsert(ProjectVM obj, IFormFile? file)
    {



        //if (ModelState.IsValid)
        //{
        //    string wwwRootPath = _hostEnvironment.WebRootPath;
        //    if (file != null)
        //    {
        //        string fileName = Guid.NewGuid().ToString();
        //        var uploads = Path.Combine(wwwRootPath, @"images\products");
        //        var extension = Path.GetExtension(file.FileName);



        //        if (obj.Product.ImageUrl != null)
        //        {
        //            var oldImagePath = Path.Combine(wwwRootPath, obj.Product.ImageUrl.TrimStart('\\'));
        //            if (System.IO.File.Exists(oldImagePath))
        //            {
        //                System.IO.File.Delete(oldImagePath);
        //            }
        //        }



        //        using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
        //        {
        //            file.CopyTo(fileStreams);
        //        }
        //        obj.Product.ImageUrl = @"\images\products\" + fileName + extension;



        //    }
        if (obj.Project.PId == 0)
        {
            _unitOfWork.Project.Add(obj.Project);
        }
        else
        {
            _unitOfWork.Project.Update(obj.Project);
        }
        _unitOfWork.Save();
        TempData["success"] = "Project created successfully";
        return RedirectToAction("Index");
        //return View(obj);
    }
    //return View(obj);
    //}
    #region API CALLS
    [HttpGet]
    public IActionResult GetAll()
    {
        var projectList = _unitOfWork.Project.GetAll(includeProperties: "Customer,ProjectManager");
        return Json(new { data = projectList });
    }



    //POST
    [HttpDelete]
    public IActionResult Delete(int? id)
    {
        var obj = _unitOfWork.Project.GetFirstOrDefault(u => u.PId == id);
        if (obj == null)
        {
            return Json(new { success = false, message = "Error while deleting" });
        }



        //var oldImagePath = Path.Combine(_hostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
        //if (System.IO.File.Exists(oldImagePath))
        //{
        //    System.IO.File.Delete(oldImagePath);
        //}



        _unitOfWork.Project.Remove(obj);
        _unitOfWork.Save();
        return Json(new { success = true, message = "Delete Successful" });



    }
    #endregion



    public IActionResult Index1()
    {
        return View();
    }



    /////////////////////
    ///
    public IActionResult Details(int? id)
    {
        ProjectDetailVM pDetailVM = new()
        {
            ProjectDetail = new(),
            ProjectList = _unitOfWork.Project.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.PId.ToString()
            }),



            CustomerList = _unitOfWork.Customer.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }),
        };



        if (id == null || id == 0)
        {
            /*create project

 

            ViewData["CoverTypeList"] = CoverTypeList;*/
            return View(pDetailVM);
        }
        else
        {
            pDetailVM.ProjectDetail = _unitOfWork.ProjectDetail.GetFirstOrDefault(u => u.Id == id);
            return View(pDetailVM);



            //update product
        }
    }
    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Details(ProjectDetailVM obj, IFormFile? file)
    {



        /*if (ModelState.IsValid)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(wwwRootPath, @"images\products");
                var extension = Path.GetExtension(file.FileName);

 

                *//*if (obj.Project.ImageUrl != null)
                {
                    var oldImagePath = Path.Combine(wwwRootPath, obj.Product.ImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }*//*

 

                using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    file.CopyTo(fileStreams);
                }
                //obj.Product.ImageUrl = @"\images\products\" + fileName + extension;

 

            }*/
        if (obj.ProjectDetail.Id == 0)
        {
            _unitOfWork.ProjectDetail.Add(obj.ProjectDetail);
        }
        else
        {
            _unitOfWork.ProjectDetail.Update(obj.ProjectDetail);
        }
        _unitOfWork.Save();
        TempData["success"] = " Source Added  successfully";
        return RedirectToAction("Index1");
    }
    [HttpGet]
    public IActionResult GetAll1()
    {
        var pDetailList = _unitOfWork.ProjectDetail.GetAll(includeProperties: "Project,Customer");
        return Json(new { data = pDetailList });
    }
    /*public IActionResult Details(int projectId)
    {
        ProjectVM = new ProjectVM()
        {
            //OrderHeader = _unitOfWork.OrderHeader.GetFirstOrDefault(u => u.Id == orderId, includeProperties: "ApplicationUser"),
            OrderDetail = _unitOfWork.Project.GetAll(u => u.projectId == projectId, includeProperties: "PDetails"),
        };
        return View(PDetailVM);
    }*/




    public IActionResult PdDelete(int? id)
    {
        var obj = _unitOfWork.ProjectDetail.GetFirstOrDefault(u => u.Id == id);
        if (obj == null)
        {
            return Json(new { success = false, message = "Error while deleting" });
        }



        //var oldImagePath = Path.Combine(_hostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
        //if (System.IO.File.Exists(oldImagePath))
        //{
        //    System.IO.File.Delete(oldImagePath);
        //}



        _unitOfWork.ProjectDetail.Remove(obj);
        _unitOfWork.Save();
        return Json(new { success = true, message = "Delete Successful" });







    }
}

























