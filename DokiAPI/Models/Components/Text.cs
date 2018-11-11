using DokiAPI.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models.Components
{
    public class Text : IComponent
    {
        [Required]
        public int Id { get; set; }
        public string Value { get; set; } = "";
        public TextWeight TextWeight { get; set; } = TextWeight.Paragraph;
    }
}
