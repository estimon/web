using System.Collections.Generic;
using System.IO;
using System.Linq;
using MediaGallery.Data;
using MediaGallery.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace MediaGallery.Commands
{
    public class SaveFolderToStorecs : ICommand<EditFolderModel>
    {

        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<SavePhotoToDatabaseCommand> _logger;
        private readonly IHostingEnvironment _host;
        private readonly GalleryContext _galleryContext;

        public SaveFolderToStorecs(ApplicationDbContext dataContext,
                                       GalleryContext galleryContext,
                                       IHostingEnvironment host,
                                       ILogger<SavePhotoToDatabaseCommand> logger)
        {
            _dataContext = dataContext;
            _logger = logger;
            _host = host;
        }

        public bool Execute(EditFolderModel model)
        {
            var parentPath = "";
            var folder = new MediaFolder();
            folder.Title = model.Title;

            if (model.parentFolderId.HasValue)
            {
                var parentFolder = _dataContext.Folders.FirstOrDefault(f => f.Id == model.parentFolderId);

                folder.ParentFolder = parentFolder;
                parentFolder.Items.Add(folder);

                parentPath = _galleryContext.GetFolderPath(model.parentFolderId.Value, null);
            }

            _dataContext.Items.Add(folder);
            _dataContext.SaveChanges();


            var path = Path.Combine(_host.WebRootPath, "gallery", parentPath, folder.Title);
            Directory.CreateDirectory(path);

            return true;
        }

        public bool Rollback()
        {
            return true;
        }



        public List<string> Validate(EditFolderModel parameter)
        {
            return new List<string>();
        }
    }
    
}
