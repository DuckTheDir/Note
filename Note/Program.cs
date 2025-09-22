namespace Note
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string? fileToOpen = null;
            if (args.Length > 0 && File.Exists(args[0]))
            {
                fileToOpen = args[0];
            }
            Application.Run(new Form1(fileToOpen));
        }
        
    }
}