using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp3
{
    [Table("case_lst")]
    public class CaseList
    {
        [Key]
        public int case_id { get; set; }
        public string case_num { get; set; }
        public int cur_case_stat_id { get; set; }
        public int client_id { get; set; }
        public int case_type_id { get; set; }
        public int case_seq_id { get; set; }
        public DateTime create_dt { get; set; }
        public int user_id { get; set; }
    }
}
