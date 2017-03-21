using System.Linq;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ShareAlbumCommand
    {
        // ShareAlbum <albumId> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public string Execute(string[] data)
        {
            int albumId = int.Parse(data[0]);
            string userName = UserControl.LoggedUser.Username;
            Role permition = (Role)Enum.Parse(typeof(Role), data[1]);
            string result;

            using (var context = new PhotoShareContext())
            {
                var album = context.Albums.FirstOrDefault(a => a.Id == albumId);

                if (album == null)
                {
                    throw new ArgumentException($"Album with ID:{albumId} not found!");
                }

                var user = UserControl.LoggedUser;

                if (user == null)
                {
                    throw new ArgumentException($"User {userName} not found!");
                }

                if (permition == Role.Owner || permition == Role.Viewer)
                {
                    if (!user.AlbumRoles.Any(r => r.Role == Role.Owner))
                    {
                        throw new ArgumentException($"You are not Owner of this album and cannot share it.");
                    }
                    user.AlbumRoles.Add(new AlbumRole() { Album = album, Role = permition });
                    context.SaveChanges();
                    result = $"Username {user.Username} added to album {album.Name} ({permition})";
                }
                else
                {
                    throw new ArgumentException($"Permission must be either “Owner” or “Viewer”!");
                }

            }
            return result;
        }
    }
}
