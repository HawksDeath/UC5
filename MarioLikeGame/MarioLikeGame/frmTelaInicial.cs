using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mariolikegame.DAL;

namespace MarioLikeGame
{
    public partial class frmTelaInicial : Form
    {       

        public frmTelaInicial()
        {
            InitializeComponent();
            txtNome.MaxLength = 8;
        }

        //Criar uma lista de midias
        List<System.Windows.Media.MediaPlayer> sounds = new List<System.Windows.Media.MediaPlayer>();

        private void PreencherGrid()
        {
           
            //Declarando a DAL
            GamerDAL gamerDAL;            

            //Instanciando a DAL na construçao do formulario
            gamerDAL = new GamerDAL();            

            //Limpando o DataSource
            dgvListaRecorde.DataSource = null;            

            //Listando a DAL
            dgvListaRecorde.DataSource = gamerDAL.Listar();

            //Removendo a coluna id_Jogador
            dgvListaRecorde.Columns.Remove("IdJogador");

            //Mudar cor da tabela
            MudaFonte();

           
        }
        

        private void txtIniciar_Click(object sender, EventArgs e)
        {                      
            
             //verificar se o campo do nome do jogador esta em branco
              if (string.IsNullOrWhiteSpace(txtNome.Text))
              {
                    MessageBox.Show("Coloque o seu ou qualquer nome!","Mario Like Game");
              }
              else
              { 

                 //parar a musica
                 stopSound();
                 //Nao exibir a instancia atual da classe
                 this.Visible = false;
                 //Criar uma nova instancia do frmTelaJogo()
                 var frm = new frmTelaJogo();
                 //Pega o nome do jogador e envia para o Form1
                 frm.nomeGamer = txtNome.Text;
                 //Exibir o Formulario
                 frm.ShowDialog();              
                                             
              }               
                                          
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {

            PreencherGrid();
            

            playSound("27 main theme.mp3");

            //Setar o foco para o TextBox: nome do jogador
            txtNome.Focus();
            txtNome.Select();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Mudar cor da tabela
        private void MudaFonte()
        {           

            dgvListaRecorde.Columns[0].HeaderText = "Jogador";
            dgvListaRecorde.Columns[0].Width = 150;
            dgvListaRecorde.Columns[1].HeaderText = "Pontos";
            dgvListaRecorde.Columns[1].Width = 100;
            dgvListaRecorde.Columns[2].HeaderText = "Data/Hora";
            dgvListaRecorde.Columns[2].Width = 180;
            dgvListaRecorde.Columns[3].HeaderText = "Tempo";
            dgvListaRecorde.Columns[3].Width = 180;

            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Font = new Font("Tekton Pro", 30, FontStyle.Regular);
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaRecorde.AutoSize = true;
            dgvListaRecorde.EnableHeadersVisualStyles = false;

            if (dgvListaRecorde.RowCount > 0)
            {
                dgvListaRecorde.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed;
            }

            dgvListaRecorde.DefaultCellStyle.Font = new Font("Tekton Pro", 30, FontStyle.Regular);
            dgvListaRecorde.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            dgvListaRecorde.DefaultCellStyle.BackColor = Color.Blue;
            dgvListaRecorde.DefaultCellStyle.ForeColor = Color.White;

            

        }

        private void playSound(string nome)
        {
            string url = Application.StartupPath + @"\" + nome;
            var sound = new System.Windows.Media.MediaPlayer();
            sound.Open(new Uri(url));
            sound.Play();
            sounds.Add(sound);

        }

        private void stopSound()
        {
            for (int i = sounds.Count - 1; i >= 0; i--)
            {
                sounds[i].Stop();
                sounds.RemoveAt(i);
            }
        }
    }
}
