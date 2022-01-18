using PatternKursProject.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject.DecoratorAnalysisSystem
{
    class DecoratorAS: AnalysisSystemMethod
    {
        /// <summary>
        /// конкретная система 
        /// </summary>
        protected AnalysisSystemMethod thisSystem;
        public DecoratorAS(AnalysisSystemMethod t)
        { thisSystem = t; }

        /// <summary>
        /// переопределение всех методов 
        /// </summary>
        /// <returns></returns>
        public int getAccountNumber() {return thisSystem.getAccountNumber(); }
        public SourceType getTypeOfSystem() { return thisSystem.getTypeOfSystem(); }
        public void addDevice(MeasuringDevice dev) { thisSystem.addDevice(dev); }
        public List<Measurement> getMeasurements() { return thisSystem.getMeasurements(); }
        public List<Measurement> getLastMeasurements() { return thisSystem.getLastMeasurements(); }
        public List<MeasuringDevice> getLastDev() { return thisSystem.getLastDev(); }
        public void delDev(int t)
        {
            thisSystem.delDev(t);
           

        }
    }
}
