namespace Library
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnEstudante = new System.Windows.Forms.Button();
            this.btnAdministracao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Library.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(209, 37);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(177, 177);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnEstudante);
            this.pnlMain.Controls.Add(this.btnAdministracao);
            this.pnlMain.Controls.Add(this.imgLogo);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(621, 365);
            this.pnlMain.TabIndex = 1;
            // 
            // btnEstudante
            // 
            this.btnEstudante.Location = new System.Drawing.Point(317, 245);
            this.btnEstudante.Name = "btnEstudante";
            this.btnEstudante.Size = new System.Drawing.Size(137, 33);
            this.btnEstudante.TabIndex = 2;
            this.btnEstudante.Text = "Àrea do Estudante";
            this.btnEstudante.UseVisualStyleBackColor = true;
            this.btnEstudante.Click += new System.EventHandler(this.btnEstudante_Click);
            // 
            // btnAdministracao
            // 
            this.btnAdministracao.Location = new System.Drawing.Point(154, 245);
            this.btnAdministracao.Name = "btnAdministracao";
            this.btnAdministracao.Size = new System.Drawing.Size(137, 33);
            this.btnAdministracao.TabIndex = 1;
            this.btnAdministracao.Text = "Àrea da Administração";
            this.btnAdministracao.UseVisualStyleBackColor = true;
            this.btnAdministracao.Click += new System.EventHandler(this.btnAdministracao_Click);
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 367);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowMain";
            this.Text = "School Library";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnEstudante;
        private System.Windows.Forms.Button btnAdministracao;
    }
}

