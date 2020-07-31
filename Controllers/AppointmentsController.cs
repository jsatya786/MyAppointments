﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAppointments.Models;
using MyAppointments.Services;

namespace MyAppointments.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly AppointmentService _AppointmentService;

        public AppointmentsController(AppointmentService _AppointmentService) {
            this._AppointmentService = _AppointmentService;
        }
        // GET: Appointments
        public ActionResult Index()
        {
            return View(_AppointmentService.Get());
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appointments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Appointment collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid) {
                    _AppointmentService.Create(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Appointments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Appointments/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}