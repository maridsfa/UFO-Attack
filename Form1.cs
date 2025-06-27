using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace trab_prog
{

    //SPACE INVADERS
    //MARIA ISABEL SOARES E MARIANA FARIAS - TRÔ 7M


    public partial class pb_Gameover : Form
    {
        private int _alienslinhaAtaqueAuto = 4;
        private int _maxAlienslinhaAtaqueAuto = 6;
        private int _maxInitialAliens = 3;
        
        public pb_Gameover()
        {
            InitializeComponent();
            pbNave.Visible = false;
            pbLogo.Visible = true;

        }

        #region Eventos do Formulario
        private void btStart_Click(object sender, EventArgs e)
        {
            pbNave.Visible = true;
            btStart.Visible = false;
            btStart.Enabled = false;
            pbLogo.Visible = false;
            bt_jogarnovamente.Visible = false;
            pb_gv.Visible = false;
            
            //Gera os aliens de forma dinâmica
            System.Windows.Forms.Timer geraLinhasAtaqueAlien = new System.Windows.Forms.Timer();
            geraLinhasAtaqueAlien.Interval = 5000;
            geraLinhasAtaqueAlien.Tick += GeraAlien_Tick;
            geraLinhasAtaqueAlien.Start();

            //Coloca os primeiros 3 aliens em colunas no formulário para o ataque
            int alienX = 50, alienY = 0;

            double incrementalNextPosition = this.Size.Width / _maxInitialAliens;

            for (int m = 1; m <= _maxInitialAliens; m++)
            {
                PictureBox pbAlien = new PictureBox();
                pbAlien.Name = "Alien";
                pbAlien.SizeMode = PictureBoxSizeMode.Zoom;
                pbAlien.Image = Image.FromFile("../../Figuras/aliens1.png");
                pbAlien.Size = new System.Drawing.Size(50, 50);
                pbAlien.Visible = true;
                pbAlien.Location = new Point(alienX, alienY);
                this.Controls.Add(pbAlien);


                alienX += (int)Math.Ceiling(incrementalNextPosition);

            }

            //Cria um timer e o evento Tick do timer para os aliens descerem no formulário
            System.Windows.Forms.Timer tmMoveAliens = new System.Windows.Forms.Timer();
            tmMoveAliens.Interval = 1000;

            //Representa o método que vai ser executado para tratar o evento Tick (quando o tempo do timer acabar) - irá gerar o resto dos aliens em colunas
            tmMoveAliens.Tick += TmMoveAliens_Tick; 
            tmMoveAliens.Start();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Desabilita o som ao pressionar as teclas
            e.SuppressKeyPress = true;
            bt_jogarnovamente.Visible = false;
            int passo = 5;


            if (e.KeyCode == Keys.D)
            {
                if (pbNave.Location.X + pbNave.Width + passo <= 700)
                {
                    pbNave.Location = new Point(pbNave.Location.X + passo, pbNave.Location.Y);
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (pbNave.Location.X + pbNave.Left + passo >= -39)
                {
                    pbNave.Location = new Point(pbNave.Location.X - passo, pbNave.Location.Y);
                }
            }


            if (e.KeyCode == Keys.Space)
            {
                int naveMidllePosition = pbNave.Size.Width / 2;

                //Cria de forma dinâmica os picture box dos tiros quando a tecla espaço for pressionada
                PictureBox pbTiro = new PictureBox();
                pbTiro.Name = Guid.NewGuid().ToString();
                pbTiro.SizeMode = PictureBoxSizeMode.Zoom;
                pbTiro.Image = Image.FromFile("../../Figuras/laser.png");
                pbTiro.Size = new System.Drawing.Size(10, 30);
                pbTiro.Visible = true;
                pbTiro.Location = new Point(pbNave.Location.X + naveMidllePosition, pbNave.Location.Y - 47);
                this.Controls.Add(pbTiro);

                //Cria de forma dinâmica o timer e o evento Tick dos tiros 
                System.Windows.Forms.Timer tmTiro = new System.Windows.Forms.Timer();
                tmTiro.Interval = 30;
                tmTiro.Tag = pbTiro.Name;

                //Representa o método que vai ser executado para tratar o evento Tick (quando o tempo do timer acabar)
                tmTiro.Tick += TmTiro_Tick; 
                tmTiro.Start();

            }

        } 

        #endregion

        #region Métodos para Identificar condição do Alien

        //Identifica se o tiro atingiu algum alien
        private bool alienAtingido(PictureBox pbAlien, PictureBox pbTiro)
        {
            bt_jogarnovamente.Visible = false;

            if ((pbTiro.Location.X >= pbAlien.Location.X) && pbTiro.Location.X <= (pbAlien.Location.X + 50))
            {

                if (pbTiro.Location.Y <= (pbAlien.Location.Y + 50) && pbTiro.Location.Y >= pbAlien.Location.Y)
                {
                    return true;
                }
            }

            return false;
        }


        private bool validaGameOver(PictureBox pbAlien)
        {
            //Identifica se o alien aterrisou
            if (pbAlien.Location.Y >= 430)
            {
                return true;
            }

            //Idetifica se o alien atingiu a nave
            int naveRightSideLocation = pbNave.Location.X + 80;
            int alienRightSideLocation = pbAlien.Location.X + 50;

            if ((pbAlien.Location.X >= pbNave.Location.X) && (pbAlien.Location.X <= naveRightSideLocation)
                    || (alienRightSideLocation >= pbNave.Location.X) && (alienRightSideLocation <= naveRightSideLocation))
            {
                if (pbAlien.Location.Y + 50 >= pbNave.Location.Y)
                {
                    return true;
                }
            }
            
            return false;
        }


        #endregion

        #region Métodos Tick dos Timers

        private void GeraAlien_Tick(object sender, EventArgs e)
        {
            int alienXPosition = 50;

            for (int m = 1; m <= _alienslinhaAtaqueAuto; m++)
            {
                PictureBox pbAlien = new PictureBox();
                pbAlien.Name = "Alien";
                pbAlien.SizeMode = PictureBoxSizeMode.Zoom;
                pbAlien.Image = Image.FromFile("../../Figuras/aliens1.png");
                pbAlien.Size = new System.Drawing.Size(50, 50);
                pbAlien.Visible = true;
                pbAlien.Location = new Point(alienXPosition, 0);
                this.Controls.Add(pbAlien);

                //Divide a janela pela quantidade de aliens na linha
                double incrementalNextPosition = this.Size.Width / _alienslinhaAtaqueAuto; 
                //Converte esse resultado para para próximo número inteiro
                alienXPosition += (int)Math.Ceiling(incrementalNextPosition); 

            }

            _alienslinhaAtaqueAuto++;

            //Identifica se o máximo numero de aliens por linha de ataque foi gerado
            if (_alienslinhaAtaqueAuto > _maxAlienslinhaAtaqueAuto)
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
                timer.Stop();
                timer.Dispose();
            }
        }

        private void TmTiro_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;

            //Informa para o timer a picture box que ele controla
            PictureBox pbTiro = this.Controls.OfType<PictureBox>().FirstOrDefault(c => c.Name == timer.Tag.ToString());
            
            //Pergunta ao formUlário se o tiro ainda está na área visivel do jogo
            bool tiroAtivo = pbTiro.Location.Y > 0;

            if (tiroAtivo)
            {
                //O uso do foreach, em suma, pergunta ao formulario quais são os aliens ativos na tela e "percorre" eles
                foreach (PictureBox alien in this.Controls.OfType<PictureBox>().Where(c => c.Name == "Alien"))
                {
                    //Verifica se algum dos diversos aliens foi atingido
                    if (alienAtingido(alien, pbTiro))
                    {  
                        //Se sim, o alien é destruído
                        alien.Visible = false;
                        this.Controls.Remove(alien);
                        alien.Dispose();
                      
                        tiroAtivo = false;
                        break;

                    }
                    
                }

                pbTiro.Location = new Point(pbTiro.Location.X, pbTiro.Location.Y - 5);
            }

            //Se o tiro não está na area do jogo ou atingiu algum alien, ele é destruido
            if (!tiroAtivo)
            {
                timer.Stop();
                timer.Dispose();
                pbTiro.Visible = false;
                this.Controls.Remove(pbTiro); 
                pbTiro.Dispose();

                //Valida se ainda ainda existem aliens no formulário
                bool todosAliensEliminados = this.Controls.OfType<PictureBox>().Count(c => c.Name == "Alien") == 0;

                if (todosAliensEliminados)
                {
                    pbGanhou.Visible = true;
                    bt_jogarnovamente.Visible = true;
                }
            }

        }

        private void TmMoveAliens_Tick(object sender, EventArgs e)
        {
            bool gameOver = false;

            //Pergunta ao formulário uma lista de todos os Picture Box que são do tipo "Alien" e percorre essa lista com o foreach
            foreach (PictureBox alien in this.Controls.OfType<PictureBox>().Where(c => c.Name == "Alien"))
            {
                gameOver = validaGameOver(alien);

                if (gameOver)
                {
                    //Type cast (identifica o timer chamador do evento)
                    System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;

                    timer.Stop(); //Desativa o timer que gera o movimento dos aliens
                    timer.Dispose();

                    break;
                }

                //Não sendo GameOver o timer seguirá movimentando os aliens
                alien.Location = new Point(alien.Location.X, alien.Location.Y + 10);
            }

            if (gameOver)
            {
                bt_jogarnovamente.Visible = true;
                pb_gv.Visible = true;
            } 

        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }
    }
}
