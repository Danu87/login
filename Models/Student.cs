using Microsoft.Build.Framework;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace login.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Standerd { get; set; }
    }
}
