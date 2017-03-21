using System.Collections.Generic;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    using System;
    public class PrintFriendsListCommand 
    {
        // PrintFriendsList <username>
        public string Execute(string[] data)
        {
            List<string> friends = new List<string>();
            string userName = data[0];
            
            using (var context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == userName);

                if (user == null)
                {
                    throw new ArgumentException($"User {userName} not found!");
                }

                foreach (var friend in user.Friends)
                {
                    friends.Add(friend.Username);
                }
            }

            if (friends.Count == 0)
            {
                return $"No friends for this user. :(";
            }
            else
            {
                return $"Friends:{Environment.NewLine}{string.Join(Environment.NewLine, friends.Select(x => $"-[{x}]"))}";
            }
        }
    }
}
