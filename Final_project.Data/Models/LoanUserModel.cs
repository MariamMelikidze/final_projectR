using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Loans_tableR")]
[PrimaryKey("LoanID")]
public class LoanUserModel
{
    
    [Column("LoanID")]
    public int LoanID { get; set; }
        
    [Column("UserID")]
    public int UserID { get; set; }
        
    [Column("LoanType")]
    public string LoanType { get; set; }
        
    [Column("Amount")]
    public decimal Amount { get; set; }
        
    [Column("Currency")]
    public string Currency { get; set; }
        
    [Column("Period")]
    public int Period { get; set; }
        
    [Column("Status")]
    public string Status { get; set; }
        

 }