using System;
using Common.Entities;

namespace Autoservice.Entities
{
    [Serializable] 
    public class Maintenance : Entity
    {
        public Transport Transport { get; set; }
        public Service Service { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Cost { get; set; }
        public string Note { get; set; }

        public override string Key
        {
            get { return $"{Transport?.Key} - {Service?.Name}"; }
        }

        public override string ToString()
        {
            return string.Format(
                "\tОбслуговування №{0}\n" +
                "\tТранспортний засіб: {1}\n" +
                "\tПослуга: {2}\n" +
                "\tДата: {3:dd.MM.yyyy HH:mm:ss}\n" +
                "\tВартість: {4}\n" +
                "\tПримітка: {5}",
                Id,
                Transport?.Key,
                Service?.Name,
                Date,
                Cost,
                Note
            );
        }

        public Maintenance(Transport transport, Service service, DateTime date, decimal cost, string note)
        {
            Transport = transport;
            Service = service;
            Date = date;
            Cost = cost;
            Note = note;
        }

        public Maintenance() : this(null, null, DateTime.MinValue, 0, null) { }
    }
}