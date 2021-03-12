using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SearchResultFinder.Models;
using SearchResultFinder.Service;

namespace SearchResultFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchFacade _searchFacade;
        public HomeController(ISearchFacade searchFacade)
        {
            _searchFacade = searchFacade;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(SearchViewModel searchViewModel)
        {
            var searchResult = _searchFacade.GetSearchResults(searchViewModel.Url, searchViewModel.Keywords, searchViewModel.SearchEngine);
            return Json(new { data = searchResult });
        }

    }
}
