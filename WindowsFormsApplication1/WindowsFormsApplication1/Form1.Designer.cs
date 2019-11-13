namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yoLabel = new System.Windows.Forms.Label();
            this.yodbLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AccessibleName = "startButton";
            this.startButton.Location = new System.Drawing.Point(12, 276);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(356, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(12, 247);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(356, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aLabel.Location = new System.Drawing.Point(12, 9);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(26, 29);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLabel.Location = new System.Drawing.Point(108, 9);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(26, 29);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(194, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(331, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(23, 25);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "0";
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(12, 221);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(356, 20);
            this.answerBox.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yoLabel
            // 
            this.yoLabel.AutoSize = true;
            this.yoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yoLabel.Location = new System.Drawing.Point(9, 49);
            this.yoLabel.Name = "yoLabel";
            this.yoLabel.Size = new System.Drawing.Size(134, 20);
            this.yoLabel.TabIndex = 8;
            this.yoLabel.Text = "Helyes megoldás:";
            // 
            // yodbLabel
            // 
            this.yodbLabel.AutoSize = true;
            this.yodbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yodbLabel.Location = new System.Drawing.Point(9, 73);
            this.yodbLabel.Name = "yodbLabel";
            this.yodbLabel.Size = new System.Drawing.Size(202, 20);
            this.yodbLabel.TabIndex = 9;
            this.yodbLabel.Text = "Helyes megoldások száma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 311);
            this.Controls.Add(this.yodbLabel);
            this.Controls.Add(this.yoLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label yoLabel;
        private System.Windows.Forms.Label yodbLabel;
    }
}

