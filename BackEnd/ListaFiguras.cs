using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ListaFiguras
    {
        public Figura[] lista { get; set; } = new Figura[10];

        public async Task GenerarFiguras(Color aColor,
                                int aAnchoVentana,
                                int aAltoVentana) 
        {
            for (int i = 0; i < 10; i++)
            {
                Figura F = new Figura();
                F.Inicializar(aColor, aAnchoVentana, aAltoVentana);
                lista[i] = F;
                await Task.Delay(100);
            }
        }

        public void MoverFiguras(int aAnchoVentana,
                                int aAltoVentana)
        {
            for (int i = 0; i < 10; i++)
            {
                lista[i].Mover(aAnchoVentana, aAltoVentana);
            }
        }
    }
}
