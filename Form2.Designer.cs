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
            this.eventEdit_btn_ok = new System.Windows.Forms.Button();
            this.NameChange = new System.Windows.Forms.TextBox();
            this.DetailsChange = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.month_label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.justText1 = new System.Windows.Forms.Label();
            this.DescriptionChange = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.name_label1 = new System.Windows.Forms.Label();
            this.day_label2 = new System.Windows.Forms.Label();
            this.timeStart_label4 = new System.Windows.Forms.Label();
            this.timeEnd_label5 = new System.Windows.Forms.Label();
            this.descr_label6 = new System.Windows.Forms.Label();
            this.place_label7 = new System.Windows.Forms.Label();
            this.details_label8 = new System.Windows.Forms.Label();
            this.minStartChange = new System.Windows.Forms.NumericUpDown();
            this.minEndChange = new System.Windows.Forms.NumericUpDown();
            this.DayChange = new System.Windows.Forms.NumericUpDown();
            this.hourStartChange = new System.Windows.Forms.NumericUpDown();
            this.hourEndChange = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStartChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEndChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourStartChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEndChange)).BeginInit();
            this.SuspendLayout();
            // 
            // eventEdit_btn_ok
            // 
            this.eventEdit_btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventEdit_btn_ok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.eventEdit_btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eventEdit_btn_ok.FlatAppearance.BorderSize = 4;
            this.eventEdit_btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.eventEdit_btn_ok.Location = new System.Drawing.Point(455, 546);
            this.eventEdit_btn_ok.MaximumSize = new System.Drawing.Size(118, 42);
            this.eventEdit_btn_ok.MinimumSize = new System.Drawing.Size(118, 42);
            this.eventEdit_btn_ok.Name = "eventEdit_btn_ok";
            this.eventEdit_btn_ok.Size = new System.Drawing.Size(118, 42);
            this.eventEdit_btn_ok.TabIndex = 0;
            this.eventEdit_btn_ok.Text = "Готово";
            this.eventEdit_btn_ok.UseVisualStyleBackColor = false;
            this.eventEdit_btn_ok.Click += new System.EventHandler(this.event_edit_btn_ok_Click);
            // 
            // NameChange
            // 
            this.NameChange.BackColor = System.Drawing.SystemColors.Info;
            this.NameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameChange.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NameChange.Location = new System.Drawing.Point(26, 46);
            this.NameChange.MaxLength = 16;
            this.NameChange.Name = "NameChange";
            this.NameChange.Size = new System.Drawing.Size(222, 35);
            this.NameChange.TabIndex = 1;
            this.NameChange.Text = "Справа 1";
            this.NameChange.WordWrap = false;
            // 
            // DetailsChange
            // 
            this.DetailsChange.BackColor = System.Drawing.SystemColors.Info;
            this.DetailsChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailsChange.Location = new System.Drawing.Point(26, 317);
            this.DetailsChange.MaxLength = 281;
            this.DetailsChange.MinimumSize = new System.Drawing.Size(547, 223);
            this.DetailsChange.Name = "DetailsChange";
            this.DetailsChange.Size = new System.Drawing.Size(547, 223);
            this.DetailsChange.TabIndex = 9;
            this.DetailsChange.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // DescriptionChange
            // 
            this.DescriptionChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DescriptionChange.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescriptionChange.Location = new System.Drawing.Point(25, 179);
            this.DescriptionChange.MaximumSize = new System.Drawing.Size(0, 29);
            this.DescriptionChange.MaxLength = 26;
            this.DescriptionChange.MinimumSize = new System.Drawing.Size(280, 29);
            this.DescriptionChange.Name = "DescriptionChange";
            this.DescriptionChange.Size = new System.Drawing.Size(280, 29);
            this.DescriptionChange.TabIndex = 7;
            this.DescriptionChange.WordWrap = false;
            // 
            // loc
            // 
            this.loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loc.BackColor = System.Drawing.SystemColors.Info;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loc.Location = new System.Drawing.Point(26, 245);
            this.loc.MaximumSize = new System.Drawing.Size(0, 29);
            this.loc.MaxLength = 26;
            this.loc.MinimumSize = new System.Drawing.Size(280, 29);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(280, 29);
            this.loc.TabIndex = 8;
            this.loc.WordWrap = false;
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
            // minStartChange
            // 
            this.minStartChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minStartChange.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minStartChange.Location = new System.Drawing.Point(215, 117);
            this.minStartChange.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minStartChange.MaximumSize = new System.Drawing.Size(52, 0);
            this.minStartChange.MinimumSize = new System.Drawing.Size(52, 0);
            this.minStartChange.Name = "minStartChange";
            this.minStartChange.ReadOnly = true;
            this.minStartChange.Size = new System.Drawing.Size(52, 29);
            this.minStartChange.TabIndex = 4;
            // 
            // minEndChange
            // 
            this.minEndChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minEndChange.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minEndChange.Location = new System.Drawing.Point(380, 117);
            this.minEndChange.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minEndChange.MaximumSize = new System.Drawing.Size(52, 0);
            this.minEndChange.MinimumSize = new System.Drawing.Size(52, 0);
            this.minEndChange.Name = "minEndChange";
            this.minEndChange.ReadOnly = true;
            this.minEndChange.Size = new System.Drawing.Size(52, 29);
            this.minEndChange.TabIndex = 6;
            this.toolTip1.SetToolTip(this.minEndChange, "Подія може тривати 30 хвилин минімум");
            // 
            // DayChange
            // 
            this.DayChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayChange.Location = new System.Drawing.Point(27, 117);
            this.DayChange.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DayChange.MaximumSize = new System.Drawing.Size(45, 0);
            this.DayChange.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.DayChange.MinimumSize = new System.Drawing.Size(45, 0);
            this.DayChange.Name = "DayChange";
            this.DayChange.ReadOnly = true;
            this.DayChange.Size = new System.Drawing.Size(45, 29);
            this.DayChange.TabIndex = 2;
            this.DayChange.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // hourStartChange
            // 
            this.hourStartChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourStartChange.Location = new System.Drawing.Point(136, 117);
            this.hourStartChange.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourStartChange.MaximumSize = new System.Drawing.Size(52, 0);
            this.hourStartChange.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.hourStartChange.MinimumSize = new System.Drawing.Size(52, 0);
            this.hourStartChange.Name = "hourStartChange";
            this.hourStartChange.ReadOnly = true;
            this.hourStartChange.Size = new System.Drawing.Size(52, 29);
            this.hourStartChange.TabIndex = 3;
            this.hourStartChange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // hourEndChange
            // 
            this.hourEndChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourEndChange.Location = new System.Drawing.Point(301, 117);
            this.hourEndChange.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourEndChange.MaximumSize = new System.Drawing.Size(52, 0);
            this.hourEndChange.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.hourEndChange.MinimumSize = new System.Drawing.Size(52, 0);
            this.hourEndChange.Name = "hourEndChange";
            this.hourEndChange.ReadOnly = true;
            this.hourEndChange.Size = new System.Drawing.Size(52, 29);
            this.hourEndChange.TabIndex = 5;
            this.toolTip1.SetToolTip(this.hourEndChange, "Подія може тривати 30 хвилин минімум");
            this.hourEndChange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EventForm
            // 
            this.AcceptButton = this.eventEdit_btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 611);
            this.Controls.Add(this.hourEndChange);
            this.Controls.Add(this.hourStartChange);
            this.Controls.Add(this.DayChange);
            this.Controls.Add(this.minEndChange);
            this.Controls.Add(this.minStartChange);
            this.Controls.Add(this.details_label8);
            this.Controls.Add(this.place_label7);
            this.Controls.Add(this.descr_label6);
            this.Controls.Add(this.timeEnd_label5);
            this.Controls.Add(this.timeStart_label4);
            this.Controls.Add(this.day_label2);
            this.Controls.Add(this.name_label1);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.DescriptionChange);
            this.Controls.Add(this.justText1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month_label3);
            this.Controls.Add(this.DetailsChange);
            this.Controls.Add(this.NameChange);
            this.Controls.Add(this.eventEdit_btn_ok);
            this.MinimumSize = new System.Drawing.Size(620, 650);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма для події";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStartChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEndChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourStartChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEndChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eventEdit_btn_ok;
        private System.Windows.Forms.TextBox NameChange;
        private System.Windows.Forms.NumericUpDown minStartChange;
        private System.Windows.Forms.NumericUpDown hourEndChange;
        private System.Windows.Forms.NumericUpDown hourStartChange;
        private System.Windows.Forms.NumericUpDown DayChange;
        private System.Windows.Forms.NumericUpDown minEndChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox DescriptionChange;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.RichTextBox DetailsChange;
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
    }
}