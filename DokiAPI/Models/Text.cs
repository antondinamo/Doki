using DokiAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models
{
    public class Text
    {
        public string Value { get; set; } = "";
        public ICollection<Entity> Entities { get; set; } = new List<Entity>();

        public Text() { }
        public Text(string text)
        {
            Value = text;
        }

        public void AddEntity(EntityType entityType, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= Value.Length)
                throw new TextException("Стартовый индекс сущности (Entity) находится за пределами массива Value.\n\r" +
                                        $"StartIndex = {startIndex}, длинна строки Value.Lenght = {Value.Length}");

            if (startIndex + length < 0 || startIndex + length > Value.Length)
                throw new TextException("Сущность (Entity) выходит за пределы массива Value.\n\r" +
                                        $"StartIndex + Length = {startIndex + length}, Value.Length = {Value.Length}");

            if (length <= 0)
                throw new TextException($"Длина сущьности (Entity) должна быть больше нуля. length = {length}");

            Entities.Add(new Entity(entityType, startIndex, length));
        }
    }

    public class Entity
    {
        public EntityType Type { get; set; }
        public int Position { get; set; }
        public int Length { get; set; }

        public Entity(EntityType entityType, int position, int length)
        {
            Type = entityType;
            Position = position;
            Length = length;
        }
    }

    public class TextException : Exception
    {
        public TextException(string message)
            : base(message) { }
    }
}
