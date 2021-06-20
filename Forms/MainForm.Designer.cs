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
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(620, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Přidání";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bGroup);
            this.Controls.Add(this.bSubject);
            this.Controls.Add(this.bEmployee);
            this.Name = "MainForm";
            this.Text = "Form1";
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
    }
}

