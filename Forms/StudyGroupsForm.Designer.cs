
namespace projektPO.Forms
{
    partial class StudyGroupsForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgStudyGroups = new System.Windows.Forms.DataGridView();
            this.lEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudyGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Upravit skupinu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Přidat studijní skupinu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgStudyGroups
            // 
            this.dgStudyGroups.AllowUserToAddRows = false;
            this.dgStudyGroups.AllowUserToDeleteRows = false;
            this.dgStudyGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgStudyGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudyGroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgStudyGroups.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStudyGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgStudyGroups.Location = new System.Drawing.Point(0, 123);
            this.dgStudyGroups.MultiSelect = false;
            this.dgStudyGroups.Name = "dgStudyGroups";
            this.dgStudyGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudyGroups.Size = new System.Drawing.Size(800, 327);
            this.dgStudyGroups.TabIndex = 6;
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(9, 12);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(356, 55);
            this.lEmployee.TabIndex = 5;
            this.lEmployee.Text = "Studijní skupiny";
            // 
            // StudyGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgStudyGroups);
            this.Controls.Add(this.lEmployee);
            this.Name = "StudyGroupsForm";
            this.Text = "StudyGroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudyGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgStudyGroups;
        private System.Windows.Forms.Label lEmployee;
    }
}