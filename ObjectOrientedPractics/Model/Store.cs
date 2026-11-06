namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Магазин: хранит данные всех товаров и покупателей приложения.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список всех товаров магазина.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Список всех покупателей магазина.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Возвращает или задаёт список товаров магазина.
        /// </summary>
        /// <exception cref="ArgumentNullException">Список равен <c>null</c>.</exception>
        public List<Item> Items
        {
            get => _items;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт список покупателей магазина.
        /// </summary>
        /// <exception cref="ArgumentNullException">Список равен <c>null</c>.</exception>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _customers = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр магазина с пустыми списками товаров и покупателей.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
