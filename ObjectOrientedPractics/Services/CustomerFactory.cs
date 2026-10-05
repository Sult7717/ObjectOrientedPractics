using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Создаёт случайных покупателей на основе наборов реальных имён и адресов.
    /// Используется для ускорения отладки программы.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Мужские фамилии (женская форма образуется добавлением «а»).
        /// </summary>
        private static readonly string[] _surnames =
        {
            "Иванов", "Петров", "Смирнов", "Кузнецов", "Попов", "Васильев",
            "Соколов", "Михайлов", "Новиков", "Фёдоров", "Морозов", "Волков",
            "Алексеев", "Лебедев", "Семёнов", "Егоров", "Павлов", "Козлов"
        };

        /// <summary>
        /// Мужские имена.
        /// </summary>
        private static readonly string[] _maleNames =
        {
            "Александр", "Дмитрий", "Максим", "Сергей", "Андрей",
            "Алексей", "Артём", "Илья", "Кирилл", "Михаил"
        };

        /// <summary>
        /// Женские имена.
        /// </summary>
        private static readonly string[] _femaleNames =
        {
            "Анна", "Мария", "Елена", "Ольга", "Наталья",
            "Екатерина", "Татьяна", "Ирина", "Светлана", "Юлия"
        };

        /// <summary>
        /// Мужские отчества.
        /// </summary>
        private static readonly string[] _malePatronymics =
        {
            "Александрович", "Дмитриевич", "Сергеевич", "Андреевич", "Алексеевич",
            "Иванович", "Михайлович", "Николаевич", "Владимирович", "Павлович"
        };

        /// <summary>
        /// Женские отчества.
        /// </summary>
        private static readonly string[] _femalePatronymics =
        {
            "Александровна", "Дмитриевна", "Сергеевна", "Андреевна", "Алексеевна",
            "Ивановна", "Михайловна", "Николаевна", "Владимировна", "Павловна"
        };

        /// <summary>
        /// Города с почтовыми индексами.
        /// </summary>
        private static readonly (string Index, string City)[] _cities =
        {
            ("101000", "Москва"), ("190000", "Санкт-Петербург"), ("630099", "Новосибирск"),
            ("620014", "Екатеринбург"), ("420111", "Казань"), ("603000", "Нижний Новгород"),
            ("634050", "Томск"), ("443010", "Самара"), ("344002", "Ростов-на-Дону")
        };

        /// <summary>
        /// Названия улиц.
        /// </summary>
        private static readonly string[] _streets =
        {
            "Ленина", "Советская", "Мира", "Гагарина", "Пушкина",
            "Садовая", "Центральная", "Школьная", "Лесная", "Набережная"
        };

        /// <summary>
        /// Создаёт случайного покупателя.
        /// </summary>
        /// <returns>Новый покупатель с уникальным номером.</returns>
        public static Customer CreateRandomCustomer()
        {
            Random random = Random.Shared;
            bool isMale = random.Next(2) == 0;

            string surname = _surnames[random.Next(_surnames.Length)];
            string name;
            string patronymic;
            if (isMale)
            {
                name = _maleNames[random.Next(_maleNames.Length)];
                patronymic = _malePatronymics[random.Next(_malePatronymics.Length)];
            }
            else
            {
                surname += "а";
                name = _femaleNames[random.Next(_femaleNames.Length)];
                patronymic = _femalePatronymics[random.Next(_femalePatronymics.Length)];
            }

            var city = _cities[random.Next(_cities.Length)];
            string street = _streets[random.Next(_streets.Length)];
            int house = random.Next(1, 150);
            int flat = random.Next(1, 300);

            string fullname = $"{surname} {name} {patronymic}";
            string address = $"{city.Index}, г. {city.City}, ул. {street}, д. {house}, кв. {flat}";
            return new Customer(fullname, address);
        }
    }
}
