using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class Project
    {
        [Key]
        [Required]
        public long ProjectId { get; set; }

        //[Required(ErrorMessage = "")]
        public string ProjectName { get; set; }

        //[Required(ErrorMessage = "")]
        public string ProjectType { get; set; }

       // [Required(ErrorMessage = "")]
        public string ProjectRegionalProgram { get; set; }

        //[Required(ErrorMessage = "")]
        public long ProjectImpact { get; set; }

        //[Required(ErrorMessage = "")]
        public string ProjectPhase { get; set; }

        //[Required(ErrorMessage = "")]
        public string ProjectFunctionalityStatus { get; set; }

    }
}
