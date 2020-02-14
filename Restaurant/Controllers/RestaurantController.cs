using RestaurantDAL;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        RestaurantRepository restaurantRepository = new RestaurantRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DisplayRestaurantDetails()
        {
            
            IEnumerable<RestaurantFields> restaurantList =restaurantRepository.DisplayRestaurantFields();
            ViewBag.RestaurantDetails = restaurantList;
            return View();
        }
        public ActionResult ViewRestaurantDetails()
        {
            IEnumerable<RestaurantFields> viewRestaurantList = restaurantRepository.DisplayRestaurantFields();
            ViewData["RestaurantDetails"] = viewRestaurantList;
            return View();
        }
        public ActionResult TempDataResult()
        {
            IEnumerable<RestaurantFields> RestaurantList = restaurantRepository.DisplayRestaurantFields();
            TempData["RestaurantDetails"] = RestaurantList;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RestaurantFields restaurantFields)
        {
            restaurantRepository.Add(restaurantFields);
            return RedirectToAction("TempDataResult");
        }
        public ActionResult Delete(int id)
        {
            restaurantRepository.Delete(id);
            return RedirectToAction("TempDataResult");
        }
        public ActionResult Edit(int id)
        {
            RestaurantFields restaurantFields = restaurantRepository.GetRestaurantById(id);
            return View(restaurantFields);
        }
        public ActionResult Update(RestaurantFields restaurantFields)
        {
            restaurantRepository.Update(restaurantFields);
            return RedirectToAction("TempdataResult");
        }
    }
}