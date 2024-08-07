using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Marca = "";
        public int Modelo = 0;
        public double ValorFabrica;
        public class Moto
        {
            public string Marca { get; set; }
            public int Modelo { get; set; }
            public double ValorFabrica { get; set; }


            public Moto(string marca, int modelo, double valor)
            {
                Marca = marca;
                Modelo = modelo;
                ValorFabrica = valor;


            }



            public double CalcularDepreciacionLineal(int vidaUtil, int añoAcalcular)
            {
                return ValorFabrica - (ValorFabrica * (añoAcalcular - Modelo) / vidaUtil);
            }
            public double CalcularDepreciacionAnual(int añoAcalcular, double tasaDepreciacion)
            {
                return ValorFabrica * (Math.Pow(1 - 0.1, añoAcalcular - Modelo));
            }

            public string ver()
            {
                return $"Marca{Marca},Modelo: ${Modelo},  Valor Fabricación:${ValorFabrica,10:f2}";
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(upAño.Value);
            int añoAcalcular = Convert.ToInt32(upAñoCalcular.Value);
            double valor = Convert.ToInt32(tbValorFabric.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);
            double tasaDpreciacion = Convert.ToDouble(tbTasa.Text);

            Moto motito = new Moto(marca, modelo, valor);

            Form2 ver = new Form2();
            ver.lbxresultados.Items.Add(motito.ver());


            double lineal = motito.CalcularDepreciacionLineal(añoAcalcular, vidaUtil);
            double anual = motito.CalcularDepreciacionAnual(añoAcalcular, tasaDpreciacion);

            ver.lbxresultados.Items.Add($"Depreciacion lineal: ${lineal}");
            ver.lbxresultados.Items.Add($"Depreciacion anual:${anual}");
            ver.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
