namespace SistemaMVC.Controls
{
    partial class UC_Ferramenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ferramenta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.lblTitulo.Location = new System.Drawing.Point(376, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 25);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "FERRAMENTAS E UTILITÁRIOS";
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.BackgroundImage")));
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.FlatAppearance.BorderSize = 0;
            this.btnCalculadora.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Location = new System.Drawing.Point(77, 202);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(240, 206);
            this.btnCalculadora.TabIndex = 19;
            this.btnCalculadora.UseVisualStyleBackColor = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnWord
            // 
            this.btnWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWord.BackgroundImage")));
            this.btnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.FlatAppearance.BorderSize = 0;
            this.btnWord.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Location = new System.Drawing.Point(366, 202);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(240, 206);
            this.btnWord.TabIndex = 20;
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(668, 202);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(240, 206);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // UC_Ferramenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UC_Ferramenta";
            this.Size = new System.Drawing.Size(1000, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}
