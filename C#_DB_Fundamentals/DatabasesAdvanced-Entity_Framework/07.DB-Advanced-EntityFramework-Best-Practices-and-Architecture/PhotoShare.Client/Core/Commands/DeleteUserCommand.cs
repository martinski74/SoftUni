namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    public class DeleteUserCommand
    {
        // DeleteUser 
        public string Execute()
        {
            string username = UserControl.LoggedUser.Username;
            using (PhotoShareContext context = new PhotoShareContext())
            {
                var user = UserControl.LoggedUser;
                if (user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                if (user.IsDeleted.Value)
                {
                    throw new InvalidOperationException($"User {username} is already deleted!");
                }
                user.IsDeleted = true;

                context.SaveChanges();

                return $"User {username} was deleted successfully!";
            }
        }
    }
}
