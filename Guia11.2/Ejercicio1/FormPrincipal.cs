using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class FormPrincipal : Form
    {
        #region dominio del problema
        int[] Numeros = new int[100];
        int Contador = 0;

        double CalcularPromedio()
        {
            double acum = 0, promedio = 0;
            for (int n = 0; n < Contador; n++)
            {
                acum += Numeros[n];
            }
            promedio += acum / Contador;
            return promedio;
        }

        int BusquedaSecuencial(int numeroBuscar)
        {
            int idx = -1;
            int n = 0;
            while (n < Contador && idx == -1)
            {
                if (Numeros[n] == numeroBuscar)
                { 
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        int BusquedaBinaria(int numeroBuscar)
        {
            int idx = -1;
            int inf = 0;
            int sup = Contador;
            
            while (inf<=sup && idx==-1)
            {
                int c = (sup + inf) / 2;

                if (Numeros[c] == numeroBuscar)
                {
                    idx = c;
                }
                else if (numeroBuscar<Numeros[c])
                {
                    sup = c-1;
                }
                else
                {
                    inf = c+1;
                }
            }
            return idx;
        }

        void Ordenar()
        {
            for (int n = 0; n < Contador - 1; n++)//actual
            {
                for (int m = n+1; m < Contador ; m++)//siguientes
                {
                    if (Numeros[n] > Numeros[m])
                    { 
                        int aux=Numeros[n];
                        Numeros[n] = Numeros[m];
                        Numeros[m] = aux;
                    }
                }
            }
        }
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            FormIngresarNumero fIngresar = new FormIngresarNumero();

            if (fIngresar.ShowDialog() == DialogResult.OK)
            {
                Numeros[Contador++] = Convert.ToInt32(fIngresar.tbNumero.Text);
                fIngresar.tbNumero.Clear();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FormVerResultado fVerResultado = new FormVerResultado();

            fVerResultado.lbxResultado.Items.Clear();

            double promedio = CalcularPromedio();
            fVerResultado.lbxResultado.Items.Add($"{promedio:f2}");

            fVerResultado.ShowDialog();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int numeroBuscar= Convert.ToInt32(tbBusqueda.Text);
            int idx = -1;

            if (rbSecuencial.Checked == true)
            {
                idx = BusquedaSecuencial(numeroBuscar);
            }
            else if (rbBinaria.Checked == true)
            {
                Ordenar();
                idx = BusquedaBinaria(numeroBuscar);
            }
            
            string resultado = "Registro no encontrado";
            if (idx > -1)
            {
                resultado = $"Registro encontrado en posición {idx}";
            }
            MessageBox.Show(resultado,"Resultado de Búsqueda"); 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Ordenar();

            FormVerResultado fVerResultado = new FormVerResultado();

            #region preinicializo la modal
            fVerResultado.lbxResultado.Items.Clear();
            for (int n = 0; n < Contador; n++)
            {
                fVerResultado.lbxResultado.Items.Add($"{Numeros[n]:000}");
            }
            #endregion

            fVerResultado.ShowDialog();
        }
    }
}
