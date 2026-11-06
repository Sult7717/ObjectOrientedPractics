using ObjectOrientedPractics.Model;
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
        /// Хранилище данных приложения (товары и покупатели).
        /// </summary>
        private Store _store = new();

        /// <summary>
        /// Создаёт главное окно, загружает данные магазина и передаёт их на вкладки.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadIcon();

            try
            {
                _store = StoreSerializer.Load();
            }
            catch (Exception ex) when (ex is IOException or InvalidDataException or UnauthorizedAccessException)
            {
                _store = new Store();
                MessageBox.Show(
                    $"Не удалось загрузить данные:\n{ex.Message}",
                    Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            ItemsView.Items = _store.Items;
            CustomersView.Customers = _store.Customers;
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
        /// Сохраняет данные магазина при закрытии окна.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try
            {
                StoreSerializer.Save(_store);
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
