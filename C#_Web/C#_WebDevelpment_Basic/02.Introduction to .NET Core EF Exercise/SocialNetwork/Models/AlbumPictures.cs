﻿namespace SocialNetwork.Models
{
    public class AlbumPictures
    {
        public int AlbumId { get; set; }

        public Album Album { get; set; }

        public int PictureId { get; set; }

        public Picture Picture { get; set; }
    }
}
