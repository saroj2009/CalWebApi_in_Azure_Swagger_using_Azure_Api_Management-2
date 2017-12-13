using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CalDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index(FormCollection form, string Calculator)
        {
            var Number1 = form["txtNumber1"].ToString();
            var Number2 = form["txtNumber2"].ToString();
            ViewBag.Req1 = Number1;
            ViewBag.Req2 = Number2;
            var URI = "https://calwebapimanagement.azure-api.net/cal/api/Math/";
            var wr = WebRequest.CreateHttp("https://calwebapimanagement.azure-api.net/cal/api/Math/");
            if (Calculator == "Add")
            {
                ViewBag.Title = "Home Page";
                wr = WebRequest.CreateHttp(URI + Calculator + "?value1=" + Number1 + "&value2=" + Number2);
                //wr.Headers.Add("Ocp-Apim-Subscription-Key", "6d5ed66744a14f2eb23618880e82162a");
                using (var response = wr.GetResponse())
                {
                    var html = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    ViewBag.WebResponse = html;
                }
            }
            if (Calculator == "Substract")
            {
                ViewBag.Title = "Home Page";
                wr = WebRequest.CreateHttp(URI + Calculator + "?value1=" + Number1 + "&value2=" + Number2);
                //wr.Headers.Add("Ocp-Apim-Subscription-Key", "6d5ed66744a14f2eb23618880e82162a");
                using (var response = wr.GetResponse())
                {
                    var html = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    ViewBag.WebResponse = html;
                }
            }
            if (Calculator == "Multiply")
            {
                ViewBag.Title = "Home Page";
                wr = WebRequest.CreateHttp(URI + Calculator + "?value1=" + Number1 + "&value2=" + Number2);
                //wr.Headers.Add("Ocp-Apim-Subscription-Key", "6d5ed66744a14f2eb23618880e82162a");
                using (var response = wr.GetResponse())
                {
                    var html = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    ViewBag.WebResponse = html;
                }
            }
            if (Calculator == "Divide")
            {
                ViewBag.Title = "Home Page";
                wr = WebRequest.CreateHttp(URI + Calculator + "?value1=" + Number1 + "&value2=" + Number2);
                //wr.Headers.Add("Ocp-Apim-Subscription-Key", "6d5ed66744a14f2eb23618880e82162a");
                using (var response = wr.GetResponse())
                {
                    var html = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    ViewBag.WebResponse = html;
                }
            }
            return View();
        }
    }
}
