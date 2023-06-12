namespace SalesCRMApp.Models
{
    public class WordList
    {

        public List<SalesLeadEntity> SalesList { get; set; }

        public WordList()
        {
            SalesList = new List<SalesLeadEntity>
            {
                new SalesLeadEntity { Id = 1, FirstName = "ПРИМЕР", LastName = "ОТЧЕТА", Mobile = "В ВОРДОВСКОМ",
                    Email = "ФОРМАТЕ", Source = "!" },
                new SalesLeadEntity { Id = 1, FirstName = "Nikita", LastName = "Shayko", Mobile = "89037096679",
                    Email = "nikita.shayko@yandex.ru", Source = "Youtube" },
                new SalesLeadEntity { Id = 2, FirstName = "Georgy", LastName = "Petrenko", Mobile = "8907454679",
                    Email = "georgy.petrenko@mail.ru", Source = "Rutube" },
                new SalesLeadEntity { Id = 3, FirstName = "Michael", LastName = "Brusenko", Mobile = "89037096679",
                    Email = "michael.brusenko@yandex.ru", Source = "Youtube" },
                new SalesLeadEntity { Id = 4, FirstName = "Ivan", LastName = "Ivanov", Mobile = "89037096679",
                    Email = "ivan.ivanov@yandex.ru", Source = "Youtube" },
                new SalesLeadEntity { Id = 5, FirstName = "Petr", LastName = "Kolyvanov", Mobile = "89037096679",
                    Email = "petr.kolyvanovo@yandex.ru", Source = "Twitch" },
                new SalesLeadEntity { Id = 6, FirstName = "Sergey", LastName = "Fedorenko", Mobile = "89037096679",
                    Email = "sergey.fedorenko@yandex.ru", Source = "Youtube" }
            };
        }
    }

    public class SalesLeadEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
    }
}
        
