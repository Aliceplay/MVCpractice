using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCpractice.Data;
using MVCpractice.Models;

namespace MVCpractice.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "keyboard" };
            return View(item);
        }
        
        //下方是READ DATA
        private readonly MyContext _context;
        public ItemsController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var item = await _context.items.ToListAsync();
            return View(item);
        }
        //修改跟刪除
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            
            return Content("id=" + id);
        }
        public IActionResult Delete(int id) 
        {
            return Content("");
        }

    }
}
