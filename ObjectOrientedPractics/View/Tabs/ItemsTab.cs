using System.ComponentModel;
using System.Globalization;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы со списком товаров: добавление, выбор, редактирование и удаление.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Название товара, которое получает новый товар при нажатии кнопки добавления.
        /// </summary>
        private const string DefaultItemName = "New Item";

        /// <summary>
        /// Цвет фона поля ввода с некорректным значением.
        /// </summary>
        private static readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Список товаров. Порядок совпадает с порядком элементов в <see cref="ItemsListBox"/>.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Признак того, что элементы управления обновляются программно,
        /// а не пользователем (обработчики событий в этом случае ничего не делают).
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Возвращает или задаёт список товаров, отображаемых на вкладке.
        /// </summary>
        /// <exception cref="ArgumentNullException">Присвоено значение <c>null</c>.</exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _items = value;
                RebuildItemsListBox();
            }
        }

        /// <summary>
        /// Создаёт вкладку товаров.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            UpdateSelectedItemInfo();
        }

        /// <summary>
        /// Возвращает текст для отображения товара в списке.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Строка вида «Id. Название».</returns>
        private static string FormatItem(Item item)
        {
            return $"{item.Id}. {item.Name.ReplaceLineEndings(" ")}";
        }

        /// <summary>
        /// Возвращает выбранный в списке товар.
        /// </summary>
        /// <returns>Выбранный товар или <c>null</c>, если ничего не выбрано.</returns>
        private Item? GetSelectedItem()
        {
            int index = ItemsListBox.SelectedIndex;
            return index >= 0 && index < _items.Count ? _items[index] : null;
        }

        /// <summary>
        /// Добавляет товар в список и выбирает его.
        /// </summary>
        /// <param name="item">Добавляемый товар.</param>
        private void AddItem(Item item)
        {
            _items.Add(item);
            ItemsListBox.Items.Add(FormatItem(item));
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Полностью перестраивает <see cref="ItemsListBox"/> по текущему списку товаров.
        /// </summary>
        private void RebuildItemsListBox()
        {
            _isUpdating = true;
            try
            {
                ItemsListBox.BeginUpdate();
                ItemsListBox.Items.Clear();
                foreach (Item item in _items)
                {
                    ItemsListBox.Items.Add(FormatItem(item));
                }

                ItemsListBox.EndUpdate();
            }
            finally
            {
                _isUpdating = false;
            }

            if (_items.Count > 0)
            {
                ItemsListBox.SelectedIndex = 0;
            }
            else
            {
                UpdateSelectedItemInfo();
            }
        }

        /// <summary>
        /// Обновляет строку выбранного товара в списке после изменения его названия.
        /// </summary>
        /// <param name="index">Индекс товара.</param>
        private void RefreshListBoxItem(int index)
        {
            _isUpdating = true;
            try
            {
                ItemsListBox.Items[index] = FormatItem(_items[index]);
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Заполняет поля справа данными выбранного товара либо очищает их,
        /// если товар не выбран.
        /// </summary>
        private void UpdateSelectedItemInfo()
        {
            Item? item = GetSelectedItem();

            _isUpdating = true;
            try
            {
                if (item is null)
                {
                    IdTextBox.Clear();
                    CostTextBox.Clear();
                    NameTextBox.Clear();
                    InfoTextBox.Clear();
                }
                else
                {
                    IdTextBox.Text = item.Id.ToString(CultureInfo.CurrentCulture);
                    CostTextBox.Text = item.Cost.ToString(CultureInfo.CurrentCulture);
                    NameTextBox.Text = item.Name;
                    InfoTextBox.Text = item.Info;
                }

                CostTextBox.BackColor = SystemColors.Window;
                NameTextBox.BackColor = SystemColors.Window;
                InfoTextBox.BackColor = SystemColors.Window;

                bool hasSelection = item is not null;
                CostTextBox.Enabled = hasSelection;
                NameTextBox.Enabled = hasSelection;
                InfoTextBox.Enabled = hasSelection;
                RemoveButton.Enabled = hasSelection;
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Пытается записать значение в выбранный товар и подсвечивает поле ввода
        /// красным цветом, если значение не прошло проверку.
        /// </summary>
        /// <param name="textBox">Поле ввода, из которого взято значение.</param>
        /// <param name="assign">Действие, записывающее значение в товар.</param>
        /// <returns><c>true</c>, если значение принято.</returns>
        private bool TryAssignValue(TextBox textBox, Action<Item> assign)
        {
            Item? item = GetSelectedItem();
            if (_isUpdating || item is null)
            {
                return false;
            }

            try
            {
                assign(item);
                textBox.BackColor = SystemColors.Window;
                return true;
            }
            catch (ArgumentException)
            {
                textBox.BackColor = _errorColor;
                return false;
            }
        }

        /// <summary>
        /// Добавляет новый товар со значениями по умолчанию и выбирает его в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddButton_Click(object? sender, EventArgs e)
        {
            AddItem(new Item(DefaultItemName, string.Empty, 0));
        }

        /// <summary>
        /// Добавляет случайно сгенерированный товар и выбирает его в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void GenerateButton_Click(object? sender, EventArgs e)
        {
            AddItem(ItemFactory.CreateRandomItem());
        }

        /// <summary>
        /// Удаляет выбранный товар из списка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            if (_items.Count > 0)
            {
                ItemsListBox.SelectedIndex = Math.Min(index, _items.Count - 1);
            }
            else
            {
                UpdateSelectedItemInfo();
            }
        }

        /// <summary>
        /// Отображает данные выбранного товара в полях справа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void ItemsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            UpdateSelectedItemInfo();
        }

        /// <summary>
        /// Записывает введённое название в товар; при ошибке подсвечивает поле красным.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void NameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (TryAssignValue(NameTextBox, item => item.Name = NameTextBox.Text))
            {
                RefreshListBoxItem(ItemsListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Записывает введённое описание в товар; при ошибке подсвечивает поле красным.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void InfoTextBox_TextChanged(object? sender, EventArgs e)
        {
            TryAssignValue(InfoTextBox, item => item.Info = InfoTextBox.Text);
        }

        /// <summary>
        /// Записывает введённую стоимость в товар; при ошибке подсвечивает поле красным.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CostTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            if (!double.TryParse(CostTextBox.Text, NumberStyles.Float, CultureInfo.CurrentCulture, out double cost))
            {
                CostTextBox.BackColor = _errorColor;
                return;
            }

            TryAssignValue(CostTextBox, item => item.Cost = cost);
        }
    }
}
