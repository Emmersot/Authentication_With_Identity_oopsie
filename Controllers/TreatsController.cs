using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierreSweets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreSweets.Controllers
{
  [Authorize]
  public class TreatsController : Controller
  {
    private readonly PierreSweetsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
  
    public TreatsController(UserManager<ApplicationUser> userManager, PierreSweetsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index(string searchString)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      if(!string.IsNullOrEmpty(searchString))
      {
        var model = _db.Treats
          .Where(treat => treat.Ingredients.Contains(searchString))
          .OrderByDescending(treat => treat.Rating)
          .ToList();
        return View(model);
      }
      else
      {
        var model = _db.Treats
          .OrderByDescending(treat => treat.Rating)
          .ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Treat treat, int CategoryId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      treat.User = currentUser;
      _db.Treats.Add(treat);
      _db.SaveChanges();
      if (CategoryId != 0)
      {
        _db.CategoryTreat.Add(new CategoryTreat() { CategoryId = CategoryId, TreatId = treat.TreatId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
          .Include(treat => treat.JoinEntities)
          .ThenInclude(join => join.Category)
          .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat, int CategoryId)
    {
      if (CategoryId != 0)
      {
        _db.CategoryTreat.Add(new CategoryTreat() { CategoryId = CategoryId, TreatId = treat.TreatId });
      }
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCategory(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddCategory(Treat treat, int CategoryId)
    {
      if (CategoryId != 0)
      {
      _db.CategoryTreat.Add(new CategoryTreat() { CategoryId = CategoryId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
      var joinEntry = _db.CategoryTreat.FirstOrDefault(entry => entry.CategoryTreatId == joinId);
      _db.CategoryTreat.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}