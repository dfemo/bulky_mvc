using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models.Status
{
    public class Status : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}

