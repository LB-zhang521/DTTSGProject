﻿using DTTSG_BLL.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTTSG_Web.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager();

        // GET: Book
        public ActionResult BookList()
        {
            ViewBag.BookList = bookManager.GetBookList();
            return View();
        }
    }
}