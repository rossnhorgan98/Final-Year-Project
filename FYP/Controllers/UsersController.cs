//This controller was scaffolded by using the "add MVC Controller with Views, using Entity Framework" option 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FYP.Models;
using Microsoft.AspNetCore.Identity;

namespace FYP.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        
        public IActionResult Index()
        {
            var users = userManager.Users;
            return View(users);
        }

        
        public async Task<IActionResult> Details(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new ApplicationUser
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                CurrentCity = user.CurrentCity,
                CurrentCountry = user.CurrentCountry
            };

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    CurrentCity = model.City,
                    CurrentCountry = model.Country 
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        /* Code below is based on:
           Edit identity user in asp.net core
           Pragimtech
           https://csharp-video-tutorials.blogspot.com/2019/07/edit-identity-user-in-aspnet-core.html */
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }         

            var model = new ApplicationUser
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                CurrentCity = user.CurrentCity,
                CurrentCountry = user.CurrentCountry
            };

            return View(model);
        }

       
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApplicationUser model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.CurrentCity = model.CurrentCity;
                user.CurrentCountry = model.CurrentCountry;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }
        //End

        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new ApplicationUser
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                CurrentCity = user.CurrentCity,
                CurrentCountry = user.CurrentCountry
            };

            return View(model);
        }

        /* Code below is based on:
           Delete identity user in asp.net core
           Pragimtech
           https://csharp-video-tutorials.blogspot.com/2019/08/delete-identity-user-in-aspnet-core.html */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return RedirectToAction(nameof(Index));
            }
        }
        //End
    }
}
