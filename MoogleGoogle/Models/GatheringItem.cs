using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoogleGoogle.Models
{

    public class GatheringItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Slot { get; set; }
        public string Zone { get; set; }
        public string Position { get; set; }
        public string FastestRoute { get; set; }
        public string Level { get; set; }
        public string Perfecption { get; set; }
        public string Type { get; set; }
    }
}