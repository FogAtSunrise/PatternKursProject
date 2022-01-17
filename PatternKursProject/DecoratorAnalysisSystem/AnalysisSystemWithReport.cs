using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace PatternKursProject.DecoratorAnalysisSystem
{
    class AnalysisSystemWithReport:DecoratorAS
    {
        private Excel.Application _excel;
        private Excel.Workbook _workbook;
        private string _filePath;
        public AnalysisSystemWithReport(AnalysisSystemMethod t) : base(t)
        {
            _excel = new Excel.Application();
        }

        public void writeInReport()
        { }

        public void createReport()
        { 
        
        }
    }
}
