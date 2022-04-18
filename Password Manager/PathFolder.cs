using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class PathFolder
    {
        internal readonly static string DataFolder =  "Data";
        internal readonly static string PasSerial = Path.Combine(DataFolder, "Pas.txt");
        internal readonly static string PasData = Path.Combine(DataFolder, "Pas.data");

        // custom SALT file
        internal readonly static string PasSalt = Path.Combine(DataFolder, "Pas.salt");

        internal static void Deploy()
        {
            try
            {
                if (!Directory.Exists(DataFolder))
                {
                    Directory.CreateDirectory(DataFolder);
                }
            }
            catch (Exception err)
            {
                // try running app as admin
                MessageBox.Show(err.Message, "Pas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }
    }
}
