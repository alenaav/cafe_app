using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace lr2_kpo_wf.Model
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("email")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [Column("password_hash")]
        [MaxLength(40)]
        public string PasswordHash { get; set; }

        [Required]
        [Column("full_name")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Column("phone")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        public static string ComputeHash(string password)
        {
            using (var sha1 = SHA1.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = sha1.ComputeHash(bytes);
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }

        /// <summary>
        /// Attempts to authenticate a user by email and plaintext password.
        /// </summary>
        public static User Login(string email, string password)
        {
            var hash = ComputeHash(password);
            using (var db = new UserContext())
            {
                return db.Users.FirstOrDefault(u => u.Email == email && u.PasswordHash == hash);
            }
        }
    }
}