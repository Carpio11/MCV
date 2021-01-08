using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2021.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            return View();
        }

        // GET: /table/Details/5 

        public ActionResult Details(int id)
        {

            return View();

        }

        //

        // GET: /table/Create 

        public ActionResult Create()
        {

            return View();

        }

        //

        // POST: /table/Create 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create(FormCollection collection)
        {

            try
            {

                // TODO: Add insert logic here 

                return RedirectToAction("Index");

            }

            catch
            {

                return View();

            }

        }

        //

        // GET: /table/Edit/5

        public ActionResult Edit(int id)
        {

            return View();

        }

        //

        // POST: /table/Edit/5 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {

                // TODO: Add update logic here

                return RedirectToAction("Index");

            }

            catch
            {

                return View();

            }

            

             private _2021.Models.Database1Entities _db = new _2021.Models.Database1Entities(); 

        public ActionResult Index()

        {

            return View(_db.Table.ToList());

        }

        }
    }
}