using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Models;

class Category
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(0)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }
}
