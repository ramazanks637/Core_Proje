﻿using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.UserName, userLoginViewModel.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı adı veya şifre");
                }

            }
            return View();
        }
    }
}
