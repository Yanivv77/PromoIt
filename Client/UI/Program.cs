

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new BusinessCompanyForm());
            //Application.Run(new NonProfitOrganizationForm());
            //Application.Run(new ProLobbyOwnerForm());
            //Application.Run(new SocialActivistsForm());
            //Application.Run(new RegistryFrom());

        }


    }
}