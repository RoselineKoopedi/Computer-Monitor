using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Directory_Monitoring
{
    class File_Handler
    {
       

        public void CreateF(string name, string location)
        {
            try
            {
                string Storage;
                Storage = location + "/" + name;
                StreamWriter sw = new StreamWriter(Storage);
                sw.Close();

                MessageBox.Show("Your File Has Been Created","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception)
            {
                MessageBox.Show("No blank spaces allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
