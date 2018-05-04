using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp3
{
    [Table("case_seq_lst")]
    public class CaseSequenceList
    {
        [Key]
        public int case_seq_id { get; set; }
        public string name { get; set; }
    }
}
