using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TFNetSecurity.Entyities;
using TFNetSecurity.Models;

namespace TFNetSecurity.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            return View(FakeDB.GetAll());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            User selected = FakeDB.GetById(id);
            return View(selected);

        }

        // GET: UserController/Create
        public ActionResult Create(User userf)
        {
            if (ModelState.IsValid)
            {
                User nouveauuser = new User()
                {
                    //Id = userf.Id,
                    Nom = userf.Nom,
                    Prenom = userf.Prenom,
                    Email=userf.Email,
                    Birthdate = userf.Birthdate,
                    
                };
                FakeDB.Ajouter(nouveauuser);
                return RedirectToAction("Index");
            }
            return View(userf);
        }
        //[HttpPost]
        public IActionResult Edit(int id)
        {
            User entite = FakeDB.GetById(id);
            return View(entite);
        }
        [HttpPost]
        public ActionResult Edit(User entite)
        {
            if (ModelState.IsValid)
            {
                // Mettre à jour l'entité dans la fausse base de données
                FakeDB.UpdateEntite(entite);
                return RedirectToAction("Index");
            }
            return View(entite);
        }

            public IActionResult Delete(int id)
        {
            FakeDB.Delete(id);
            return RedirectToAction("Index");
        }


    }
}



