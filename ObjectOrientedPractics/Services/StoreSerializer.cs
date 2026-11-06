using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сохраняет данные магазина (<see cref="Store"/>) в JSON-файл и загружает их обратно.
    /// </summary>
    public static class StoreSerializer
    {
        /// <summary>
        /// Имя файла с данными магазина.
        /// </summary>
        private const string FileName = "store.json";

        /// <summary>
        /// Возвращает путь к файлу данных в папке запущенного приложения.
        /// </summary>
        public static string DefaultFilePath => Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            FileName);

        /// <summary>
        /// Сохраняет данные магазина в файл по умолчанию.
        /// </summary>
        /// <param name="store">Сохраняемый объект магазина.</param>
        /// <exception cref="IOException">Не удалось записать файл.</exception>
        public static void Save(Store store)
        {
            Save(store, DefaultFilePath);
        }

        /// <summary>
        /// Сохраняет данные магазина в указанный файл.
        /// </summary>
        /// <param name="store">Сохраняемый объект магазина.</param>
        /// <param name="filePath">Путь к файлу.</param>
        /// <exception cref="IOException">Не удалось записать файл.</exception>
        public static void Save(Store store, string filePath)
        {
            ArgumentNullException.ThrowIfNull(store);
            ArgumentException.ThrowIfNullOrEmpty(filePath);

            string? directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonConvert.SerializeObject(store, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Загружает данные магазина из файла по умолчанию.
        /// </summary>
        /// <returns>Загруженный объект <see cref="Store"/> или новый пустой магазин, если файла ещё нет.</returns>
        /// <exception cref="IOException">Не удалось прочитать файл.</exception>
        /// <exception cref="InvalidDataException">Содержимое файла некорректно.</exception>
        public static Store Load()
        {
            return Load(DefaultFilePath);
        }

        /// <summary>
        /// Загружает данные магазина из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Загруженный объект <see cref="Store"/> или новый пустой магазин, если файла не существует.</returns>
        /// <exception cref="IOException">Не удалось прочитать файл.</exception>
        /// <exception cref="InvalidDataException">Содержимое файла некорректно.</exception>
        public static Store Load(string filePath)
        {
            ArgumentException.ThrowIfNullOrEmpty(filePath);

            if (!File.Exists(filePath))
            {
                return new Store();
            }

            string json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            Store? store;
            try
            {
                store = JsonConvert.DeserializeObject<Store>(json, settings);
            }
            catch (Exception ex) when (ex is JsonException or ArgumentException)
            {
                throw new InvalidDataException($"Файл «{filePath}» содержит некорректные данные.", ex);
            }

            store ??= new Store();

            // Чтобы новые объекты не получили уже занятые номера.
            int maxItemId = store.Items.Select(item => item.Id).DefaultIfEmpty(0).Max();
            int maxCustomerId = store.Customers.Select(customer => customer.Id).DefaultIfEmpty(0).Max();
            IdGenerator.SynchronizeWith(Math.Max(maxItemId, maxCustomerId));

            return store;
        }
    }
}
