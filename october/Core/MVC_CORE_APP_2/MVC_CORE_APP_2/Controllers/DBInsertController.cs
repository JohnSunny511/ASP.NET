using Microsoft.AspNetCore.Mvc;
using MVC_CORE_APP_2.Models;
using System.Net;
using System.Net.Http;

namespace MVC_CORE_APP_2.Controllers
{
    public class DBInsertController : Controller
    {
        public IActionResult Insert_Load()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert_Click(Employeecls objcls)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                var postTask = client.PostAsJsonAsync<Employeecls>("posttab", objcls);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("AllProfile_Page", "DisplayAll");
                }
            }
            return RedirectToAction("AllProfile_Page", "DisplayAll");
        }


        
    }
}
