using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject.commandPatt
{
    class CommandAddSystem
    {
       public AnalysisSystemMethod execute(SourceType t, MonitoringSystem s)
        { return new AnalysisSystem(s.getCountAS(), t); }
    }
}
