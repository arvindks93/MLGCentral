using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp3
{
    [Table("charge_type_lst")]
    public class ChargeTypeList
    {
        [Key]
        public int charge_type_id { get; set; }
        public string charge_class { get; set; }
    }

}
