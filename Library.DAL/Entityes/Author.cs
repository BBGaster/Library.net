﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.DAL.Entityes
{
    public class Author
    {
        [Key]
        public int ID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        [JsonIgnore]
        public ICollection<Book>? Books { get;  } = new List<Book>();
    }

}
