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
            this.event_edit_btn_ok = new System.Windows.Forms.Button();
            this.NameChange = new System.Windows.Forms.TextBox();
            this.DetailsChange = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.justText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.justText1 = new System.Windows.Forms.Label();
            this.DescriptionChange = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // event_edit_btn_ok
            // 
            this.event_edit_btn_ok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.event_edit_btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.event_edit_btn_ok.FlatAppearance.BorderSize = 4;
            this.event_edit_btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.event_edit_btn_ok.Location = new System.Drawing.Point(455, 546);
            this.event_edit_btn_ok.Name = "event_edit_btn_ok";
            this.event_edit_btn_ok.Size = new System.Drawing.Size(118, 42);
            this.event_edit_btn_ok.TabIndex = 0;
            this.event_edit_btn_ok.Text = "Готово";
            this.event_edit_btn_ok.UseVisualStyleBackColor = false;
            this.event_edit_btn_ok.Click += new System.EventHandler(this.event_edit_btn_ok_Click);
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
            this.NameChange.TextChanged += new System.EventHandler(this.NameChange_TextChanged);
            // 
            // DetailsChange
            // 
            this.DetailsChange.BackColor = System.Drawing.SystemColors.Info;
            this.DetailsChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailsChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetailsChange.Location = new System.Drawing.Point(26, 317);
            this.DetailsChange.MaxLength = 281;
            this.DetailsChange.Name = "DetailsChange";
            this.DetailsChange.Size = new System.Drawing.Size(547, 223);
            this.DetailsChange.TabIndex = 9;
            this.DetailsChange.Text = "";
            this.DetailsChange.TextChanged += new System.EventHandler(this.DetailsChange_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // justText
            // 
            this.justText.AutoSize = true;
            this.justText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.justText.Location = new System.Drawing.Point(78, 119);
            this.justText.Name = "justText";
            this.justText.Size = new System.Drawing.Size(35, 24);
            this.justText.TabIndex = 9;
            this.justText.Text = ".06";
            this.justText.Click += new System.EventHandler(this.justText_Click);
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
            this.DescriptionChange.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescriptionChange.Location = new System.Drawing.Point(25, 179);
            this.DescriptionChange.MaxLength = 26;
            this.DescriptionChange.Name = "DescriptionChange";
            this.DescriptionChange.Size = new System.Drawing.Size(280, 29);
            this.DescriptionChange.TabIndex = 7;
            this.DescriptionChange.WordWrap = false;
            this.DescriptionChange.TextChanged += new System.EventHandler(this.DescriptionChange_TextChanged);
            // 
            // loc
            // 
            this.loc.BackColor = System.Drawing.SystemColors.Info;
            this.loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loc.Location = new System.Drawing.Point(26, 245);
            this.loc.MaxLength = 26;
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(279, 29);
            this.loc.TabIndex = 8;
            this.loc.WordWrap = false;
            this.loc.TextChanged += new System.EventHandler(this.loc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Назва справи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "День";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(132, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Час початку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(297, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Час кінця";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Короткий опис";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Місце проведення";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(23, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Деталі справи (280 символів)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(215, 117);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(52, 29);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(380, 117);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(52, 29);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown3.Location = new System.Drawing.Point(27, 117);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(45, 29);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown4.Location = new System.Drawing.Point(136, 117);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.ReadOnly = true;
            this.numericUpDown4.Size = new System.Drawing.Size(52, 29);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown5.Location = new System.Drawing.Point(301, 117);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.ReadOnly = true;
            this.numericUpDown5.Size = new System.Drawing.Size(52, 29);
            this.numericUpDown5.TabIndex = 5;
            this.numericUpDown5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // EventForm
            // 
            this.AcceptButton = this.event_edit_btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 611);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.DescriptionChange);
            this.Controls.Add(this.justText1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.justText);
            this.Controls.Add(this.DetailsChange);
            this.Controls.Add(this.NameChange);
            this.Controls.Add(this.event_edit_btn_ok);
            this.MinimumSize = new System.Drawing.Size(620, 650);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма для події";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button event_edit_btn_ok;
        private System.Windows.Forms.TextBox NameChange;
        private System.Windows.Forms.RichTextBox DetailsChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label justText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label justText1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionChange;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}