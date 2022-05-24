using System.Runtime.Serialization;
using System.Text;

namespace Password_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static ApplicationContext _mainContext = new ApplicationContext();
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!Directory.Exists(PathFolder.DataFolder))
            {
                
                PathFolder.Deploy();
                
            }
            if (!File.Exists(PathFolder.Pas))
            {
                _mainContext.MainForm = new RegistrationForm();
            }
            else
            {
                _mainContext.MainForm = new AuthorizationForm();
                
            }

            Application.Run(_mainContext);
        }
        internal static void SetMainForm(Form form)
        {
            _mainContext.MainForm = form;
            
        }
        internal static void ShowMainForm()
        {
            _mainContext.MainForm.Show();
        }
        internal static void SaveSettings()
        {
            using (var stream = File.Open(PathFolder.PasData, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    foreach (Account account in MainForm.Accounts)
                    {

                        writer.Write(account.Name);
                        writer.Write(account.Username);
                       
                        writer.Write(account.Password);
                       

                    }
                }
            }
        }
    }
}