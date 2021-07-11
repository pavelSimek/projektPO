
namespace projektPO.Forms
{
    partial class EmployeeForm
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
            this.lEmployee = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPartyCode = new System.Windows.Forms.TextBox();
            this.tbWorkMail = new System.Windows.Forms.TextBox();
            this.tbPersonalEmail = new System.Windows.Forms.TextBox();
            this.tbPersonalPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbWorkPhone = new System.Windows.Forms.TextBox();
            this.nWorkTime = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.cbPhdStudent = new System.Windows.Forms.CheckBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(12, 20);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(316, 55);
            this.lEmployee.TabIndex = 0;
            this.lEmployee.Text = "Zaměstnanec";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(29, 117);
            this.tbFirstName.MaxLength = 100;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(29, 143);
            this.tbLastName.MaxLength = 100;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbPartyCode
            // 
            this.tbPartyCode.Location = new System.Drawing.Point(29, 169);
            this.tbPartyCode.MaxLength = 10;
            this.tbPartyCode.Name = "tbPartyCode";
            this.tbPartyCode.Size = new System.Drawing.Size(100, 20);
            this.tbPartyCode.TabIndex = 3;
            // 
            // tbWorkMail
            // 
            this.tbWorkMail.Location = new System.Drawing.Point(29, 195);
            this.tbWorkMail.MaxLength = 250;
            this.tbWorkMail.Name = "tbWorkMail";
            this.tbWorkMail.Size = new System.Drawing.Size(100, 20);
            this.tbWorkMail.TabIndex = 4;
            // 
            // tbPersonalEmail
            // 
            this.tbPersonalEmail.Location = new System.Drawing.Point(282, 117);
            this.tbPersonalEmail.MaxLength = 250;
            this.tbPersonalEmail.Name = "tbPersonalEmail";
            this.tbPersonalEmail.Size = new System.Drawing.Size(100, 20);
            this.tbPersonalEmail.TabIndex = 5;
            // 
            // tbPersonalPhone
            // 
            this.tbPersonalPhone.Location = new System.Drawing.Point(282, 169);
            this.tbPersonalPhone.MaxLength = 9;
            this.tbPersonalPhone.Name = "tbPersonalPhone";
            this.tbPersonalPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPersonalPhone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rodné číslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pracovní email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soukromý email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefonní číslo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pracovní telefonní číslo";
            // 
            // tbWorkPhone
            // 
            this.tbWorkPhone.Location = new System.Drawing.Point(282, 143);
            this.tbWorkPhone.MaxLength = 9;
            this.tbWorkPhone.Name = "tbWorkPhone";
            this.tbWorkPhone.Size = new System.Drawing.Size(100, 20);
            this.tbWorkPhone.TabIndex = 13;
            // 
            // nWorkTime
            // 
            this.nWorkTime.DecimalPlaces = 2;
            this.nWorkTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nWorkTime.Location = new System.Drawing.Point(282, 195);
            this.nWorkTime.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWorkTime.Name = "nWorkTime";
            this.nWorkTime.Size = new System.Drawing.Size(100, 20);
            this.nWorkTime.TabIndex = 19;
            this.nWorkTime.ValueChanged += new System.EventHandler(this.nWorkTime_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Úvazek";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(418, 7);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(103, 31);
            this.bAdd.TabIndex = 21;
            this.bAdd.Text = "Přidat";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(193, 78);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 23;
            this.bClear.Text = "Vyčistit";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // cbPhdStudent
            // 
            this.cbPhdStudent.AutoSize = true;
            this.cbPhdStudent.Location = new System.Drawing.Point(221, 230);
            this.cbPhdStudent.Name = "cbPhdStudent";
            this.cbPhdStudent.Size = new System.Drawing.Size(76, 17);
            this.cbPhdStudent.TabIndex = 24;
            this.cbPhdStudent.Text = "Doktorand";
            this.cbPhdStudent.UseVisualStyleBackColor = true;
            this.cbPhdStudent.CheckedChanged += new System.EventHandler(this.cbPhdStudent_CheckedChanged);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(418, 44);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(103, 31);
            this.bDelete.TabIndex = 25;
            this.bDelete.Text = "Smazat";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dgEvents
            // 
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Location = new System.Drawing.Point(553, 75);
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.Size = new System.Drawing.Size(565, 216);
            this.dgEvents.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(543, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 55);
            this.label7.TabIndex = 27;
            this.label7.Text = "Rozvrhové akce";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 295);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.cbPhdStudent);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nWorkTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbWorkPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPersonalPhone);
            this.Controls.Add(this.tbPersonalEmail);
            this.Controls.Add(this.tbWorkMail);
            this.Controls.Add(this.tbPartyCode);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Zaměstnanec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nWorkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPartyCode;
        private System.Windows.Forms.TextBox tbWorkMail;
        private System.Windows.Forms.TextBox tbPersonalEmail;
        private System.Windows.Forms.TextBox tbPersonalPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbWorkPhone;
        private System.Windows.Forms.NumericUpDown nWorkTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.CheckBox cbPhdStudent;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Label label7;
    }
}