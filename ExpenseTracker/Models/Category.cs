﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
