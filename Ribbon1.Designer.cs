namespace ExcelAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.monte = this.Factory.CreateRibbonGroup();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.reset = this.Factory.CreateRibbonButton();
            this.step = this.Factory.CreateRibbonButton();
            this.run = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.monte.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.monte);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // monte
            // 
            this.monte.Items.Add(this.buttonGroup1);
            this.monte.Label = "MONTE";
            this.monte.Name = "monte";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.reset);
            this.buttonGroup1.Items.Add(this.step);
            this.buttonGroup1.Items.Add(this.run);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // reset
            // 
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.Label = "";
            this.reset.Name = "reset";
            this.reset.ScreenTip = "Reset the simulation.";
            this.reset.ShowImage = true;
            this.reset.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.reset_Click);
            // 
            // step
            // 
            this.step.Image = ((System.Drawing.Image)(resources.GetObject("step.Image")));
            this.step.Label = "";
            this.step.Name = "step";
            this.step.ScreenTip = "Single step through the simulation.";
            this.step.ShowImage = true;
            this.step.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.step_Click);
            // 
            // run
            // 
            this.run.Image = ((System.Drawing.Image)(resources.GetObject("run.Image")));
            this.run.Label = "";
            this.run.Name = "run";
            this.run.ScreenTip = "Run the simulation. Press the Esc key to stop.";
            this.run.ShowImage = true;
            this.run.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.run_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.monte.ResumeLayout(false);
            this.monte.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup monte;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton reset;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton step;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton run;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
