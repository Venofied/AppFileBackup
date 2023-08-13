using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppFileBackup.Models
{
    public class MainSettings
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        [DisplayName("Комментарий")]
        public string? Description { get; set; }

        [Column(Order = 2)]
        [DisplayName("В работе")]
        public bool IsActive { get; set; }



    }
}
