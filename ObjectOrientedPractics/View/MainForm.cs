using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Главное окно приложения. Содержит вкладки для работы с товарами и покупателями.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Имя встроенного ресурса с иконкой главного окна.
        /// </summary>
        private const string IconResourceName = "AppIcon.ico";

        /// <summary>
        /// Создаёт главное окно.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadIcon();
        }

        /// <summary>
        /// Устанавливает иконку главного окна из встроенного ресурса.
        /// </summary>
        private void LoadIcon()
        {
            using Stream? stream = typeof(MainForm).Assembly.GetManifestResourceStream(IconResourceName);
            if (stream is not null)
            {
                Icon = new Icon(stream);
            }
        }

        /// <summary>
        /// Загружает сохранённые данные при открытии окна.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void MainForm_Load(object? sender, EventArgs e)
        {
            try
            {
                ProjectData data = ProjectSerializer.Load();
                ItemsView.Items = data.Items;
                CustomersView.Customers = data.Customers;
            }
            catch (Exception ex) when (ex is IOException or InvalidDataException or UnauthorizedAccessException)
            {
                MessageBox.Show(
                    $"Не удалось загрузить данные:\n{ex.Message}",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Сохраняет данные при закрытии окна.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try
            {
                var data = new ProjectData
                {
                    Items = ItemsView.Items,
                    Customers = CustomersView.Customers
                };
                ProjectSerializer.Save(data);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                MessageBox.Show(
                    $"Не удалось сохранить данные:\n{ex.Message}",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
