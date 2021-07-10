
namespace projektPO.Forms
{
    partial class StudyGroupSubjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudyGroup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Přiřazení předmětu a studijní skupiny";
            // 
            // cbStudyGroup
            // 
            this.cbStudyGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudyGroup.FormattingEnabled = true;
            this.cbStudyGroup.Location = new System.Drawing.Point(141, 101);
            this.cbStudyGroup.Name = "cbStudyGroup";
            this.cbStudyGroup.Size = new System.Drawing.Size(361, 21);
            this.cbStudyGroup.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "Studijní skupina";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(141, 168);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(361, 21);
            this.cbSubject.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Předmět";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(282, 220);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 97;
            this.bAdd.Text = "Uložit";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // StudyGroupSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 265);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.cbStudyGroup);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "StudyGroupSubjectForm";
            this.Text = "StudyGroupSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudyGroup;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAdd;
    }
}