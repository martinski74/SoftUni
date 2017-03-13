using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers.Models
{
    public class Picture
    {
        public Picture()
        {
            this.Albums = new List<Album>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string FileSystemPath { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}

