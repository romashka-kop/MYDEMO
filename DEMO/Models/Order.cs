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

class Order
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(0)]
    public int Id { get; set; }

    [NotNull]
    public int Customer_Id { get; set; }

    [NotNull]
    public DateOnly Order_Date { get; set; }

    [NotNull]
    public int Cost { get; set; }
}
