using Microsoft.AspNetCore.Mvc;
using MVC_CORE_APP_2.Models;

namespace MVC_CORE_APP_2.Controllers
{
    public class DisplayAllController : Controller
    {
        public IActionResult AllProfile_Page()
        {
            List<Employeecls> employees = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                var responseTask = client.GetAsync("GetAlltab");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<Employeecls>>(); 
                    readTask.Wait();
                    employees = readTask.Result;
                }
            } 
            return View(employees);
        }

        public IActionResult Deletetab(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                var postTask = client.DeleteAsync($"deletetab/{id}");
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("AllProfile_Page");
                }
            }
            return RedirectToAction("AllProfile_Page");
        }

        public IActionResult Detailstab(int id)
        {
            Employeecls emp = null;
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                var postTask = client.GetAsync($"Gettabwithid/{id}");
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Employeecls>();
                    readTask.Wait();
                    emp = readTask.Result;
                }
                else
                {
                    emp = new Employeecls();
                }
            }
            return View(emp);
        }

        public IActionResult Edittab(int id)
        {
            Employeecls emp = null;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                var postTask = client.GetAsync($"Gettabwithid/{id}");
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Employeecls>();
                    readTask.Wait();
                    emp = readTask.Result;
                }
                else
                {
                    emp = new Employeecls();
                }
            }
            return View(emp);
        }

        public IActionResult Edittabpost(Employeecls empobj)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5076/APITesting/");
                    var postTask = client.PutAsJsonAsync<Employeecls>($"Updatetab/{empobj.eid}", empobj);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AllProfile_Page");

                    }
                }
                return View("Edittab");
            }
            return View("Edittab");
        }
    }
}
