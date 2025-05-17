using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lr2_kpo_wf.Model
{
    [Table("loyalty_points")]
    public class LoyaltyPoints
    {
        [Key]
        [Column("card_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardId { get; set; }

        [Required]
        [Column("current_balance")]
        public int CurrentBalance { get; set; }

        [Required]
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}

