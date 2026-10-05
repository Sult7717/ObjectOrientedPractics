using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Данные проекта, которые сохраняются в файл и загружаются из него.
    /// </summary>
    public class ProjectData
    {
        /// <summary>
        /// Возвращает или задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new();

        /// <summary>
        /// Возвращает или задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; } = new();
    }
}
