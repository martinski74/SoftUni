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
                    title: "��������������",
                    body: @"<p>������� ����� �� ������ �������� �� ������ ��������� � ������� �� ������� � ���-����� �� �������� ����� �� �������� �� ��� ��������� �� ������ ��������. �������� ��- ����� ����������� � ����������� �� ���������� ���������. ���-����� ����������� ���� ����� ����� ���������� �� �������� �� ������ ������� ���������, �� ������� � �������� � ��������. ���������� � ��������� �����������, �������� � ������������� �� �G.D. Searle� ���� 1965. �������� ����������� � ������������� �� ��������������� �������� �������� </p>
                    <p>���� ��������� �� ������������� ��������� �� ������� � ����������� ���� 1974 ��� ���������� ������� �� ������� � ������������ ���������, ���� �� ������������ ������������ �����. ������� ���� ��������������� ������ �G.D. Searle� ���� ���������� �� ���� �� �����������, ������ </p>
                    ",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "����������� �� �������",
                    body: @"<p>�������� �� ������������ �� �������� ���������. ���������� �� ��� ��������� �� ������� � ����� ���������� �� ���������� � ��� �� ����� ����������� � ������ � �� ��� �� �� ��������� ��� ���������� ������� �� ������. �������� �� ��������� ��������� �� ����������� �� ������� �� ���������, �� ���������������� �� ��������, �������� � ��������, ������ �-� ������ �����, ����� � ������ � ��������� �����������, �� ������ �������� �����. ������������ ����� ������ �� ������������� �� ����������������� ������ �� ������ �������������. �������� ����� ���� ���� � ����� �� ������, ��� ���� �� ��������� �� ��������� �������� �������, �������� ���������� ����� � ��� ��-����� ������ ������� � ���������.</p>
                    <p>��� ����� ����������� �� ������� (��� 10�C) �������� �� ������������. ������ ���� � ����� ������� � ��������� ����� �� �� �� ���������� ��������, � �� �������� �� ������ �����������. ��� ��������� ��� 40�C ������������� �� �������� ������� �� ��������, � ��� 70�C ���������� �� ������� ������. ������ � ��������� ������� ������������ �����, �� �� ���� �� �� ���������� �������� � ���������.</p>",
                    date: new DateTime(2016, 05, 11, 08, 22, 03),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "������������ �� ������������ � ������� � ���������",
                    body: @"<p>�������������� � ���� ��������� ���� � ����� ��������, ���� �� ������ ������� �� ���������� ����� ��� �������� ���������. ��� ����� ������ �� ��������� ���� ����������� ��-���� ������������.
�  ����������� �� �� ���������� ��� ���������, ��-����� �� ���������� ��������, � ����� ������ �� ��������� �� ��������� �� ������ �����, ����� �� ����� ���� � ������������ ��������. ��������� �� ����� �������� � ������������; ����� ��� ��� � ��������� �����, ���� � ��������� ��������, �� ��� ����������� ���� � �� ����� �� ������� �� �������������� ���������.</p>
                    <p> ���������  � � ������ ����� ���� �� ������������������� ������� (���) � �� �� � ������������� ���������� �� ���������� �������� ��� ������������� (�������������, ������� ���������). ����� �� �� �� ��������, �������������� ��� ���������� �������� (���. �������������, �������� � ��������). ���������� � ����� ���� �� ������� � ��� ��������� ������, ����� �� �������� � �.���. ��������������� �������� ������� ���������� �� �������� ��������� � � ������ ����������, �� ��� ��������� �������. ��� ���������� ������� ����� ��������� ����� �� �� ����� ���� �� ���������� ��������, ������ �� ����� �� ��������. ������������, ��� ���������� �� ��� ������ ���� � ���������� ������������ ������������! ����� � ���������� �� ����� ���������� �� ���������� �� �������, ����� �� ������� � ������������ ����������������.</p>
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



