namespace Library
{
    partial class LoginEstudante
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.llblCadastrar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área do Estudante";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(128, 168);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caso não seja cadastrado,";
            // 
            // llblCadastrar
            // 
            this.llblCadastrar.AutoSize = true;
            this.llblCadastrar.Location = new System.Drawing.Point(204, 212);
            this.llblCadastrar.Name = "llblCadastrar";
            this.llblCadastrar.Size = new System.Drawing.Size(65, 13);
            this.llblCadastrar.TabIndex = 5;
            this.llblCadastrar.TabStop = true;
            this.llblCadastrar.Text = "cadastre-se.";
            this.llblCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCadastrar_LinkClicked);
            // 
            // LoginEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 266);
            this.Controls.Add(this.llblCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginEstudante";
            this.Text = "LoginEstudante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblCadastrar;
    }
}