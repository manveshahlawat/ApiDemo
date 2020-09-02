using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Management;
using ApiDemo.Models;
namespace ApiDemo.Controllers
{
    public class MenuApiController : ApiController
    {
        Context context = new Context();

        [HttpGet]
        public IEnumerable<Menu> GetBooks()
        {
            return context.Menus.ToList();
        }

        [HttpGet]
        public Menu GetBook(int id)
        {
            return context.Menus.Find(id);
        }

        [HttpPost]
        public bool AddBook(Menu bk)
        {
            bool successFlag = false;
            context.Menus.Add(bk);
            context.SaveChanges();
            successFlag = true;
            return successFlag;
        }

        [HttpPut]
        public bool UpdateBook(Menu bk)
        {
            bool successflag = false;
            var book = context.Menus.SingleOrDefault(x => x.Id == bk.Id);

            if (book != null)
            {
                book.FoodName = bk.FoodName;
                context.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;




        }

        [HttpDelete]
        public bool DeleteBook(int id)
        {
            bool successflag = false;
            var book = context.Menus.SingleOrDefault(x => x.Id == id);
            if (book != null)
            {
                context.Menus.Remove(book);
                context.SaveChanges();
                successflag = true;
                return successflag;
            }

            return successflag;
        }


    }
}