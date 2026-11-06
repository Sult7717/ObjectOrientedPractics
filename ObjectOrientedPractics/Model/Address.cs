using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Адрес доставки: хранит почтовый индекс, страну, город, улицу, номер дома и номер квартиры.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Минимальное значение почтового индекса (шестизначное число).
        /// </summary>
        public const int MinIndex = 100000;

        /// <summary>
        /// Максимальное значение почтового индекса (шестизначное число).
        /// </summary>
        public const int MaxIndex = 999999;

        /// <summary>
        /// Максимальная длина названия страны или региона.
        /// </summary>
        public const int MaxCountryLength = 50;

        /// <summary>
        /// Максимальная длина названия города (населённого пункта).
        /// </summary>
        public const int MaxCityLength = 50;

        /// <summary>
        /// Максимальная длина названия улицы.
        /// </summary>
        public const int MaxStreetLength = 100;

        /// <summary>
        /// Максимальная длина номера дома.
        /// </summary>
        public const int MaxBuildingLength = 10;

        /// <summary>
        /// Максимальная длина номера квартиры или помещения.
        /// </summary>
        public const int MaxApartmentLength = 10;

        /// <summary>
        /// Почтовый индекс (целое шестизначное число).
        /// </summary>
        private int _index = MinIndex;

        /// <summary>
        /// Страна или регион.
        /// </summary>
        private string _country = string.Empty;

        /// <summary>
        /// Город (населённый пункт).
        /// </summary>
        private string _city = string.Empty;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street = string.Empty;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building = string.Empty;

        /// <summary>
        /// Номер квартиры или помещения.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Возвращает или задаёт почтовый индекс (целое шестизначное число от <see cref="MinIndex"/> до <see cref="MaxIndex"/>).
        /// </summary>
        /// <exception cref="ArgumentException">Почтовый индекс выходит за допустимые границы.</exception>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertValueInRange(value, MinIndex, MaxIndex, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт страну или регион. Длина — не более <see cref="MaxCountryLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Строка превышает допустимую длину или равна <c>null</c>.</exception>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxCountryLength, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт город (населённый пункт). Длина — не более <see cref="MaxCityLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Строка превышает допустимую длину или равна <c>null</c>.</exception>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxCityLength, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт название улицы. Длина — не более <see cref="MaxStreetLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Строка превышает допустимую длину или равна <c>null</c>.</exception>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxStreetLength, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт номер дома. Длина — не более <see cref="MaxBuildingLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Строка превышает допустимую длину или равна <c>null</c>.</exception>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxBuildingLength, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт номер квартиры или помещения. Длина — не более <see cref="MaxApartmentLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Строка превышает допустимую длину или равна <c>null</c>.</exception>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxApartmentLength, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт пустой адрес со значениями по умолчанию.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Создаёт адрес с указанными параметрами.
        /// </summary>
        /// <param name="index">Почтовый индекс (шестизначное число).</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город (населённый пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры или помещения.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло валидацию.</exception>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
