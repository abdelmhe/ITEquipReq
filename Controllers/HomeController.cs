using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ITEquipReq.Models;

namespace ITEquipReq.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RequestForm(){
        return View();
    }
    [HttpPost]
    public ViewResult RequestForm(FormResponse formResponse)
    {
        if (ModelState.IsValid){
            Repository.AddResponse(formResponse);
            return View("Confirmation", formResponse);
        }else{
            return View();
        }


    }

   
    public ViewResult Requests()
    
    {
        return View(Repository.Responses);


    }

    // All Equipment ActionMethod 
    public ViewResult AllEquipment()
    
    {
        return View(EquipmentRepository.GetEquipment());


    }

    // Available Equipment ActionMethod
    
}
