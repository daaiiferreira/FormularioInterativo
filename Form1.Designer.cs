namespace FormularioInterativo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Criar = new Button();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            txtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // Criar
            // 
            Criar.BackColor = Color.Cyan;
            Criar.Location = new Point(626, 363);
            Criar.Name = "Criar";
            Criar.Size = new Size(136, 65);
            Criar.TabIndex = 0;
            Criar.Text = "Criar";
            Criar.UseVisualStyleBackColor = false;
            Criar.Click += Criar_click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(32, 68);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(134, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Digite o seu nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(32, 152);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(151, 20);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Digite o seu telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(139, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Digite o seu e-mail:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(32, 108);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(133, 20);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Digite a sua idade:";
            // 
            // txtNome
            // 
            txtNome.ForeColor = Color.FromArgb(0, 64, 64);
            txtNome.Location = new Point(176, 65);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome a ser impresso no cartão";
            txtNome.Size = new Size(586, 27);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.ForeColor = Color.FromArgb(0, 64, 64);
            txtIdade.Location = new Point(176, 102);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Utilizar apenas números";
            txtIdade.Size = new Size(586, 27);
            txtIdade.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(0, 64, 64);
            txtEmail.Location = new Point(176, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "exemplo@email.com";
            txtEmail.Size = new Size(586, 26);
            txtEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(95, 8);
            label1.Name = "label1";
            label1.Size = new Size(608, 54);
            label1.TabIndex = 9;
            label1.Text = "Cartão de visitas - Maker";
            // 
            // txtTelefone
            // 
            txtTelefone.ForeColor = Color.FromArgb(0, 64, 64);
            txtTelefone.Location = new Point(189, 145);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(573, 27);
            txtTelefone.TabIndex = 10;
            txtTelefone.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefone);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(Criar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Criar;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblIdade;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEmail;
        private Label label1;
        private MaskedTextBox txtTelefone;
    }
}
