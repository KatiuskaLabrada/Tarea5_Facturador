using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_Facturador
{
    public partial class Facturacion : Form
    {
        double valCant, itbis, valDesc, totalValDesc, valPrecio, totalPrecio, valSubTotal = 0, valITBIS = 0, totalDesc = 0, totalCant = 0, valTotal = 0;
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int data = dataGridViewFacturador.Rows.Add();
            
            valPrecio = Convert.ToDouble(precio.Text);
            valDesc = Convert.ToDouble(descuento.Text);
            valCant = Convert.ToDouble(cantidad.Text);

            itbis = valPrecio * 0.18;
            totalPrecio = valPrecio * valCant;
            totalValDesc = valDesc * valCant;

            dataGridViewFacturador.Rows[data].Cells[0].Value = cantidad.Text;
            dataGridViewFacturador.Rows[data].Cells[1].Value = codigoProducto.Text;
            dataGridViewFacturador.Rows[data].Cells[2].Value = nombreProducto.Text;
            dataGridViewFacturador.Rows[data].Cells[3].Value = descripcion.Text;
            dataGridViewFacturador.Rows[data].Cells[4].Value = descuento.Text;
            dataGridViewFacturador.Rows[data].Cells[5].Value = precio.Text;
            dataGridViewFacturador.Rows[data].Cells[6].Value = itbis;

            cantidad.Text = "";
            codigoProducto.Text = "";
            nombreProducto.Text = "";
            descripcion.Text = "";
            descuento.Text = "";
            precio.Text = "";

            valSubTotal = valSubTotal + totalPrecio;
            valITBIS = valSubTotal * 0.18;
            
            totalDesc = totalDesc + totalValDesc;
            totalCant = totalCant + valCant;

            valTotal = valSubTotal + valITBIS - totalDesc;

            subTotal.Text = valSubTotal.ToString();
            totalITBIS.Text = valITBIS.ToString();
            Descuentos.Text = totalDesc.ToString();
            totalCantidadProductos.Text = totalCant.ToString();
            total.Text = string.Format("{0:C2}", valTotal);
            labelTotal.Text = string.Format("{0:C2}", valTotal);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cantidad.Clear();
            codigoProducto.Clear();
            nombreProducto.Clear();
            descripcion.Clear();
            descuento.Clear();
            precio.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
