using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_progra_miercoles
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][]{

           new String[]{"1", "2", "3", "4", "5", "6", "7", "8", "9","10","11","12","13","14","15" },//Num
            new String[]{"500", "1000", "2000", "3000", "6000", "18000", "30000", "60000", "100000", "20000", "300000", "400000", "500000", "1000000", "999999999" },//Masa
            new String[]{ "0.01", "500.01", "1000.01", "2000.01", "3000.01", "8000.01", "18000.01", "30000.01", "60000.01", "100000.01","200000.01","300000.01","400000.01","500000.01","1000000.01" }, //Desde 
        };//Matriz Dentada
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int desde, hasta;
            double monto, respuesta, precio, adicional;

            desde = cboDesde.SelectedIndex;
            hasta = cboHasta.SelectedIndex;
            monto = double.Parse(txtMonto.Text);

            //Invversiones


            double[][] Inversion = {
                new double[]{ 0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01,400000.01,500000.01,1000000.01 }, //Desde
                new double[]{ 500, 1000, 2000, 3000, 6000, 18000, 30000, 60000, 100000, 20000, 300000, 400000,500000,1000000,999999999 }, //Hasta
                new double[]{ 1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195,255,300,340,490}, //Precio
                new double[]{ 0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6,0.45,0.4,0.30,0.18} //Adicional

        };// Array Unidimensional
            respuesta = monto- Inversion[cbNum.SelectedIndex][desde] / Inversion[cbNum.SelectedIndex][hasta] /adicional* precio;
            lblRespuesta.Text = "Respuesta: " + Math.Round(respuesta, 3);



        }

        private void cbNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNum_TextChanged(object sender, EventArgs e)
        {
            cboDesde.Items.Clear();
            cboDesde.Items.AddRange(TiposConversores[cbNum.SelectedIndex]);

            cboHasta.Items.Clear();
            cboHasta.Items.AddRange(TiposConversores[cbNum.SelectedIndex]);
        }
    }
}
