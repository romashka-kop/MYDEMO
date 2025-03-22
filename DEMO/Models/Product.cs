using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace DEMO.Models;

class Product
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(0)]
    public int Id { get; set; }

    public string? Title { get; set; }

    [NotNull]
    public int Price { get; set; }

    [NotNull]
    public int Category_Id { get; set; }
}
