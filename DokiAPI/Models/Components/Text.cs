using DokiAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models.Components
{
    public class Text : IComponent
    {
        public string Value { get; set; } = "";
        public TextWeight TextWeight { get; set; } = TextWeight.Paragraph;
    }
}
