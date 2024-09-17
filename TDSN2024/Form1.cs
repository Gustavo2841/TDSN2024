using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDSN2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Circunferência":
                    ExibirRaio(true);
                    ExibirLado(false);
                    ExibirAltura(true);
                    ExibirBase(false);
                    ExibirTriangulo(false);
                    
                    break;
                case "Quadrado":
                    ExibirRaio(false);
                    ExibirLado(true);
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirTriangulo(false);

                    break;
                case "Triângulo":
                    ExibirRaio(false);
                    ExibirLado(true);
                    ExibirAltura(true);
                    ExibirBase(true);
                    ExibirTriangulo(true);
                    break;
                case "Retangulo":
                    ExibirRaio(false);
                    ExibirLado(true); 
                    ExibirAltura(true);
                    ExibirAltura(false);
                    ExibirBase(true);
                    ExibirTriangulo(false);

                    break;
                default:
                    break;
            }
        }

        private void ExibirTriangulo(bool visivel)
        {
            cmbTriangulo.Visible = lblTriangulo.Visible = visivel;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void ExibirLado(bool visivel)
        {
            lblLado.Visible = txtLado.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    FormaGeometrica objeto;
                    objeto = new Quadrado() { Lado = Convert.ToDouble(txtLado.Text) };
                    cmbObjetos.Items.Add(objeto);
                    txtLado.Clear();
                    break;
                default:
                    break;
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica objeto = cmbObjetos.SelectedItem as FormaGeometrica;

            txtArea.Text = objeto.CalcularArea().ToString();
            txtPerimetro.Text = objeto.CalcularPerimetro().ToString();
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
