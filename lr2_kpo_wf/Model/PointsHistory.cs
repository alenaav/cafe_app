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
    [Table("points_history")]
    public class PointsHistory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("card_id")]
        public int CardId { get; set; }

        [Required]
        [Column("points_change")]
        public int PointsChange { get; set; }

        [Required]
        [Column("change_date")]
        public DateTime ChangeDate { get; set; }

        [Required]
        [Column("order_id")]
        public int OrderId { get; set; }
    }
}
