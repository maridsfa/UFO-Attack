namespace trab_prog
{
    partial class pb_Gameover
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pb_Gameover));
            this.pbNave = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bt_jogarnovamente = new System.Windows.Forms.Button();
            this.pb_gv = new System.Windows.Forms.PictureBox();
            this.pbGanhou = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGanhou)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNave
            // 
            this.pbNave.Image = ((System.Drawing.Image)(resources.GetObject("pbNave.Image")));
            this.pbNave.Location = new System.Drawing.Point(421, 458);
            this.pbNave.Margin = new System.Windows.Forms.Padding(4);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(80, 100);
            this.pbNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNave.TabIndex = 0;
            this.pbNave.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStart.BackgroundImage")));
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btStart.Location = new System.Drawing.Point(347, 335);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(222, 52);
            this.btStart.TabIndex = 1;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(163, 66);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(598, 246);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // bt_jogarnovamente
            // 
            this.bt_jogarnovamente.Location = new System.Drawing.Point(347, 335);
            this.bt_jogarnovamente.Name = "bt_jogarnovamente";
            this.bt_jogarnovamente.Size = new System.Drawing.Size(222, 52);
            this.bt_jogarnovamente.TabIndex = 4;
            this.bt_jogarnovamente.Text = "Jogar novamente";
            this.bt_jogarnovamente.UseVisualStyleBackColor = true;
            this.bt_jogarnovamente.Visible = false;
            this.bt_jogarnovamente.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_gv
            // 
            this.pb_gv.Image = ((System.Drawing.Image)(resources.GetObject("pb_gv.Image")));
            this.pb_gv.Location = new System.Drawing.Point(163, 66);
            this.pb_gv.Name = "pb_gv";
            this.pb_gv.Size = new System.Drawing.Size(605, 246);
            this.pb_gv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_gv.TabIndex = 5;
            this.pb_gv.TabStop = false;
            this.pb_gv.Visible = false;
            // 
            // pbGanhou
            // 
            this.pbGanhou.Image = ((System.Drawing.Image)(resources.GetObject("pbGanhou.Image")));
            this.pbGanhou.Location = new System.Drawing.Point(163, 66);
            this.pbGanhou.Name = "pbGanhou";
            this.pbGanhou.Size = new System.Drawing.Size(605, 246);
            this.pbGanhou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGanhou.TabIndex = 6;
            this.pbGanhou.TabStop = false;
            this.pbGanhou.Visible = false;
            // 
            // pb_Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(912, 583);
            this.Controls.Add(this.pbGanhou);
            this.Controls.Add(this.pb_gv);
            this.Controls.Add(this.bt_jogarnovamente);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbNave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "pb_Gameover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPACE INVADERS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGanhou)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNave;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button bt_jogarnovamente;
        private System.Windows.Forms.PictureBox pb_gv;
        private System.Windows.Forms.PictureBox pbGanhou;
    }
}

