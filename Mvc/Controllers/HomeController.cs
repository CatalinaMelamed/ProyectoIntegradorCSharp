﻿using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<mvcCliente> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clientes").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcCliente>>().Result;
            DataSelectList selectList = new DataSelectList();
            selectList.Clientes = empList;

            IEnumerable<mvcArticulo> artList;
            HttpResponseMessage responsearticulo = GlobalVariables.WebApiClient.GetAsync("Articuloes").Result;
            artList = responsearticulo.Content.ReadAsAsync<IEnumerable<mvcArticulo>>().Result;
            selectList.Articulos = artList;
            return View("~/Views/Home/Index.cshtml", selectList);
        }
    }
}