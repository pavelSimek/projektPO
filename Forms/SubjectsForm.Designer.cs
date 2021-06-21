
namespace projektPO.Forms
{
    partial class SubjectsForm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.dgSubjects = new System.Windows.Forms.DataGridView();
            this.lEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(383, 52);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(206, 45);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Přidat předmět";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgSubjects
            // 
            this.dgSubjects.AllowUserToAddRows = false;
            this.dgSubjects.AllowUserToDeleteRows = false;
            this.dgSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubjects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSubjects.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgSubjects.Location = new System.Drawing.Point(0, 123);
            this.dgSubjects.MultiSelect = false;
            this.dgSubjects.Name = "dgSubjects";
            this.dgSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubjects.Size = new System.Drawing.Size(610, 327);
            this.dgSubjects.TabIndex = 5;
            this.dgSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSubjects_CellContentClick);
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(12, 52);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(230, 55);
            this.lEmployee.TabIndex = 4;
            this.lEmployee.Text = "Předměty";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dgSubjects);
            this.Controls.Add(this.lEmployee);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dgSubjects;
        private System.Windows.Forms.Label lEmployee;
    }
}