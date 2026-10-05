namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует уникальные идентификаторы. Нумерация сквозная для всех
    /// классов программы (товаров, покупателей и т.д.).
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Объект синхронизации для потокобезопасной генерации идентификаторов.
        /// </summary>
        private static readonly object _lockObject = new();

        /// <summary>
        /// Последний выданный идентификатор.
        /// </summary>
        private static int _lastId;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Новый уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            lock (_lockObject)
            {
                _lastId++;
                return _lastId;
            }
        }

        /// <summary>
        /// Согласовывает генератор с уже использованными идентификаторами,
        /// например, после загрузки данных из файла. Следующий выданный
        /// идентификатор будет больше <paramref name="lastUsedId"/>.
        /// </summary>
        /// <param name="lastUsedId">Наибольший из уже использованных идентификаторов.</param>
        public static void SynchronizeWith(int lastUsedId)
        {
            lock (_lockObject)
            {
                if (lastUsedId > _lastId)
                {
                    _lastId = lastUsedId;
                }
            }
        }
    }
}
