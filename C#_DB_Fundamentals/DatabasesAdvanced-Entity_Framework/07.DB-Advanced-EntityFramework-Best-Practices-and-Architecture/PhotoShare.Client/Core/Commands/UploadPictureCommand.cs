using System.Linq;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class UploadPictureCommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public string Execute(string[] data)
        {
            string albumName = data[0];
            string pictureTitle = data[1];
            string pictureFilePath = data[2];
            string result;

            using (var context = new PhotoShareContext())
            {
                var album = context.Albums.FirstOrDefault(a => a.Name == albumName);

                if (album == null)
                {
                    throw new ArgumentException($"Album {albumName} not found!");
                }

                if (!UserControl.LoggedUser.AlbumRoles.Any(r => r.Role == Role.Owner))
                {
                    throw new ArgumentException($"You are not Owner of this album and cannot upload pictures to it.");
                }

                album.Pictures.Add(new Picture()
                {
                    Title = pictureTitle,
                    Path = pictureFilePath
                });

                context.SaveChanges();
                result = $"Picture {pictureTitle} added to {album.Name}!";
            }
            return result;
        }
    }
}
