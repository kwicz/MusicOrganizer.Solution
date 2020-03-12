using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class RecordController : Controller
  {

    [HttpGet("/records")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetAll();
      return View(allRecords);
    }

    [HttpGet("/records/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/records")]
    public ActionResult Create(string title, string artist)
    {
      Record newRecord = new Record(title, artist);
      return RedirectToAction("Index");
    }

    [HttpGet("/records/{id}")]
    public ActionResult Show(int id)
    {
      Record selectedRecord = Record.Find(id);
      return View(selectedRecord);
    }
  }
}