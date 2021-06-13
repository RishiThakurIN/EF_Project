using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    [Table("tbl_Genre")]
    public class Gener
    {
        public int GenerId { get; set; }

        [Column("Name")]
        public string GenerName { get; set; }
        //public int DisplayOrder { get; set; }
    }
}
