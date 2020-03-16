using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAspNetCoreWeb3.Models;
using TestAspNetCoreWeb3.DomainModels;
using TestAspNetCoreWeb3.Repositories;
using AutoMapper;
using AutoMapper.Mappers;

namespace TestAspNetCoreWeb3.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository contactRepository;

        public ContactController( IContactRepository contactRepository )
        {
            this.contactRepository = contactRepository;
        }

        // GET: Contact
        public ActionResult Index()
        {
            Contact contact = contactRepository.GetContactById(1);

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Contact, ContactViewModel>();
            });

            IMapper iMapper = config.CreateMapper();
            ContactViewModel contactViewModel = iMapper.Map<Contact, ContactViewModel>(contact);

            return View(contactViewModel);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
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

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
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