using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenLabPractice.Model
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public int IdCategory { get; set; }

        [ForeignKey("IdCategory")]
        public Category Category { get; set; }
        public string Name { get; set; }
        public enum Status
        {
            Свободен,
            Используется,
            Обслуживается
        }
    }
}
