using Microsoft.AspNetCore.Server.IIS.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XUnit_proficiency.Models
{
    [Table("payer")]
    public class Payer
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public string photo { get; set; }


        public Payer(string name, int age, string photo)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
            this.photo = photo;
        }
    }
}
