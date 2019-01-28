namespace Task4_CG
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CylRadioButton = new System.Windows.Forms.RadioButton();
            this.ConusRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TLFX = new System.Windows.Forms.NumericUpDown();
            this.TLFY = new System.Windows.Forms.NumericUpDown();
            this.TLFZ = new System.Windows.Forms.NumericUpDown();
            this.BRNX = new System.Windows.Forms.NumericUpDown();
            this.BRNY = new System.Windows.Forms.NumericUpDown();
            this.BRNZ = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TLFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLFY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLFZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNZ)).BeginInit();
            this.SuspendLayout();
            // 
            // CylRadioButton
            // 
            this.CylRadioButton.AutoSize = true;
            this.CylRadioButton.Checked = true;
            this.CylRadioButton.Location = new System.Drawing.Point(283, 12);
            this.CylRadioButton.Name = "CylRadioButton";
            this.CylRadioButton.Size = new System.Drawing.Size(103, 24);
            this.CylRadioButton.TabIndex = 1;
            this.CylRadioButton.TabStop = true;
            this.CylRadioButton.Text = "Цилиндр";
            this.CylRadioButton.UseVisualStyleBackColor = true;
            this.CylRadioButton.CheckedChanged += new System.EventHandler(this.CylRadioButton_CheckedChanged);
            // 
            // ConusRadioButton
            // 
            this.ConusRadioButton.AutoSize = true;
            this.ConusRadioButton.Location = new System.Drawing.Point(392, 12);
            this.ConusRadioButton.Name = "ConusRadioButton";
            this.ConusRadioButton.Size = new System.Drawing.Size(77, 24);
            this.ConusRadioButton.TabIndex = 2;
            this.ConusRadioButton.Text = "Конус";
            this.ConusRadioButton.UseVisualStyleBackColor = true;
            this.ConusRadioButton.CheckedChanged += new System.EventHandler(this.ConusRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "TLF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "BRN";
            // 
            // TLFX
            // 
            this.TLFX.Location = new System.Drawing.Point(63, 36);
            this.TLFX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TLFX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.TLFX.Name = "TLFX";
            this.TLFX.Size = new System.Drawing.Size(53, 26);
            this.TLFX.TabIndex = 14;
            this.TLFX.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // TLFY
            // 
            this.TLFY.Location = new System.Drawing.Point(63, 70);
            this.TLFY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TLFY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.TLFY.Name = "TLFY";
            this.TLFY.Size = new System.Drawing.Size(53, 26);
            this.TLFY.TabIndex = 15;
            this.TLFY.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // TLFZ
            // 
            this.TLFZ.Location = new System.Drawing.Point(63, 103);
            this.TLFZ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TLFZ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.TLFZ.Name = "TLFZ";
            this.TLFZ.Size = new System.Drawing.Size(53, 26);
            this.TLFZ.TabIndex = 16;
            this.TLFZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TLFZ.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // BRNX
            // 
            this.BRNX.Location = new System.Drawing.Point(166, 36);
            this.BRNX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BRNX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.BRNX.Name = "BRNX";
            this.BRNX.Size = new System.Drawing.Size(53, 26);
            this.BRNX.TabIndex = 17;
            this.BRNX.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // BRNY
            // 
            this.BRNY.Location = new System.Drawing.Point(166, 70);
            this.BRNY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BRNY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.BRNY.Name = "BRNY";
            this.BRNY.Size = new System.Drawing.Size(53, 26);
            this.BRNY.TabIndex = 18;
            this.BRNY.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // BRNZ
            // 
            this.BRNZ.Location = new System.Drawing.Point(166, 103);
            this.BRNZ.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BRNZ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.BRNZ.Name = "BRNZ";
            this.BRNZ.Size = new System.Drawing.Size(53, 26);
            this.BRNZ.TabIndex = 19;
            this.BRNZ.ValueChanged += new System.EventHandler(this.TLFX_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 665);
            this.Controls.Add(this.BRNZ);
            this.Controls.Add(this.BRNY);
            this.Controls.Add(this.BRNX);
            this.Controls.Add(this.TLFZ);
            this.Controls.Add(this.TLFY);
            this.Controls.Add(this.TLFX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConusRadioButton);
            this.Controls.Add(this.CylRadioButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.TLFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLFY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLFZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BRNZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton CylRadioButton;
        private System.Windows.Forms.RadioButton ConusRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TLFX;
        private System.Windows.Forms.NumericUpDown TLFY;
        private System.Windows.Forms.NumericUpDown TLFZ;
        private System.Windows.Forms.NumericUpDown BRNX;
        private System.Windows.Forms.NumericUpDown BRNY;
        private System.Windows.Forms.NumericUpDown BRNZ;
    }
}

