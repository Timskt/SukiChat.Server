﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.DataBase.DataBase.DataEntity
{
    public class ChatGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string UserFromId { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]
        [StringLength(10)]
        public string GroupId { get; set; }
        public Group Group { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public bool IsRetracted { get; set; } = false;

        [Required]
        public DateTime RetractTime { get; set; } = DateTime.MinValue;
    }
}
