using DokiAPI.Models;
using DokiAPI.Models.Cards;
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
            var text1 = new TextCard
            {
                Id = 1,
                Text = new Text("Текст номер один"),
                TextType = TextType.Header1
            };
            var text2 = new TextCard
            {
                Id = 2,
                Text = new Text("Новый абзац текста\n\r c переносом строки aasdasd asdasd"),
                TextType = TextType.Paragraph
            };
            text2.Text.AddEntity(EntityType.Bold, 0, 11);
            text2.Text.AddEntity(EntityType.Italic, 11, 8);
            text2.Text.AddEntity(EntityType.Strikethrough, 13, 5);
            text2.Text.AddEntity(EntityType.Underline, 18, 7);
            var listText = new Text("очередной пункт списка");
            listText.AddEntity(EntityType.Bold, 0, 11);
            listText.AddEntity(EntityType.Italic, 11, 8);
            var list1 = new ListCard
            {
                Id = 3,
                Items = new List<Text> { listText, listText, listText, listText },
                ListType = ListType.BulletedList
            };
            var list2 = new ListCard
            {
                Id = 3,
                Items = new List<Text> { listText, listText },
                ListType = ListType.OrderedList
            };
            page.Cards.Add(text1);
            page.Cards.Add(text2);
            page.Cards.Add(list1);
            page.Cards.Add(list2);
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
