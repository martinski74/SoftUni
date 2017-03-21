using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class MakeFriendsCommand
    {
        // MakeFriends <username2>
        public string Execute(string[] data)
        {
            string userName1 = UserControl.LoggedUser.Username;
            string userName2 = data[1];
            string result;

            using (var context = new PhotoShareContext())
            {
                var user1 = UserControl.LoggedUser;
                var user2 = context.Users.FirstOrDefault(u => u.Username == userName2);

                if (user1 != null)
                {
                    if (user2 != null)
                    {
                        if (!user1.Friends.Contains(user2))
                        {
                            user1.Friends.Add(user2);
                            context.SaveChanges();
                            result = $"Friend {userName2} added to {userName1}";
                        }
                        else
                        {
                            throw new InvalidOperationException($"{userName2} is already a friend to {userName1}");
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"{userName2} not found!");
                    }
                }
                else
                {
                    throw new ArgumentException($"{userName1} not found!");
                }
            }
            return result;

        }
    }
}
