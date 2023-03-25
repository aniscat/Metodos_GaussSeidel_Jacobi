using MN_U3ProyectoIndividual.Clases;
using System;
using System.Windows.Forms;

namespace MN_U3ProyectoIndividual
{
    public partial class FormMétodos : Form
    {
        double[,] A;
        double[] x, b;
        int iteraciones;
        MetodosIterativos metodos;

        public FormMétodos()
        {
            InitializeComponent();
            metodos = new MetodosIterativos();
        }

        private void BtnGaussSeidel_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
            DataGridGaussSeidel.Rows.Clear();
            metodos.GaussSeidel(this.A, this.b, this.x, this.iteraciones, DataGridGaussSeidel);
        }

        private void BtnJacobi_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
            DataGridJacobi.Rows.Clear();
            metodos.Jacobi(this.A, this.b, this.x, this.iteraciones, DataGridJacobi);
        }


        private void ObtenerDatos()
        {
            this.A = new double[3, 3] { { Convert.ToDouble(TxtBxX1.Text), Convert.ToDouble(TxtBxY1.Text), Convert.ToDouble(TxtBxZ1.Text) }, { Convert.ToDouble(TxtBxX2.Text), Convert.ToDouble(TxtBxY2.Text), Convert.ToDouble(TxtBxZ2.Text) }, { Convert.ToDouble(TxtBxX3.Text), Convert.ToDouble(TxtBxY3.Text), Convert.ToDouble(TxtBxZ3.Text) } };
            this.b = new double[3] { Convert.ToDouble(TxtBxB1.Text), Convert.ToDouble(TxtBxB2.Text), Convert.ToDouble(TxtBxB3.Text) };
            this.x = new double[3] { Convert.ToDouble(TxtBxX0.Text), Convert.ToDouble(TxtBxY0.Text), Convert.ToDouble(TxtBxZ0.Text) }; ;
            this.iteraciones = Convert.ToInt32(TxtBxIteraciones.Text);

        } 
    }
}
