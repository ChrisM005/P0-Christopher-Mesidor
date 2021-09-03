using System;
using System.Collections.Generic;

namespace RR_BL
{
    public class Reviews
    {
        public Reviews() { }
        public Reviews(int id, int uid, int rid, int? rating, string comment)
        {
            this.ID = id;
            this.UID = uid;
            this.RID = rid;
            this.Rating = rating;
            this.Comment = comment;
        }
        
        public int ID { get; set; }
        public int UID { get; set; }
        public int RID { get; set; }
        public int? Rating { get; set; }
        public string Comment { get; set; }
    }
}
