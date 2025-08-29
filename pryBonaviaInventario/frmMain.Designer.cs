namespace pryBonaviaInventario
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            agregar = new TabPage();
            modificar = new TabPage();
            eliminar = new TabPage();
            reporte = new TabPage();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblCategorias = new Label();
            txtAgregarDescripcion = new TextBox();
            txtAgregarCodigo = new TextBox();
            txtAgregarNombre = new TextBox();
            txtAgregarPrecio = new TextBox();
            txtAgregarStock = new TextBox();
            txtAgregarCategorias = new TextBox();
            btnAgregar = new Button();
            gpbBuscarModificar = new GroupBox();
            txtBusqueda_modificar = new TextBox();
            lblBuscarModificar = new Label();
            rdbNombre_modificar = new RadioButton();
            rdbCodigo_modificar = new RadioButton();
            rdbCategoria_modificar = new RadioButton();
            btnBuscar_modificar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtCategorias_eliminar = new TextBox();
            txtStock_eliminar = new TextBox();
            txtPrecio_eliminar = new TextBox();
            txtNombre_eliminar = new TextBox();
            txtCodigo_eliminar = new TextBox();
            txtDescripcion_eliminar = new TextBox();
            lblCategorias_eliminar = new Label();
            lblStock_eliminar = new Label();
            lblPrecio_eliminar = new Label();
            lblDescripcion_eliminar = new Label();
            lblNombre_eliminar = new Label();
            lblCodigo_eliminar = new Label();
            gpbBuscar_eliminar = new GroupBox();
            btnBuscar_eliminar = new Button();
            rdbCategoria_eliminar = new RadioButton();
            rdbCodigo_eliminar = new RadioButton();
            rdbNombre_eliminar = new RadioButton();
            label13 = new Label();
            txtBuscar_eliminar = new TextBox();
            tabControl1.SuspendLayout();
            agregar.SuspendLayout();
            modificar.SuspendLayout();
            eliminar.SuspendLayout();
            gpbBuscarModificar.SuspendLayout();
            gpbBuscar_eliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(agregar);
            tabControl1.Controls.Add(modificar);
            tabControl1.Controls.Add(eliminar);
            tabControl1.Controls.Add(reporte);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(514, 393);
            tabControl1.TabIndex = 0;
            // 
            // agregar
            // 
            agregar.Controls.Add(btnAgregar);
            agregar.Controls.Add(txtAgregarCategorias);
            agregar.Controls.Add(txtAgregarStock);
            agregar.Controls.Add(txtAgregarPrecio);
            agregar.Controls.Add(txtAgregarNombre);
            agregar.Controls.Add(txtAgregarCodigo);
            agregar.Controls.Add(txtAgregarDescripcion);
            agregar.Controls.Add(lblCategorias);
            agregar.Controls.Add(lblStock);
            agregar.Controls.Add(lblPrecio);
            agregar.Controls.Add(lblDescripcion);
            agregar.Controls.Add(lblNombre);
            agregar.Controls.Add(lblCodigo);
            agregar.Location = new Point(4, 24);
            agregar.Name = "agregar";
            agregar.Padding = new Padding(3);
            agregar.Size = new Size(506, 365);
            agregar.TabIndex = 0;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            modificar.Controls.Add(btnModificar);
            modificar.Controls.Add(textBox1);
            modificar.Controls.Add(textBox2);
            modificar.Controls.Add(textBox3);
            modificar.Controls.Add(textBox4);
            modificar.Controls.Add(textBox5);
            modificar.Controls.Add(textBox6);
            modificar.Controls.Add(label1);
            modificar.Controls.Add(label2);
            modificar.Controls.Add(label3);
            modificar.Controls.Add(label4);
            modificar.Controls.Add(label5);
            modificar.Controls.Add(label6);
            modificar.Controls.Add(gpbBuscarModificar);
            modificar.Location = new Point(4, 24);
            modificar.Name = "modificar";
            modificar.Padding = new Padding(3);
            modificar.Size = new Size(506, 365);
            modificar.TabIndex = 1;
            modificar.Text = "Modificar";
            modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Controls.Add(btnEliminar);
            eliminar.Controls.Add(txtCategorias_eliminar);
            eliminar.Controls.Add(txtStock_eliminar);
            eliminar.Controls.Add(txtPrecio_eliminar);
            eliminar.Controls.Add(txtNombre_eliminar);
            eliminar.Controls.Add(txtCodigo_eliminar);
            eliminar.Controls.Add(txtDescripcion_eliminar);
            eliminar.Controls.Add(lblCategorias_eliminar);
            eliminar.Controls.Add(lblStock_eliminar);
            eliminar.Controls.Add(lblPrecio_eliminar);
            eliminar.Controls.Add(lblDescripcion_eliminar);
            eliminar.Controls.Add(lblNombre_eliminar);
            eliminar.Controls.Add(lblCodigo_eliminar);
            eliminar.Controls.Add(gpbBuscar_eliminar);
            eliminar.Location = new Point(4, 24);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(506, 365);
            eliminar.TabIndex = 2;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // reporte
            // 
            reporte.Location = new Point(4, 24);
            reporte.Name = "reporte";
            reporte.Size = new Size(768, 398);
            reporte.TabIndex = 3;
            reporte.Text = "Reporte";
            reporte.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(118, 68);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 97);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(118, 213);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(84, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(118, 126);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(118, 155);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(118, 184);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(77, 15);
            lblCategorias.TabIndex = 5;
            lblCategorias.Text = "Categorías";
            // 
            // txtAgregarDescripcion
            // 
            txtAgregarDescripcion.Location = new Point(220, 210);
            txtAgregarDescripcion.Multiline = true;
            txtAgregarDescripcion.Name = "txtAgregarDescripcion";
            txtAgregarDescripcion.Size = new Size(172, 53);
            txtAgregarDescripcion.TabIndex = 6;
            // 
            // txtAgregarCodigo
            // 
            txtAgregarCodigo.Location = new Point(220, 65);
            txtAgregarCodigo.Name = "txtAgregarCodigo";
            txtAgregarCodigo.Size = new Size(172, 23);
            txtAgregarCodigo.TabIndex = 7;
            // 
            // txtAgregarNombre
            // 
            txtAgregarNombre.Location = new Point(220, 94);
            txtAgregarNombre.Name = "txtAgregarNombre";
            txtAgregarNombre.Size = new Size(172, 23);
            txtAgregarNombre.TabIndex = 8;
            // 
            // txtAgregarPrecio
            // 
            txtAgregarPrecio.Location = new Point(220, 123);
            txtAgregarPrecio.Name = "txtAgregarPrecio";
            txtAgregarPrecio.Size = new Size(172, 23);
            txtAgregarPrecio.TabIndex = 9;
            // 
            // txtAgregarStock
            // 
            txtAgregarStock.Location = new Point(220, 152);
            txtAgregarStock.Name = "txtAgregarStock";
            txtAgregarStock.Size = new Size(172, 23);
            txtAgregarStock.TabIndex = 10;
            // 
            // txtAgregarCategorias
            // 
            txtAgregarCategorias.Location = new Point(220, 181);
            txtAgregarCategorias.Name = "txtAgregarCategorias";
            txtAgregarCategorias.Size = new Size(172, 23);
            txtAgregarCategorias.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(220, 269);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(172, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gpbBuscarModificar
            // 
            gpbBuscarModificar.Controls.Add(btnBuscar_modificar);
            gpbBuscarModificar.Controls.Add(rdbCategoria_modificar);
            gpbBuscarModificar.Controls.Add(rdbCodigo_modificar);
            gpbBuscarModificar.Controls.Add(rdbNombre_modificar);
            gpbBuscarModificar.Controls.Add(lblBuscarModificar);
            gpbBuscarModificar.Controls.Add(txtBusqueda_modificar);
            gpbBuscarModificar.Location = new Point(6, 6);
            gpbBuscarModificar.Name = "gpbBuscarModificar";
            gpbBuscarModificar.Size = new Size(494, 79);
            gpbBuscarModificar.TabIndex = 0;
            gpbBuscarModificar.TabStop = false;
            gpbBuscarModificar.Text = "Buscar";
            // 
            // txtBusqueda_modificar
            // 
            txtBusqueda_modificar.Location = new Point(6, 42);
            txtBusqueda_modificar.Name = "txtBusqueda_modificar";
            txtBusqueda_modificar.Size = new Size(324, 23);
            txtBusqueda_modificar.TabIndex = 15;
            // 
            // lblBuscarModificar
            // 
            lblBuscarModificar.AutoSize = true;
            lblBuscarModificar.Location = new Point(6, 19);
            lblBuscarModificar.Name = "lblBuscarModificar";
            lblBuscarModificar.Size = new Size(84, 15);
            lblBuscarModificar.TabIndex = 16;
            lblBuscarModificar.Text = "Buscar por:";
            // 
            // rdbNombre_modificar
            // 
            rdbNombre_modificar.AutoSize = true;
            rdbNombre_modificar.Location = new Point(96, 17);
            rdbNombre_modificar.Name = "rdbNombre_modificar";
            rdbNombre_modificar.Size = new Size(67, 19);
            rdbNombre_modificar.TabIndex = 17;
            rdbNombre_modificar.TabStop = true;
            rdbNombre_modificar.Text = "Nombre";
            rdbNombre_modificar.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo_modificar
            // 
            rdbCodigo_modificar.AutoSize = true;
            rdbCodigo_modificar.Location = new Point(169, 17);
            rdbCodigo_modificar.Name = "rdbCodigo_modificar";
            rdbCodigo_modificar.Size = new Size(67, 19);
            rdbCodigo_modificar.TabIndex = 18;
            rdbCodigo_modificar.TabStop = true;
            rdbCodigo_modificar.Text = "Código";
            rdbCodigo_modificar.UseVisualStyleBackColor = true;
            // 
            // rdbCategoria_modificar
            // 
            rdbCategoria_modificar.AutoSize = true;
            rdbCategoria_modificar.Location = new Point(242, 17);
            rdbCategoria_modificar.Name = "rdbCategoria_modificar";
            rdbCategoria_modificar.Size = new Size(88, 19);
            rdbCategoria_modificar.TabIndex = 19;
            rdbCategoria_modificar.TabStop = true;
            rdbCategoria_modificar.Text = "Categoría";
            rdbCategoria_modificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar_modificar
            // 
            btnBuscar_modificar.Location = new Point(342, 42);
            btnBuscar_modificar.Name = "btnBuscar_modificar";
            btnBuscar_modificar.Size = new Size(146, 24);
            btnBuscar_modificar.TabIndex = 20;
            btnBuscar_modificar.Text = "Buscar";
            btnBuscar_modificar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 96);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 247);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 55);
            textBox6.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 17;
            label1.Text = "Categorías";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 16;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 134);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "Código";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(348, 278);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(146, 24);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(348, 289);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 24);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCategorias_eliminar
            // 
            txtCategorias_eliminar.Location = new Point(114, 220);
            txtCategorias_eliminar.Name = "txtCategorias_eliminar";
            txtCategorias_eliminar.Size = new Size(172, 23);
            txtCategorias_eliminar.TabIndex = 37;
            // 
            // txtStock_eliminar
            // 
            txtStock_eliminar.Location = new Point(114, 191);
            txtStock_eliminar.Name = "txtStock_eliminar";
            txtStock_eliminar.Size = new Size(172, 23);
            txtStock_eliminar.TabIndex = 36;
            // 
            // txtPrecio_eliminar
            // 
            txtPrecio_eliminar.Location = new Point(114, 162);
            txtPrecio_eliminar.Name = "txtPrecio_eliminar";
            txtPrecio_eliminar.Size = new Size(172, 23);
            txtPrecio_eliminar.TabIndex = 35;
            // 
            // txtNombre_eliminar
            // 
            txtNombre_eliminar.Location = new Point(114, 133);
            txtNombre_eliminar.Name = "txtNombre_eliminar";
            txtNombre_eliminar.Size = new Size(172, 23);
            txtNombre_eliminar.TabIndex = 33;
            // 
            // txtCodigo_eliminar
            // 
            txtCodigo_eliminar.Location = new Point(114, 104);
            txtCodigo_eliminar.Name = "txtCodigo_eliminar";
            txtCodigo_eliminar.Size = new Size(172, 23);
            txtCodigo_eliminar.TabIndex = 32;
            // 
            // txtDescripcion_eliminar
            // 
            txtDescripcion_eliminar.Location = new Point(114, 249);
            txtDescripcion_eliminar.Multiline = true;
            txtDescripcion_eliminar.Name = "txtDescripcion_eliminar";
            txtDescripcion_eliminar.Size = new Size(172, 64);
            txtDescripcion_eliminar.TabIndex = 31;
            // 
            // lblCategorias_eliminar
            // 
            lblCategorias_eliminar.AutoSize = true;
            lblCategorias_eliminar.Location = new Point(12, 223);
            lblCategorias_eliminar.Name = "lblCategorias_eliminar";
            lblCategorias_eliminar.Size = new Size(77, 15);
            lblCategorias_eliminar.TabIndex = 30;
            lblCategorias_eliminar.Text = "Categorías";
            // 
            // lblStock_eliminar
            // 
            lblStock_eliminar.AutoSize = true;
            lblStock_eliminar.Location = new Point(12, 194);
            lblStock_eliminar.Name = "lblStock_eliminar";
            lblStock_eliminar.Size = new Size(42, 15);
            lblStock_eliminar.TabIndex = 29;
            lblStock_eliminar.Text = "Stock";
            // 
            // lblPrecio_eliminar
            // 
            lblPrecio_eliminar.AutoSize = true;
            lblPrecio_eliminar.Location = new Point(12, 165);
            lblPrecio_eliminar.Name = "lblPrecio_eliminar";
            lblPrecio_eliminar.Size = new Size(49, 15);
            lblPrecio_eliminar.TabIndex = 28;
            lblPrecio_eliminar.Text = "Precio";
            // 
            // lblDescripcion_eliminar
            // 
            lblDescripcion_eliminar.AutoSize = true;
            lblDescripcion_eliminar.Location = new Point(12, 252);
            lblDescripcion_eliminar.Name = "lblDescripcion_eliminar";
            lblDescripcion_eliminar.Size = new Size(84, 15);
            lblDescripcion_eliminar.TabIndex = 27;
            lblDescripcion_eliminar.Text = "Descripción";
            // 
            // lblNombre_eliminar
            // 
            lblNombre_eliminar.AutoSize = true;
            lblNombre_eliminar.Location = new Point(12, 136);
            lblNombre_eliminar.Name = "lblNombre_eliminar";
            lblNombre_eliminar.Size = new Size(49, 15);
            lblNombre_eliminar.TabIndex = 26;
            lblNombre_eliminar.Text = "Nombre";
            // 
            // lblCodigo_eliminar
            // 
            lblCodigo_eliminar.AutoSize = true;
            lblCodigo_eliminar.Location = new Point(12, 107);
            lblCodigo_eliminar.Name = "lblCodigo_eliminar";
            lblCodigo_eliminar.Size = new Size(49, 15);
            lblCodigo_eliminar.TabIndex = 25;
            lblCodigo_eliminar.Text = "Código";
            // 
            // gpbBuscar_eliminar
            // 
            gpbBuscar_eliminar.Controls.Add(btnBuscar_eliminar);
            gpbBuscar_eliminar.Controls.Add(rdbCategoria_eliminar);
            gpbBuscar_eliminar.Controls.Add(rdbCodigo_eliminar);
            gpbBuscar_eliminar.Controls.Add(rdbNombre_eliminar);
            gpbBuscar_eliminar.Controls.Add(label13);
            gpbBuscar_eliminar.Controls.Add(txtBuscar_eliminar);
            gpbBuscar_eliminar.Location = new Point(6, 8);
            gpbBuscar_eliminar.Name = "gpbBuscar_eliminar";
            gpbBuscar_eliminar.Size = new Size(494, 79);
            gpbBuscar_eliminar.TabIndex = 24;
            gpbBuscar_eliminar.TabStop = false;
            gpbBuscar_eliminar.Text = "Buscar";
            // 
            // btnBuscar_eliminar
            // 
            btnBuscar_eliminar.Location = new Point(342, 42);
            btnBuscar_eliminar.Name = "btnBuscar_eliminar";
            btnBuscar_eliminar.Size = new Size(146, 24);
            btnBuscar_eliminar.TabIndex = 20;
            btnBuscar_eliminar.Text = "Buscar";
            btnBuscar_eliminar.UseVisualStyleBackColor = true;
            // 
            // rdbCategoria_eliminar
            // 
            rdbCategoria_eliminar.AutoSize = true;
            rdbCategoria_eliminar.Location = new Point(242, 17);
            rdbCategoria_eliminar.Name = "rdbCategoria_eliminar";
            rdbCategoria_eliminar.Size = new Size(88, 19);
            rdbCategoria_eliminar.TabIndex = 19;
            rdbCategoria_eliminar.TabStop = true;
            rdbCategoria_eliminar.Text = "Categoría";
            rdbCategoria_eliminar.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo_eliminar
            // 
            rdbCodigo_eliminar.AutoSize = true;
            rdbCodigo_eliminar.Location = new Point(169, 17);
            rdbCodigo_eliminar.Name = "rdbCodigo_eliminar";
            rdbCodigo_eliminar.Size = new Size(67, 19);
            rdbCodigo_eliminar.TabIndex = 18;
            rdbCodigo_eliminar.TabStop = true;
            rdbCodigo_eliminar.Text = "Código";
            rdbCodigo_eliminar.UseVisualStyleBackColor = true;
            // 
            // rdbNombre_eliminar
            // 
            rdbNombre_eliminar.AutoSize = true;
            rdbNombre_eliminar.Location = new Point(96, 17);
            rdbNombre_eliminar.Name = "rdbNombre_eliminar";
            rdbNombre_eliminar.Size = new Size(67, 19);
            rdbNombre_eliminar.TabIndex = 17;
            rdbNombre_eliminar.TabStop = true;
            rdbNombre_eliminar.Text = "Nombre";
            rdbNombre_eliminar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 19);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 16;
            label13.Text = "Buscar por:";
            // 
            // txtBuscar_eliminar
            // 
            txtBuscar_eliminar.Location = new Point(6, 42);
            txtBuscar_eliminar.Name = "txtBuscar_eliminar";
            txtBuscar_eliminar.Size = new Size(324, 23);
            txtBuscar_eliminar.TabIndex = 15;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 443);
            Controls.Add(tabControl1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMain";
            Text = "Gestion de Inventario";
            tabControl1.ResumeLayout(false);
            agregar.ResumeLayout(false);
            agregar.PerformLayout();
            modificar.ResumeLayout(false);
            modificar.PerformLayout();
            eliminar.ResumeLayout(false);
            eliminar.PerformLayout();
            gpbBuscarModificar.ResumeLayout(false);
            gpbBuscarModificar.PerformLayout();
            gpbBuscar_eliminar.ResumeLayout(false);
            gpbBuscar_eliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage agregar;
        private Label lblCategorias;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblCodigo;
        private TabPage modificar;
        private TabPage eliminar;
        private TabPage reporte;
        private TextBox txtAgregarCategorias;
        private TextBox txtAgregarStock;
        private TextBox txtAgregarPrecio;
        private TextBox txtAgregarNombre;
        private TextBox txtAgregarCodigo;
        private TextBox txtAgregarDescripcion;
        private Button btnAgregar;
        private GroupBox gpbBuscarModificar;
        private TextBox txtBusqueda_modificar;
        private Label lblBuscarModificar;
        private Button btnBuscar_modificar;
        private RadioButton rdbCategoria_modificar;
        private RadioButton rdbCodigo_modificar;
        private RadioButton rdbNombre_modificar;
        private Button btnModificar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminar;
        private TextBox txtCategorias_eliminar;
        private TextBox txtStock_eliminar;
        private TextBox txtPrecio_eliminar;
        private TextBox txtNombre_eliminar;
        private TextBox txtCodigo_eliminar;
        private TextBox txtDescripcion_eliminar;
        private Label lblCategorias_eliminar;
        private Label lblStock_eliminar;
        private Label lblPrecio_eliminar;
        private Label lblDescripcion_eliminar;
        private Label lblNombre_eliminar;
        private Label lblCodigo_eliminar;
        private GroupBox gpbBuscar_eliminar;
        private Button btnBuscar_eliminar;
        private RadioButton rdbCategoria_eliminar;
        private RadioButton rdbCodigo_eliminar;
        private RadioButton rdbNombre_eliminar;
        private Label label13;
        private TextBox txtBuscar_eliminar;
    }
}