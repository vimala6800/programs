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
[Area("Vendor")]
[Authorize(Roles = SD.Role_User_Comp)]
public class VendorsController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _hostEnvironment;




    public VendorsController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _hostEnvironment = hostEnvironment;
    }



    public IActionResult Index()
    {
        IEnumerable<Project> objProjectList = _unitOfWork.Project.GetAll(includeProperties: "Customer,ProjectManager");
        return View(objProjectList);
    }
    //GET
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
        return RedirectToAction("Index");
    }
}