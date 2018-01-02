using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ExcelAddIn1
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // For each *.xll ...
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            this.Application.RegisterXLL(baseDir + "\\xllmonte.xll");
            //Globals.ThisAddIn.Application.RegisterXLL(baseDir + "\\xllmonte.xll");
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            
        }

        public void RunMacro(object macro)
        {
            object m = Type.Missing;
            this.Application.Run(macro,
                m, m, m, m, m, m,
                m, m, m, m, m, m,
                m, m, m, m, m, m,
                m, m, m, m, m, m,
                m, m, m, m, m, m);
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
