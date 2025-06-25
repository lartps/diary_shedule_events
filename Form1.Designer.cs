using System.Windows.Documents;
using System.Windows.Forms;

namespace weekly_planer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Add_Event_Btn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.toolTipOnEventBlock = new System.Windows.Forms.ToolTip(this.components);
            this.sunday = new System.Windows.Forms.GroupBox();
            this.saturday = new System.Windows.Forms.GroupBox();
            this.friday = new System.Windows.Forms.GroupBox();
            this.thursday = new System.Windows.Forms.GroupBox();
            this.wednesday = new System.Windows.Forms.GroupBox();
            this.tuesday = new System.Windows.Forms.GroupBox();
            this.monday = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.set_TimeD = new System.Windows.Forms.NumericUpDown();
            this.set_Time = new System.Windows.Forms.Button();
            this.set_TimeM = new System.Windows.Forms.NumericUpDown();
            this.set_TimeH = new System.Windows.Forms.NumericUpDown();
            this.findBtn = new System.Windows.Forms.Button();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.groupDays = new System.Windows.Forms.GroupBox();
            this.Days_table = new System.Windows.Forms.TableLayoutPanel();
            this.timeTable = new System.Windows.Forms.TableLayoutPanel();
            this.label05 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label00 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Overlaps_table = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_PlusPic = new System.Windows.Forms.PictureBox();
            this.Delay_table = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.groupDays.SuspendLayout();
            this.Days_table.SuspendLayout();
            this.timeTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Overlaps_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_PlusPic)).BeginInit();
            this.Delay_table.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Event_Btn
            // 
            resources.ApplyResources(this.Add_Event_Btn, "Add_Event_Btn");
            this.Add_Event_Btn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Add_Event_Btn.Name = "Add_Event_Btn";
            this.Add_Event_Btn.UseVisualStyleBackColor = true;
            this.Add_Event_Btn.Click += new System.EventHandler(this.Add_Event_Btn_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBox.Name = "searchBox";
            // 
            // sunday
            // 
            this.sunday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.sunday, "sunday");
            this.sunday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sunday.Name = "sunday";
            this.sunday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.sunday, resources.GetString("sunday.ToolTip"));
            // 
            // saturday
            // 
            this.saturday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.saturday, "saturday");
            this.saturday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saturday.Name = "saturday";
            this.saturday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.saturday, resources.GetString("saturday.ToolTip"));
            // 
            // friday
            // 
            this.friday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.friday, "friday");
            this.friday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.friday.Name = "friday";
            this.friday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.friday, resources.GetString("friday.ToolTip"));
            // 
            // thursday
            // 
            this.thursday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.thursday, "thursday");
            this.thursday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thursday.Name = "thursday";
            this.thursday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.thursday, resources.GetString("thursday.ToolTip"));
            // 
            // wednesday
            // 
            this.wednesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.wednesday, "wednesday");
            this.wednesday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wednesday.Name = "wednesday";
            this.wednesday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.wednesday, resources.GetString("wednesday.ToolTip"));
            // 
            // tuesday
            // 
            this.tuesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            resources.ApplyResources(this.tuesday, "tuesday");
            this.tuesday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tuesday.Name = "tuesday";
            this.tuesday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.tuesday, resources.GetString("tuesday.ToolTip"));
            // 
            // monday
            // 
            resources.ApplyResources(this.monday, "monday");
            this.monday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.monday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monday.Name = "monday";
            this.monday.TabStop = false;
            this.toolTipOnEventBlock.SetToolTip(this.monday, resources.GetString("monday.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Timer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.set_TimeD);
            this.groupBox1.Controls.Add(this.set_Time);
            this.groupBox1.Controls.Add(this.set_TimeM);
            this.groupBox1.Controls.Add(this.set_TimeH);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.searchPic);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Timer
            // 
            resources.ApplyResources(this.Timer, "Timer");
            this.Timer.Name = "Timer";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // set_TimeD
            // 
            resources.ApplyResources(this.set_TimeD, "set_TimeD");
            this.set_TimeD.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.set_TimeD.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.set_TimeD.Name = "set_TimeD";
            this.set_TimeD.ReadOnly = true;
            this.set_TimeD.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // set_Time
            // 
            resources.ApplyResources(this.set_Time, "set_Time");
            this.set_Time.Name = "set_Time";
            this.set_Time.UseVisualStyleBackColor = true;
            this.set_Time.Click += new System.EventHandler(this.set_Time_Click);
            // 
            // set_TimeM
            // 
            resources.ApplyResources(this.set_TimeM, "set_TimeM");
            this.set_TimeM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.set_TimeM.Name = "set_TimeM";
            // 
            // set_TimeH
            // 
            resources.ApplyResources(this.set_TimeH, "set_TimeH");
            this.set_TimeH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.set_TimeH.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.set_TimeH.Name = "set_TimeH";
            this.set_TimeH.ReadOnly = true;
            this.set_TimeH.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // findBtn
            // 
            resources.ApplyResources(this.findBtn, "findBtn");
            this.findBtn.Name = "findBtn";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // searchPic
            // 
            resources.ApplyResources(this.searchPic, "searchPic");
            this.searchPic.BackColor = System.Drawing.Color.Transparent;
            this.searchPic.Image = global::weekly_planer.Resource1._CAEE0E46_BC96_48C4_A17A_94A7AC826043_;
            this.searchPic.InitialImage = global::weekly_planer.Resource1._CAEE0E46_BC96_48C4_A17A_94A7AC826043_;
            this.searchPic.Name = "searchPic";
            this.searchPic.TabStop = false;
            // 
            // groupDays
            // 
            resources.ApplyResources(this.groupDays, "groupDays");
            this.groupDays.Controls.Add(this.Days_table);
            this.groupDays.Controls.Add(this.timeTable);
            this.groupDays.Name = "groupDays";
            this.groupDays.TabStop = false;
            // 
            // Days_table
            // 
            resources.ApplyResources(this.Days_table, "Days_table");
            this.Days_table.Controls.Add(this.monday, 0, 0);
            this.Days_table.Controls.Add(this.tuesday, 1, 0);
            this.Days_table.Controls.Add(this.wednesday, 2, 0);
            this.Days_table.Controls.Add(this.thursday, 3, 0);
            this.Days_table.Controls.Add(this.friday, 4, 0);
            this.Days_table.Controls.Add(this.saturday, 5, 0);
            this.Days_table.Controls.Add(this.sunday, 6, 0);
            this.Days_table.Name = "Days_table";
            // 
            // timeTable
            // 
            resources.ApplyResources(this.timeTable, "timeTable");
            this.timeTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.timeTable.CausesValidation = false;
            this.timeTable.Controls.Add(this.label05, 0, 0);
            this.timeTable.Controls.Add(this.label06, 0, 1);
            this.timeTable.Controls.Add(this.label07, 0, 2);
            this.timeTable.Controls.Add(this.label08, 0, 3);
            this.timeTable.Controls.Add(this.label09, 0, 4);
            this.timeTable.Controls.Add(this.label10, 0, 5);
            this.timeTable.Controls.Add(this.label11, 0, 6);
            this.timeTable.Controls.Add(this.label12, 0, 7);
            this.timeTable.Controls.Add(this.label13, 0, 8);
            this.timeTable.Controls.Add(this.label14, 0, 9);
            this.timeTable.Controls.Add(this.label15, 0, 10);
            this.timeTable.Controls.Add(this.label16, 0, 11);
            this.timeTable.Controls.Add(this.label17, 0, 12);
            this.timeTable.Controls.Add(this.label18, 0, 13);
            this.timeTable.Controls.Add(this.label19, 0, 14);
            this.timeTable.Controls.Add(this.label20, 0, 15);
            this.timeTable.Controls.Add(this.label21, 0, 16);
            this.timeTable.Controls.Add(this.label22, 0, 17);
            this.timeTable.Controls.Add(this.label23, 0, 18);
            this.timeTable.Controls.Add(this.label00, 0, 19);
            this.errorProvider1.SetIconAlignment(this.timeTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("timeTable.IconAlignment"))));
            this.timeTable.Name = "timeTable";
            // 
            // label05
            // 
            resources.ApplyResources(this.label05, "label05");
            this.label05.Name = "label05";
            // 
            // label06
            // 
            resources.ApplyResources(this.label06, "label06");
            this.label06.Name = "label06";
            // 
            // label07
            // 
            resources.ApplyResources(this.label07, "label07");
            this.label07.Name = "label07";
            // 
            // label08
            // 
            resources.ApplyResources(this.label08, "label08");
            this.label08.Name = "label08";
            // 
            // label09
            // 
            resources.ApplyResources(this.label09, "label09");
            this.label09.Name = "label09";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label00
            // 
            resources.ApplyResources(this.label00, "label00");
            this.label00.Name = "label00";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.Overlaps_table);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Overlaps_table
            // 
            this.Overlaps_table.Controls.Add(this.button1);
            this.Overlaps_table.Controls.Add(this.button2);
            this.Overlaps_table.Controls.Add(this.button5);
            this.Overlaps_table.Controls.Add(this.button7);
            this.Overlaps_table.Controls.Add(this.button8);
            this.Overlaps_table.Controls.Add(this.button9);
            resources.ApplyResources(this.Overlaps_table, "Overlaps_table");
            this.Overlaps_table.Name = "Overlaps_table";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // cutToolStripMenuItem
            // 
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            // 
            // pasteToolStripMenuItem
            // 
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            resources.ApplyResources(this.contentsToolStripMenuItem, "contentsToolStripMenuItem");
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            resources.ApplyResources(this.indexToolStripMenuItem, "indexToolStripMenuItem");
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.add_PlusPic);
            this.panel1.Controls.Add(this.Add_Event_Btn);
            this.panel1.Name = "panel1";
            // 
            // add_PlusPic
            // 
            resources.ApplyResources(this.add_PlusPic, "add_PlusPic");
            this.add_PlusPic.Name = "add_PlusPic";
            this.add_PlusPic.TabStop = false;
            // 
            // Delay_table
            // 
            this.Delay_table.Controls.Add(this.panel3);
            resources.ApplyResources(this.Delay_table, "Delay_table");
            this.Delay_table.Name = "Delay_table";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.Delay_table);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            resources.ApplyResources(this.button9, "button9");
            this.button9.Name = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupDays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.groupDays.ResumeLayout(false);
            this.groupDays.PerformLayout();
            this.Days_table.ResumeLayout(false);
            this.Days_table.PerformLayout();
            this.timeTable.ResumeLayout(false);
            this.timeTable.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.Overlaps_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_PlusPic)).EndInit();
            this.Delay_table.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Event_Btn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ToolTip toolTipOnEventBlock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupDays;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox monday;
        private System.Windows.Forms.GroupBox thursday;
        private System.Windows.Forms.GroupBox wednesday;
        private System.Windows.Forms.GroupBox tuesday;
        private System.Windows.Forms.GroupBox friday;
        private System.Windows.Forms.GroupBox saturday;
        private System.Windows.Forms.GroupBox sunday;
        private System.Windows.Forms.PictureBox add_PlusPic;
        private System.Windows.Forms.PictureBox searchPic;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer;
        public System.Windows.Forms.TableLayoutPanel timeTable;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel Days_table;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private GroupBox groupBox4;
        private FlowLayoutPanel Delay_table;
        public NumericUpDown set_TimeM;
        public NumericUpDown set_TimeH;
        private Button set_Time;
        private Label label00;
        public NumericUpDown set_TimeD;
        private Label label1;
        private FlowLayoutPanel Overlaps_table;
        private Button button4;
        private Button button6;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}

