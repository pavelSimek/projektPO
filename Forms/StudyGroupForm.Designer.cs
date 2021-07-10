
namespace projektPO.Forms
{
    partial class StudyGroupForm
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
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nClassSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nYear = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStudyType = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbStudyForm = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.lStudyGroup = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(29, 156);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(170, 21);
            this.cbSemester.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 112;
            this.label13.Text = "Semestr";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 111;
            this.button1.Text = "Vyčistit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nClassSize
            // 
            this.nClassSize.Location = new System.Drawing.Point(294, 186);
            this.nClassSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nClassSize.Name = "nClassSize";
            this.nClassSize.Size = new System.Drawing.Size(159, 20);
            this.nClassSize.TabIndex = 109;
            this.nClassSize.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Rok";
            // 
            // nYear
            // 
            this.nYear.Location = new System.Drawing.Point(29, 184);
            this.nYear.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nYear.Name = "nYear";
            this.nYear.Size = new System.Drawing.Size(169, 20);
            this.nYear.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Druh studia";
            // 
            // cbStudyType
            // 
            this.cbStudyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudyType.FormattingEnabled = true;
            this.cbStudyType.Location = new System.Drawing.Point(294, 159);
            this.cbStudyType.Name = "cbStudyType";
            this.cbStudyType.Size = new System.Drawing.Size(159, 21);
            this.cbStudyType.TabIndex = 105;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(294, 131);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(159, 21);
            this.cbLanguage.TabIndex = 104;
            // 
            // cbStudyForm
            // 
            this.cbStudyForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudyForm.FormattingEnabled = true;
            this.cbStudyForm.Location = new System.Drawing.Point(294, 106);
            this.cbStudyForm.Name = "cbStudyForm";
            this.cbStudyForm.Size = new System.Drawing.Size(159, 21);
            this.cbStudyForm.TabIndex = 103;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(462, 46);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(103, 23);
            this.bClear.TabIndex = 102;
            this.bClear.Text = "Smazat";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(462, 9);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(103, 31);
            this.bAdd.TabIndex = 101;
            this.bAdd.Text = "Přidat";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Počet studentů";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = "Jazyk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Studium";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Zkratka";
            // 
            // tbShortName
            // 
            this.tbShortName.Location = new System.Drawing.Point(29, 130);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(169, 20);
            this.tbShortName.TabIndex = 95;
            // 
            // lStudyGroup
            // 
            this.lStudyGroup.AutoSize = true;
            this.lStudyGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStudyGroup.Location = new System.Drawing.Point(12, 9);
            this.lStudyGroup.Name = "lStudyGroup";
            this.lStudyGroup.Size = new System.Drawing.Size(359, 55);
            this.lStudyGroup.TabIndex = 94;
            this.lStudyGroup.Text = "Studijní skupina";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(204, 107);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 115;
            this.lName.Text = "Název";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(30, 104);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 114;
            // 
            // StudyGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 241);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nClassSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStudyType);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbStudyForm);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShortName);
            this.Controls.Add(this.lStudyGroup);
            this.Name = "StudyGroupForm";
            this.Text = "StudyGroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.nClassSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nClassSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStudyType;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbStudyForm;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label lStudyGroup;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
    }
}