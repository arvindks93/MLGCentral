using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL
{
    [Table("case_type_lst")]
    public class CaseType
    {
        [Key]
        public int case_type_id { get; set; }
        public string name { get; set; }
    }
}
