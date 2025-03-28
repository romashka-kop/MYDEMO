﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO.Models;

class Customer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(0)]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Patronymic { get; set; }

    public string? Email { get; set; }

    public string? NumberPhone { get; set; }
}
