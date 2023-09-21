using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimiento
{
    public partial class Form1 : Form
    {
        int velocidad = 100;

        private ListaFiguras Figuras = new ListaFiguras();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btIniciar_Click(object sender, EventArgs e)
        {
            btIniciar.Visible = false;

            await Figuras.GenerarFiguras(Color.Red, this.Width, this.Height);
            await Task.Delay(100);


            for (int i = 0; i<10;i++)
            {
                Controls.Add(Figuras.lista[i].Figu);
            }

            this.Refresh();

            for (int i = 0; i < 500; i++)
            {
                Figuras.MoverFiguras(this.Width, this.Height);
                this.Refresh();
                await Task.Delay(velocidad);
            }
        }
    }
}
