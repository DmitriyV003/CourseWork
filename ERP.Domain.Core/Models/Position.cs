﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.Domain.Core.Abstract;
using ERP.Domain.Core.Enums;
using JetBrains.Annotations;

namespace ERP.Domain.Core.Models
{
    public class Position : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get; set; }
        public string Name { get; set; }
        [CanBeNull] public string Description { get; set; }
        public DateTime IncludeAt { get; set; }
        [CanBeNull] public DateTime? ExcludeAt { get; set; }

        public virtual ICollection<Person> People { get; set; }

        public Position()
        {
        }

    }
}