﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenerator.Controllers
{
    public class BuildController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
