﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name="Created")]
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
