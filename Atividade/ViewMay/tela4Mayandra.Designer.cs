
namespace Atividade.ViewMay
{
    partial class tela4Mayandra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela4Mayandra));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.tbxCarro = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(59, 164);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(59, 192);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(59, 127);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(229, 23);
            this.dateTime.TabIndex = 2;
            // 
            // cbxCor
            // 
            this.cbxCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbxCor.ForeColor = System.Drawing.Color.White;
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Location = new System.Drawing.Point(130, 250);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(114, 23);
            this.cbxCor.TabIndex = 3;
            // 
            // tbxNome
            // 
            this.tbxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxNome.ForeColor = System.Drawing.Color.White;
            this.tbxNome.Location = new System.Drawing.Point(130, 164);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 23);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxPlaca.ForeColor = System.Drawing.Color.White;
            this.tbxPlaca.Location = new System.Drawing.Point(130, 192);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(100, 23);
            this.tbxPlaca.TabIndex = 4;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCarro.ForeColor = System.Drawing.Color.White;
            this.lblCarro.Location = new System.Drawing.Point(59, 221);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(36, 15);
            this.lblCarro.TabIndex = 5;
            this.lblCarro.Text = "Carro";
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitutlo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitutlo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitutlo.Location = new System.Drawing.Point(130, 78);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(77, 32);
            this.lblTitutlo.TabIndex = 6;
            this.lblTitutlo.Text = "Ticket";
            // 
            // tbxCarro
            // 
            this.tbxCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxCarro.ForeColor = System.Drawing.Color.White;
            this.tbxCarro.Location = new System.Drawing.Point(130, 221);
            this.tbxCarro.Name = "tbxCarro";
            this.tbxCarro.Size = new System.Drawing.Size(100, 23);
            this.tbxCarro.TabIndex = 4;
            this.tbxCarro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCor.ForeColor = System.Drawing.Color.White;
            this.lblCor.Location = new System.Drawing.Point(59, 250);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 15);
            this.lblCor.TabIndex = 5;
            this.lblCor.Text = "Cor";
            // 
            // lblResultado
            // 
            this.lblResultado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(59, 328);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(171, 78);
            this.lblResultado.TabIndex = 7;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Lime;
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(59, 289);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 8;
            this.btnValidar.Text = "button1";
            this.btnValidar.UseVisualStyleBackColor = false;
            // 
            // tela4Mayandra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitutlo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.tbxCarro);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela4Mayandra";
            this.Text = "tela4Mayandra";
            this.Load += new System.EventHandler(this.tela4Mayandra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.TextBox tbxCarro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnValidar;
    }
}