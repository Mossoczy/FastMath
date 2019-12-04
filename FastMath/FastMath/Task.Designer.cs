namespace FastMath
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.firstNum = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.correctAnswer = new System.Windows.Forms.Label();
            this.correctAnswers = new System.Windows.Forms.Label();
            this.incorrectAnswers = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeRemain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = true;
            this.firstNum.Location = new System.Drawing.Point(12, 138);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(40, 13);
            this.firstNum.TabIndex = 0;
            this.firstNum.Text = "1.szám";
            // 
            // secondNum
            // 
            this.secondNum.AutoSize = true;
            this.secondNum.Location = new System.Drawing.Point(141, 138);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(40, 13);
            this.secondNum.TabIndex = 1;
            this.secondNum.Text = "2.szám";
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Location = new System.Drawing.Point(77, 138);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(45, 13);
            this.Operation.TabIndex = 2;
            this.Operation.Text = "Művelet";
            // 
            // correctAnswer
            // 
            this.correctAnswer.AutoSize = true;
            this.correctAnswer.Location = new System.Drawing.Point(12, 24);
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(90, 13);
            this.correctAnswer.TabIndex = 3;
            this.correctAnswer.Text = "Helyes megoldás:";
            // 
            // correctAnswers
            // 
            this.correctAnswers.AutoSize = true;
            this.correctAnswers.Location = new System.Drawing.Point(12, 48);
            this.correctAnswers.Name = "correctAnswers";
            this.correctAnswers.Size = new System.Drawing.Size(135, 13);
            this.correctAnswers.TabIndex = 4;
            this.correctAnswers.Text = "Helyes megoldások száma:";
            // 
            // incorrectAnswers
            // 
            this.incorrectAnswers.AutoSize = true;
            this.incorrectAnswers.Location = new System.Drawing.Point(12, 71);
            this.incorrectAnswers.Name = "incorrectAnswers";
            this.incorrectAnswers.Size = new System.Drawing.Size(147, 13);
            this.incorrectAnswers.TabIndex = 5;
            this.incorrectAnswers.Text = "Helytelen megoldások száma:";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(96, 226);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 6;
            this.done.Text = "Kész";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Task_Load);
            // 
            // timeRemain
            // 
            this.timeRemain.AutoSize = true;
            this.timeRemain.Location = new System.Drawing.Point(141, 9);
            this.timeRemain.Name = "timeRemain";
            this.timeRemain.Size = new System.Drawing.Size(73, 13);
            this.timeRemain.TabIndex = 7;
            this.timeRemain.Text = "Hátralévő idő:";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timeRemain);
            this.Controls.Add(this.done);
            this.Controls.Add(this.incorrectAnswers);
            this.Controls.Add(this.correctAnswers);
            this.Controls.Add(this.correctAnswer);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feladat";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNum;
        private System.Windows.Forms.Label secondNum;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.Label correctAnswer;
        private System.Windows.Forms.Label correctAnswers;
        private System.Windows.Forms.Label incorrectAnswers;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeRemain;    }
}