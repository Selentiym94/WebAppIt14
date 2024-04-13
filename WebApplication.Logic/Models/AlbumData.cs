﻿using Miha.Models;
using System.Xml.Linq;

namespace WebApplication2.Logic.Models
{
    public class AlbumData
    {
        public AlbumData(Album album, List<Photo> photos)
        {
            Album = album;
            Photos = photos;
        }
        public Album Album { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
