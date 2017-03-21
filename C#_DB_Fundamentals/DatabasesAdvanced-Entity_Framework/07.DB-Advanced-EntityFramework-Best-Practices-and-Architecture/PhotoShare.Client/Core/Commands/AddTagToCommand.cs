using System.Linq;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class AddTagToCommand
    {
        // AddTagTo <albumName> <tag>
        public string Execute(string[] data)
        {
            string albumName = data[0];
            string tagName =  $"#{data[1]}";
            string result;

            using (var context = new PhotoShareContext())
            {
                var album = context.Albums.FirstOrDefault(a => a.Name == albumName);
                var tag = context.Tags.FirstOrDefault(t => t.Name == tagName);

                if (album == null || tag == null)
                {
                    throw new ArgumentException($"Either tag or album do not exist!");
                }

               var isOwner = album.AlbumRoles.Any(a => a.Role == Role.Owner);

                if (!isOwner)
                {
                    throw new ArgumentException($"You are not Owner of this album!");
                }
                album.Tags.Add(tag);
                context.SaveChanges();
                result = $"Tag {tag.Name} added to {album.Name}!";
            }
            return result;
        }
    }
}
