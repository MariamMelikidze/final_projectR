using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNamespace
{
        
}
[Table("Users")]

public sealed class User
{
        [Column("UserId")]
        public int UserId { get; set; }
        
        [Column("FirstName")]
        public string FirstName { get; set; }
        
        [Column("LastName")]
        public string LastName { get; set; }
        
        [Column("Username")]
        public string Username { get; set; }
        
        [Column("Age")]
        public int Age { get; set; }
        
        [Column("Email")]
        public string Email { get; set; }
        
        [Column("MonthlyIncome")]
        public decimal MonthlyIncome { get; set; }
        
        [Column("IsBlocked")]
        public bool IsBlocked { get; set; }
        
        [Column("HashedPassword")]
        public string HashedPassword { get; set; }
}

