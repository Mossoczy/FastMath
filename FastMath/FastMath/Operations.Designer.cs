namespace FastMath
{
    partial class ChooseOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseOperation));
            this.Osszeadas = new System.Windows.Forms.Button();
            this.Kivonas = new System.Windows.Forms.Button();
            this.Szorzas = new System.Windows.Forms.Button();
            this.Osztas = new System.Windows.Forms.Button();
            this.OpInstr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Osszeadas
            // 
            resources.ApplyResources(this.Osszeadas, "Osszeadas");
            this.Osszeadas.Name = "Osszeadas";
            this.Osszeadas.UseVisualStyleBackColor = true;
            this.Osszeadas.Click += new System.EventHandler(this.Osszeadas_Click);
            // 
            // Kivonas
            // 
            resources.ApplyResources(this.Kivonas, "Kivonas");
            this.Kivonas.Name = "Kivonas";
            this.Kivonas.UseVisualStyleBackColor = true;
            this.Kivonas.Click += new System.EventHandler(this.Kivonas_Click);
            // 
            // Szorzas
            // 
            resources.ApplyResources(this.Szorzas, "Szorzas");
            this.Szorzas.Name = "Szorzas";
            this.Szorzas.UseVisualStyleBackColor = true;
            this.Szorzas.Click += new System.EventHandler(this.Szorzas_Click);
            // 
            // Osztas
            // 
            resources.ApplyResources(this.Osztas, "Osztas");
            this.Osztas.Name = "Osztas";
            this.Osztas.UseVisualStyleBackColor = true;
            this.Osztas.Click += new System.EventHandler(this.Osztas_Click);
            // 
            // OpInstr
            // 
            resources.ApplyResources(this.OpInstr, "OpInstr");
            this.OpInstr.Name = "OpInstr";
            // 
            // ChooseOperation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpInstr);
            this.Controls.Add(this.Osztas);
            this.Controls.Add(this.Szorzas);
            this.Controls.Add(this.Kivonas);
            this.Controls.Add(this.Osszeadas);
            this.Name = "ChooseOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Osszeadas;
        private System.Windows.Forms.Button Kivonas;
        private System.Windows.Forms.Button Szorzas;
        private System.Windows.Forms.Button Osztas;
        private System.Windows.Forms.Label OpInstr;
    }
}

