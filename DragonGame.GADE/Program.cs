namespace DragonGame.GADE
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
            Application.Run(new SplashScreen());

            Form1 setupForm = new Form1();
            Application.Run(setupForm);

            
            Application.Run(new Form2(setupForm.player1, setupForm.player2));
        }
    }
}