using Newtonsoft.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель: хранит уникальный номер, полное имя и адрес доставки.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Максимальная длина полного имени покупателя.
        /// </summary>
        public const int MaxFullnameLength = 200;

        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя (Фамилия Имя Отчество).
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Возвращает уникальный номер покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает или задаёт полное имя покупателя (Фамилия Имя Отчество).
        /// Длина — не более <see cref="MaxFullnameLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Имя превышает допустимую длину или равно <c>null</c>.</exception>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxFullnameLength, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт адрес доставки покупателя.
        /// </summary>
        /// <exception cref="ArgumentNullException">Адрес равен <c>null</c>.</exception>
        public Address Address
        {
            get => _address;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт нового покупателя с пустым адресом доставки и уникальным номером.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <exception cref="ArgumentException">Имя не прошло проверку.</exception>
        public Customer(string fullname)
        {
            Fullname = fullname;
            Address = new Address();
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создаёт нового покупателя с указанным адресом доставки и уникальным номером.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        public Customer(string fullname, Address address)
        {
            // Номер выдаётся после проверки значений, чтобы при ошибке не терять идентификаторы.
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создаёт нового покупателя с указанными параметрами адреса и уникальным номером.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        public Customer(string fullname, int index, string country, string city, string street, string building, string apartment)
        {
            Fullname = fullname;
            Address = new Address(index, country, city, street, building, apartment);
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Восстанавливает покупателя с заранее известным номером (используется при загрузке из файла).
        /// </summary>
        /// <param name="id">Номер покупателя.</param>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        [JsonConstructor]
        private Customer(int id, string fullname, Address? address)
        {
            Fullname = fullname;
            Address = address ?? new Address();
            _id = id;
        }
    }
}
