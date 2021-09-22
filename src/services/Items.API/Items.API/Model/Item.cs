using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Items.API.Model
{
    /// <summary>
    /// Entity object
    /// </summary>
    public class Item
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Owner { get; set; }
    }
}
