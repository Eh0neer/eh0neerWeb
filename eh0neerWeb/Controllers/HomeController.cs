using eh0neerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eh0neerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var personalInfo = new PersonalInfo
            {
                FullName = "Косарев Андрей Иванович",
                PhotoUrl = "/images/profile.jpg",
                Bio = "Я разработчик программного обеспечения с опытом работы в создании веб-приложений и инфраструктур с использованием современных технологий. А также создание настольных приложений.",
                Occupation = "Middle .NET C# Software Developer"
            };

            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Проект 1",
                    Description = "Описание проекта 1",
                    ScreenshotUrl = "/images/project1.jpg",
                    CodeSnippet = "// Пример кода...",
                    ProjectUrl = "https://github.com/ivanov/project1"
                },
                new Project
                {
                    Title = "Проект 2",
                    Description = "Описание проекта 2",
                    ScreenshotUrl = "/images/project2.jpg",
                    CodeSnippet = "// Пример кода...",
                    ProjectUrl = "https://github.com/ivanov/project2"
                }
            };

            var contact = new Contact
            {
                TelegramUrl = "https://t.me/eh0neer",
                Email = "eh0neer@silverloom.ru",
                HhUrl = "https://hh.ru/resume/17f225bdff0b8a98f60039ed1f7073396d4e72",
                LinkedInUrl = "",
                GitHubUrl = "https://github.com/Eh0neer"
            };

            var portfolioViewModel = new PortfolioViewModel
            {
                PersonalInfo = personalInfo,
                Projects = projects,
                Contact = contact
            };

            return View(portfolioViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
