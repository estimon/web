using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaGallery.Data;
using MediaGallery.Models;
using Microsoft.Extensions.Logging;

namespace MediaGallery.Commands
{
    public class SaveFolderToDatabaseCommand : ICommand<EditFolderModel>
    {
        private readonly ApplicationDbContext _dataContext;
        private readonly ILogger<SavePhotoToDatabaseCommand> _logger;
        private readonly GalleryContext _galleryContext;

        

        public SaveFolderToDatabaseCommand(ApplicationDbContext dataContext, ILogger<SavePhotoToDatabaseCommand> logger)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public bool Execute(EditFolderModel model)
        {
            MediaFolder folder = null;

            if (model.parentFolderId.HasValue)
            {
                folder = folder = _dataContext.Folders.First(f => f.Id == model.parentFolderId.Value);
            }
            _dataContext.Items.Add(folder);
            _dataContext.SaveChanges();

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

