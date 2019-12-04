namespace FastMath
{
    partial class Difficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Difficulty));
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.Mixed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.Location = new System.Drawing.Point(104, 65);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(75, 23);
            this.Easy.TabIndex = 0;
            this.Easy.Text = "Könnyű";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.Location = new System.Drawing.Point(104, 111);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(75, 23);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Közepes";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(104, 156);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(75, 23);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Nehéz";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Mixed
            // 
            this.Mixed.Location = new System.Drawing.Point(104, 202);
            this.Mixed.Name = "Mixed";
            this.Mixed.Size = new System.Drawing.Size(75, 23);
            this.Mixed.TabIndex = 3;
            this.Mixed.Text = "Vegyes";
            this.Mixed.UseVisualStyleBackColor = true;
            this.Mixed.Click += new System.EventHandler(this.Mixed_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Mixed);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nehézség";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button Mixed;
    }
}