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
        /// Цвет фона поля ввода с некорректным значением.
        /// </summary>
        private static readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Список товаров. Порядок совпадает с порядком элементов в <see cref="ItemsListBox"/>.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Признак того, что элементы управления обновляются программно,
        /// а не пользователем.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Признак режима добавления нового товара: поля справа пусты
        /// и предназначены для ввода данных нового товара.
        /// </summary>
        private bool _isAddingNew;

        /// <summary>
        /// Возвращает или задаёт список товаров, отображаемых на вкладке.
        /// </summary>
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
        private static string FormatItem(Item item)
        {
            return $"{item.Id}. {item.Name.ReplaceLineEndings(" ")}";
        }

        /// <summary>
        /// Возвращает выбранный в списке товар.
        /// </summary>
        private Item? GetSelectedItem()
        {
            int index = ItemsListBox.SelectedIndex;
            return index >= 0 && index < _items.Count ? _items[index] : null;
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
        /// Обновляет строку товара в списке после изменения его названия.
        /// </summary>
        private void RefreshListBoxItem(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                return;
            }

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
        /// Заполняет поля справа данными выбранного товара либо очищает их.
        /// </summary>
        private void UpdateSelectedItemInfo()
        {
            Item? item = GetSelectedItem();

            _isUpdating = true;
            try
            {
                if (item is null || _isAddingNew)
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

                bool hasSelection = item is not null && !_isAddingNew;
                CostTextBox.Enabled = hasSelection;
                NameTextBox.Enabled = hasSelection;
                InfoTextBox.Enabled = hasSelection;

                RemoveButton.Enabled = hasSelection;
                EditButton.Enabled = hasSelection;

                AddButton.Text = _isAddingNew ? "Save" : "Add";
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Пытается записать значение в выбранный товар и подсвечивает поле
        /// красным цветом, если значение не прошло проверку.
        /// </summary>
        private bool TryAssignValue(TextBox textBox, Action<Item> assign)
        {
            Item? item = GetSelectedItem();
            if (_isUpdating || item is null || _isAddingNew)
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
        /// Проверяет корректность значений, введённых в поля справа.
        /// </summary>
        private bool ValidateInputs(out string name, out string info, out double cost)
        {
            bool isValid = true;
            name = NameTextBox.Text;
            info = InfoTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                NameTextBox.BackColor = _errorColor;
                isValid = false;
            }
            else
            {
                NameTextBox.BackColor = SystemColors.Window;
            }

            if (!double.TryParse(CostTextBox.Text, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out cost) || cost < 0)
            {
                CostTextBox.BackColor = _errorColor;
                isValid = false;
            }
            else
            {
                CostTextBox.BackColor = SystemColors.Window;
            }

            InfoTextBox.BackColor = SystemColors.Window;
            return isValid;
        }

        /// <summary>
        /// Включает режим добавления нового товара: очищает поля справа
        /// и делает их доступными для ввода.
        /// </summary>
        private void StartAddingNew()
        {
            _isAddingNew = true;

            _isUpdating = true;
            try
            {
                ItemsListBox.ClearSelected();
                IdTextBox.Clear();
                NameTextBox.Clear();
                InfoTextBox.Clear();
                CostTextBox.Clear();

                NameTextBox.BackColor = SystemColors.Window;
                InfoTextBox.BackColor = SystemColors.Window;
                CostTextBox.BackColor = SystemColors.Window;

                NameTextBox.Enabled = true;
                InfoTextBox.Enabled = true;
                CostTextBox.Enabled = true;

                RemoveButton.Enabled = false;
                EditButton.Enabled = false;
                AddButton.Text = "Save";
            }
            finally
            {
                _isUpdating = false;
            }

            NameTextBox.Focus();
        }

        /// <summary>
        /// Выключает режим добавления нового товара.
        /// </summary>
        private void EndAddingNew()
        {
            _isAddingNew = false;
            AddButton.Text = "Add";
            UpdateSelectedItemInfo();
        }

        /// <summary>
        /// Обрабатывает кнопку «Add»/«Save».
        /// </summary>
        private void AddButton_Click(object? sender, EventArgs e)
        {
            if (!_isAddingNew)
            {
                StartAddingNew();
                return;
            }

            if (!ValidateInputs(out string name, out string info, out double cost))
            {
                return;
            }

            var item = new Item(name, info, cost);
            _items.Add(item);
            ItemsListBox.Items.Add(FormatItem(item));

            _isAddingNew = false;
            AddButton.Text = "Add";

            _isUpdating = true;
            try
            {
                ItemsListBox.SelectedIndex = _items.Count - 1;
            }
            finally
            {
                _isUpdating = false;
            }

            UpdateSelectedItemInfo();
        }

        /// <summary>
        /// Сохраняет изменения, введённые в поля выбранного товара.
        /// </summary>
        private void EditButton_Click(object? sender, EventArgs e)
        {
            Item? item = GetSelectedItem();
            if (item is null || _isAddingNew)
            {
                return;
            }

            if (!ValidateInputs(out string name, out string info, out double cost))
            {
                return;
            }

            item.Name = name;
            item.Info = info;
            item.Cost = cost;

            RefreshListBoxItem(ItemsListBox.SelectedIndex);
        }

        /// <summary>
        /// Добавляет случайно сгенерированный товар и выбирает его в списке.
        /// </summary>
        private void GenerateButton_Click(object? sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                EndAddingNew();
            }

            Item item = ItemFactory.CreateRandomItem();
            _items.Add(item);
            ItemsListBox.Items.Add(FormatItem(item));
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Удаляет выбранный товар из списка.
        /// </summary>
        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                EndAddingNew();
                return;
            }

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
        private void ItemsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            if (_isAddingNew && ItemsListBox.SelectedIndex >= 0)
            {
                _isAddingNew = false;
                AddButton.Text = "Add";
            }

            UpdateSelectedItemInfo();
        }

        private void NameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (TryAssignValue(NameTextBox, item => item.Name = NameTextBox.Text))
            {
                RefreshListBoxItem(ItemsListBox.SelectedIndex);
            }
        }

        private void InfoTextBox_TextChanged(object? sender, EventArgs e)
        {
            TryAssignValue(InfoTextBox, item => item.Info = InfoTextBox.Text);
        }

        private void CostTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating || _isAddingNew)
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