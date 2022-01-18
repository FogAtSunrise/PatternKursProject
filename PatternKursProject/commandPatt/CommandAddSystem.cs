using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject.commandPatt
{
    class CommandAddSystem : Command
    {
        private AnalysisSystemMethod syst;
       private MonitoringSystem centre;
        public int execute()
        { centre = MonitoringSystem.getInstance();
            centre.addAnalysisSystem(syst);
            return syst.getAccountNumber();
        }
        public CommandAddSystem(AnalysisSystemMethod a)
        {
            syst = a;
        }
    }
}
