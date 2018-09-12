using System.Collections.Generic;

namespace Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}