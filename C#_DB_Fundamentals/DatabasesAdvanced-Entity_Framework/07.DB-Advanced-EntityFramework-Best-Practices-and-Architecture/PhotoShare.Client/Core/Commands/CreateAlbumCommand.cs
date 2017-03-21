using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class CreateAlbumCommand
    {
        // CreateAlbum <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            string username = UserControl.LoggedUser.Username;
            string albumTitle = data[0];
            Color bgColor = Color.Black;
            HashSet<Tag> tags = new HashSet<Tag>();
            string result;

            using (var context = new PhotoShareContext())
            {
                var albumName = context.Albums.FirstOrDefault(a => a.Name == albumTitle);
                if (albumName != null)
                {
                    throw new ArgumentException($"Album {albumTitle} exists!");
                }

                var user = UserControl.LoggedUser;

                if (user == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                if (data.Length >= 2)
                {
                    if (!Enum.IsDefined(typeof(Color), data[1]))
                    {
                        throw new ArgumentException($"Color {data[1]} not found!");
                    }
                    bgColor = (Color)Enum.Parse(typeof(Color), data[1]);

                    if (data.Length > 2)
                    {
                        List<string> albumTagNames = new List<string>(data.Skip(2).ToList());
                        bool match = true;
                        foreach (var albumTagName in albumTagNames)
                        {
                            if (match)
                            {
                                match = false;
                                foreach (var tag in context.Tags)
                                {
                                    if (tag.Name == $"#{albumTagName}")
                                    {
                                        match = true;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                throw new ArgumentException($"Invalid tags!");
                            }
                        }

                        foreach (var albumTagName in albumTagNames)
                        {
                            Tag tag = new Tag()
                            {
                                Name = $"#{albumTagName}",
                            };
                            tags.Add(tag);
                        }
                    }
                }

                Album album = new Album()
                {
                    Name = albumTitle,
                    IsPublic = true
                };

                if (data.Length >= 2)
                {
                    album.BackgroundColor = bgColor;
                }

                foreach (var tag in tags)
                {
                    album.Tags.Add(tag);
                }

                context.Albums.Add(album);
                context.SaveChanges();
                result = $"Album {album.Name} successfully created!";
            }
            return result;
        }
    }
}
