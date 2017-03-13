using Photographers.Data;
using Photographers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers
{
    class Program
    {
        static void Main(string[] args)
        {
            // From 05 - 10 exercise are here!
            var context = new PhotographerContext();
            Console.WriteLine(context.Photographers.Count());

            //08.Tag attribute
            Tag tag = new Tag() { Label = "#Krushi" };
            context.Tags.Add(tag);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                tag.Label = TagTransformer.Transform(tag.Label);
                context.SaveChanges();
            }

        }
    }
}
