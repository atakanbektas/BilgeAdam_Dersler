using _11.IdentityUygulama.Models;
using _11.IdentityUygulama.Models.Authentication.SignIn;
using _11.IdentityUygulama.Models.Authentication.SıgnUp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Management.Service.Models;
using MyCompany.Management.Service.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace _11.IdentityUygulama.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromForm] SignInAppUser appUser)
        {
            IActionResult viewResult;
            var userByName = await _userManager.FindByNameAsync(appUser.Username);

            if (userByName != null)
            {
                if (await _userManager.CheckPasswordAsync(userByName, appUser.Password))
                {
                    //TOKEN GENERATION
                    //TOKEN DISPLAY

                    var payload = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,appUser.Username),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()
                        )};


                    viewResult = RedirectToAction("Index", "Home");
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "HATA", Message = "Parola hatalıdır!" });

                }
            }
            else
            {
                viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "HATA", Message = "Sistemde böyle bir kullanıcı bulunamadı!" });
            }


            return viewResult;
        }





        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] SignUpAppUser appUser, string role = "USER")
        {
            IActionResult viewResult;
            var userByName = await _userManager.FindByNameAsync(appUser.Username);
            var userByEmail = await _userManager.FindByEmailAsync(appUser.Email);

            if (userByEmail != null || userByName != null)
            {
                viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "Hata Oluştu", Message = "Bu kullanıcı zaten kayıtlı!" });
            }
            else
            {
                var userRole = await _roleManager.FindByNameAsync(role);
                if (userRole != null)
                {
                    IdentityUser eklenecekKullanici = new()
                    {
                        UserName = appUser.Username,
                        Email = appUser.Email,
                        SecurityStamp = Guid.NewGuid().ToString(),
                    };

                    var eklemeSonucu = await _userManager.CreateAsync(eklenecekKullanici, appUser.Password);

                    if (eklemeSonucu.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(eklenecekKullanici, role);
                        viewResult = RedirectToAction("Index");
                    }
                    else
                    {
                        viewResult = StatusCode(StatusCodes.Status500InternalServerError, new AppResponse() { Status = "Hata Oluştu", Message = "Kullanıcı sisteme kayıt edilirken sunucuda hata oluştu!" });
                    }
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "Hata Oluştu", Message = "Böyle bir kullanıcı bulunamadı!" });
                }
            }

            return viewResult;
        }

        public IActionResult SendMail()
        {
            var emailMessage = new MailMessage(new Dictionary<string, string>()
            {
                { "Atakan Bektaş 1", "atakanbektas.c@gmail.com" },
                { "Fatih Kaan Açıkgöz 2", "gokcehangucuk@gmail.com" }
            },
            "İlk mail denemesi başlığı",
            "<h1>Mantığının anlaşılması gereken hadiseler</h1>" +
            "<ol>" +
            "<li>" +
            "OOP Mantığı" +
            "</li>" +
            "<li>" +
            "SOLID prensipleri" +
            "</li>" +
            "</ol>" +
            "<p>Yazan: " +
            "<b>Fatih Kaan Açıkgöz</b>" +
            "</p>");

            _emailService.SendEmail(emailMessage);

            return StatusCode(StatusCodes.Status200OK, new AppResponse() { Status = "Başarılı", Message = "Email başarıyla gönderildi!" });
        }
    }
}
