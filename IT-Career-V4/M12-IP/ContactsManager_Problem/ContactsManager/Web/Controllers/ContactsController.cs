using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Contacts;
using Web.Models.Shared;

namespace Web.Controllers
{
    public class ContactsController : Controller
    {
        private const int PageSize = 10;
        private readonly ContactsDb _context;

        public ContactsController()
        {
            _context = new ContactsDb();
        }

        // GET: Contacts
        public async Task<IActionResult> Index(ContactsIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<ContactsViewModel> items = await _context.Contacts.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(c => new ContactsViewModel()
            {
                Id = c.Id,
                Email = c.Email,
                Name = c.Name,
                Note = c.Note,
                PhoneNumber = c.PhoneNumber

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Contacts.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ContactsCreateViewModel model = new ContactsCreateViewModel();

            return View(model);
        }

        // POST: Contacts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactsCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact
                {
                    Note = model.Note,
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber
                };

                _context.Add(contact);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            ContactsEditViewModel model = new ContactsEditViewModel
            {
                Id = contact.Id,
                Email = contact.Email,
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber,
                Note = contact.Note

            };

            return View(model);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ContactsEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Contact contact = new Contact
                {
                    Id = model.Id,
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber,
                    Note = model.Note
                };

                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Contact contact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}
