namespace MarioLikeGame
{
    partial class frmTelaInicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.dgvListaRecorde = new System.Windows.Forms.DataGridView();
            this.pnlTelaInicialSup = new System.Windows.Forms.Panel();
            this.pbMario2 = new System.Windows.Forms.PictureBox();
            this.pbMario1 = new System.Windows.Forms.PictureBox();
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.lblMaxCaracter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).BeginInit();
            this.pnlTelaInicialSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).BeginInit();
            this.gbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaRecorde
            // 
            this.dgvListaRecorde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaRecorde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRecorde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaRecorde.BackgroundColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaRecorde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaRecorde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaRecorde.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaRecorde.Location = new System.Drawing.Point(5, 125);
            this.dgvListaRecorde.Name = "dgvListaRecorde";
            this.dgvListaRecorde.RowHeadersVisible = false;
            this.dgvListaRecorde.Size = new System.Drawing.Size(673, 296);
            this.dgvListaRecorde.TabIndex = 0;
            // 
            // pnlTelaInicialSup
            // 
            this.pnlTelaInicialSup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTelaInicialSup.BackColor = System.Drawing.Color.Coral;
            this.pnlTelaInicialSup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTelaInicialSup.BackgroundImage")));
            this.pnlTelaInicialSup.Controls.Add(this.pbMario2);
            this.pnlTelaInicialSup.Controls.Add(this.pbMario1);
            this.pnlTelaInicialSup.Controls.Add(this.lblNomeJogo);
            this.pnlTelaInicialSup.Location = new System.Drawing.Point(2, 0);
            this.pnlTelaInicialSup.Name = "pnlTelaInicialSup";
            this.pnlTelaInicialSup.Size = new System.Drawing.Size(1166, 122);
            this.pnlTelaInicialSup.TabIndex = 1;
            // 
            // pbMario2
            // 
            this.pbMario2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMario2.BackColor = System.Drawing.Color.Transparent;
            this.pbMario2.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW1;
            this.pbMario2.Location = new System.Drawing.Point(922, 11);
            this.pbMario2.Name = "pbMario2";
            this.pbMario2.Size = new System.Drawing.Size(77, 108);
            this.pbMario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario2.TabIndex = 3;
            this.pbMario2.TabStop = false;
            // 
            // pbMario1
            // 
            this.pbMario1.BackColor = System.Drawing.Color.Transparent;
            this.pbMario1.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW1;
            this.pbMario1.Location = new System.Drawing.Point(71, 11);
            this.pbMario1.Name = "pbMario1";
            this.pbMario1.Size = new System.Drawing.Size(77, 108);
            this.pbMario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario1.TabIndex = 2;
            this.pbMario1.TabStop = false;
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblNomeJogo.Location = new System.Drawing.Point(392, 11);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(330, 76);
            this.lblNomeJogo.TabIndex = 4;
            this.lblNomeJogo.Text = "MarioLike";
            // 
            // lblJogador
            // 
            this.lblJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJogador.AutoSize = true;
            this.lblJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(894, 165);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(165, 46);
            this.lblJogador.TabIndex = 5;
            this.lblJogador.Text = "Jogador";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(829, 238);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 53);
            this.txtNome.TabIndex = 6;
            this.txtNome.Text = "Player 1";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(67, 52);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(204, 115);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.txtIniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(67, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(204, 115);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.gbOpcoes.Controls.Add(this.btnSair);
            this.gbOpcoes.Controls.Add(this.btnIniciar);
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(812, 310);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(343, 328);
            this.gbOpcoes.TabIndex = 9;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // lblMaxCaracter
            // 
            this.lblMaxCaracter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxCaracter.AutoSize = true;
            this.lblMaxCaracter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblMaxCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCaracter.ForeColor = System.Drawing.Color.Red;
            this.lblMaxCaracter.Location = new System.Drawing.Point(917, 218);
            this.lblMaxCaracter.Name = "lblMaxCaracter";
            this.lblMaxCaracter.Size = new System.Drawing.Size(154, 16);
            this.lblMaxCaracter.TabIndex = 10;
            this.lblMaxCaracter.Text = "Max. de 8 Caracteres";
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.lblMaxCaracter);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.pnlTelaInicialSup);
            this.Controls.Add(this.dgvListaRecorde);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaInicial";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).EndInit();
            this.pnlTelaInicialSup.ResumeLayout(false);
            this.pnlTelaInicialSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).EndInit();
            this.gbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRecorde;
        private System.Windows.Forms.Panel pnlTelaInicialSup;
        private System.Windows.Forms.PictureBox pbMario1;
        private System.Windows.Forms.PictureBox pbMario2;
        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Label lblMaxCaracter;
    }
}