using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        //automatically add id as an identity column
        [Key]
        public int Id { get; set; }

        //name can't be null
        [Required]
        public int Name { get; set; }
        public String Author { get; set; }
    }
}
