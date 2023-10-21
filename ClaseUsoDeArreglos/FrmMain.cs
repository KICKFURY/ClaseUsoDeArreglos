using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseUsoDeArreglos
{
    public partial class FrmMain : Form
    {
        Estudiante estudiante;
        Asignatura asignatura;

        int n, k = 0, m = 7, acum, exam, apro, repro = 0;
        double auxnota;
        string auxNombreA, nombreEstudiante, nombreAsignatura, carrera;
        double promedio, sumaNota = 0;

        public FrmMain()
        {
            InitializeComponent();
            Desactivar();
        }

        public void CapturarDatos()
        {
            nombreEstudiante = txtNombreEstudiante.Text;
            nombreAsignatura = cmbAsignaturas.Text;
            carrera = cmbCarrera.Text;
            acum = int.Parse(cmbAcumulado.Text);
            exam = int.Parse(cmbExamen.Text);
        }

        public void limpiar()
        {
            txtNombreEstudiante.Clear();
            cmbCarrera.Text = "";
            cmbAsignaturas.Text = "";
            cmbAcumulado.Text = "";
            cmbExamen.Text = "";
        }

        public void Desactivar()
        {
            txtNombreEstudiante.Enabled = false;
            cmbCarrera.Enabled = false;
            cmbAsignaturas.Enabled = false;
            cmbAcumulado.Enabled = false;
            cmbExamen.Enabled = false;
            btnAgregar.Enabled = false;
        }

        public void AgregarCarrera()
        {
            cmbCarrera.Items.Add("Ing. Sistemas");
            cmbCarrera.Items.Add("Ingenieria Agronomica");
            cmbCarrera.Items.Add("Ingenieria Civil");
        }

        public void AgregarAcumulado()
        {
            for (int i = 0; i <= 60; i++)
                cmbAcumulado.Items.Add(i);
        }

        public void AgregarExamen()
        {
            for (int i = 0; i <= 40; i++)
                cmbExamen.Items.Add(i);
        }

        public void Activar()
        {
            txtNombreEstudiante.Enabled = true;
            cmbCarrera.Enabled = true;
            cmbAsignaturas.Enabled = true;
            cmbAcumulado.Enabled = true;
            cmbCarrera.Enabled = true;
            cmbExamen.Enabled = true;
            btnAgregar.Enabled = true;
            btnOrdenAscendente.Visible = false;
            btnOrdenDescendente.Visible = false;
        }

        public void AgregarAsignatura()
        {
            cmbAsignaturas.Items.Add("Fundamentos de programacion");
            cmbAsignaturas.Items.Add("Fundamentos de Sistema de Informacion");
            cmbAsignaturas.Items.Add("Estructuras de datos I");
            cmbAsignaturas.Items.Add("Diseno Grafico");
            cmbAsignaturas.Items.Add("Calculo I");
            cmbAsignaturas.Items.Add("Suelo I");
            cmbAsignaturas.Items.Add("Termodinamica");
        }

        public void NuevaA()
        {
            cmbAsignaturas.Enabled = true;
            cmbAcumulado.Enabled = true;
            cmbExamen.Enabled = true;
            cmbAsignaturas.Text = "";
            cmbAcumulado.Text = "";
            cmbExamen.Text = "";
            btnAceptar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidadAsignaturas.Text == "")
            {
                error1.SetError(txtCantidadAsignaturas, "Debe ingresar la cantidad de asignaturas");
                txtCantidadAsignaturas.Focus();
                return;
            }
            else
                error1.SetError(txtCantidadAsignaturas, "");

            n = int.Parse(txtCantidadAsignaturas.Text);

            estudiante = new Estudiante(n);
            asignatura = new Asignatura(n);

            if (n <= 0)
            {
                MessageBox.Show("La cantidad debe ser un numero positivo");
                txtCantidadAsignaturas.Focus();
                return;
            }
            Activar();
            limpiar();
            AgregarCarrera();
            AgregarAsignatura();
            AgregarAcumulado();
            AgregarExamen();
        }

        private void btnNuevaAsignatura_Click(object sender, EventArgs e)
        {
            NuevaA();

            if (k == n)
            {
                MessageBox.Show("Ha excedido el limite de asignaturas");
                Desactivar();

                promedio = Estudiante.CalcularPromedio(sumaNota, n);

                txtPromedioEstudiante.Text = promedio.ToString();

                btnOrdenAscendente.Visible = true;
                btnOrdenDescendente.Visible = true;

                btnAgregar.Enabled = false;
            }
        }

        private void btnOrdenAscendente_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (asignatura.Nota[j] > asignatura.Nota[j+1])
                    {
                        string auxNombreA = asignatura.NombreA[j];
                        asignatura.NombreA[j] = asignatura.NombreA[j + 1];
                        asignatura.NombreA[j + 1] = auxNombreA;

                        double auxNota = asignatura.Nota[j];
                        asignatura.Nota[j] = asignatura.Nota[j + 1];
                        asignatura.Nota[j + 1] = auxNota;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                dataGridView1.Rows.Add(asignatura.NombreA[i], asignatura.Nota[i]);
        }

        private void btnOrdenDescendente_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (asignatura.Nota[j] < asignatura.Nota[j + 1])
                    {
                        string auxNombreA = asignatura.NombreA[j];
                        asignatura.NombreA[j] = asignatura.NombreA[j + 1];
                        asignatura.NombreA[j + 1] = auxNombreA;

                        double auxNota = asignatura.Nota[j];
                        asignatura.Nota[j] = asignatura.Nota[j + 1];
                        asignatura.Nota[j + 1] = auxNota;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                dataGridView1.Rows.Add(asignatura.NombreA[i], asignatura.Nota[i]);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string asigBuscar = txtAsignaturabusqueda.Text;
            int j = 0;

            while (j < asignatura.NombreA.Length && asignatura.NombreA[j] != asigBuscar)
            {
                j += 1;

                if (j >= asignatura.NombreA.Length)
                {
                    dataGridView1.Rows.Clear();
                    MessageBox.Show("La asignatura no se encuentra");
                    for (int i = 0; i < asignatura.NombreA.Length; i++)
                    {
                        dataGridView1.Rows.Add(asignatura.NombreA[i], asignatura.Nota[i]);
                    }
                    txtAsignaturabusqueda.Clear();
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(asignatura.NombreA[j], asignatura.Nota[j]);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreEstudiante.Text == "")
            {
                error1.SetError(txtNombreEstudiante, "Debe ingresar un nombre");
                txtNombreEstudiante.Focus();
                return;
            }
            else
            {
                error1.SetError(txtNombreEstudiante, "");
            }
            CapturarDatos();

            estudiante.AgregarDatos(nombreEstudiante, carrera, k);
            asignatura.CalcularNota(acum, exam);
            asignatura.AgregarDatos(nombreAsignatura, k);

            if (asignatura.Nota[k] < 60)
            {
                repro++;
            }
            else
            {
                apro++;
            }

            txtAsignaturasAprobadas.Text = apro.ToString();
            txtAsignaturasReprobadas.Text = repro.ToString();

            int j = cmbAsignaturas.SelectedIndex;

            for (int i = 0; i <= m; i++)
            {
                if (i == j)
                {
                    cmbAsignaturas.Items.RemoveAt(i);
                    m--;
                }
            }

            sumaNota += asignatura.Nota[k];
            MessageBox.Show("Los datos se han guardado correctamente");
            dataGridView1.Rows.Add(asignatura.NombreA[k], asignatura.Nota[k]);
            k++;

            Desactivar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
