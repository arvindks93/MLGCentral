using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL
{
    [Table("case_lst")]
    public class CaseList
    {
        [Key]
        public int case_id { get; set; }
        public string case_num { get; set; }
        public int case_seq_id { get; set; }
        public int case_type_id { get; set; }
        public DateTime create_dt { get; set; }
    }
}
