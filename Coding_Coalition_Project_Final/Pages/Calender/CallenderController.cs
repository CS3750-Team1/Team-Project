using DHTMLX.Scheduler;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Coding_Coalition_Project.Pages.Calender
{
    public class CallenderController : Controller
    {
        // GET: CallenderControllerC:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Calender\CallenderController.cs
        public ActionResult Calender()        {

            return View();        
        }
      

        // GET: CallenderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CallenderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallenderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CallenderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CallenderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CallenderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CallenderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
