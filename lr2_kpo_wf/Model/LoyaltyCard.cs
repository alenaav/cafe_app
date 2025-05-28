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
    [Table("loyalty_cards")]
    public class LoyaltyCard
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [Column("card_number")]
        [MaxLength(6)]
        public string CardNumber { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("level")]
        public string Level { get; set; } = "Бронзовый";

    }
}
