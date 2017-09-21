namespace _02.OneToManyRalation
{
    using System;

    public class OneToMany
    {
        public static void Main()
        {
            // Included problem 3(Self-Referenced Table)

            MyDbContext context = new MyDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
