using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenLabPractice.Model
{
    public class ServicedDevice
    {
        [Key]
        public int Id { get; set; }
        public int IdDevice { get; set; }

        [ForeignKey("IdDevice")]
        public Device Device { get; set; }
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public Users User { get; set; }
        public string Reason { get; set; }
        public enum Status 
        { 
            Новая,
            Выполняется,
            Готово
        }
        public DateTime DateOfIssue { get; set; }
    }
}
