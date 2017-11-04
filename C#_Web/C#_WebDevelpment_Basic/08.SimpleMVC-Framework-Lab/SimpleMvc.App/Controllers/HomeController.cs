namespace SimpleMvc.App.Controllers
{
    using Framework.Controllers;
    using Framework.Attributes.Methods;

    public class HomeController : Controller
    {
        public void Index()
        {
            //Returns some view
        }

        //GET /home/create
        public void Create()
        {
            //returns form
        }

        // POST /home/create
        [HttpPost]
        public void Create(int id)
        {
            // saves the form in to the db
        }
        
    }
}
