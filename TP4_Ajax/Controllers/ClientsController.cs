using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TP4_Ajax.Data;
using TP4_Ajax.Models;
using TP4_Ajax.ViewModels;

namespace TP4_Ajax.Controllers
{
    public class ClientsController : Controller
    {
        private readonly TPDbContext _context;

        public ClientsController(TPDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{controller}/{action}")]
        public async Task<IActionResult> Index()
        {
            var vm = _context.Clients
                .Include(c => c.Abonnement)
                .Select(client => new ClientIndexVM()
                {
                    ClientId = client.ClientId,
                    Nom = client.Nom,
                    Age = client.Age,
                    Courriel = client.Courriel,
                    NoTelephone = client.NoTelephone,
                    AbonnementId = client.AbonnementId,
                    Abonnement = client.Abonnement

                })
                .ToList();

            return View(vm);
        }






        [HttpGet]
        [Route("{controller}/{action}")]
        public IActionResult Create()
        {
            ClientCreateVM vm = new ClientCreateVM();

            vm.ListeAbonnementSelectItems = _context.Abonnements
                .Select(a => new SelectListItem()
                {
                    Text = a.Type,
                    Value = a.AbonnementId.ToString()
                })
                .ToList();


            return View(vm);
        }



        [HttpPost]
        [Route("{controller}/{action}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientCreateVM vm)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    Client nouveauClient = new Client();
                    nouveauClient.ClientId = vm.ClientId;
                    nouveauClient.Courriel = vm.Courriel;
                    nouveauClient.Nom = vm.Nom;
                    nouveauClient.NoTelephone = vm.NoTelephone;
                    nouveauClient.Age = vm.Age;
                    nouveauClient.AbonnementId = vm.AbonnementId;




                    _context.Clients.Add(nouveauClient);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(vm);
            }
            catch (Exception)

            {
                return View("Error");
            }
        }



        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.ClientId == id);
        }
    }
}
