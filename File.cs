using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Monitoring
{
    class File
    {
        private string fileName;
        private string location;

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        public File()
        {

        }
        public File(string fileName, string fileLocation)
        {
            this.fileName = fileName;
            this.location = fileLocation;
        }
    }
}
