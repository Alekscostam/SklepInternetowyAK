﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SklepInternetowyAK.DAL;
using SklepInternetowyAK.Infrastructure;
using SklepInternetowyAK.ViewModels;

namespace SklepInternetowyAK.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        CartManager cartManager;
        FilmsContext db;
        ISessionManager session;

        public CartController()
        {
            db = new FilmsContext();
            session = new SessionManager();
            cartManager = new CartManager(db, session);
        }


        // GET: Cart
        public ActionResult Index()
        {
            CartViewModel cvm = new CartViewModel()
            {
                CartItems = cartManager.GetCartItems(),
                TotalPrice = cartManager.GetCartValue()
            };

            return View(cvm);
        }

        public ActionResult AddToCart(int id)
        {
            cartManager.AddToCart(id);

            return RedirectToAction("Index");
        }
    }
}