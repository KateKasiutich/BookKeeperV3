using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public User UserId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}