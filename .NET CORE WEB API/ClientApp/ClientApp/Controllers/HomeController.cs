using ClientApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {

        HttpClient client = new HttpClient();
        public IActionResult Index()
        {

            List<Student> movie_list = new List<Student>();





            var response = client.GetAsync("http://localhost:5160/api/Student");
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var movies = test.Content.ReadAsAsync<List<Student>>();
                movies.Wait();
                movie_list = movies.Result;

            }
            return View(movie_list);


        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student movie)
        {

            // Sends a POST request as an asynchronous operation to the specified Uri with the given value serialized as JSON. 
            var response = client.PostAsJsonAsync<Student>("http://localhost:5160/api/Student", movie);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View();
        }
        public ActionResult Delete(int id)
        {
            var responce = client.DeleteAsync("http://localhost:5160/api/Student/" + id);

            responce.Wait();
            var test = responce.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }



            return RedirectToAction("NotFound");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student responce = Index(id);

            if (responce.Id == id)
            {
                return View(responce);
            }
            return RedirectToAction("NotFound");
        }

        [HttpPost]
        public ActionResult Edit(Student movie)
        {
            var responce = client.PutAsJsonAsync<Student>("http://localhost:5160/api/Student/" + movie.Id, movie);
            var test = responce.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("NotFound");
        }


        [Route("Home/Index/{id}")]
        [HttpGet]
        public Student Index(int id)
        {



            //List<Movie> movie_list = new List<Movie>();







            var response = client.GetAsync("http://localhost:5160/api/Student/" + id);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                //var movies = test.Content.ReadAsAsync<List<Movie>>();
                //movies.Wait();
                //movie_list = movies.Result;
                var result = test.Content.ReadAsAsync<Student>();
                result.Wait();
                Student finalResult = result.Result;
                return finalResult;



            }
            return null;
            //return View(movie_list);




        }


        public ActionResult Details(int id)
        {
            Student responce = Index(id);



            if (responce.Id == id)
            {
                return View(responce);
            }



            return RedirectToAction("NotFound");
        }
    }
}