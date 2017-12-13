namespace CamerBazaar.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class CameraContoller : Controller
    {
        [Authorize]
        public IActionResult Add() => this.View();

    }
}
