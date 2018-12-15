using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Square.ViewModels
{
    public class ResultViewModel
    {
        [Required]
        public int testvalue { get; set; }
        public int randomproduct { get; set; }
        public String Error { get; set; }
    }
}


