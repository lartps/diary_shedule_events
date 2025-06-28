namespace weekly_planer
{
    partial class EventForm
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
            this.eventEdit_ok_btn = new System.Windows.Forms.Button();
            this.Name_Change = new System.Windows.Forms.TextBox();
            this.Details_Change = new System.Windows.Forms.RichTextBox();
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.month_label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.justText1 = new System.Windows.Forms.Label();
            this.Descr_Change = new System.Windows.Forms.TextBox();
            this.Loc_Change = new System.Windows.Forms.TextBox();
            this.name_label1 = new System.Windows.Forms.Label();
            this.day_label2 = new System.Windows.Forms.Label();
            this.timeStart_label4 = new System.Windows.Forms.Label();
            this.timeEnd_label5 = new System.Windows.Forms.Label();
            this.descr_label6 = new System.Windows.Forms.Label();
            this.place_label7 = new System.Windows.Forms.Label();
            this.details_label8 = new System.Windows.Forms.Label();
            this.minStart_Change = new System.Windows.Forms.NumericUpDown();
            this.minEnd_Change = new System.Windows.Forms.NumericUpDown();
            this.Day_Change = new System.Windows.Forms.NumericUpDown();
            this.hourStart_Change = new System.Windows.Forms.NumericUpDown();
            this.hourEnd_Change = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStart_Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEnd_Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day_Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourStart_Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd_Change)).BeginInit();
            this.SuspendLayout();
            // 
            // eventEdit_ok_btn
            // 
            this.eventEdit_ok_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventEdit_ok_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.eventEdit_ok_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eventEdit_ok_btn.FlatAppearance.BorderSize = 4;
            this.eventEdit_ok_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.eventEdit_ok_btn.Location = new System.Drawing.Point(455, 546);
            this.eventEdit_ok_btn.MaximumSize = new System.Drawing.Size(118, 42);
            this.eventEdit_ok_btn.MinimumSize = new System.Drawing.Size(118, 42);
            this.eventEdit_ok_btn.Name = "eventEdit_ok_btn";
            this.eventEdit_ok_btn.Size = new System.Drawing.Size(118, 42);
            this.eventEdit_ok_btn.TabIndex = 18;
            this.eventEdit_ok_btn.Text = "Готово";
            this.eventEdit_ok_btn.UseVisualStyleBackColor = false;
            this.eventEdit_ok_btn.Click += new System.EventHandler(this.eventEdit_okButton_Click);
            // 
            // Name_Change
            // 
            this.Name_Change.BackColor = System.Drawing.SystemColors.Info;
            this.Name_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_Change.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name_Change.Location = new System.Drawing.Point(26, 46);
            this.Name_Change.MaxLength = 12;
            this.Name_Change.Name = "Name_Change";
            this.Name_Change.Size = new System.Drawing.Size(182, 35);
            this.Name_Change.TabIndex = 1;
            this.Name_Change.Text = "Справа 1";
            this.toolTip1.SetToolTip(this.Name_Change, "Некоректні імена: порожне, тільки цифри, один символ, тільки символи, лише пробіл" +
        "и, - будуть замінені на \"Справа 1, 2 і т.д.\"");
            this.Name_Change.WordWrap = false;
            // 
            // Details_Change
            // 
            this.Details_Change.BackColor = System.Drawing.SystemColors.Info;
            this.Details_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Details_Change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details_Change.Location = new System.Drawing.Point(26, 317);
            this.Details_Change.MaxLength = 281;
            this.Details_Change.MinimumSize = new System.Drawing.Size(547, 223);
            this.Details_Change.Name = "Details_Change";
            this.Details_Change.Size = new System.Drawing.Size(547, 223);
            this.Details_Change.TabIndex = 9;
            this.Details_Change.Text = "";
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // month_label3
            // 
            this.month_label3.AutoSize = true;
            this.month_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month_label3.Location = new System.Drawing.Point(78, 119);
            this.month_label3.Name = "month_label3";
            this.month_label3.Size = new System.Drawing.Size(35, 24);
            this.month_label3.TabIndex = 9;
            this.month_label3.Text = ".06";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(359, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // justText1
            // 
            this.justText1.AutoSize = true;
            this.justText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.justText1.Location = new System.Drawing.Point(273, 117);
            this.justText1.Name = "justText1";
            this.justText1.Size = new System.Drawing.Size(22, 24);
            this.justText1.TabIndex = 17;
            this.justText1.Text = "--";
            // 
            // Descr_Change
            // 
            this.Descr_Change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Descr_Change.BackColor = System.Drawing.SystemColors.Info;
            this.Descr_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Descr_Change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Descr_Change.Location = new System.Drawing.Point(25, 179);
            this.Descr_Change.MaximumSize = new System.Drawing.Size(4, 29);
            this.Descr_Change.MaxLength = 26;
            this.Descr_Change.MinimumSize = new System.Drawing.Size(280, 29);
            this.Descr_Change.Name = "Descr_Change";
            this.Descr_Change.Size = new System.Drawing.Size(280, 29);
            this.Descr_Change.TabIndex = 7;
            this.Descr_Change.WordWrap = false;
            // 
            // Loc_Change
            // 
            this.Loc_Change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Loc_Change.BackColor = System.Drawing.SystemColors.Info;
            this.Loc_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loc_Change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loc_Change.Location = new System.Drawing.Point(26, 245);
            this.Loc_Change.MaximumSize = new System.Drawing.Size(4, 29);
            this.Loc_Change.MaxLength = 26;
            this.Loc_Change.MinimumSize = new System.Drawing.Size(280, 29);
            this.Loc_Change.Name = "Loc_Change";
            this.Loc_Change.Size = new System.Drawing.Size(280, 29);
            this.Loc_Change.TabIndex = 8;
            this.Loc_Change.WordWrap = false;
            // 
            // name_label1
            // 
            this.name_label1.AutoSize = true;
            this.name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label1.Location = new System.Drawing.Point(23, 21);
            this.name_label1.Name = "name_label1";
            this.name_label1.Size = new System.Drawing.Size(126, 22);
            this.name_label1.TabIndex = 0;
            this.name_label1.Text = "Назва справи";
            // 
            // day_label2
            // 
            this.day_label2.AutoSize = true;
            this.day_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day_label2.Location = new System.Drawing.Point(23, 90);
            this.day_label2.Name = "day_label2";
            this.day_label2.Size = new System.Drawing.Size(57, 24);
            this.day_label2.TabIndex = 0;
            this.day_label2.Text = "День";
            // 
            // timeStart_label4
            // 
            this.timeStart_label4.AutoSize = true;
            this.timeStart_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeStart_label4.Location = new System.Drawing.Point(132, 90);
            this.timeStart_label4.Name = "timeStart_label4";
            this.timeStart_label4.Size = new System.Drawing.Size(116, 24);
            this.timeStart_label4.TabIndex = 0;
            this.timeStart_label4.Text = "Час початку";
            // 
            // timeEnd_label5
            // 
            this.timeEnd_label5.AutoSize = true;
            this.timeEnd_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeEnd_label5.Location = new System.Drawing.Point(297, 90);
            this.timeEnd_label5.Name = "timeEnd_label5";
            this.timeEnd_label5.Size = new System.Drawing.Size(91, 24);
            this.timeEnd_label5.TabIndex = 0;
            this.timeEnd_label5.Text = "Час кінця";
            // 
            // descr_label6
            // 
            this.descr_label6.AutoSize = true;
            this.descr_label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descr_label6.Location = new System.Drawing.Point(23, 154);
            this.descr_label6.Name = "descr_label6";
            this.descr_label6.Size = new System.Drawing.Size(133, 22);
            this.descr_label6.TabIndex = 0;
            this.descr_label6.Text = "Короткий опис";
            // 
            // place_label7
            // 
            this.place_label7.AutoSize = true;
            this.place_label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_label7.Location = new System.Drawing.Point(23, 220);
            this.place_label7.Name = "place_label7";
            this.place_label7.Size = new System.Drawing.Size(164, 22);
            this.place_label7.TabIndex = 0;
            this.place_label7.Text = "Місце проведення";
            // 
            // details_label8
            // 
            this.details_label8.AutoSize = true;
            this.details_label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.details_label8.Location = new System.Drawing.Point(23, 292);
            this.details_label8.Name = "details_label8";
            this.details_label8.Size = new System.Drawing.Size(258, 22);
            this.details_label8.TabIndex = 0;
            this.details_label8.Text = "Деталі справи (280 символів)";
            // 
            // minStart_Change
            // 
            this.minStart_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minStart_Change.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minStart_Change.Location = new System.Drawing.Point(215, 117);
            this.minStart_Change.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minStart_Change.MaximumSize = new System.Drawing.Size(52, 0);
            this.minStart_Change.MinimumSize = new System.Drawing.Size(52, 0);
            this.minStart_Change.Name = "minStart_Change";
            this.minStart_Change.ReadOnly = true;
            this.minStart_Change.Size = new System.Drawing.Size(52, 29);
            this.minStart_Change.TabIndex = 4;
            // 
            // minEnd_Change
            // 
            this.minEnd_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minEnd_Change.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minEnd_Change.Location = new System.Drawing.Point(380, 117);
            this.minEnd_Change.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minEnd_Change.MaximumSize = new System.Drawing.Size(52, 0);
            this.minEnd_Change.MinimumSize = new System.Drawing.Size(52, 0);
            this.minEnd_Change.Name = "minEnd_Change";
            this.minEnd_Change.ReadOnly = true;
            this.minEnd_Change.Size = new System.Drawing.Size(52, 29);
            this.minEnd_Change.TabIndex = 6;
            this.toolTip1.SetToolTip(this.minEnd_Change, "Подія може тривати 30 хвилин минімум");
            // 
            // Day_Change
            // 
            this.Day_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Day_Change.Location = new System.Drawing.Point(27, 117);
            this.Day_Change.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.Day_Change.MaximumSize = new System.Drawing.Size(45, 0);
            this.Day_Change.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Day_Change.MinimumSize = new System.Drawing.Size(45, 0);
            this.Day_Change.Name = "Day_Change";
            this.Day_Change.ReadOnly = true;
            this.Day_Change.Size = new System.Drawing.Size(45, 29);
            this.Day_Change.TabIndex = 2;
            this.Day_Change.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Day_Change.ValueChanged += new System.EventHandler(this.DayChange_ValueChanged);
            // 
            // hourStart_Change
            // 
            this.hourStart_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourStart_Change.Location = new System.Drawing.Point(136, 117);
            this.hourStart_Change.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourStart_Change.MaximumSize = new System.Drawing.Size(52, 0);
            this.hourStart_Change.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hourStart_Change.MinimumSize = new System.Drawing.Size(52, 0);
            this.hourStart_Change.Name = "hourStart_Change";
            this.hourStart_Change.ReadOnly = true;
            this.hourStart_Change.Size = new System.Drawing.Size(52, 29);
            this.hourStart_Change.TabIndex = 3;
            this.hourStart_Change.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hourStart_Change.ValueChanged += new System.EventHandler(this.hourStartChange_ValueChanged);
            // 
            // hourEnd_Change
            // 
            this.hourEnd_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourEnd_Change.Location = new System.Drawing.Point(301, 117);
            this.hourEnd_Change.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourEnd_Change.MaximumSize = new System.Drawing.Size(52, 0);
            this.hourEnd_Change.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hourEnd_Change.MinimumSize = new System.Drawing.Size(52, 0);
            this.hourEnd_Change.Name = "hourEnd_Change";
            this.hourEnd_Change.ReadOnly = true;
            this.hourEnd_Change.Size = new System.Drawing.Size(52, 29);
            this.hourEnd_Change.TabIndex = 5;
            this.toolTip1.SetToolTip(this.hourEnd_Change, "Подія може тривати 30 хвилин минімум");
            this.hourEnd_Change.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.hourEnd_Change.ValueChanged += new System.EventHandler(this.hourEndChange_ValueChanged);
            // 
            // EventForm
            // 
            this.AcceptButton = this.eventEdit_ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 611);
            this.Controls.Add(this.hourEnd_Change);
            this.Controls.Add(this.hourStart_Change);
            this.Controls.Add(this.Day_Change);
            this.Controls.Add(this.minEnd_Change);
            this.Controls.Add(this.minStart_Change);
            this.Controls.Add(this.details_label8);
            this.Controls.Add(this.place_label7);
            this.Controls.Add(this.descr_label6);
            this.Controls.Add(this.timeEnd_label5);
            this.Controls.Add(this.timeStart_label4);
            this.Controls.Add(this.day_label2);
            this.Controls.Add(this.name_label1);
            this.Controls.Add(this.Loc_Change);
            this.Controls.Add(this.Descr_Change);
            this.Controls.Add(this.justText1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month_label3);
            this.Controls.Add(this.Details_Change);
            this.Controls.Add(this.Name_Change);
            this.Controls.Add(this.eventEdit_ok_btn);
            this.MinimumSize = new System.Drawing.Size(620, 650);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма для події";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStart_Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEnd_Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day_Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourStart_Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd_Change)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Name_Change;
        public System.Windows.Forms.NumericUpDown minStart_Change;
        public System.Windows.Forms.NumericUpDown hourEnd_Change;
        public System.Windows.Forms.NumericUpDown hourStart_Change;
        public System.Windows.Forms.NumericUpDown Day_Change;
        public System.Windows.Forms.NumericUpDown minEnd_Change;
        private System.Windows.Forms.ErrorProvider errorMessage;
        public System.Windows.Forms.TextBox Descr_Change;
        public System.Windows.Forms.TextBox Loc_Change;
        public System.Windows.Forms.RichTextBox Details_Change;
        private System.Windows.Forms.Label month_label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label justText1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label day_label2;
        private System.Windows.Forms.Label name_label1;
        private System.Windows.Forms.Label timeEnd_label5;
        private System.Windows.Forms.Label timeStart_label4;
        private System.Windows.Forms.Label place_label7;
        private System.Windows.Forms.Label descr_label6;
        private System.Windows.Forms.Label details_label8;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button eventEdit_ok_btn;
    }
}