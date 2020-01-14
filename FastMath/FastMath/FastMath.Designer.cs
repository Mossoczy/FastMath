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

        private void MainMenu()
        {
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.startBtn = new System.Windows.Forms.Button();
            this.highscoresBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackgroundImage = global::FastMath.Properties.Resources.start;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(262, 124);
            this.startBtn.Location = new System.Drawing.Point((this.ClientSize.Width - this.startBtn.Width) / 2, 83);
            this.startBtn.TabIndex = 0;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_CLick);
            this.startBtn.MouseEnter += new System.EventHandler(this.startBtn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.startBtn_MouseLeave);
            // 
            // highscoresBtn
            // 
            this.highscoresBtn.BackColor = System.Drawing.Color.Transparent;
            this.highscoresBtn.BackgroundImage = global::FastMath.Properties.Resources.highscores;
            this.highscoresBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highscoresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoresBtn.FlatAppearance.BorderSize = 0;
            this.highscoresBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highscoresBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highscoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoresBtn.Name = "highscoresBtn";
            this.highscoresBtn.Size = new System.Drawing.Size(336, 124);
            this.highscoresBtn.Location = new System.Drawing.Point((this.ClientSize.Width - this.highscoresBtn.Width) / 2, 310);
            this.highscoresBtn.TabIndex = 1;
            this.highscoresBtn.UseVisualStyleBackColor = false;
            this.highscoresBtn.Click += new System.EventHandler(this.highscoresBtn_CLick);
            this.highscoresBtn.MouseEnter += new System.EventHandler(this.highscoresBtn_MouseEnter);
            this.highscoresBtn.MouseLeave += new System.EventHandler(this.highscoresBtn_MouseLeave);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.BackgroundImage = global::FastMath.Properties.Resources.quit;
            this.quitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(252, 124);
            this.quitBtn.Location = new System.Drawing.Point((this.ClientSize.Width - this.quitBtn.Width) / 2, 560);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_CLick);
            this.quitBtn.MouseEnter += new System.EventHandler(this.quitBtn_MouseEnter);
            this.quitBtn.MouseLeave += new System.EventHandler(this.quitBtn_MouseLeave);
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FastMath.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CenterToScreen();
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.highscoresBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "MainMenu";
            this.Text = "Főmenü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Operators()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastMath));
            this.Osszeadas = new System.Windows.Forms.Button();
            this.Kivonas = new System.Windows.Forms.Button();
            this.Szorzas = new System.Windows.Forms.Button();
            this.Osztas = new System.Windows.Forms.Button();
            this.opInstruction = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Vegyes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Osszeadas
            // 
            this.Osszeadas.BackColor = System.Drawing.Color.Transparent;
            this.Osszeadas.BackgroundImage = global::FastMath.Properties.Resources.ossz;
            this.Osszeadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Osszeadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Osszeadas.FlatAppearance.BorderSize = 0;
            this.Osszeadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Osszeadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Osszeadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Osszeadas.Name = "Osszeadas";
            this.Osszeadas.Size = new System.Drawing.Size(184, 62);
            this.Osszeadas.Location = new System.Drawing.Point((this.ClientSize.Width - this.Osszeadas.Width) / 2, 105);
            this.Osszeadas.TabIndex = 0;
            this.Osszeadas.UseVisualStyleBackColor = false;
            this.Osszeadas.Click += new System.EventHandler(this.Osszeadas_Click);
            this.Osszeadas.MouseEnter += new System.EventHandler(this.Osszeadas_MouseEnter);
            this.Osszeadas.MouseLeave += new System.EventHandler(this.Osszeadas_MouseLeave);
            // 
            // Kivonas
            // 
            this.Kivonas.BackColor = System.Drawing.Color.Transparent;
            this.Kivonas.BackgroundImage = global::FastMath.Properties.Resources.kiv;
            this.Kivonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kivonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kivonas.FlatAppearance.BorderSize = 0;
            this.Kivonas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Kivonas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Kivonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kivonas.Name = "Kivonas";
            this.Kivonas.Size = new System.Drawing.Size(184, 62);
            this.Kivonas.Location = new System.Drawing.Point((this.ClientSize.Width - this.Kivonas.Width) / 2, 201);
            this.Kivonas.TabIndex = 1;
            this.Kivonas.UseVisualStyleBackColor = true;
            this.Kivonas.Click += new System.EventHandler(this.Kivonas_Click);
            this.Kivonas.MouseEnter += new System.EventHandler(this.Kivonas_MouseEnter);
            this.Kivonas.MouseLeave += new System.EventHandler(this.Kivonas_MouseLeave);
            // 
            // Szorzas
            // 
            this.Szorzas.BackColor = System.Drawing.Color.Transparent;
            this.Szorzas.BackgroundImage = global::FastMath.Properties.Resources.szor;
            this.Szorzas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Szorzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Szorzas.FlatAppearance.BorderSize = 0;
            this.Szorzas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Szorzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Szorzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Szorzas.Name = "Szorzas";
            this.Szorzas.Size = new System.Drawing.Size(183, 62);
            this.Szorzas.Location = new System.Drawing.Point((this.ClientSize.Width - this.Szorzas.Width) / 2, 288);
            this.Szorzas.TabIndex = 2;
            this.Szorzas.UseVisualStyleBackColor = true;
            this.Szorzas.Click += new System.EventHandler(this.Szorzas_Click);
            this.Szorzas.MouseEnter += new System.EventHandler(this.Szorzas_MouseEnter);
            this.Szorzas.MouseLeave += new System.EventHandler(this.Szorzas_MouseLeave);
            // 
            // Osztas
            // 
            this.Osztas.BackColor = System.Drawing.Color.Transparent;
            this.Osztas.BackgroundImage = global::FastMath.Properties.Resources.oszt;
            this.Osztas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Osztas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Osztas.FlatAppearance.BorderSize = 0;
            this.Osztas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Osztas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Osztas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Osztas.Name = "Osztas";
            this.Osztas.Size = new System.Drawing.Size(186, 62);
            this.Osztas.Location = new System.Drawing.Point((this.ClientSize.Width - this.Osztas.Width) / 2, 373);
            this.Osztas.TabIndex = 3;
            this.Osztas.UseVisualStyleBackColor = true;
            this.Osztas.Click += new System.EventHandler(this.Osztas_Click);
            this.Osztas.MouseEnter += new System.EventHandler(this.Osztas_MouseEnter);
            this.Osztas.MouseLeave += new System.EventHandler(this.Osztas_MouseLeave);
            // 
            // Vegyes
            // 
            this.Vegyes.BackColor = System.Drawing.Color.Transparent;
            this.Vegyes.BackgroundImage = global::FastMath.Properties.Resources.vegyes;
            this.Vegyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Vegyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vegyes.FlatAppearance.BorderSize = 0;
            this.Vegyes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Vegyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Vegyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vegyes.Name = "Vegyes";
            this.Vegyes.Size = new System.Drawing.Size(184, 62);
            this.Vegyes.Location = new System.Drawing.Point((this.ClientSize.Width - this.Vegyes.Width) / 2, 467);
            this.Vegyes.TabIndex = 4;
            this.Vegyes.UseVisualStyleBackColor = true;
            this.Vegyes.MouseEnter += new System.EventHandler(this.Vegyes_MouseEnter);
            this.Vegyes.MouseLeave += new System.EventHandler(this.Vegyes_MouseLeave);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = global::FastMath.Properties.Resources.back;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(178, 62);
            this.Back.Location = new System.Drawing.Point((this.ClientSize.Width - this.Back.Width) / 2, 683);
            this.Back.TabIndex = 5;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_ToMainMenuClick);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);
            // 
            // opInstruction
            // 
            this.opInstruction.ForeColor = System.Drawing.Color.White;
            this.opInstruction.BackColor = System.Drawing.Color.Transparent;
            this.opInstruction.AutoSize = true;
            this.opInstruction.Location = new System.Drawing.Point(45, 26);
            this.opInstruction.Name = "opInstruction";
            this.opInstruction.Size = new System.Drawing.Size(238, 13);
            this.opInstruction.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opInstruction.TabIndex = 5;
            this.opInstruction.Text = "Válassza ki melyik műveletet szeretné gyakorolni!";
            // 
            // FastMath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.opInstruction);
            this.Controls.Add(this.Osztas);
            this.Controls.Add(this.Szorzas);
            this.Controls.Add(this.Kivonas);
            this.Controls.Add(this.Osszeadas);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FastMath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Művelet";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void InitializeComponent()
        {
        }

        private void Difficulty()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastMath));
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.Mixed = new System.Windows.Forms.Button();
            this.chooseOp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.Transparent;
            this.Easy.BackgroundImage = global::FastMath.Properties.Resources.easy;
            this.Easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Easy.FlatAppearance.BorderSize = 0;
            this.Easy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(184, 62);
            this.Easy.Location = new System.Drawing.Point((this.ClientSize.Width - this.Easy.Width) / 2, 105);
            this.Easy.TabIndex = 0;
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            this.Easy.MouseEnter += new System.EventHandler(this.Easy_MouseEnter);
            this.Easy.MouseLeave += new System.EventHandler(this.Easy_MouseLeave);
            // 
            // Medium
            // 
            this.Medium.BackColor = System.Drawing.Color.Transparent;
            this.Medium.BackgroundImage = global::FastMath.Properties.Resources.med;
            this.Medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Medium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medium.FlatAppearance.BorderSize = 0;
            this.Medium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Medium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(184, 62);
            this.Medium.Location = new System.Drawing.Point((this.ClientSize.Width - this.Medium.Width) / 2, 201);
            this.Medium.TabIndex = 1;
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            this.Medium.MouseEnter += new System.EventHandler(this.Medium_MouseEnter);
            this.Medium.MouseLeave += new System.EventHandler(this.Medium_MouseLeave);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.Transparent;
            this.Hard.BackgroundImage = global::FastMath.Properties.Resources.hard;
            this.Hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hard.FlatAppearance.BorderSize = 0;
            this.Hard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(184, 62);
            this.Hard.Location = new System.Drawing.Point((this.ClientSize.Width - this.Hard.Width) / 2, 288);
            this.Hard.TabIndex = 2;
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            this.Hard.MouseEnter += new System.EventHandler(this.Hard_MouseEnter);
            this.Hard.MouseLeave += new System.EventHandler(this.Hard_MouseLeave);
            // 
            // Mixed
            // 
            this.Vegyes.Location = new System.Drawing.Point((this.ClientSize.Width - this.Vegyes.Width) / 2, 373);
            this.Vegyes.Click += new System.EventHandler(this.Mixed_Click);
            // 
            // chooseOp
            // 
            this.chooseOp.AutoSize = true;
            this.chooseOp.ForeColor = System.Drawing.Color.White;
            this.chooseOp.BackColor = System.Drawing.Color.Transparent;
            this.chooseOp.Location = new System.Drawing.Point(120, 23);
            this.chooseOp.Name = "chooseOp";
            this.chooseOp.Size = new System.Drawing.Size(170, 13);
            this.chooseOp.TabIndex = 4;
            this.chooseOp.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseOp.Text = "Válassz nehézséget a művelethez!";
            // 
            // Back
            // 
            this.Back.Click += new System.EventHandler(this.Back_ToOperationsClick);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.chooseOp);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Vegyes);
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
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.BackColor = System.Drawing.Color.Transparent;
            this.firstNum.ForeColor = System.Drawing.Color.White;
            this.firstNum.AutoSize = false;
            this.firstNum.Name = "firstNum";
            this.firstNum.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNum.Size = new System.Drawing.Size(800, 100);
            this.firstNum.Location = new System.Drawing.Point((this.ClientSize.Width - this.firstNum.Width) / 2, 43);
            this.firstNum.TabIndex = 6;
            this.firstNum.Text = "művelet";
            this.firstNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctAnswer
            // 
            this.correctAnswer.BackColor = System.Drawing.Color.Transparent;
            this.correctAnswer.AutoSize = true;
            this.correctAnswer.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(90, 13);
            this.correctAnswer.TabIndex = 3;
            this.correctAnswer.Text = "Helyes megoldás:";
            // 
            // correctAnswers
            // 
            this.correctAnswers.ForeColor = System.Drawing.Color.White;
            this.correctAnswers.BackColor = System.Drawing.Color.Transparent;
            this.correctAnswers.AutoSize = true;
            this.correctAnswers.Location = new System.Drawing.Point(29, 560);
            this.correctAnswers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.correctAnswers.Name = "correctAnswers";
            this.correctAnswers.Size = new System.Drawing.Size(135, 13);
            this.correctAnswers.TabIndex = 4;
            this.correctAnswers.Text = "Helyes megoldások száma:";
            // 
            // incorrectAnswers
            // 
            this.incorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.incorrectAnswers.ForeColor = System.Drawing.Color.White;
            this.incorrectAnswers.AutoSize = true;
            this.incorrectAnswers.Location = new System.Drawing.Point(265, 560);
            this.incorrectAnswers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectAnswers.Name = "incorrectAnswers";
            this.incorrectAnswers.Size = new System.Drawing.Size(147, 13);
            this.incorrectAnswers.TabIndex = 5;
            this.incorrectAnswers.Text = "Helytelen megoldások száma:";
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.Transparent;
            this.done.BackgroundImage = global::FastMath.Properties.Resources.done;
            this.done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderSize = 0;
            this.done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(300, 100);
            this.done.Location = new System.Drawing.Point((this.ClientSize.Width - this.done.Width) / 2, 380);
            this.done.TabIndex = 6;
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            this.done.MouseEnter += new System.EventHandler(this.done_MouseEnter);
            this.done.MouseLeave += new System.EventHandler(this.done_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Task_Load);
            // 
            // timeRemain
            // 
            this.timeRemain.BackColor = System.Drawing.Color.Transparent;
            this.timeRemain.ForeColor = System.Drawing.Color.White;
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
            this.answer.Name = "answer";
            this.answer.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer.Size = new System.Drawing.Size(200, 55);
            this.answer.Location = new System.Drawing.Point((this.ClientSize.Width - this.answer.Width) / 2, 264);
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answer.TabIndex = 8;
            this.answer.Text = null;
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.Color.Transparent;
            this.tasks.ForeColor = System.Drawing.Color.White;
            this.tasks.AutoSize = true;
            this.tasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(119, 20);
            this.tasks.Location = new System.Drawing.Point((this.ClientSize.Width - this.tasks.Width) / 2, 13);
            this.tasks.TabIndex = 9;
            this.tasks.Text = "Feladatok: 10/2";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private void GameEnded()
        {
            this.scoreearned = new System.Windows.Forms.Label();
            this.writename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scoreearned
            // 
            this.scoreearned.AutoSize = true;
            this.scoreearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreearned.ForeColor = System.Drawing.Color.White;
            this.scoreearned.Name = "score";
            this.scoreearned.Size = new System.Drawing.Size(294, 46);
            this.scoreearned.TabIndex = 0;
            this.scoreearned.Text = "Pontot értél el!";
            // 
            // writename
            // 
            this.writename.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.writename.MaxLength = 50;
            this.writename.Name = "writename";
            this.writename.Size = new System.Drawing.Size(216, 45);
            this.writename.Location = new System.Drawing.Point((this.ClientSize.Width - this.writename.Width) / 2, 291);
            this.writename.TabIndex = 1;
            this.writename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameEnded
            // 
            this.done.Click += new System.EventHandler(this.SumbitSql_Click);
            this.done.Click -= new System.EventHandler(this.done_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.writename);
            this.Controls.Add(this.scoreearned);
            this.Controls.Add(this.done);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "GameEnded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Játék vége";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void HighScore()
        {
            this.Back = new System.Windows.Forms.Button();
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(550, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;

            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.BackgroundImage = global::FastMath.Properties.Resources.back;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(178, 62);
            this.Back.Location = new System.Drawing.Point((this.ClientSize.Width - this.Back.Width) / 2, 500);
            this.Back.TabIndex = 0;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_ToMainMenuClick);
            this.Back.MouseEnter += new System.EventHandler(this.Back_MouseEnter);
            this.Back.MouseLeave += new System.EventHandler(this.Back_MouseLeave);

            this.CenterToScreen();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "HighScoresF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eredmények";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion      
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button highscoresBtn;
        private System.Windows.Forms.Button quitBtn;
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
        private System.Windows.Forms.Label chooseOp;
        private System.Windows.Forms.Button Osszeadas;
        private System.Windows.Forms.Button Kivonas;
        private System.Windows.Forms.Button Szorzas;
        private System.Windows.Forms.Button Osztas;
        private System.Windows.Forms.Label opInstruction;
        private System.Windows.Forms.Button Vegyes;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label scoreearned;
        private System.Windows.Forms.TextBox writename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

