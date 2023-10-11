namespace Restaurant_Otomasyonu
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new frmGiris());
        }
    }
}