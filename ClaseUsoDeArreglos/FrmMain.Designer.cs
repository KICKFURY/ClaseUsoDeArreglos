namespace ClaseUsoDeArreglos
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantidadAsignaturas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbExamen = new System.Windows.Forms.ComboBox();
            this.cmbAcumulado = new System.Windows.Forms.ComboBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsignaturasReprobadas = new System.Windows.Forms.TextBox();
            this.txtAsignaturasAprobadas = new System.Windows.Forms.TextBox();
            this.txtPromedioEstudiante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrdenDescendente = new System.Windows.Forms.Button();
            this.btnNuevaAsignatura = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtAsignaturabusqueda = new System.Windows.Forms.TextBox();
            this.btnOrdenAscendente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asignaturaHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtCantidadAsignaturas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(253, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantidadAsignaturas
            // 
            this.txtCantidadAsignaturas.Location = new System.Drawing.Point(176, 16);
            this.txtCantidadAsignaturas.Name = "txtCantidadAsignaturas";
            this.txtCantidadAsignaturas.Size = new System.Drawing.Size(48, 20);
            this.txtCantidadAsignaturas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Asignaturas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cmbExamen);
            this.groupBox2.Controls.Add(this.cmbAcumulado);
            this.groupBox2.Controls.Add(this.cmbCarrera);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbAsignaturas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreEstudiante);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Estudiantes";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(488, 127);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.Location = new System.Drawing.Point(384, 127);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbExamen
            // 
            this.cmbExamen.Enabled = false;
            this.cmbExamen.FormattingEnabled = true;
            this.cmbExamen.Location = new System.Drawing.Point(555, 70);
            this.cmbExamen.Name = "cmbExamen";
            this.cmbExamen.Size = new System.Drawing.Size(109, 24);
            this.cmbExamen.TabIndex = 4;
            // 
            // cmbAcumulado
            // 
            this.cmbAcumulado.Enabled = false;
            this.cmbAcumulado.FormattingEnabled = true;
            this.cmbAcumulado.Location = new System.Drawing.Point(346, 70);
            this.cmbAcumulado.Name = "cmbAcumulado";
            this.cmbAcumulado.Size = new System.Drawing.Size(113, 24);
            this.cmbAcumulado.TabIndex = 3;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.Enabled = false;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(499, 28);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(165, 24);
            this.cmbCarrera.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Examen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acumulado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carrera";
            // 
            // cmbAsignaturas
            // 
            this.cmbAsignaturas.Enabled = false;
            this.cmbAsignaturas.FormattingEnabled = true;
            this.cmbAsignaturas.Location = new System.Drawing.Point(103, 71);
            this.cmbAsignaturas.Name = "cmbAsignaturas";
            this.cmbAsignaturas.Size = new System.Drawing.Size(121, 24);
            this.cmbAsignaturas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignatura";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Location = new System.Drawing.Point(163, 28);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(235, 23);
            this.txtNombreEstudiante.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Estudiante";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtAsignaturasReprobadas);
            this.groupBox3.Controls.Add(this.txtAsignaturasAprobadas);
            this.groupBox3.Controls.Add(this.txtPromedioEstudiante);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(379, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 121);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Asignaturas Aprobadas";
            // 
            // txtAsignaturasReprobadas
            // 
            this.txtAsignaturasReprobadas.Enabled = false;
            this.txtAsignaturasReprobadas.Location = new System.Drawing.Point(231, 89);
            this.txtAsignaturasReprobadas.Name = "txtAsignaturasReprobadas";
            this.txtAsignaturasReprobadas.Size = new System.Drawing.Size(66, 23);
            this.txtAsignaturasReprobadas.TabIndex = 2;
            // 
            // txtAsignaturasAprobadas
            // 
            this.txtAsignaturasAprobadas.Enabled = false;
            this.txtAsignaturasAprobadas.Location = new System.Drawing.Point(231, 57);
            this.txtAsignaturasAprobadas.Name = "txtAsignaturasAprobadas";
            this.txtAsignaturasAprobadas.Size = new System.Drawing.Size(66, 23);
            this.txtAsignaturasAprobadas.TabIndex = 1;
            // 
            // txtPromedioEstudiante
            // 
            this.txtPromedioEstudiante.Enabled = false;
            this.txtPromedioEstudiante.Location = new System.Drawing.Point(231, 26);
            this.txtPromedioEstudiante.Name = "txtPromedioEstudiante";
            this.txtPromedioEstudiante.Size = new System.Drawing.Size(66, 23);
            this.txtPromedioEstudiante.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Asignaturas Reprobadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Promedio Estudiante";
            // 
            // btnOrdenDescendente
            // 
            this.btnOrdenDescendente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrdenDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenDescendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenDescendente.Location = new System.Drawing.Point(606, 392);
            this.btnOrdenDescendente.Name = "btnOrdenDescendente";
            this.btnOrdenDescendente.Size = new System.Drawing.Size(107, 46);
            this.btnOrdenDescendente.TabIndex = 9;
            this.btnOrdenDescendente.Text = "Ordenamiento Descendente";
            this.btnOrdenDescendente.UseVisualStyleBackColor = false;
            this.btnOrdenDescendente.Click += new System.EventHandler(this.btnOrdenDescendente_Click);
            // 
            // btnNuevaAsignatura
            // 
            this.btnNuevaAsignatura.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevaAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAsignatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevaAsignatura.Location = new System.Drawing.Point(379, 392);
            this.btnNuevaAsignatura.Name = "btnNuevaAsignatura";
            this.btnNuevaAsignatura.Size = new System.Drawing.Size(100, 46);
            this.btnNuevaAsignatura.TabIndex = 7;
            this.btnNuevaAsignatura.Text = "Nueva Asignatura";
            this.btnNuevaAsignatura.UseVisualStyleBackColor = false;
            this.btnNuevaAsignatura.Click += new System.EventHandler(this.btnNuevaAsignatura_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 254);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Asignatura";
            // 
            // txtAsignaturabusqueda
            // 
            this.txtAsignaturabusqueda.Location = new System.Drawing.Point(108, 253);
            this.txtAsignaturabusqueda.Name = "txtAsignaturabusqueda";
            this.txtAsignaturabusqueda.Size = new System.Drawing.Size(140, 20);
            this.txtAsignaturabusqueda.TabIndex = 3;
            // 
            // btnOrdenAscendente
            // 
            this.btnOrdenAscendente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrdenAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenAscendente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenAscendente.Location = new System.Drawing.Point(484, 392);
            this.btnOrdenAscendente.Name = "btnOrdenAscendente";
            this.btnOrdenAscendente.Size = new System.Drawing.Size(120, 46);
            this.btnOrdenAscendente.TabIndex = 8;
            this.btnOrdenAscendente.Text = "Ordenamiento Ascendiente";
            this.btnOrdenAscendente.UseVisualStyleBackColor = false;
            this.btnOrdenAscendente.Click += new System.EventHandler(this.btnOrdenAscendente_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(273, 245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 34);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignaturaHeader,
            this.NotaHeader});
            this.dataGridView1.Location = new System.Drawing.Point(15, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // asignaturaHeader
            // 
            this.asignaturaHeader.HeaderText = "Asignatura";
            this.asignaturaHeader.Name = "asignaturaHeader";
            this.asignaturaHeader.ReadOnly = true;
            // 
            // NotaHeader
            // 
            this.NotaHeader.HeaderText = "Nota";
            this.NotaHeader.Name = "NotaHeader";
            this.NotaHeader.ReadOnly = true;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOrdenAscendente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevaAsignatura);
            this.Controls.Add(this.txtAsignaturabusqueda);
            this.Controls.Add(this.btnOrdenDescendente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Name = "FrmMain";
            this.Text = "Formulario Calculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantidadAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbExamen;
        private System.Windows.Forms.ComboBox cmbAcumulado;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAsignaturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAsignaturasReprobadas;
        private System.Windows.Forms.TextBox txtAsignaturasAprobadas;
        private System.Windows.Forms.TextBox txtPromedioEstudiante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrdenDescendente;
        private System.Windows.Forms.Button btnNuevaAsignatura;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtAsignaturabusqueda;
        private System.Windows.Forms.Button btnOrdenAscendente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignaturaHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaHeader;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

