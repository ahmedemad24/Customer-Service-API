using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

#nullable disable

namespace Technical_TaskAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Calls = new HashSet<Call>();
        }

        public int CustomerId { get; set; }
        [Required, MinLength(3)]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public int? CustomerPhone { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [JsonIgnore]

        public virtual ICollection<Call> Calls { get; set; }
    }
}
