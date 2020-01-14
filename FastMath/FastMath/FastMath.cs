using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath
{
    public partial class FastMath : Form
    {
        string difficulty;
        bool wrong = false;
        bool correct = false;
        bool invalid = false;
        char művelet;
        int counter;
        int cAnswers;
        int incAnswers;
        Random rnd= new Random();
        double a = 0, b = 0, result, answerGiven;
        int taskCount;
        int maxTask;
        int score;
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\higscores.mdf;Integrated Security=True");

        public FastMath()
        {
            MainMenu();
        }
        private void startTask()
        {
            counter = 20;
            tasks.Text = "Feladatok: 10/" + (taskCount + 1);
            timeRemain.Text = "Hátralévő idő:\n" + counter + " másodperc";
            answer.Text = string.Empty;
            timer.Start();
            switch (művelet)
            {
                case '+':
                    DoOsszeadas(difficulty);
                    break;
                case '-':
                    DoKivonas(difficulty);
                    break;
                case '*':
                    DoSzorzas(difficulty);
                    break;
                case '/':
                    DoOsztas(difficulty);
                    break;
                default:
                    break;
            }
        }
        private void Task_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter = counter - 1;
                timeRemain.Text = "Hátralévő idő:\n" + counter + " másodperc";
                timer.Tick -= timer_Tick;
            }
            else
            {
                timer.Stop();
                timeRemain.Text = "Hátralévő idő:\n" + "Az idő lejárt!";
                MessageBox.Show("Sajnos nem sikerült időben befejezni.", ":(");
                if (taskCount+1!=maxTask)
                {
                    incAnswers++;
                    incorrectAnswers.Text = "Helytelen megoldások száma: " + incAnswers;
                    startTask();
                }
                else
                {
                    incAnswers++;
                    incorrectAnswers.Text = "Helytelen megoldások száma: " + incAnswers;
                    GameOver();
                }
            }
        }
        private void DoOsszeadas(string difficulty)
        {
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(101);
                    b = rnd.Next(101);
                    break;
                case "med":
                    a = rnd.Next(1001);
                    b = rnd.Next(1001);
                    break;
                case "hard":
                    a = rnd.NextDouble() * 50;
                    b = rnd.NextDouble() * 50;
                    a = Math.Round(a, 2);
                    b = Math.Round(b, 2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            DoOsszeadas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoOsszeadas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoOsszeadas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=?";
            result = a + b;
        }
        private void DoKivonas(string difficulty)
        {
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(101);
                    b = rnd.Next(101);
                    break;
                case "med":
                    a = rnd.Next(1001);
                    b = rnd.Next(1001);
                    break;
                case "hard":
                    a = rnd.NextDouble() * 50;
                    b = rnd.NextDouble() * 50;
                    a = Math.Round(a, 1);
                    b = Math.Round(b, 1);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            DoKivonas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoKivonas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoKivonas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=?";
            result = a - b;

        }
        private void DoSzorzas(string difficulty)
        {
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(11);
                    b = rnd.Next(11);
                    break;
                case "med":
                    a = rnd.Next(51);
                    b = rnd.Next(51);
                    break;
                case "hard":
                    a = rnd.NextDouble() * 20;
                    b = rnd.Next(31);
                    a = Math.Round(a, 2);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            DoSzorzas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoSzorzas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoSzorzas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = a.ToString() + művelet + b.ToString() + "=?";
            result = a * b;

        }
        private void DoOsztas(string difficulty)
        {
            switch (difficulty)
            {
                case "ez":
                    a = rnd.Next(11);
                    b = rnd.Next(1,11);
                    break;
                case "med":
                    a = rnd.Next(21);
                    b = rnd.Next(1,21);
                    break;
                case "hard":
                    a = rnd.Next(41);
                    b = rnd.Next(1,41);
                    break;
                case "mixed":
                    int mix = rnd.Next(1, 4);
                    switch (mix)
                    {
                        case 1:
                            difficulty = "ez";
                            DoSzorzas(difficulty);
                            break;
                        case 2:
                            difficulty = "med";
                            DoSzorzas(difficulty);
                            break;
                        case 3:
                            difficulty = "hard";
                            DoSzorzas(difficulty);
                            break;
                        default:
                            MessageBox.Show("ERR");
                            break;
                    }
                    break;
                default:
                    break;
            }
            firstNum.Text = (a*b).ToString() + művelet + b.ToString() + "=?";
            result = a ;
        }
        private void done_Click(object sender, EventArgs e)
        {
            
            CheckValidAnswer();
            if (answer.Text==result.ToString())
            {
                switch (difficulty)
                {
                    case "ez":
                        score += 100;
                        break;
                    case "med":
                        score += 150;
                        break;
                    case "hard":
                        score += 200;
                        break;
                    case "mixed":
                        score += 150;
                        break;
                    default:
                        break;
                }
                allscores.Text = "Pontok:" + score;
                cAnswers += 1;
                correctAnswer.ForeColor = Color.Green;
                correctAnswer.Text = "Helyes megoldás!";
                this.correctAnswer.Location = new System.Drawing.Point((this.ClientSize.Width - this.correctAnswer.Width) / 2, 143);
                correct = true;
            }
            else if(invalid==false)
            {
                correctAnswer.ForeColor = Color.Red;
                correctAnswer.Text = "Helyes megoldás:\n"+result;
                this.correctAnswer.Location = new System.Drawing.Point((this.ClientSize.Width - this.correctAnswer.Width) / 2, 143);
                incAnswers += 1;
                wrong = true;
            }
            correctAnswers.Text = "Helyes megoldások száma: " + cAnswers;
            correctAnswer.TextAlign = ContentAlignment.MiddleCenter;
            incorrectAnswers.Text = "Helytelen megoldások száma: " + incAnswers;
            if (taskCount+1 == maxTask)
            {
                GameOver();
            }

            else if ((wrong==true || correct==true || counter==0) && invalid==false)
            {
                taskCount++;
                startTask();
                timer.Enabled = true;
                timer.Start();
            }
        }
        private void CheckValidAnswer()
        {
            invalid = false;
            try
            {
                answerGiven=double.Parse(answer.Text);
            }
            catch (Exception)
            {
                invalid = true;
                timer.Stop();
                MessageBox.Show("Érvénytelen értéket adtál meg","Hiba");
                timer.Start();
            }
        }
        private void GameOver()
        {
            timer.Stop();
            //MessageBox.Show("Vége a " + (taskCount+1) + " feladatnak.\nHelyes megoldások: " + cAnswers + "\nHelytelen megoldások: " + incAnswers, "Game Over");
            this.Controls.Clear();
            GameEnded();
            scoreearned.Text = score + " Pontot értél el!\n";
            this.scoreearned.Location = new System.Drawing.Point((this.ClientSize.Width - this.scoreearned.Width) / 2, 89);
            this.writeurname.Location = new System.Drawing.Point((this.ClientSize.Width - this.writeurname.Width) / 2, 140);
        }
#region Events
        private void Osszeadas_Click(object sender, EventArgs e)
        {
            művelet = '+';
            this.Controls.Clear();
            Difficulty();
        }

        private void Kivonas_Click(object sender, EventArgs e)
        {
            művelet = '-';
            this.Controls.Clear();
            Difficulty();
        }

        private void Szorzas_Click(object sender, EventArgs e)
        {
            művelet = '*';
            this.Controls.Clear();
            Difficulty();
        }

        private void Osztas_Click(object sender, EventArgs e)
        {
            művelet = '/';
            this.Controls.Clear();
            Difficulty();
        }
        private void Easy_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "ez";
            startTask();
        }
        private void Medium_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "med";
            startTask();
        }
        private void Hard_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "hard";
            startTask();
        }
        private void Mixed_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Task();
            difficulty = "mixed";
            startTask();
        }
        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            startBtn.BackgroundImage = global::FastMath.Properties.Resources.start2;
        }
        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.BackgroundImage = global::FastMath.Properties.Resources.start;
        }
        private void highscoresBtn_MouseEnter(object sender, EventArgs e)
        {
            highscoresBtn.BackgroundImage = global::FastMath.Properties.Resources.highscores2;
        }

        private void highscoresBtn_MouseLeave(object sender, EventArgs e)
        {
            highscoresBtn.BackgroundImage = global::FastMath.Properties.Resources.highscores;
        }
        private void highscoresBtn_CLick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            HighScore();
            List<String> names = new List<String>();
            List<int> scores = new List<int>();
            List<string> dates = new List<string>();
            cn.Open();
            string query = "SELECT name FROM highscores ORDER BY score DESC";
            string query2 = "SELECT score FROM highscores ORDER BY score DESC";
            string query3 = "SELECT date FROM highscores ORDER BY score DESC";
            SqlCommand command = new SqlCommand(query, cn);
            SqlCommand command2 = new SqlCommand(query2, cn);
            SqlCommand command3 = new SqlCommand(query3, cn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
                }
            }
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                while (reader.Read())
                {
                    scores.Add(reader.GetInt32(0));
                }
            }
            using (SqlDataReader reader = command3.ExecuteReader())
            {
                while (reader.Read())
                {
                    dates.Add(reader.GetDateTime(0).ToString());
                }
            }
            label1.Text = "Név\n\n";
            label2.Text = "Pont\n\n";
            label3.Text = "Dátum\n\n";


            for (int i = 0; i < names.Count; i++)
            {
                label1.Text += i + 1 + ". " + names[i]+"\n";
                label2.Text += scores[i]+"\n";
                label3.Text += dates[i]+"\n";
                if (i==9)
                {
                    break;
                }
            }

            cn.Close();
        }
        private void SumbitSql_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO highscores (name, score, date) VALUES (@name, @score ,@date)";
            cmd.Parameters.AddWithValue("@name", writename.Text);
            cmd.Parameters.AddWithValue("@score", score);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            cn.Close();
            this.Controls.Clear();
            score = 0;
            taskCount = 0;
            cAnswers = 0;
            incAnswers = 0;
            MainMenu();
        }
        private void quitBtn_MouseEnter(object sender, EventArgs e)
        {
            quitBtn.BackgroundImage = global::FastMath.Properties.Resources.quit2;
        }

        private void quitBtn_MouseLeave(object sender, EventArgs e)
        {
            quitBtn.BackgroundImage = global::FastMath.Properties.Resources.quit;
        }
        private void quitBtn_CLick(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void startBtn_CLick(object sender, System.EventArgs e)
        {
            Operators();
            this.Controls.Clear();
            Operators();
            maxTask = 10;
        }
        private void Osszeadas_MouseEnter(object sender, EventArgs e)
        {
            Osszeadas.BackgroundImage = global::FastMath.Properties.Resources.ossz2;
        }

        private void Osszeadas_MouseLeave(object sender, EventArgs e)
        {
            Osszeadas.BackgroundImage = global::FastMath.Properties.Resources.ossz;
        }

        private void Kivonas_MouseEnter(object sender, EventArgs e)
        {
            Kivonas.BackgroundImage = global::FastMath.Properties.Resources.kiv2;
        }

        private void Kivonas_MouseLeave(object sender, EventArgs e)
        {
            Kivonas.BackgroundImage = global::FastMath.Properties.Resources.kiv;
        }

        private void Szorzas_MouseEnter(object sender, EventArgs e)
        {
            Szorzas.BackgroundImage = global::FastMath.Properties.Resources.szor2;
        }

        private void Szorzas_MouseLeave(object sender, EventArgs e)
        {
            Szorzas.BackgroundImage = global::FastMath.Properties.Resources.szor;
        }

        private void Osztas_MouseEnter(object sender, EventArgs e)
        {
            Osztas.BackgroundImage = global::FastMath.Properties.Resources.oszt2;
        }

        private void Osztas_MouseLeave(object sender, EventArgs e)
        {
            Osztas.BackgroundImage = global::FastMath.Properties.Resources.oszt;
        }

        private void Vegyes_MouseEnter(object sender, EventArgs e)
        {
            Vegyes.BackgroundImage = global::FastMath.Properties.Resources.vegyes2;
        }

        private void Vegyes_MouseLeave(object sender, EventArgs e)
        {
            Vegyes.BackgroundImage = global::FastMath.Properties.Resources.vegyes;
        }
        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back.BackgroundImage = global::FastMath.Properties.Resources.back2;
        }

        private void done_MouseLeave(object sender, EventArgs e)
        {
            done.BackgroundImage = global::FastMath.Properties.Resources.done;
        }
        private void done_MouseEnter(object sender, EventArgs e)
        {
            done.BackgroundImage = global::FastMath.Properties.Resources.done2;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back.BackgroundImage = global::FastMath.Properties.Resources.back;
        }
        private void Back_ToMainMenuClick(object sender, EventArgs e)
        {
            Back.BackgroundImage = global::FastMath.Properties.Resources.back;
            this.Controls.Clear();
            MainMenu();
        }
        private void Back_ToOperationsClick(object sender, EventArgs e)
        {
            Back.BackgroundImage = global::FastMath.Properties.Resources.back;
            this.Controls.Clear();
            Operators();
        }
        private void Easy_MouseLeave(object sender, EventArgs e)
        {
            Easy.BackgroundImage = global::FastMath.Properties.Resources.easy;
        }
        private void Easy_MouseEnter(object sender, EventArgs e)
        {
            Easy.BackgroundImage = global::FastMath.Properties.Resources.easy2;
        }
        private void Medium_MouseLeave(object sender, EventArgs e)
        {
            Medium.BackgroundImage = global::FastMath.Properties.Resources.med;
        }
        private void Medium_MouseEnter(object sender, EventArgs e)
        {
            Medium.BackgroundImage = global::FastMath.Properties.Resources.med2;
        }
        private void Hard_MouseLeave(object sender, EventArgs e)
        {
            Hard.BackgroundImage = global::FastMath.Properties.Resources.hard;
        }
        private void Hard_MouseEnter(object sender, EventArgs e)
        {
            Hard.BackgroundImage = global::FastMath.Properties.Resources.hard2;
        }
#endregion
    }
}
