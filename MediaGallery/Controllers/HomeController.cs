﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MediaGallery.Commands;
using MediaGallery.Data;
using MediaGallery.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly GalleryContext _galleryContext;
        private readonly IHostingEnvironment _host;

        public HomeController(ApplicationDbContext dataContext,
                              IHostingEnvironment host,
                              GalleryContext galleryContext)
        {
            _dataContext = dataContext;
            _galleryContext = galleryContext;
            _host = host;
        }

        public IActionResult Index()
        {
            var model = new FrontPageModel();
            model.NewPhotos = _dataContext.Photos.Cast<MediaItem>().ToList();
            model.PopularPhotos = _dataContext.Photos.Cast<MediaItem>().ToList();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var item = _dataContext.Items
                                   .Include(i => i.ParentFolder)
                                   .Include(i => ((MediaFolder)i).Items)
                                   .FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            _galleryContext.PageTitle = item.Title;
            _galleryContext.CurrentItem = item;

            if(item is MediaFolder)
            {
                return View("Folder", item);
            }

            return View("Picture", item);
        }

        public IActionResult CreateFolder(int? parentFolder)
        {
            var model = new EditFolderModel();
            model.parentFolderId = parentFolder;

            return View(model);
        }
    
        [HttpPost]
        public IActionResult CreateFolder(IList<IFormFile> files, int? parentFolder, [FromServices] SaveFolderCommand saveFolderCommand)
        {
            var list = new List<string>();

            foreach (var file in files)
            {
                var model = new EditFolderModel();
                model.Title = Path.GetFileName(file.FileName);
                model.parentFolderId = parentFolder;
                model.Folder = file;
                

                list.AddRange(saveFolderCommand.Validate(model));

                saveFolderCommand.Execute(model);
            }

            ViewBag.Messages = list;

            return View();
        } 

        public IActionResult Edit(int id)
        {
            var item = _dataContext.Photos.FirstOrDefault(i => i.Id == id);
            if(item == null)
            {
                return NotFound();
            }

            var model = new PhotoEditModel();
            model.Title = item.Title;
            model.Id = item.Id;

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PhotoEditModel model)
        {
            var item = _dataContext.Photos.FirstOrDefault(i => i.Id == model.Id);
            if(item == null)
            {
                return NotFound();
            }

            if(!ModelState.IsValid)
            {
                return View(model);
            }

            item.Title = model.Title;

            _dataContext.SaveChanges();

            return RedirectToAction("Details", new { id = model.Id });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult UploadFile(int? parentFolder)
        {
            ViewBag.ParentFolderId = parentFolder;

            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IList<IFormFile> files, int? parentFolder, [FromServices]SavePhotoCommand savePhotoCommand)
        {
            var list = new List<string>();

            foreach(var file in files)
            {
                var model = new PhotoEditModel();
                model.FileName = Path.GetFileName(file.FileName);
                model.Thumbnail = Path.GetFileName(file.FileName);
                model.ParentFolderId = parentFolder;
                model.File = file;

                list.AddRange(savePhotoCommand.Validate(model));

                savePhotoCommand.Execute(model);
            }

            ViewBag.Messages = list;

            return View();
        }
    }
}
