using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epoca
{
    public partial class Form1 : Form
    {
        Button btn1929 = new Button();
        Button btn1934 = new Button();
        Button btn1937 = new Button();
        Button btn1945 = new Button();
        Button btnCurioso = new Button();

        Label lblTitulo = new Label();
        Label lblConteudo = new Label();

        PictureBox imgDemonstrativo = new PictureBox();

        public Form1() 
        {
            InitializeComponent();
            construtor();
        }

        public void construtor()
        {
            // RadioButtons.Text
            btn1929.Text = "1929";
            btn1934.Text = "1934";
            btn1937.Text = "1937";
            btn1945.Text = "1945";
            btnCurioso.Text = "Extras";

            // Labels.Text
            lblTitulo.Text = "Selecione umas das épocas";
            lblConteudo.Text = "Veja o que aconteceu nesses anos específicos";

            // Eventos
            btn1929.Click += Clickado;
            btn1934.Click += Clickado;
            btn1937.Click += Clickado;
            btn1945.Click += Clickado;
            btnCurioso.Click += Clickado;

            // Tamanho dos elementos
            this.Size = new Size(860, 400);

            btn1929.Size = new Size(100, 30);
            btn1934.Size = new Size(100, 30);
            btn1937.Size = new Size(100, 30);
            btn1945.Size = new Size(100, 30);
            btnCurioso.Size = new Size(100, 30);
            lblTitulo.AutoSize = true;
            lblConteudo.AutoSize = true;

            // Localização dos elementos
            btn1929.Location = new Point(100, 50);
            btn1934.Location = new Point(240, 50);
            btn1937.Location = new Point(380, 50);
            btn1945.Location = new Point(520, 50);
            btnCurioso.Location = new Point(660, 50);
            lblTitulo.Location = new Point(100, 100);
            lblConteudo.Location = new Point(100, 130);

            // Adicionar os elementos ao formulário
            this.Controls.Add(btn1929);
            this.Controls.Add(btn1934);
            this.Controls.Add(btn1937);
            this.Controls.Add(btn1945);
            this.Controls.Add(btnCurioso);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblConteudo);
        }

        private void Clickado(object sender, EventArgs e) //Sim, clickado.
        {
            
        } 
    }
}
