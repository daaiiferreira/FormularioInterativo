namespace FormularioInterativo
{
    partial class FrmResultado
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
            lblNome1 = new Label();
            lblIdade1 = new Label();
            lblTelefone1 = new Label();
            lblEmail1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome1
            // 
            lblNome1.AutoSize = true;
            lblNome1.Font = new Font("Mistral", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome1.ForeColor = Color.Teal;
            lblNome1.Location = new Point(140, 20);
            lblNome1.Name = "lblNome1";
            lblNome1.Size = new Size(224, 48);
            lblNome1.TabIndex = 1;
            lblNome1.Text = "Joana da Silva";
            // 
            // lblIdade1
            // 
            lblIdade1.AutoSize = true;
            lblIdade1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdade1.ForeColor = Color.Teal;
            lblIdade1.Location = new Point(28, 86);
            lblIdade1.Name = "lblIdade1";
            lblIdade1.Size = new Size(135, 20);
            lblIdade1.TabIndex = 2;
            lblIdade1.Text = "IDADE: 26 anos";
            // 
            // lblTelefone1
            // 
            lblTelefone1.AutoSize = true;
            lblTelefone1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone1.ForeColor = Color.Teal;
            lblTelefone1.Location = new Point(28, 128);
            lblTelefone1.Name = "lblTelefone1";
            lblTelefone1.Size = new Size(179, 20);
            lblTelefone1.TabIndex = 3;
            lblTelefone1.Text = "TEL: (18) 98137-5555";
            // 
            // lblEmail1
            // 
            lblEmail1.AutoSize = true;
            lblEmail1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail1.ForeColor = Color.Teal;
            lblEmail1.Location = new Point(28, 167);
            lblEmail1.Name = "lblEmail1";
            lblEmail1.Size = new Size(234, 20);
            lblEmail1.TabIndex = 4;
            lblEmail1.Text = "E-MAIL: joana@maker.com";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox1.Location = new Point(303, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 126);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(493, 224);
            Controls.Add(pictureBox1);
            Controls.Add(lblEmail1);
            Controls.Add(lblTelefone1);
            Controls.Add(lblIdade1);
            Controls.Add(lblNome1);
            Name = "FrmResultado";
            Text = "FrmResultado";
            Load += FrmResultado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblNome1;
        private Label lblIdade1;
        private Label lblTelefone1;
        private Label lblEmail1;
        private PictureBox pictureBox1;
    }
}