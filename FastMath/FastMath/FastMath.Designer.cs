namespace FastMath
{
    partial class FastMath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastMath));
            this.Osszeadas = new System.Windows.Forms.Button();
            this.Kivonas = new System.Windows.Forms.Button();
            this.Szorzas = new System.Windows.Forms.Button();
            this.Osztas = new System.Windows.Forms.Button();
            this.opInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osszeadas
            // 
            this.Osszeadas.Location = new System.Drawing.Point(107, 65);
            this.Osszeadas.Name = "Osszeadas";
            this.Osszeadas.Size = new System.Drawing.Size(75, 23);
            this.Osszeadas.TabIndex = 0;
            this.Osszeadas.Text = "Összeadás";
            this.Osszeadas.UseVisualStyleBackColor = true;
            this.Osszeadas.Click += new System.EventHandler(this.Osszeadas_Click);
            // 
            // Kivonas
            // 
            this.Kivonas.Location = new System.Drawing.Point(107, 111);
            this.Kivonas.Name = "Kivonas";
            this.Kivonas.Size = new System.Drawing.Size(75, 23);
            this.Kivonas.TabIndex = 1;
            this.Kivonas.Text = "Kivonás";
            this.Kivonas.UseVisualStyleBackColor = true;
            this.Kivonas.Click += new System.EventHandler(this.Kivonas_Click);
            // 
            // Szorzas
            // 
            this.Szorzas.Location = new System.Drawing.Point(107, 154);
            this.Szorzas.Name = "Szorzas";
            this.Szorzas.Size = new System.Drawing.Size(75, 23);
            this.Szorzas.TabIndex = 2;
            this.Szorzas.Text = "Szorzás";
            this.Szorzas.UseVisualStyleBackColor = true;
            this.Szorzas.Click += new System.EventHandler(this.Szorzas_Click);
            // 
            // Osztas
            // 
            this.Osztas.Location = new System.Drawing.Point(107, 201);
            this.Osztas.Name = "Osztas";
            this.Osztas.Size = new System.Drawing.Size(75, 23);
            this.Osztas.TabIndex = 3;
            this.Osztas.Text = "Osztás";
            this.Osztas.UseVisualStyleBackColor = true;
            this.Osztas.Click += new System.EventHandler(this.Osztas_Click);
            // 
            // opInstruction
            // 
            this.opInstruction.AutoSize = true;
            this.opInstruction.Location = new System.Drawing.Point(34, 26);
            this.opInstruction.Name = "opInstruction";
            this.opInstruction.Size = new System.Drawing.Size(238, 13);
            this.opInstruction.TabIndex = 4;
            this.opInstruction.Text = "Válassza ki melyik műveletet szeretné gyakorolni!";
            // 
            // FastMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.opInstruction);
            this.Controls.Add(this.Osztas);
            this.Controls.Add(this.Szorzas);
            this.Controls.Add(this.Kivonas);
            this.Controls.Add(this.Osszeadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FastMath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastMath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Difficulty()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastMath));
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.Mixed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Válassz nehézséget a művelethez!";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mixed);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nehézség";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Task()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastMath));
            this.firstNum = new System.Windows.Forms.Label();
            this.correctAnswer = new System.Windows.Forms.Label();
            this.correctAnswers = new System.Windows.Forms.Label();
            this.incorrectAnswers = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeRemain = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.tasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = false;
            this.firstNum.Location = new System.Drawing.Point(74, 43);
            this.firstNum.Name = "firstNum";
            this.firstNum.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNum.Size = new System.Drawing.Size(800, 100);
            this.firstNum.TabIndex = 6;
            this.firstNum.Text = "művelet";
            this.firstNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctAnswer
            // 
            this.correctAnswer.AutoSize = true;
            this.correctAnswer.Location = new System.Drawing.Point(330, 143);
            this.correctAnswer.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(90, 13);
            this.correctAnswer.TabIndex = 3;
            this.correctAnswer.Text = "Helyes megoldás:";
            // 
            // correctAnswers
            // 
            this.correctAnswers.AutoSize = true;
            this.correctAnswers.Location = new System.Drawing.Point(29, 506);
            this.correctAnswers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswers.Name = "correctAnswers";
            this.correctAnswers.Size = new System.Drawing.Size(135, 13);
            this.correctAnswers.TabIndex = 4;
            this.correctAnswers.Text = "Helyes megoldások száma:";
            // 
            // incorrectAnswers
            // 
            this.incorrectAnswers.AutoSize = true;
            this.incorrectAnswers.Location = new System.Drawing.Point(265, 506);
            this.incorrectAnswers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectAnswers.Name = "incorrectAnswers";
            this.incorrectAnswers.Size = new System.Drawing.Size(147, 13);
            this.incorrectAnswers.TabIndex = 5;
            this.incorrectAnswers.Text = "Helytelen megoldások száma:";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(436, 402);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 6;
            this.done.Text = "Start";
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
            this.timeRemain.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeRemain.Location = new System.Drawing.Point(850, 26);
            this.timeRemain.Name = "timeRemain";
            this.timeRemain.Size = new System.Drawing.Size(158, 27);
            this.timeRemain.TabIndex = 7;
            this.timeRemain.Text = "Hátralévő idő:";
            this.timeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(373, 264);
            this.answer.Name = "answer";
            this.answer.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer.Size = new System.Drawing.Size(200, 55);
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answer.TabIndex = 8;
            this.answer.Text = null;
            // 
            // tasks
            // 
            this.tasks.AutoSize = true;
            this.tasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasks.Location = new System.Drawing.Point(410, 13);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(119, 20);
            this.tasks.TabIndex = 7;
            this.tasks.Text = "Feladatok: 10/2";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.CenterToScreen();
            this.Controls.Add(this.answer);
            this.Controls.Add(this.timeRemain);
            this.Controls.Add(this.done);
            this.Controls.Add(this.incorrectAnswers);
            this.Controls.Add(this.correctAnswers);
            this.Controls.Add(this.correctAnswer);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.tasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Task";
            this.Text = "Feladat";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label firstNum;
        private System.Windows.Forms.Label correctAnswer;
        private System.Windows.Forms.Label correctAnswers;
        private System.Windows.Forms.Label incorrectAnswers;
        private System.Windows.Forms.Label tasks;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeRemain;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Button Mixed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Osszeadas;
        private System.Windows.Forms.Button Kivonas;
        private System.Windows.Forms.Button Szorzas;
        private System.Windows.Forms.Button Osztas;
        private System.Windows.Forms.Label opInstruction;
    }
}

