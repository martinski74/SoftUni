using Judge.App.Data;
using Microsoft.EntityFrameworkCore;
using SimpleMvc.Framework;
using SimpleMvc.Framework.Routers;

namespace Judge.App
{
    public class Launcher
    {
        static Launcher()
        {
            using (var db = new JudgeDbContext())
            {
                db.Database.Migrate();
            }

            //AutoMapperConfiguration.Initialize();
        }

        public static void Main()
            => MvcEngine.Run(
                new WebServer.WebServer(1337,
                    new ResourceRouter(),
                    new ResourceRouter()));
    }
}

