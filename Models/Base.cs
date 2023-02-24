using System.ComponentModel.DataAnnotations;

namespace InversiApp.API.Models
{
    public abstract class Base
    {
        [Key]
        public int ID { get; set; }
    }
}
