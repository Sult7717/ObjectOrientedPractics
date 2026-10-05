using Newtonsoft.Json;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сохраняет данные проекта в JSON-файл и загружает их обратно.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Имя файла с данными проекта.
        /// </summary>
        private const string FileName = "project.json";

        /// <summary>
        /// Возвращает путь к файлу данных в папке запущенного приложения.
        /// </summary>
        public static string DefaultFilePath => Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            FileName);

        /// <summary>
        /// Сохраняет данные проекта в файл по умолчанию.
        /// </summary>
        /// <param name="data">Сохраняемые данные.</param>
        /// <exception cref="IOException">Не удалось записать файл.</exception>
        public static void Save(ProjectData data)
        {
            Save(data, DefaultFilePath);
        }

        /// <summary>
        /// Сохраняет данные проекта в указанный файл.
        /// </summary>
        /// <param name="data">Сохраняемые данные.</param>
        /// <param name="filePath">Путь к файлу.</param>
        /// <exception cref="IOException">Не удалось записать файл.</exception>
        public static void Save(ProjectData data, string filePath)
        {
            ArgumentNullException.ThrowIfNull(data);
            ArgumentException.ThrowIfNullOrEmpty(filePath);

            string? directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Загружает данные проекта из файла по умолчанию.
        /// </summary>
        /// <returns>Загруженные данные или пустой проект, если файла ещё нет.</returns>
        /// <exception cref="IOException">Не удалось прочитать файл.</exception>
        /// <exception cref="InvalidDataException">Содержимое файла некорректно.</exception>
        public static ProjectData Load()
        {
            return Load(DefaultFilePath);
        }

        /// <summary>
        /// Загружает данные проекта из указанного файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Загруженные данные или пустой проект, если файла не существует.</returns>
        /// <exception cref="IOException">Не удалось прочитать файл.</exception>
        /// <exception cref="InvalidDataException">Содержимое файла некорректно.</exception>
        public static ProjectData Load(string filePath)
        {
            ArgumentException.ThrowIfNullOrEmpty(filePath);

            if (!File.Exists(filePath))
            {
                return new ProjectData();
            }

            string json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            ProjectData? data;
            try
            {
                data = JsonConvert.DeserializeObject<ProjectData>(json, settings);
            }
            catch (Exception ex) when (ex is JsonException or ArgumentException)
            {
                throw new InvalidDataException($"Файл «{filePath}» содержит некорректные данные.", ex);
            }

            data ??= new ProjectData();

            // Чтобы новые объекты не получили уже занятые номера.
            int maxItemId = data.Items.Select(item => item.Id).DefaultIfEmpty(0).Max();
            int maxCustomerId = data.Customers.Select(customer => customer.Id).DefaultIfEmpty(0).Max();
            IdGenerator.SynchronizeWith(Math.Max(maxItemId, maxCustomerId));

            return data;
        }
    }
}
