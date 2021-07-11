namespace projektPO
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bEmployee = new System.Windows.Forms.Button();
            this.bSubject = new System.Windows.Forms.Button();
            this.bGroup = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // bEmployee
            // 
            this.bEmployee.Location = new System.Drawing.Point(600, 59);
            this.bEmployee.Name = "bEmployee";
            this.bEmployee.Size = new System.Drawing.Size(188, 46);
            this.bEmployee.TabIndex = 0;
            this.bEmployee.Text = "Zaměstnanec";
            this.bEmployee.UseVisualStyleBackColor = true;
            this.bEmployee.Click += new System.EventHandler(this.bEmployee_Click);
            // 
            // bSubject
            // 
            this.bSubject.Location = new System.Drawing.Point(600, 111);
            this.bSubject.Name = "bSubject";
            this.bSubject.Size = new System.Drawing.Size(188, 46);
            this.bSubject.TabIndex = 1;
            this.bSubject.Text = "Předmět";
            this.bSubject.UseVisualStyleBackColor = true;
            this.bSubject.Click += new System.EventHandler(this.bSubject_Click);
            // 
            // bGroup
            // 
            this.bGroup.Location = new System.Drawing.Point(600, 163);
            this.bGroup.Name = "bGroup";
            this.bGroup.Size = new System.Drawing.Size(188, 46);
            this.bGroup.TabIndex = 2;
            this.bGroup.Text = "Skupina";
            this.bGroup.UseVisualStyleBackColor = true;
            this.bGroup.Click += new System.EventHandler(this.bGroup_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Rozvrhové akce";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Přiřazení skupiny k předmětu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(620, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Úpravy";
            // 
            // dgEmployees
            // 
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(12, 80);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.Size = new System.Drawing.Size(551, 233);
            this.dgEmployees.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Úvazky zaměstnanců a body";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Obnovit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bGroup);
            this.Controls.Add(this.bSubject);
            this.Controls.Add(this.bEmployee);
            this.Name = "MainForm";
            this.Text = "Hlavní formulář";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEmployee;
        private System.Windows.Forms.Button bSubject;
        private System.Windows.Forms.Button bGroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

