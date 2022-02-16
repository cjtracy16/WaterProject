using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class EFWaterProjectRepository : IWaterProjectRepository
    {
        private ProjectContext context { get; set; }

        public EFWaterProjectRepository (ProjectContext temp)
        {
            context = temp;
        }
        public IQueryable<Project> Projects => context.Projects;
    }
}
