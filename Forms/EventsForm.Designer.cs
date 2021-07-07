
namespace projektPO.Forms
{
    partial class EventsForm
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
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.bAdd = new System.Windows.Forms.Button();
            this.lEmployee = new System.Windows.Forms.Label();
            this.bEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEvents
            // 
            this.dgEvents.AllowUserToAddRows = false;
            this.dgEvents.AllowUserToDeleteRows = false;
            this.dgEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEvents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgEvents.Location = new System.Drawing.Point(0, 123);
            this.dgEvents.MultiSelect = false;
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEvents.Size = new System.Drawing.Size(800, 327);
            this.dgEvents.TabIndex = 11;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(388, 30);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(206, 45);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Přidat rozvrhovou akci";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmployee.Location = new System.Drawing.Point(12, 13);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(370, 55);
            this.lEmployee.TabIndex = 10;
            this.lEmployee.Text = "Rozvrhové akce";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(594, 30);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(206, 45);
            this.bEdit.TabIndex = 13;
            this.bEdit.Text = "Upravit rozvrhovou akci";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lEmployee);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.Button bEdit;
    }
}