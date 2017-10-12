using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
using System.Collections.Generic;

namespace FriendLetter.Controllers
  {
    public class HomeController : Controlle
  {
    [HttpGet("/")]
    public ActionResult Index()
  {
    return View();
  }

    [HttpGet("/letters")]
    public ActoinResult Letters()
    {
      List<Letters> allLetters = Letters.GetAll();
    }

    [HttpGet("/letters/new")]
    public ActionResult LetterForm()
    {
      return View();
    }

    [HttpPost("/letters")]
    public ActionResult AddLetter()
    {
      Letter newLetter = new letter(Request.Form["new-Letter"]);
      List<Letter> allLetters = Letter.GetAll();
    }

    [HttpGet("/letters/{id}")]
    public ActionResult LetterDetail(int id)
    {
      Letter letter = letter.Find(id);
      return View(letter);
    }
  }
}
