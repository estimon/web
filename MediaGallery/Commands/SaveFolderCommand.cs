using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaGallery.Models;

namespace MediaGallery.Commands
{
    public class SaveFolderCommand : CompositeCommand<EditFolderModel>
    {
        public SaveFolderCommand(SaveFolderToDatabaseCommand storeCommand,
                                SaveFolderToStorecs dbCommand)
        {
            Add(storeCommand);
            Add(dbCommand);
        }
    }
}
