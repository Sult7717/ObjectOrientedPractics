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
        /// Максимальная длина адреса доставки.
        /// </summary>
        public const int MaxAddressLength = 500;

        /// <summary>
        /// Уникальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя (Фамилия Имя Отчество).
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private string _address = string.Empty;

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
        /// Возвращает или задаёт адрес доставки.
        /// Длина — не более <see cref="MaxAddressLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Адрес превышает допустимую длину или равен <c>null</c>.</exception>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxAddressLength, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт нового покупателя с уникальным номером.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        public Customer(string fullname, string address)
        {
            // Номер выдаётся после проверки значений, чтобы при ошибке не терять идентификаторы.
            Fullname = fullname;
            Address = address;
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
        private Customer(int id, string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = id;
        }
    }
}
