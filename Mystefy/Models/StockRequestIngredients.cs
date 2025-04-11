using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mystefy.Models;

public class StockRequestIngredients
{
    
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{ get; set; }
    [Required]
    public int AmountRequested{ get; set; }
    [Required]
    // public string Status { get; set; } = string.Empty;
    public StockStatus Status{ get; set; }
    public DateTime RequestDate { get; set; } = DateTime.UtcNow;


    // Foreign Keys 
    // FK Constraint formed with Ingredients Table
    [Required]
    [ForeignKey("Ingredients")]
    public int IngredientsId { get; set; }
    public Ingredients? Ingredients { get; set; }


    [Required]
    [ForeignKey("User")]
    // FK Constraint formed with User Table
    public int? UserId { get; set; }
    //Navigation Property of Ingredients
    public User? User { get; set; }


    // FK Constraint formed with Warehouse Table
    [Required]
    [ForeignKey("Warehouse")]
    public int WarehouseId { get; set; }
    //Navigation Property of Ingredients
    public Warehouse? Warehouse { get; set; }
}
