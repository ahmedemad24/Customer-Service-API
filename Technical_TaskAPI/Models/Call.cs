using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

#nullable disable

namespace Technical_TaskAPI.Models
{
    public partial class Call
    {
        public int CallId { get; set; }
        [Required]
        public DateTime? CallDate { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
    }
}
