using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyHealthyBlog.Models;

namespace MyHealthyBlog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyHealthyBlog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyHealthyBlog.Models.ApplicationDbContext";
        }

        protected override void Seed(MyHealthyBlog.Models.ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                // If the database is empty, populate sample data in it

                CreateUser(context, "admin@gmail.com", "123", "System Administrator");
                CreateUser(context, "pesho@gmail.com", "123", "Peter Ivanov");
                CreateUser(context, "merry@gmail.com", "123", "Maria Petrova");

                CreateRole(context, "Administrators");
                AddUserToRole(context, "admin@gmail.com", "Administrators");

                CreatePost(context,
                    title: "Подсладителите",
                    body: @"<p>Навярно много от нашите читатели са главно запознати с вредите от захарта и най-често се замислят първо за фигурата си при покупката на сладки продукти. Всъщност по- малко калоричните й заместители са истинските вредители. Най-често съобщението „без захар“ върху опаковките на любимите ви сладки изделия означават, че захарта е заменена с аспартам. Аспартамът е изкуствен подсладител, създаден в лабораториите на “G.D. Searle” през 1965. Научните изследвания в лабораторията на фармацевтичната компания откриват </p>
                    <p>След одобрение от Американската асоциация по храните и лекарствата през 1974 той постепенно започва да навлиза в хранителната индустрия, като се популяризира изключително бързо. Въпреки това фармацевтичният гигант “G.D. Searle” бива разследван от екип от специалисти, заради </p>
                    ",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "Температура на хранене",
                    body: @"<p>Ензимите са жизненоважни за човешкия организъм. Незаменими са при смилането на храната и дават възможност на веществата в нея да бъдат абсорбирани в кръвта и от там да се използват при различните функции на тялото. Ензимите са основните виновници за доставянето на енергия на организма, за възстановяването на клетките, тъканите и органите, затова д-р Едуард Хауъл, лекар и пионер в ензимните изследвания, ги нарича „искрици живот”. Изключително важен фактор за ефективността на храносмилателните ензими се оказва температурата. Днешната храна като цяло е бедна на ензими, тъй като на трапезата си сервираме предимно готвени, термично обработени ястия и все по-малко пресни плодове и зеленчуци.</p>
                    <p>При ниска температура на храната (под 10°C) ензимите не функционират. Поради това е нужно студени и замразени храни да не се консумират директно, а да престоят на стайна температура. При загряване над 40°C ефективността на ензимите започва да намалява, а при 70°C действието им напълно замира. Затова е необходим техният допълнителен прием, за да може да се възстанови балансът в организма.</p>",
                    date: new DateTime(2016, 05, 11, 08, 22, 03),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "Класификация на компонентите в храните и добавките",
                    body: @"<p>Терминологията в това отношение сега е доста объркана, като за дадено понятие на различните места има различни пояснения. Тук бихме искали да предложим едно сравнително по-ясно подразделяне.
•  Подправките са от растителен или минерален, по-рядко от синтетичен произход, и преди всичко се използват за постигане на вкусов ефект, макар че някои имат и консервиращи свойства. Влиянието им върху здравето е нееднозначно; между тях има и прекрасни билки, соли и органични киселини, но при предозиране дори и те могат да доведат до неблагоприятни резултати.</p>
                    <p> Добавките  – в случая става дума за биологичноактивните добавки (БАД) – те са с концентрирано съдържание на хранителни вещества или биопротектори (антиоксиданти, билкови екстракти). Могат да са от природен, полусинтетичен или синтетичен произход (вкл. аминокиселини, витамини и минерали). Обикновено в малки дози са полезни и без странични ефекти, макар че например в т.нар. ортомолекулярна медицина отделни субстанции се прилагат безвредно и в големи количества, но при съответни условия. Над определена граница обаче добавките могат да са добри само за определени индивиди, докато на други да навредят. Следователно, при употребата им във високи дози е необходимо индивидуално съобразяване! Важно е опаковките да бъдат придружени от информация за състава, срока на годност и евентуалните противопоказания.</p>
                    ",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "pesho@gmail.com"
                );

                context.SaveChanges();
            }
        }

        private void CreateUser(ApplicationDbContext context,
            string email, string password, string fullName)
        {
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = fullName
            };

            var userCreateResult = userManager.Create(user, password);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(ApplicationDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreatePost(ApplicationDbContext context,
            string title, string body, DateTime date, string authorUsername)
        {
            var post = new Post();
            post.Title = title;
            post.Body = body;
            post.Date = date;
            post.Author = context.Users.Where(u => u.UserName == authorUsername).FirstOrDefault();
            context.Posts.Add(post);
        }
    }
}



