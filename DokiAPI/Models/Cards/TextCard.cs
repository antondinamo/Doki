using DokiAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models.Cards
{
    public class TextCard : ICard
    {
        public int Id { get; set; }
        public CardType CardType { get; } = CardType.Text;
        public Text Text { get; set; } = new Text();
        public TextType TextType { get; set; } = TextType.Paragraph;
    }
}
