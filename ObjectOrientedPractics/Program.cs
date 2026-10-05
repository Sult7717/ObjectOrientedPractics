using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Точка входа в приложение.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главный метод приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
