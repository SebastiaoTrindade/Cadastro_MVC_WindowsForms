namespace SistemaMVC
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelMovel = new System.Windows.Forms.Panel();
            this.btnConfiguracao = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduto = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelLateral.Controls.Add(this.panelMovel);
            this.panelLateral.Controls.Add(this.btnConfiguracao);
            this.panelLateral.Controls.Add(this.btnProduto);
            this.panelLateral.Controls.Add(this.btnUsuario);
            this.panelLateral.Controls.Add(this.btnDashboard);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.pictureBoxLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 749);
            this.panelLateral.TabIndex = 0;
            // 
            // panelMovel
            // 
            this.panelMovel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMovel.BackColor = System.Drawing.Color.White;
            this.panelMovel.Location = new System.Drawing.Point(3, 226);
            this.panelMovel.Name = "panelMovel";
            this.panelMovel.Size = new System.Drawing.Size(10, 61);
            this.panelMovel.TabIndex = 3;
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfiguracao.BorderColor = System.Drawing.Color.White;
            this.btnConfiguracao.CheckedState.Parent = this.btnConfiguracao;
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.CustomImages.Parent = this.btnConfiguracao;
            this.btnConfiguracao.FillColor = System.Drawing.Color.Transparent;
            this.btnConfiguracao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.HoverState.Parent = this.btnConfiguracao;
            this.btnConfiguracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracao.Image")));
            this.btnConfiguracao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfiguracao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfiguracao.Location = new System.Drawing.Point(12, 484);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.ShadowDecoration.Parent = this.btnConfiguracao;
            this.btnConfiguracao.Size = new System.Drawing.Size(185, 61);
            this.btnConfiguracao.TabIndex = 4;
            this.btnConfiguracao.Text = "FERRAMENTAS";
            this.btnConfiguracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduto.BorderColor = System.Drawing.Color.White;
            this.btnProduto.CheckedState.Parent = this.btnProduto;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.CustomImages.Parent = this.btnProduto;
            this.btnProduto.FillColor = System.Drawing.Color.Transparent;
            this.btnProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto.HoverState.Parent = this.btnProduto;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduto.ImageSize = new System.Drawing.Size(40, 40);
            this.btnProduto.Location = new System.Drawing.Point(12, 398);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.ShadowDecoration.Parent = this.btnProduto;
            this.btnProduto.Size = new System.Drawing.Size(185, 61);
            this.btnProduto.TabIndex = 3;
            this.btnProduto.Text = "PRODUTO";
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuario.BorderColor = System.Drawing.Color.White;
            this.btnUsuario.CheckedState.Parent = this.btnUsuario;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.CustomImages.Parent = this.btnUsuario;
            this.btnUsuario.FillColor = System.Drawing.Color.Transparent;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.HoverState.Parent = this.btnUsuario;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuario.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsuario.Location = new System.Drawing.Point(12, 311);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.ShadowDecoration.Parent = this.btnUsuario;
            this.btnUsuario.Size = new System.Drawing.Size(185, 61);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "USUÁRIO";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(12, 224);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(185, 61);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA C#\r\nMVC\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(62, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 63);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSair);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 48);
            this.panelTop.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderColor = System.Drawing.Color.Transparent;
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.FillColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnSair.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageSize = new System.Drawing.Size(60, 60);
            this.btnSair.Location = new System.Drawing.Point(943, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(54, 45);
            this.btnSair.TabIndex = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.labelTime2);
            this.panelInfo.Controls.Add(this.labelTime);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(200, 48);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1000, 96);
            this.panelInfo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(816, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(816, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // labelTime2
            // 
            this.labelTime2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime2.ForeColor = System.Drawing.Color.White;
            this.labelTime2.Location = new System.Drawing.Point(872, 54);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(71, 19);
            this.labelTime2.TabIndex = 1;
            this.labelTime2.Text = "00:00:00";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(872, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(200, 144);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1000, 605);
            this.panelConteudo.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnConfiguracao;
        private Guna.UI2.WinForms.Guna2Button btnProduto;
        private Guna.UI2.WinForms.Guna2Button btnUsuario;
        private System.Windows.Forms.Panel panelMovel;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSair;
    }
}