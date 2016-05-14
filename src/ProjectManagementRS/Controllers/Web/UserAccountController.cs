using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using ProjectManagementRS.Dtos;
using ProjectManagementRS.Models;
using System.Threading.Tasks;

namespace ProjectManagementRS.Controllers.Web
{
    public class UserAccountController: Controller
    {
        private IUserRepository _userRepository;

        public UserAccountController(IUserRepository repository)
        {
            _userRepository = repository;
        }

        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(int Token, string Email)
        {
            User user = _userRepository.FindById(Token);
            if (user != null)
            {
                if (user.Email == Email)
                {
                    user.IsActive = true;
                  //  _userRepository.UpdateAsync(user);
                   // await SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home", new { ConfirmedEmail = user.Email });
                }
                else
                {
                    return RedirectToAction("Confirm", "Account", new { Email = user.Email });
                }
            }
            else
            {
                return RedirectToAction("Confirm", "Account", new { Email = "" });
            }
        }

        [AllowAnonymous]
        public ActionResult Confirm(string Email)
        {
            ViewBag.Email = Email;
            return View();
        }
        [HttpGet]
        public ActionResult UserRegistration(UserDto model)
        {
            //if (ModelState.IsValid)
            //{
            //    var user = new User() { UserName = model.UserName };
            //    user.Email = model.Email;
            //    user.IsActive = false;
            //    bool success =  _userRepository.TryCreate(user, model.Password);
            //    if (success)
            //    {
            //        //System.Net.Mail.MailMessage m = new System.Net.Mail.MailMessage(
            //        //new System.Net.Mail.MailAddress("sender@mydomain.com", "Web Registration"),
            //        //new System.Net.Mail.MailAddress(user.Email));
            //        //m.Subject = "Email confirmation";
            //        //m.Body = string.Format(@"Dear {0}
            //        //<BR/> Thank you for your registration, please click on the
          
            //        //   below link to complete your registration: < a href =""{1}""         
            //        //   title =""User Email Confirm"">{1}</a>", user.UserName, Url.Action("ConfirmEmail", "Account",
            //        //   new { Token = user.Id, Email = user.Email }, "blaaa")) ;
            //        //m.IsBodyHtml = true;
            //        //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.mydomain.com");
            //        //smtp.Credentials = new System.Net.NetworkCredential("sender@mydomain.com", "password");
            //        //smtp.EnableSsl = true;
            //        //smtp.Send(m);
            //        //return RedirectToAction("Confirm", "Account", new { Email = user.Email });
            //    }
            //    else
            //    {
            //       // AddErrors(result);
            //    }
            //}
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        public ActionResult LogIn(UserLoginDto model, string returnUrl)
        {
            //if (ModelState.IsValid)
            //{
            //    var user = _userRepository.FindUser(model.UserName, model.Password);
            //    if (user != null)
            //    {
            //        if (user.IsActive == true)
            //        {
            //            //await SignInAsync(user, model.RememberMe);
            //            //return RedirectToLocal(returnUrl);
            //        }
            //        else
            //        {
            //            ModelState.AddModelError("", "Confirm Email Address.");
            //        }
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Invalid username or password.");
            //    }
            //}
            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}
