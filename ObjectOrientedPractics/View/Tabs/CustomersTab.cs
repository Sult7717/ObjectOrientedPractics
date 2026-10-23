using System.ComponentModel;
using System.Globalization;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы со списком покупателей: добавление, выбор, редактирование и удаление.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Цвет фона поля ввода с некорректным значением.
        /// </summary>
        private static readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Список покупателей. Порядок совпадает с порядком элементов в <see cref="CustomersListBox"/>.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Признак того, что элементы управления обновляются программно,
        /// а не пользователем.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Признак режима добавления нового покупателя: поля справа пусты
        /// и предназначены для ввода данных нового покупателя.
        /// </summary>
        private bool _isAddingNew;

        /// <summary>
        /// Возвращает или задаёт список покупателей, отображаемых на вкладке.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _customers = value;
                RebuildCustomersListBox();
            }
        }

        /// <summary>
        /// Создаёт вкладку покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            UpdateSelectedCustomerInfo();
        }

        /// <summary>
        /// Возвращает текст для отображения покупателя в списке.
        /// </summary>
        private static string FormatCustomer(Customer customer)
        {
            return $"{customer.Id}. {customer.Fullname.ReplaceLineEndings(" ")}";
        }

        /// <summary>
        /// Возвращает выбранного в списке покупателя.
        /// </summary>
        private Customer? GetSelectedCustomer()
        {
            int index = CustomersListBox.SelectedIndex;
            return index >= 0 && index < _customers.Count ? _customers[index] : null;
        }

        /// <summary>
        /// Полностью перестраивает <see cref="CustomersListBox"/> по текущему списку покупателей.
        /// </summary>
        private void RebuildCustomersListBox()
        {
            _isUpdating = true;
            try
            {
                CustomersListBox.BeginUpdate();
                CustomersListBox.Items.Clear();
                foreach (Customer customer in _customers)
                {
                    CustomersListBox.Items.Add(FormatCustomer(customer));
                }
                CustomersListBox.EndUpdate();
            }
            finally
            {
                _isUpdating = false;
            }

            if (_customers.Count > 0)
            {
                CustomersListBox.SelectedIndex = 0;
            }
            else
            {
                UpdateSelectedCustomerInfo();
            }
        }

        /// <summary>
        /// Обновляет строку покупателя в списке после изменения его имени.
        /// </summary>
        private void RefreshListBoxItem(int index)
        {
            if (index < 0 || index >= _customers.Count)
            {
                return;
            }

            _isUpdating = true;
            try
            {
                CustomersListBox.Items[index] = FormatCustomer(_customers[index]);
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Заполняет поля справа данными выбранного покупателя либо очищает их.
        /// </summary>
        private void UpdateSelectedCustomerInfo()
        {
            Customer? customer = GetSelectedCustomer();

            _isUpdating = true;
            try
            {
                if (customer is null || _isAddingNew)
                {
                    IdTextBox.Clear();
                    FullnameTextBox.Clear();
                    AddressTextBox.Clear();
                }
                else
                {
                    IdTextBox.Text = customer.Id.ToString(CultureInfo.CurrentCulture);
                    FullnameTextBox.Text = customer.Fullname;
                    AddressTextBox.Text = customer.Address;
                }

                FullnameTextBox.BackColor = SystemColors.Window;
                AddressTextBox.BackColor = SystemColors.Window;

                bool hasSelection = customer is not null && !_isAddingNew;
                FullnameTextBox.Enabled = hasSelection;
                AddressTextBox.Enabled = hasSelection;

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
        /// Пытается записать значение в выбранного покупателя и подсвечивает поле
        /// красным цветом, если значение не прошло проверку.
        /// </summary>
        private bool TryAssignValue(TextBox textBox, Action<Customer> assign)
        {
            Customer? customer = GetSelectedCustomer();
            if (_isUpdating || customer is null || _isAddingNew)
            {
                return false;
            }

            try
            {
                assign(customer);
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
        private bool ValidateInputs(out string fullname, out string address)
        {
            bool isValid = true;
            fullname = FullnameTextBox.Text;
            address = AddressTextBox.Text;

            if (string.IsNullOrWhiteSpace(fullname))
            {
                FullnameTextBox.BackColor = _errorColor;
                isValid = false;
            }
            else
            {
                FullnameTextBox.BackColor = SystemColors.Window;
            }

            AddressTextBox.BackColor = SystemColors.Window;
            return isValid;
        }

        /// <summary>
        /// Включает режим добавления нового покупателя: очищает поля справа
        /// и делает их доступными для ввода.
        /// </summary>
        private void StartAddingNew()
        {
            _isAddingNew = true;

            _isUpdating = true;
            try
            {
                CustomersListBox.ClearSelected();
                IdTextBox.Clear();
                FullnameTextBox.Clear();
                AddressTextBox.Clear();

                FullnameTextBox.BackColor = SystemColors.Window;
                AddressTextBox.BackColor = SystemColors.Window;

                FullnameTextBox.Enabled = true;
                AddressTextBox.Enabled = true;

                RemoveButton.Enabled = false;
                EditButton.Enabled = false;
                AddButton.Text = "Save";
            }
            finally
            {
                _isUpdating = false;
            }

            FullnameTextBox.Focus();
        }

        /// <summary>
        /// Выключает режим добавления нового покупателя.
        /// </summary>
        private void EndAddingNew()
        {
            _isAddingNew = false;
            AddButton.Text = "Add";
            UpdateSelectedCustomerInfo();
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

            if (!ValidateInputs(out string fullname, out string address))
            {
                return;
            }

            var customer = new Customer(fullname, address);
            _customers.Add(customer);
            CustomersListBox.Items.Add(FormatCustomer(customer));

            _isAddingNew = false;
            AddButton.Text = "Add";

            _isUpdating = true;
            try
            {
                CustomersListBox.SelectedIndex = _customers.Count - 1;
            }
            finally
            {
                _isUpdating = false;
            }

            UpdateSelectedCustomerInfo();
        }

        /// <summary>
        /// Сохраняет изменения, введённые в поля выбранного покупателя.
        /// </summary>
        private void EditButton_Click(object? sender, EventArgs e)
        {
            Customer? customer = GetSelectedCustomer();
            if (customer is null || _isAddingNew)
            {
                return;
            }

            if (!ValidateInputs(out string fullname, out string address))
            {
                return;
            }

            customer.Fullname = fullname;
            customer.Address = address;

            RefreshListBoxItem(CustomersListBox.SelectedIndex);
        }

        /// <summary>
        /// Добавляет случайно сгенерированного покупателя и выбирает его в списке.
        /// </summary>
        private void GenerateButton_Click(object? sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                EndAddingNew();
            }

            Customer customer = CustomerFactory.CreateRandomCustomer();
            _customers.Add(customer);
            CustomersListBox.Items.Add(FormatCustomer(customer));
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Удаляет выбранного покупателя из списка.
        /// </summary>
        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            if (_isAddingNew)
            {
                EndAddingNew();
                return;
            }

            int index = CustomersListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (_customers.Count > 0)
            {
                CustomersListBox.SelectedIndex = Math.Min(index, _customers.Count - 1);
            }
            else
            {
                UpdateSelectedCustomerInfo();
            }
        }

        /// <summary>
        /// Отображает данные выбранного покупателя в полях справа.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            if (_isAddingNew && CustomersListBox.SelectedIndex >= 0)
            {
                _isAddingNew = false;
                AddButton.Text = "Add";
            }

            UpdateSelectedCustomerInfo();
        }

        private void FullnameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (TryAssignValue(FullnameTextBox, customer => customer.Fullname = FullnameTextBox.Text))
            {
                RefreshListBoxItem(CustomersListBox.SelectedIndex);
            }
        }

        private void AddressTextBox_TextChanged(object? sender, EventArgs e)
        {
            TryAssignValue(AddressTextBox, customer => customer.Address = AddressTextBox.Text);
        }

        private void SelectedCustomerTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}