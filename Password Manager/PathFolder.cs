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
        internal readonly static string Pas = Path.Combine(DataFolder, "Pas.dat");
        internal readonly static string PasData = Path.Combine(DataFolder, "PasData.dat");

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
