﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazynEdu.DataAcces.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
