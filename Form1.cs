using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicSpace;

namespace T2_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Medicamento> lista = new List<Medicamento>();

        public void guardarMedicamento()
        {
            Medicamento medicamento = new Medicamento(txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), double.Parse(txtPrecioUnitario.Text), int.Parse(txtCantidad.Text)* double.Parse(txtPrecioUnitario.Text));
            lista.Add(medicamento);
            //OrdenarMedicamentos();
            gridMedicamentos.DataSource = null;
            gridMedicamentos.DataSource = lista;
            Limpiar();
        }

        public void eliminar (string codigo)
        {
            foreach (var medicamento in lista)
            {
                if(codigo == medicamento.Codigo)
                {
                    lista.Remove(medicamento);
                    break;
                }
            }
        }

        public void OrdenarMedicamentos()
        {
            int aux;
            for (int i = 0; i < lista.Count; i++)
            { 
               
            }
        }

        public void buscar (string codigo)
        {
            bool encontrado = false;

            foreach (var medicamento in lista)
            {
                if (codigo == medicamento.Codigo)
                {
                    encontrado = true;
                    break;
                }
            }

            if(encontrado == true)
            {
                MessageBox.Show("Existe el medicamento con codigo: " + codigo);                
            }
            else
            {
                MessageBox.Show("No existe el medicamento con codigo: " + codigo);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardarMedicamento();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar(txtCodigoEliminar.Text);
            gridMedicamentos.DataSource = null;
            gridMedicamentos.DataSource = lista;
            Limpiar();

        }
        void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
            txtCodigoEliminar.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar(txtCodigoEliminar.Text);
        }
    }
}
