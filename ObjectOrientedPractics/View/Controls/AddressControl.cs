using System.ComponentModel;
using System.Globalization;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для отображения, редактирования и валидации адреса доставки (<see cref="Model.Address"/>).
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Цвет фона поля ввода с некорректным значением.
        /// </summary>
        private static readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Текущий редактируемый адрес доставки.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Признак программного обновления полей элемента управления.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Возвращает или задаёт адрес доставки, отображаемый в элементе управления.
        /// При получении гарантирует актуальность всех корректно введённых данных.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                ApplyValidFieldsToAddress();
                return _address;
            }
            set
            {
                _address = value ?? new Address();
                UpdateControlsFromAddress();
            }
        }

        /// <summary>
        /// Создаёт элемент управления для редактирования адреса доставки.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            UpdateControlsFromAddress();
        }

        /// <summary>
        /// Очищает все текстовые поля и сбрасывает подсветку ошибок.
        /// </summary>
        public void Clear()
        {
            _isUpdating = true;
            try
            {
                PostIndexTextBox.Clear();
                CountryTextBox.Clear();
                CityTextBox.Clear();
                StreetTextBox.Clear();
                BuildingTextBox.Clear();
                ApartmentTextBox.Clear();
                ResetValidationState();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Проверяет корректность всех введённых полей адреса, подсвечивает ошибки и записывает корректные значения в <see cref="Address"/>.
        /// </summary>
        /// <returns><c>true</c>, если все поля заполнены корректно; иначе <c>false</c>.</returns>
        public bool ValidateAddress()
        {
            bool isIndexValid = ValidateAndAssignPostIndex();
            bool isCountryValid = ValidateAndAssignString(CountryTextBox, val => _address.Country = val);
            bool isCityValid = ValidateAndAssignString(CityTextBox, val => _address.City = val);
            bool isStreetValid = ValidateAndAssignString(StreetTextBox, val => _address.Street = val);
            bool isBuildingValid = ValidateAndAssignString(BuildingTextBox, val => _address.Building = val);
            bool isApartmentValid = ValidateAndAssignString(ApartmentTextBox, val => _address.Apartment = val);

            return isIndexValid && isCountryValid && isCityValid && isStreetValid && isBuildingValid && isApartmentValid;
        }

        /// <summary>
        /// Заполняет текстовые поля данными из объекта <see cref="_address"/>.
        /// </summary>
        private void UpdateControlsFromAddress()
        {
            _isUpdating = true;
            try
            {
                PostIndexTextBox.Text = _address.Index.ToString(CultureInfo.CurrentCulture);
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
                ResetValidationState();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        /// <summary>
        /// Сбрасывает цвет фона всех полей и очищает всплывающие подсказки об ошибках.
        /// </summary>
        private void ResetValidationState()
        {
            TextBox[] textBoxes =
            {
                PostIndexTextBox, CountryTextBox, CityTextBox,
                StreetTextBox, BuildingTextBox, ApartmentTextBox
            };

            foreach (TextBox textBox in textBoxes)
            {
                textBox.BackColor = SystemColors.Window;
                ErrorToolTip.SetToolTip(textBox, string.Empty);
            }
        }

        /// <summary>
        /// Применяет все корректные значения из полей ввода к объекту <see cref="_address"/>.
        /// </summary>
        private void ApplyValidFieldsToAddress()
        {
            if (int.TryParse(PostIndexTextBox.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int index))
            {
                try { _address.Index = index; } catch (ArgumentException) { }
            }

            try { _address.Country = CountryTextBox.Text; } catch (ArgumentException) { }
            try { _address.City = CityTextBox.Text; } catch (ArgumentException) { }
            try { _address.Street = StreetTextBox.Text; } catch (ArgumentException) { }
            try { _address.Building = BuildingTextBox.Text; } catch (ArgumentException) { }
            try { _address.Apartment = ApartmentTextBox.Text; } catch (ArgumentException) { }
        }

        /// <summary>
        /// Проверяет и записывает почтовый индекс, устанавливая подсветку и всплывающую подсказку при ошибке.
        /// </summary>
        private bool ValidateAndAssignPostIndex()
        {
            if (!int.TryParse(PostIndexTextBox.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int index))
            {
                PostIndexTextBox.BackColor = _errorColor;
                ErrorToolTip.SetToolTip(PostIndexTextBox, "Почтовый индекс должен быть целым шестизначным числом.");
                return false;
            }

            try
            {
                _address.Index = index;
                PostIndexTextBox.BackColor = SystemColors.Window;
                ErrorToolTip.SetToolTip(PostIndexTextBox, string.Empty);
                return true;
            }
            catch (ArgumentException ex)
            {
                PostIndexTextBox.BackColor = _errorColor;
                ErrorToolTip.SetToolTip(PostIndexTextBox, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Проверяет и записывает строковое поле адреса, устанавливая подсветку и всплывающую подсказку при ошибке.
        /// </summary>
        private bool ValidateAndAssignString(TextBox textBox, Action<string> assign)
        {
            try
            {
                assign(textBox.Text);
                textBox.BackColor = SystemColors.Window;
                ErrorToolTip.SetToolTip(textBox, string.Empty);
                return true;
            }
            catch (ArgumentException ex)
            {
                textBox.BackColor = _errorColor;
                ErrorToolTip.SetToolTip(textBox, ex.Message);
                return false;
            }
        }

        private void PostIndexTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignPostIndex();
        }

        private void CountryTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignString(CountryTextBox, val => _address.Country = val);
        }

        private void CityTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignString(CityTextBox, val => _address.City = val);
        }

        private void StreetTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignString(StreetTextBox, val => _address.Street = val);
        }

        private void BuildingTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignString(BuildingTextBox, val => _address.Building = val);
        }

        private void ApartmentTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }

            ValidateAndAssignString(ApartmentTextBox, val => _address.Apartment = val);
        }
    }
}
