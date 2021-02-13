using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

namespace MediaPlayer
{
	public partial class Form1 : Form
	{
		Timer tmr = new Timer();
		WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
		public string[] Arquivos;
		public int Indice_Som = 0;
		public bool tocando = false, pauseOn = false;
		public double tempo;

		public Form1()
		{
			InitializeComponent();
			Player.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Wplayer_PlayStateChange);
			tmr.Interval = 2;
			tmr.Stop();
			tmr.Tick += new EventHandler(tmr_Tick);
		}

		void tmr_Tick(object sender, EventArgs e)
		{
			tmr.Stop();
			IniciaMusica();
		}

		void Wplayer_PlayStateChange(int NewState)
		{
			if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
			{
				if (Indice_Som < Arquivos.Length - 1)
				{
					Indice_Som++;
				}
				else
				{
					Indice_Som = 0;
				}
				tmr.Start();
			}
		}
		public void DefineNomeMusica()
		{
			string[] nome = Arquivos[Indice_Som].Split('\\');
			label1.Text = nome[nome.Length - 1];
		}

		public void IniciaMusica()
		{
			if (pauseOn == true)
			{
				Player.controls.currentPosition = tempo;
				pauseOn = false;
	
			}
			else
			{
				Player.URL = Arquivos[Indice_Som];
				DefineNomeMusica();
			}

			Player.controls.play();
			play_button.Image = Image.FromFile(@"Imagens\pause.png");
			label1.Visible = true;
			tocando = true;

		}

		private void Play_button_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (tocando == false)
				{
					IniciaMusica();
				}
				else
				{
					tocando = false;
					pauseOn = true;
					tempo = Player.controls.currentPosition;
					Player.controls.pause();
					play_button.Image = Image.FromFile(@"Imagens\play.png");
				}
			}
			catch
			{
				var form = new Form2();
				form.Show();
			}

		}

		private void Prox_button_Click_1(object sender, EventArgs e)
		{
			pauseOn = false;
			try
			{
				if (Indice_Som < Arquivos.Length - 1)
					Indice_Som++;
				else
					Indice_Som = 0;

				IniciaMusica();
			}
			catch 
			{
				var form = new Form2();
				form.Show();
			}
		}

		private void pasta_button_Click(object sender, EventArgs e)
		{
			string[] nome;
			ListaArquivos.Text = "";

			try
			{
				using (var fbd = new FolderBrowserDialog())
				{
					DialogResult result = fbd.ShowDialog();

					if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
					{
						Arquivos = Directory.GetFiles(fbd.SelectedPath, "*.mp3");
					}
					else
					{
						return;
					}
				}

				label2.Visible = true;

				for (int i = 0; i < Arquivos.Length; i++)
				{
					nome = Arquivos[i].Split('\\');
					ListaArquivos.Text = ListaArquivos.Text + (i + 1) + " - " + nome[nome.Length - 1] + "\n";
				}
				if (Arquivos.Length == 0)
				{
					label2.Text = "Nenhuma música encontrada";
				}
				else
				{
					label2.Text = "Músicas encontradas";
				}
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Erro ao ler arquivo");
			}

		}
	

		private void Voltar_button_Click_1(object sender, EventArgs e)
		{
			pauseOn = false;
			try
			{
				if (Indice_Som > 0)
				{
					Indice_Som--;
				}
				else
				{
					Indice_Som = Arquivos.Length - 1;
				}

				IniciaMusica();
			}
			catch
			{
				var form = new Form2();
				form.Show();
			}
		}
	}
}
