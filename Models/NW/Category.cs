using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbFirstMVC.Models.NW;

public partial class Category
{
    [Display(Name ="ID")]
    public int CategoryId { get; set; }

    [MaxLength (15, ErrorMessage = "The max number of characters is {1}.")]
    [Display(Name ="Category")]
    public string CategoryName { get; set; } = null!;

    [Required]
    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
