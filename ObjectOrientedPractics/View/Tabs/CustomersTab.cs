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
        /// Полное имя, которое получает новый покупатель при нажатии кнопки добавления.
        /// </summary>
        private const string DefaultCustomerName = "New Customer";

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
        /// а не пользователем (обработчики событий в этом случае ничего не делают).
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Возвращает или задаёт список покупателей, отображаемых на вкладке.
        /// </summary>
        /// <exception cref="ArgumentNullException">Присвоено значение <c>null</c>.</exception>
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
        /// <param name="customer">Покупатель.</param>
        /// <returns>Строка вида «Id. Полное имя».</returns>
        private static string FormatCustomer(Customer customer)
        {
            return $"{customer.Id}. {customer.Fullname.ReplaceLineEndings(" ")}";
        }

        /// <summary>
        /// Возвращает выбранного в списке покупателя.
        /// </summary>
        /// <returns>Выбранный покупатель или <c>null</c>, если ничего не выбрано.</returns>
        private Customer? GetSelectedCustomer()
        {
            int index = CustomersListBox.SelectedIndex;
            return index >= 0 && index < _customers.Count ? _customers[index] : null;
        }

        /// <summary>
        /// Добавляет покупателя в список и выбирает его.
        /// </summary>
        /// <param name="customer">Добавляемый покупатель.</param>
        private void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
            CustomersListBox.Items.Add(FormatCustomer(customer));
            CustomersListBox.SelectedIndex = _customers.Count - 1;
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
        /// Обновляет строку выбранного покупателя в списке после изменения его имени.
        /// </summary>
        /// <param name="index">Индекс покупателя.</param>
        private void RefreshListBoxItem(int index)
        {
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
        /// Заполняет поля справа данными выбранного покупателя либо очищает их,
        /// если покупатель не выбран.
        /// </summary>
        private void UpdateSelectedCustomerInfo()
        {
            Customer? customer = GetSelectedCustomer();

            _isUpdating = true;
            try
            {
                if (customer is null)
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

                bool hasSelection = customer is not null;
                FullnameTextBox.Enabled = hasSelection;
                AddressTextBox.Enabled = hasSelection;
                RemoveButton.Enabled = hasSelection;
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Пытается записать значение в выбранного покупателя и подсвечивает поле ввода
        /// красным цветом, если значение не прошло проверку.
        /// </summary>
        /// <param name="textBox">Поле ввода, из которого взято значение.</param>
        /// <param name="assign">Действие, записывающее значение в покупателя.</param>
        /// <returns><c>true</c>, если значение принято.</returns>
        private bool TryAssignValue(TextBox textBox, Action<Customer> assign)
        {
            Customer? customer = GetSelectedCustomer();
            if (_isUpdating || customer is null)
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
        /// Добавляет нового покупателя со значениями по умолчанию и выбирает его в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddButton_Click(object? sender, EventArgs e)
        {
            AddCustomer(new Customer(DefaultCustomerName, string.Empty));
        }

        /// <summary>
        /// Добавляет случайно сгенерированного покупателя и выбирает его в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void GenerateButton_Click(object? sender, EventArgs e)
        {
            AddCustomer(CustomerFactory.CreateRandomCustomer());
        }

        /// <summary>
        /// Удаляет выбранного покупателя из списка.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveButton_Click(object? sender, EventArgs e)
        {
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
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CustomersListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            UpdateSelectedCustomerInfo();
        }

        /// <summary>
        /// Записывает введённое имя в покупателя; при ошибке подсвечивает поле красным.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void FullnameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (TryAssignValue(FullnameTextBox, customer => customer.Fullname = FullnameTextBox.Text))
            {
                RefreshListBoxItem(CustomersListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Записывает введённый адрес в покупателя; при ошибке подсвечивает поле красным.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddressTextBox_TextChanged(object? sender, EventArgs e)
        {
            TryAssignValue(AddressTextBox, customer => customer.Address = AddressTextBox.Text);
        }
    }
}
