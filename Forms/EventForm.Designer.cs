
namespace projektPO.Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nClassSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nWeeks = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGuaranteeingInstitute = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nCredits = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Vyčistit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Počet týdnů";
            // 
            // nClassSize
            // 
            this.nClassSize.Location = new System.Drawing.Point(30, 197);
            this.nClassSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nClassSize.Name = "nClassSize";
            this.nClassSize.Size = new System.Drawing.Size(100, 20);
            this.nClassSize.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Počet hodin";
            // 
            // nWeeks
            // 
            this.nWeeks.Location = new System.Drawing.Point(30, 171);
            this.nWeeks.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWeeks.Name = "nWeeks";
            this.nWeeks.Size = new System.Drawing.Size(100, 20);
            this.nWeeks.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Typ rozvrhové akce";
            // 
            // cbGuaranteeingInstitute
            // 
            this.cbGuaranteeingInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuaranteeingInstitute.FormattingEnabled = true;
            this.cbGuaranteeingInstitute.Location = new System.Drawing.Point(339, 170);
            this.cbGuaranteeingInstitute.Name = "cbGuaranteeingInstitute";
            this.cbGuaranteeingInstitute.Size = new System.Drawing.Size(115, 21);
            this.cbGuaranteeingInstitute.TabIndex = 82;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(339, 142);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(115, 21);
            this.cbLanguage.TabIndex = 81;
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(292, 117);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(162, 21);
            this.cbSubject.TabIndex = 80;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(463, 57);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(103, 23);
            this.bClear.TabIndex = 75;
            this.bClear.Text = "Smazat";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(463, 20);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(103, 31);
            this.bAdd.TabIndex = 74;
            this.bAdd.Text = "Přidat";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Počet studentů";
            // 
            // nCredits
            // 
            this.nCredits.Location = new System.Drawing.Point(339, 197);
            this.nCredits.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nCredits.Name = "nCredits";
            this.nCredits.Size = new System.Drawing.Size(115, 20);
            this.nCredits.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Jazyk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Předmět";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Název";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(30, 117);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 64;
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(13, 20);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(370, 55);
            this.lEmployee.TabIndex = 63;
            this.lEmployee.Text = "Rozvrhová akce";
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(30, 143);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(170, 21);
            this.cbEmployee.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Zaměstnanec";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 272);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nClassSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nWeeks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGuaranteeingInstitute);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nCredits);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lEmployee);
            this.Name = "EventForm";
            this.Text = "Rozvrhová akce";
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nClassSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nWeeks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGuaranteeingInstitute;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nCredits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label label13;
    }
}