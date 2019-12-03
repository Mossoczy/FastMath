namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.osszeadGomb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kivonGomb = new System.Windows.Forms.Button();
            this.szorozGomb = new System.Windows.Forms.Button();
            this.osztGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // osszeadGomb
            // 
            this.osszeadGomb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osszeadGomb.Location = new System.Drawing.Point(15, 56);
            this.osszeadGomb.Name = "osszeadGomb";
            this.osszeadGomb.Size = new System.Drawing.Size(114, 39);
            this.osszeadGomb.TabIndex = 0;
            this.osszeadGomb.Text = "Összeadás";
            this.osszeadGomb.UseVisualStyleBackColor = true;
            this.osszeadGomb.Click += new System.EventHandler(this.osszeadGomb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Helyesen megoldott feladatok száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(273, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(273, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(411, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Milyen matematikai műveletet szeretne gyakorolni?";
            // 
            // kivonGomb
            // 
            this.kivonGomb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kivonGomb.Location = new System.Drawing.Point(15, 118);
            this.kivonGomb.Name = "kivonGomb";
            this.kivonGomb.Size = new System.Drawing.Size(114, 39);
            this.kivonGomb.TabIndex = 12;
            this.kivonGomb.Text = "Kivonás";
            this.kivonGomb.UseVisualStyleBackColor = true;
            this.kivonGomb.Click += new System.EventHandler(this.kivonGomb_Click);
            // 
            // szorozGomb
            // 
            this.szorozGomb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szorozGomb.Location = new System.Drawing.Point(135, 56);
            this.szorozGomb.Name = "szorozGomb";
            this.szorozGomb.Size = new System.Drawing.Size(114, 39);
            this.szorozGomb.TabIndex = 13;
            this.szorozGomb.Text = "Szorzás";
            this.szorozGomb.UseVisualStyleBackColor = true;
            this.szorozGomb.Click += new System.EventHandler(this.szorozGomb_Click);
            // 
            // osztGomb
            // 
            this.osztGomb.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztGomb.Location = new System.Drawing.Point(135, 118);
            this.osztGomb.Name = "osztGomb";
            this.osztGomb.Size = new System.Drawing.Size(114, 39);
            this.osztGomb.TabIndex = 14;
            this.osztGomb.Text = "Osztás";
            this.osztGomb.UseVisualStyleBackColor = true;
            this.osztGomb.Click += new System.EventHandler(this.osztGomb_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 229);
            this.Controls.Add(this.osztGomb);
            this.Controls.Add(this.szorozGomb);
            this.Controls.Add(this.kivonGomb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.osszeadGomb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osszeadGomb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button kivonGomb;
        private System.Windows.Forms.Button szorozGomb;
        private System.Windows.Forms.Button osztGomb;
    }
}