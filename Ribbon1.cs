using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void reset_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.RunMacro("MONTE.RESET");
        }

        private void step_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.RunMacro("MONTE.STEP");
        }

        private void run_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.RunMacro("MONTE.RUN");
        }
    }
}
