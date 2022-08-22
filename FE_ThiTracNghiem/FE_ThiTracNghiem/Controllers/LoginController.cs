using FE_ThiTracNghiem.Commons;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FE_ThiTracNghiem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(string username, string password, string sobaodanh)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    object data = new
                    {
                        userName = username,
                        password = password,
                        sobaodanh = sobaodanh,
                    };

                    var content = JsonConvert.SerializeObject(data);
                    var stringContent = new StringContent(content, UnicodeEncoding.UTF8, "application/json");

                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Clear();
                    var response = await client.PostAsync(CommonVariable.baseAddress + "Thi/Login?userName=" + username + "&password=" + password, stringContent);
                    var _resultMessage = response.Content.ReadAsStringAsync().Result;
                    var ReturnMessage = JsonConvert.DeserializeObject<Dictionary<string, object>>(_resultMessage.ToString());

                    var user = JsonConvert.DeserializeObject<Dictionary<string, object>>(ReturnMessage["user"].ToString());
                    var token = ReturnMessage["token"];
                    var userSession = new UserLogin();

                    userSession.UserName = user["username"].ToString();
                    userSession.Name = user["name"].ToString();
                    userSession.UserID = user["uuid"].ToString();
                    userSession.TokenAccess = token.ToString();
                    userSession.Password = password;

                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    Session.Timeout = 525600;


                    return Json(new { redirectToUrl = Url.Action("Index", "Home", new { area = "" }) });
                }
            }
            catch
            {

            }

            return View("Index");
        }
    }
}