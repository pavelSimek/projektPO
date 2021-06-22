
namespace projektPO.Forms
{
    partial class SubjectForm
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
            this.bClear = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nCredits = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lEmployee = new System.Windows.Forms.Label();
            this.nLectureHours = new System.Windows.Forms.NumericUpDown();
            this.nExcerciseHours = new System.Windows.Forms.NumericUpDown();
            this.nSeminarHours = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEndType = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbGuaranteeingInstitute = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nWeeks = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGuarantorName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nClassSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLectureHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nExcerciseHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSeminarHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(321, 49);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(103, 23);
            this.bClear.TabIndex = 43;
            this.bClear.Text = "Smazat";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(321, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(103, 31);
            this.bAdd.TabIndex = 42;
            this.bAdd.Text = "Přidat";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Počet kreditů";
            // 
            // nCredits
            // 
            this.nCredits.Location = new System.Drawing.Point(282, 184);
            this.nCredits.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nCredits.Name = "nCredits";
            this.nCredits.Size = new System.Drawing.Size(100, 20);
            this.nCredits.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Jazyk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ukončení předmětu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Hodiny cvičení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Hodiny přednášek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Zkratka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Název";
            // 
            // tbShortName
            // 
            this.tbShortName.Location = new System.Drawing.Point(29, 132);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(163, 20);
            this.tbShortName.TabIndex = 27;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(29, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 26;
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(12, 9);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(206, 55);
            this.lEmployee.TabIndex = 25;
            this.lEmployee.Text = "Předmět";
            // 
            // nLectureHours
            // 
            this.nLectureHours.Location = new System.Drawing.Point(29, 159);
            this.nLectureHours.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nLectureHours.Name = "nLectureHours";
            this.nLectureHours.Size = new System.Drawing.Size(100, 20);
            this.nLectureHours.TabIndex = 45;
            // 
            // nExcerciseHours
            // 
            this.nExcerciseHours.Location = new System.Drawing.Point(29, 184);
            this.nExcerciseHours.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nExcerciseHours.Name = "nExcerciseHours";
            this.nExcerciseHours.Size = new System.Drawing.Size(100, 20);
            this.nExcerciseHours.TabIndex = 47;
            // 
            // nSeminarHours
            // 
            this.nSeminarHours.Location = new System.Drawing.Point(29, 210);
            this.nSeminarHours.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nSeminarHours.Name = "nSeminarHours";
            this.nSeminarHours.Size = new System.Drawing.Size(100, 20);
            this.nSeminarHours.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Hodiny seminářů";
            // 
            // cbEndType
            // 
            this.cbEndType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndType.FormattingEnabled = true;
            this.cbEndType.Location = new System.Drawing.Point(282, 106);
            this.cbEndType.Name = "cbEndType";
            this.cbEndType.Size = new System.Drawing.Size(100, 21);
            this.cbEndType.TabIndex = 50;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(282, 131);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(100, 21);
            this.cbLanguage.TabIndex = 51;
            // 
            // cbGuaranteeingInstitute
            // 
            this.cbGuaranteeingInstitute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuaranteeingInstitute.FormattingEnabled = true;
            this.cbGuaranteeingInstitute.Location = new System.Drawing.Point(282, 159);
            this.cbGuaranteeingInstitute.Name = "cbGuaranteeingInstitute";
            this.cbGuaranteeingInstitute.Size = new System.Drawing.Size(100, 21);
            this.cbGuaranteeingInstitute.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Garantující ústav";
            // 
            // nWeeks
            // 
            this.nWeeks.Location = new System.Drawing.Point(282, 210);
            this.nWeeks.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWeeks.Name = "nWeeks";
            this.nWeeks.Size = new System.Drawing.Size(100, 20);
            this.nWeeks.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Počet týdnů";
            // 
            // tbGuarantorName
            // 
            this.tbGuarantorName.Location = new System.Drawing.Point(29, 236);
            this.tbGuarantorName.Name = "tbGuarantorName";
            this.tbGuarantorName.Size = new System.Drawing.Size(130, 20);
            this.tbGuarantorName.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Jméno garanta";
            // 
            // nClassSize
            // 
            this.nClassSize.Location = new System.Drawing.Point(282, 236);
            this.nClassSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nClassSize.Name = "nClassSize";
            this.nClassSize.Size = new System.Drawing.Size(100, 20);
            this.nClassSize.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(399, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Velikost třídy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Vyčistit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgEvents
            // 
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Location = new System.Drawing.Point(546, 106);
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.Size = new System.Drawing.Size(321, 171);
            this.dgEvents.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(548, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(319, 42);
            this.label13.TabIndex = 62;
            this.label13.Text = "Skupiny předmětu";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 289);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nClassSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbGuarantorName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nWeeks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGuaranteeingInstitute);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbEndType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nSeminarHours);
            this.Controls.Add(this.nExcerciseHours);
            this.Controls.Add(this.nLectureHours);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nCredits);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShortName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lEmployee);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.nCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLectureHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nExcerciseHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSeminarHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nCredits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.NumericUpDown nLectureHours;
        private System.Windows.Forms.NumericUpDown nExcerciseHours;
        private System.Windows.Forms.NumericUpDown nSeminarHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEndType;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbGuaranteeingInstitute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nWeeks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGuarantorName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nClassSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Label label13;
    }
}