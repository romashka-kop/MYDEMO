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

class Delivery
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(0)]
    public int Id { get; set; }

    [NotNull]
    public int Order_Id { get; set; }

    [NotNull]
    public DateOnly Delivery_Date { get; set; }

    public string? Status { get; set; }
}
