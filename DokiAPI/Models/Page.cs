using DokiAPI.Models.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Models
{
    public class Page
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<IComponent> Components { get; set; } = new List<IComponent>();
    }
}
