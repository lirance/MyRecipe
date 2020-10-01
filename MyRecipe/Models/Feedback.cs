using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyRecipe.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "please fill your name")]
        [StringLength(50, ErrorMessage = "name cannot extend 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please fill your email")]
        [StringLength(50, ErrorMessage = "email cannot extend 50 characters")]
        [DataType(DataType.EmailAddress, ErrorMessage = "wrong email format")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "please fill the right format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "please fill your feedback")]
        [StringLength(400, ErrorMessage = "feedback cannot extend 400 characters")]
        public string Message { get; set; }
        public DateTime CreateDateUTC { get; set; }
    }
}
