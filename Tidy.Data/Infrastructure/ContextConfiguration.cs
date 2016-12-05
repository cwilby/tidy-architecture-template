using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace $safeprojectname$.Infrastructure
{
    public class ContextConfiguration
    {
        [ImportMany(typeof(IEntityConfiguration))]
        public IEnumerable<IEntityConfiguration> Configurations { get; set; }
    }
}
