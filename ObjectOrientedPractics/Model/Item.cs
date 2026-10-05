using Newtonsoft.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар: хранит уникальный номер, название, описание и стоимость.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Максимальная длина названия товара.
        /// </summary>
        public const int MaxNameLength = 200;

        /// <summary>
        /// Максимальная длина описания товара.
        /// </summary>
        public const int MaxInfoLength = 1000;

        /// <summary>
        /// Минимальная стоимость товара.
        /// </summary>
        public const double MinCost = 0;

        /// <summary>
        /// Максимальная стоимость товара.
        /// </summary>
        public const double MaxCost = 100000;

        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info = string.Empty;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает или задаёт название товара. Длина — не более <see cref="MaxNameLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Название превышает допустимую длину или равно <c>null</c>.</exception>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxNameLength, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт описание товара. Длина — не более <see cref="MaxInfoLength"/> символов.
        /// </summary>
        /// <exception cref="ArgumentException">Описание превышает допустимую длину или равно <c>null</c>.</exception>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxInfoLength, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт стоимость товара. Допустимый диапазон — от
        /// <see cref="MinCost"/> до <see cref="MaxCost"/>.
        /// </summary>
        /// <exception cref="ArgumentException">Стоимость выходит за границы допустимого диапазона.</exception>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, MinCost, MaxCost, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт новый товар с уникальным номером.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        public Item(string name, string info, double cost)
        {
            // Номер выдаётся после проверки значений, чтобы при ошибке не терять идентификаторы.
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Восстанавливает товар с заранее известным номером (используется при загрузке из файла).
        /// </summary>
        /// <param name="id">Номер товара.</param>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <exception cref="ArgumentException">Одно из значений не прошло проверку.</exception>
        [JsonConstructor]
        private Item(int id, string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = id;
        }
    }
}
