namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Содержит методы проверки значений, общие для классов бизнес-логики.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает заданного максимума.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, в котором выполняется проверка.</param>
        /// <exception cref="ArgumentNullException">
        /// Строка не задана (<c>null</c>).
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Длина строки превышает <paramref name="maxLength"/>.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(propertyName, $"{propertyName} не должен быть null");
            }

            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в заданном диапазоне (границы включаются).
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="minValue">Минимально допустимое значение.</param>
        /// <param name="maxValue">Максимально допустимое значение.</param>
        /// <param name="propertyName">Имя свойства, в котором выполняется проверка.</param>
        /// <exception cref="ArgumentException">
        /// Число выходит за границы диапазона или не является числом (<see cref="double.NaN"/>).
        /// </exception>
        public static void AssertValueInRange(double value, double minValue, double maxValue, string propertyName)
        {
            // Сравнение записано в «положительной» форме, чтобы NaN тоже считался ошибкой.
            if (!(value >= minValue && value <= maxValue))
            {
                throw new ArgumentException($"{propertyName} должен быть в диапазоне от {minValue} до {maxValue}");
            }
        }
    }
}
