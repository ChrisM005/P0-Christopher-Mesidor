using System;
using System.Collections.Generic;

#nullable disable

namespace RR_DL.Entities
{
    public partial class Review
    {
        public int Id { get; set; }
        public int Users { get; set; }
        public int Restaurant { get; set; }
        public int? Rating { get; set; }
        public string Comments { get; set; }

        public virtual Restaurant RestaurantNavigation { get; set; }
        public virtual User UsersNavigation { get; set; }
    }
}
