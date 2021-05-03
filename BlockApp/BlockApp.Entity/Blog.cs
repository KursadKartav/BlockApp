using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }

        [BindNever] //form üzerinden gönderilmeyeceği için
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; } //onaylanıp onaylanmadığı    
        public bool IsHome { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } //Her bloğun "bir" kategorisi olabilir.

    }
}
