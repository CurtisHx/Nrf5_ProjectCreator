using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRF52ProjectCreator
{
  class EmProjectModifyer
  {
    public EmProjectModifyer(FileInfo emProjectToModify, String newName, String locationFolder)
    {
      
    }

    /* Entries in the emProject file that need to be modified:
     * solution Name
     * project Name
     * all of c_user_include_directories
     * CMSIS_CONFIG_TOOL
     * debug_register_definition_file
     * debug_additional_load_file
     * anything with "file_name" in it.
     */
  }
}
