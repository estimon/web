using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MediaGallery.Models
{
    public class EditFolderModel
    {
        [Required]
        [StringLength(10)]

        public int Id { get; set; }
        public string Title { get; set; }
        public int? parentFolderId { get; set; }
        public IFormFile Folder { get; set; }
    }
}
