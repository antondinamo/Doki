using DokiAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models.Cards
{
    public class ListCard : ICard
    {
        public int Id { get; set; }
        public CardType CardType { get; } = CardType.List;
        public ICollection<Text> Items { get; set; } = new List<Text>();
        public TextType TextType { get; } = TextType.Paragraph;
        public ListType ListType { get; set; } = ListType.BulletedList;
    }
}
