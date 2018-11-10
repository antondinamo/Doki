using DokiAPI.Models;
using DokiAPI.Models.Components;
using DokiAPI.Models.Enums;
using DokiAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DokiAPI.Services
{
    public class PageRepository : IRepository<Page>
    {
        public Page Get(int id)
        {
            var page = new Page
            {
                Title = "Новая страница",
                Description = "Описание новой страницы"
            };
            var text1 = new Text
            {
                Value = "Новый заголовок",
                TextWeight = TextWeight.Header1
            };
            var text2 = new Text
            {
                Value = "Новый абзац текстаn\rс переносом строки",
                TextWeight = TextWeight.Paragraph
            };
            page.Components.Add(text1);
            page.Components.Add(text2);
            return page;
        }

        public IEnumerable<Page> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Create(Page item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Page item)
        {
            throw new NotImplementedException();
        }
    }
}
