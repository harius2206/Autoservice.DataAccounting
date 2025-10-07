using System;
using Common.Entities;
using Common.Interfaces;

namespace Autoservice.Entities
{
    [Serializable]
    public class Transport : Entity, IHierarchical<Transport>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public Owner Owner { get; set; }
        public Transport Parent { get; set; }

        public override string Key
        {
            get { return Number; }
        }

        public override string ToString()
        {
            string parentInfo = Parent != null
                ? $"{Parent.Key} ({Parent.Make} {Parent.Model})"
                : "-";
            return string.Format(
                "\tМарка: {0}\n" +
                "\tМодель: {1}\n" +
                "\tНомер: {2}\n" +
                "\tОпис: {3}\n" +
                "\tВласник: {4}\n" +
                "\tБатьківський транспорт: {5}",
                Make,
                Model,
                Number,
                Description,
                Owner?.Key,
                parentInfo
            );
        }

        public Transport(string make, string model, string number, string description, Owner owner, Transport parent = null)
        {
            Make = make;
            Model = model;
            Number = number;
            Description = description;
            Owner = owner;
            Parent = parent;
        }

        public Transport() : this(null, null, null, null, null) { }
    }
}