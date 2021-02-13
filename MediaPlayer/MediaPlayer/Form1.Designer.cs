namespace MediaPlayer
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ListaArquivos = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.voltar_button = new Guna.UI2.WinForms.Guna2ImageButton();
			this.prox_button = new Guna.UI2.WinForms.Guna2ImageButton();
			this.play_button = new Guna.UI2.WinForms.Guna2ImageButton();
			this.label2 = new System.Windows.Forms.Label();
			this.pasta_button = new Guna.UI2.WinForms.Guna2ImageButton();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ListaArquivos
			// 
			this.ListaArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ListaArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
			this.ListaArquivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListaArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListaArquivos.ForeColor = System.Drawing.SystemColors.Control;
			this.ListaArquivos.Location = new System.Drawing.Point(765, 54);
			this.ListaArquivos.Name = "ListaArquivos";
			this.ListaArquivos.Size = new System.Drawing.Size(291, 475);
			this.ListaArquivos.TabIndex = 2;
			this.ListaArquivos.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(12, 510);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 22);
			this.label1.TabIndex = 5;
			this.label1.Text = "Música Atual";
			this.label1.Visible = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(144)))));
			this.panel3.Controls.Add(this.pasta_button);
			this.panel3.Controls.Add(this.guna2PictureBox1);
			this.panel3.Controls.Add(this.voltar_button);
			this.panel3.Controls.Add(this.prox_button);
			this.panel3.Controls.Add(this.play_button);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.ListaArquivos);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1084, 541);
			this.panel3.TabIndex = 8;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.Location = new System.Drawing.Point(319, 12);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(429, 435);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 10;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// voltar_button
			// 
			this.voltar_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.voltar_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.voltar_button.CheckedState.Parent = this.voltar_button;
			this.voltar_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.voltar_button.HoverState.Parent = this.voltar_button;
			this.voltar_button.Image = ((System.Drawing.Image)(resources.GetObject("voltar_button.Image")));
			this.voltar_button.ImageRotate = 0F;
			this.voltar_button.Location = new System.Drawing.Point(346, 444);
			this.voltar_button.Name = "voltar_button";
			this.voltar_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.voltar_button.PressedState.Parent = this.voltar_button;
			this.voltar_button.Size = new System.Drawing.Size(72, 75);
			this.voltar_button.TabIndex = 9;
			this.voltar_button.Click += new System.EventHandler(this.Voltar_button_Click_1);
			// 
			// prox_button
			// 
			this.prox_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.prox_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.prox_button.CheckedState.Parent = this.prox_button;
			this.prox_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.prox_button.HoverState.Parent = this.prox_button;
			this.prox_button.Image = ((System.Drawing.Image)(resources.GetObject("prox_button.Image")));
			this.prox_button.ImageRotate = 0F;
			this.prox_button.Location = new System.Drawing.Point(638, 444);
			this.prox_button.Name = "prox_button";
			this.prox_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.prox_button.PressedState.Parent = this.prox_button;
			this.prox_button.Size = new System.Drawing.Size(72, 75);
			this.prox_button.TabIndex = 8;
			this.prox_button.Click += new System.EventHandler(this.Prox_button_Click_1);
			// 
			// play_button
			// 
			this.play_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.play_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.play_button.CheckedState.Parent = this.play_button;
			this.play_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.play_button.HoverState.Parent = this.play_button;
			this.play_button.Image = ((System.Drawing.Image)(resources.GetObject("play_button.Image")));
			this.play_button.ImageRotate = 0F;
			this.play_button.Location = new System.Drawing.Point(487, 444);
			this.play_button.Name = "play_button";
			this.play_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.play_button.PressedState.Parent = this.play_button;
			this.play_button.Size = new System.Drawing.Size(88, 75);
			this.play_button.TabIndex = 7;
			this.play_button.Click += new System.EventHandler(this.Play_button_Click_1);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(836, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "Músicas encontradas";
			this.label2.Visible = false;
			// 
			// pasta_button
			// 
			this.pasta_button.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.pasta_button.CheckedState.Parent = this.pasta_button;
			this.pasta_button.HoverState.ImageSize = new System.Drawing.Size(64, 64);
			this.pasta_button.HoverState.Parent = this.pasta_button;
			this.pasta_button.Image = ((System.Drawing.Image)(resources.GetObject("pasta_button.Image")));
			this.pasta_button.ImageRotate = 0F;
			this.pasta_button.Location = new System.Drawing.Point(12, 3);
			this.pasta_button.Name = "pasta_button";
			this.pasta_button.PressedState.ImageSize = new System.Drawing.Size(64, 64);
			this.pasta_button.PressedState.Parent = this.pasta_button;
			this.pasta_button.Size = new System.Drawing.Size(89, 92);
			this.pasta_button.TabIndex = 11;
			this.pasta_button.Click += new System.EventHandler(this.pasta_button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(1084, 541);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Media Player";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox ListaArquivos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ImageButton play_button;
		private Guna.UI2.WinForms.Guna2ImageButton voltar_button;
		private Guna.UI2.WinForms.Guna2ImageButton prox_button;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2ImageButton pasta_button;
	}
}

