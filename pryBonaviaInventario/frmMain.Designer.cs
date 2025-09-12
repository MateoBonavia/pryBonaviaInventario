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
            tpbAgregar = new TabPage();
            cmbCategoriasAgregar = new ComboBox();
            lblTituloAgregar = new Label();
            btnAgregar = new Button();
            txtAgregarStock = new TextBox();
            txtAgregarPrecio = new TextBox();
            txtAgregarNombre = new TextBox();
            txtAgregarCodigo = new TextBox();
            txtAgregarDescripcion = new TextBox();
            lblCategorias = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            tpbModificar = new TabPage();
            btnModificar = new Button();
            txtCategoriaModificar = new TextBox();
            txtStockModificar = new TextBox();
            txtPrecioModificar = new TextBox();
            txtNombreModificar = new TextBox();
            txtCodigoModificar = new TextBox();
            txtDescripcionModificar = new TextBox();
            lblCatModificar = new Label();
            lblStockModificar = new Label();
            lblPrecioModificar = new Label();
            lblDescModificar = new Label();
            lblNombreModificar = new Label();
            lblCodModificar = new Label();
            gpbBuscarModificar = new GroupBox();
            btnBuscar_modificar = new Button();
            rdbCategoria_modificar = new RadioButton();
            rdbCodigo_modificar = new RadioButton();
            rdbNombre_modificar = new RadioButton();
            lblBuscarModificar = new Label();
            txtBusqueda_modificar = new TextBox();
            tpbEliminar = new TabPage();
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
            lblBuscarEliminar = new Label();
            txtBuscar_eliminar = new TextBox();
            tpbReporte = new TabPage();
            tabControl1.SuspendLayout();
            tpbAgregar.SuspendLayout();
            tpbModificar.SuspendLayout();
            gpbBuscarModificar.SuspendLayout();
            tpbEliminar.SuspendLayout();
            gpbBuscar_eliminar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpbAgregar);
            tabControl1.Controls.Add(tpbModificar);
            tabControl1.Controls.Add(tpbEliminar);
            tabControl1.Controls.Add(tpbReporte);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(514, 337);
            tabControl1.TabIndex = 0;
            // 
            // tpbAgregar
            // 
            tpbAgregar.Controls.Add(cmbCategoriasAgregar);
            tpbAgregar.Controls.Add(lblTituloAgregar);
            tpbAgregar.Controls.Add(btnAgregar);
            tpbAgregar.Controls.Add(txtAgregarStock);
            tpbAgregar.Controls.Add(txtAgregarPrecio);
            tpbAgregar.Controls.Add(txtAgregarNombre);
            tpbAgregar.Controls.Add(txtAgregarCodigo);
            tpbAgregar.Controls.Add(txtAgregarDescripcion);
            tpbAgregar.Controls.Add(lblCategorias);
            tpbAgregar.Controls.Add(lblStock);
            tpbAgregar.Controls.Add(lblPrecio);
            tpbAgregar.Controls.Add(lblDescripcion);
            tpbAgregar.Controls.Add(lblNombre);
            tpbAgregar.Controls.Add(lblCodigo);
            tpbAgregar.Location = new Point(4, 24);
            tpbAgregar.Name = "tpbAgregar";
            tpbAgregar.Padding = new Padding(3);
            tpbAgregar.Size = new Size(506, 309);
            tpbAgregar.TabIndex = 0;
            tpbAgregar.Text = "Agregar";
            tpbAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriasAgregar
            // 
            cmbCategoriasAgregar.FormattingEnabled = true;
            cmbCategoriasAgregar.Location = new Point(208, 180);
            cmbCategoriasAgregar.Name = "cmbCategoriasAgregar";
            cmbCategoriasAgregar.Size = new Size(172, 23);
            cmbCategoriasAgregar.TabIndex = 14;
            // 
            // lblTituloAgregar
            // 
            lblTituloAgregar.AutoSize = true;
            lblTituloAgregar.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloAgregar.Location = new Point(106, 11);
            lblTituloAgregar.Name = "lblTituloAgregar";
            lblTituloAgregar.Size = new Size(274, 24);
            lblTituloAgregar.TabIndex = 13;
            lblTituloAgregar.Text = "Agregar nuevo producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(208, 268);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(172, 24);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtAgregarStock
            // 
            txtAgregarStock.Location = new Point(208, 151);
            txtAgregarStock.Name = "txtAgregarStock";
            txtAgregarStock.Size = new Size(74, 23);
            txtAgregarStock.TabIndex = 10;
            // 
            // txtAgregarPrecio
            // 
            txtAgregarPrecio.Location = new Point(208, 122);
            txtAgregarPrecio.Name = "txtAgregarPrecio";
            txtAgregarPrecio.Size = new Size(74, 23);
            txtAgregarPrecio.TabIndex = 9;
            // 
            // txtAgregarNombre
            // 
            txtAgregarNombre.Location = new Point(208, 93);
            txtAgregarNombre.Name = "txtAgregarNombre";
            txtAgregarNombre.Size = new Size(172, 23);
            txtAgregarNombre.TabIndex = 8;
            // 
            // txtAgregarCodigo
            // 
            txtAgregarCodigo.Location = new Point(208, 64);
            txtAgregarCodigo.Name = "txtAgregarCodigo";
            txtAgregarCodigo.Size = new Size(74, 23);
            txtAgregarCodigo.TabIndex = 7;
            // 
            // txtAgregarDescripcion
            // 
            txtAgregarDescripcion.Location = new Point(208, 209);
            txtAgregarDescripcion.Multiline = true;
            txtAgregarDescripcion.Name = "txtAgregarDescripcion";
            txtAgregarDescripcion.Size = new Size(172, 53);
            txtAgregarDescripcion.TabIndex = 6;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(106, 183);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(77, 15);
            lblCategorias.TabIndex = 5;
            lblCategorias.Text = "Categorías";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(106, 154);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(106, 125);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(49, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(106, 212);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(84, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(106, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(49, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(106, 67);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // tpbModificar
            // 
            tpbModificar.Controls.Add(btnModificar);
            tpbModificar.Controls.Add(txtCategoriaModificar);
            tpbModificar.Controls.Add(txtStockModificar);
            tpbModificar.Controls.Add(txtPrecioModificar);
            tpbModificar.Controls.Add(txtNombreModificar);
            tpbModificar.Controls.Add(txtCodigoModificar);
            tpbModificar.Controls.Add(txtDescripcionModificar);
            tpbModificar.Controls.Add(lblCatModificar);
            tpbModificar.Controls.Add(lblStockModificar);
            tpbModificar.Controls.Add(lblPrecioModificar);
            tpbModificar.Controls.Add(lblDescModificar);
            tpbModificar.Controls.Add(lblNombreModificar);
            tpbModificar.Controls.Add(lblCodModificar);
            tpbModificar.Controls.Add(gpbBuscarModificar);
            tpbModificar.Location = new Point(4, 24);
            tpbModificar.Name = "tpbModificar";
            tpbModificar.Padding = new Padding(3);
            tpbModificar.Size = new Size(506, 309);
            tpbModificar.TabIndex = 1;
            tpbModificar.Text = "Modificar";
            tpbModificar.UseVisualStyleBackColor = true;
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
            // txtCategoriaModificar
            // 
            txtCategoriaModificar.Location = new Point(114, 218);
            txtCategoriaModificar.Name = "txtCategoriaModificar";
            txtCategoriaModificar.Size = new Size(172, 23);
            txtCategoriaModificar.TabIndex = 23;
            // 
            // txtStockModificar
            // 
            txtStockModificar.Location = new Point(114, 189);
            txtStockModificar.Name = "txtStockModificar";
            txtStockModificar.Size = new Size(172, 23);
            txtStockModificar.TabIndex = 22;
            // 
            // txtPrecioModificar
            // 
            txtPrecioModificar.Location = new Point(114, 160);
            txtPrecioModificar.Name = "txtPrecioModificar";
            txtPrecioModificar.Size = new Size(172, 23);
            txtPrecioModificar.TabIndex = 21;
            // 
            // txtNombreModificar
            // 
            txtNombreModificar.Location = new Point(114, 131);
            txtNombreModificar.Name = "txtNombreModificar";
            txtNombreModificar.Size = new Size(172, 23);
            txtNombreModificar.TabIndex = 20;
            // 
            // txtCodigoModificar
            // 
            txtCodigoModificar.Location = new Point(114, 96);
            txtCodigoModificar.Name = "txtCodigoModificar";
            txtCodigoModificar.Size = new Size(172, 23);
            txtCodigoModificar.TabIndex = 19;
            // 
            // txtDescripcionModificar
            // 
            txtDescripcionModificar.Location = new Point(114, 247);
            txtDescripcionModificar.Multiline = true;
            txtDescripcionModificar.Name = "txtDescripcionModificar";
            txtDescripcionModificar.Size = new Size(172, 55);
            txtDescripcionModificar.TabIndex = 18;
            // 
            // lblCatModificar
            // 
            lblCatModificar.AutoSize = true;
            lblCatModificar.Location = new Point(12, 221);
            lblCatModificar.Name = "lblCatModificar";
            lblCatModificar.Size = new Size(77, 15);
            lblCatModificar.TabIndex = 17;
            lblCatModificar.Text = "Categorías";
            // 
            // lblStockModificar
            // 
            lblStockModificar.AutoSize = true;
            lblStockModificar.Location = new Point(12, 192);
            lblStockModificar.Name = "lblStockModificar";
            lblStockModificar.Size = new Size(42, 15);
            lblStockModificar.TabIndex = 16;
            lblStockModificar.Text = "Stock";
            // 
            // lblPrecioModificar
            // 
            lblPrecioModificar.AutoSize = true;
            lblPrecioModificar.Location = new Point(12, 163);
            lblPrecioModificar.Name = "lblPrecioModificar";
            lblPrecioModificar.Size = new Size(49, 15);
            lblPrecioModificar.TabIndex = 15;
            lblPrecioModificar.Text = "Precio";
            // 
            // lblDescModificar
            // 
            lblDescModificar.AutoSize = true;
            lblDescModificar.Location = new Point(12, 250);
            lblDescModificar.Name = "lblDescModificar";
            lblDescModificar.Size = new Size(84, 15);
            lblDescModificar.TabIndex = 14;
            lblDescModificar.Text = "Descripción";
            // 
            // lblNombreModificar
            // 
            lblNombreModificar.AutoSize = true;
            lblNombreModificar.Location = new Point(12, 134);
            lblNombreModificar.Name = "lblNombreModificar";
            lblNombreModificar.Size = new Size(49, 15);
            lblNombreModificar.TabIndex = 13;
            lblNombreModificar.Text = "Nombre";
            // 
            // lblCodModificar
            // 
            lblCodModificar.AutoSize = true;
            lblCodModificar.Location = new Point(12, 99);
            lblCodModificar.Name = "lblCodModificar";
            lblCodModificar.Size = new Size(49, 15);
            lblCodModificar.TabIndex = 12;
            lblCodModificar.Text = "Código";
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
            // btnBuscar_modificar
            // 
            btnBuscar_modificar.Location = new Point(342, 42);
            btnBuscar_modificar.Name = "btnBuscar_modificar";
            btnBuscar_modificar.Size = new Size(146, 24);
            btnBuscar_modificar.TabIndex = 20;
            btnBuscar_modificar.Text = "Buscar";
            btnBuscar_modificar.UseVisualStyleBackColor = true;
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
            // lblBuscarModificar
            // 
            lblBuscarModificar.AutoSize = true;
            lblBuscarModificar.Location = new Point(6, 19);
            lblBuscarModificar.Name = "lblBuscarModificar";
            lblBuscarModificar.Size = new Size(84, 15);
            lblBuscarModificar.TabIndex = 16;
            lblBuscarModificar.Text = "Buscar por:";
            // 
            // txtBusqueda_modificar
            // 
            txtBusqueda_modificar.Location = new Point(6, 42);
            txtBusqueda_modificar.Name = "txtBusqueda_modificar";
            txtBusqueda_modificar.Size = new Size(324, 23);
            txtBusqueda_modificar.TabIndex = 15;
            // 
            // tpbEliminar
            // 
            tpbEliminar.Controls.Add(btnEliminar);
            tpbEliminar.Controls.Add(txtCategorias_eliminar);
            tpbEliminar.Controls.Add(txtStock_eliminar);
            tpbEliminar.Controls.Add(txtPrecio_eliminar);
            tpbEliminar.Controls.Add(txtNombre_eliminar);
            tpbEliminar.Controls.Add(txtCodigo_eliminar);
            tpbEliminar.Controls.Add(txtDescripcion_eliminar);
            tpbEliminar.Controls.Add(lblCategorias_eliminar);
            tpbEliminar.Controls.Add(lblStock_eliminar);
            tpbEliminar.Controls.Add(lblPrecio_eliminar);
            tpbEliminar.Controls.Add(lblDescripcion_eliminar);
            tpbEliminar.Controls.Add(lblNombre_eliminar);
            tpbEliminar.Controls.Add(lblCodigo_eliminar);
            tpbEliminar.Controls.Add(gpbBuscar_eliminar);
            tpbEliminar.Location = new Point(4, 24);
            tpbEliminar.Name = "tpbEliminar";
            tpbEliminar.Size = new Size(506, 309);
            tpbEliminar.TabIndex = 2;
            tpbEliminar.Text = "Eliminar";
            tpbEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(347, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 24);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtCategorias_eliminar
            // 
            txtCategorias_eliminar.Location = new Point(113, 209);
            txtCategorias_eliminar.Name = "txtCategorias_eliminar";
            txtCategorias_eliminar.Size = new Size(172, 23);
            txtCategorias_eliminar.TabIndex = 37;
            // 
            // txtStock_eliminar
            // 
            txtStock_eliminar.Location = new Point(113, 180);
            txtStock_eliminar.Name = "txtStock_eliminar";
            txtStock_eliminar.Size = new Size(172, 23);
            txtStock_eliminar.TabIndex = 36;
            // 
            // txtPrecio_eliminar
            // 
            txtPrecio_eliminar.Location = new Point(113, 151);
            txtPrecio_eliminar.Name = "txtPrecio_eliminar";
            txtPrecio_eliminar.Size = new Size(172, 23);
            txtPrecio_eliminar.TabIndex = 35;
            // 
            // txtNombre_eliminar
            // 
            txtNombre_eliminar.Location = new Point(113, 122);
            txtNombre_eliminar.Name = "txtNombre_eliminar";
            txtNombre_eliminar.Size = new Size(172, 23);
            txtNombre_eliminar.TabIndex = 33;
            // 
            // txtCodigo_eliminar
            // 
            txtCodigo_eliminar.Location = new Point(113, 93);
            txtCodigo_eliminar.Name = "txtCodigo_eliminar";
            txtCodigo_eliminar.Size = new Size(172, 23);
            txtCodigo_eliminar.TabIndex = 32;
            // 
            // txtDescripcion_eliminar
            // 
            txtDescripcion_eliminar.Location = new Point(113, 238);
            txtDescripcion_eliminar.Multiline = true;
            txtDescripcion_eliminar.Name = "txtDescripcion_eliminar";
            txtDescripcion_eliminar.Size = new Size(172, 64);
            txtDescripcion_eliminar.TabIndex = 31;
            // 
            // lblCategorias_eliminar
            // 
            lblCategorias_eliminar.AutoSize = true;
            lblCategorias_eliminar.Location = new Point(11, 212);
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
            lblPrecio_eliminar.Location = new Point(11, 154);
            lblPrecio_eliminar.Name = "lblPrecio_eliminar";
            lblPrecio_eliminar.Size = new Size(49, 15);
            lblPrecio_eliminar.TabIndex = 28;
            lblPrecio_eliminar.Text = "Precio";
            // 
            // lblDescripcion_eliminar
            // 
            lblDescripcion_eliminar.AutoSize = true;
            lblDescripcion_eliminar.Location = new Point(11, 241);
            lblDescripcion_eliminar.Name = "lblDescripcion_eliminar";
            lblDescripcion_eliminar.Size = new Size(84, 15);
            lblDescripcion_eliminar.TabIndex = 27;
            lblDescripcion_eliminar.Text = "Descripción";
            // 
            // lblNombre_eliminar
            // 
            lblNombre_eliminar.AutoSize = true;
            lblNombre_eliminar.Location = new Point(11, 125);
            lblNombre_eliminar.Name = "lblNombre_eliminar";
            lblNombre_eliminar.Size = new Size(49, 15);
            lblNombre_eliminar.TabIndex = 26;
            lblNombre_eliminar.Text = "Nombre";
            // 
            // lblCodigo_eliminar
            // 
            lblCodigo_eliminar.AutoSize = true;
            lblCodigo_eliminar.Location = new Point(11, 96);
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
            gpbBuscar_eliminar.Controls.Add(lblBuscarEliminar);
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
            // lblBuscarEliminar
            // 
            lblBuscarEliminar.AutoSize = true;
            lblBuscarEliminar.Location = new Point(6, 19);
            lblBuscarEliminar.Name = "lblBuscarEliminar";
            lblBuscarEliminar.Size = new Size(84, 15);
            lblBuscarEliminar.TabIndex = 16;
            lblBuscarEliminar.Text = "Buscar por:";
            // 
            // txtBuscar_eliminar
            // 
            txtBuscar_eliminar.Location = new Point(6, 42);
            txtBuscar_eliminar.Name = "txtBuscar_eliminar";
            txtBuscar_eliminar.Size = new Size(324, 23);
            txtBuscar_eliminar.TabIndex = 15;
            // 
            // tpbReporte
            // 
            tpbReporte.Location = new Point(4, 24);
            tpbReporte.Name = "tpbReporte";
            tpbReporte.Size = new Size(506, 309);
            tpbReporte.TabIndex = 3;
            tpbReporte.Text = "Reporte";
            tpbReporte.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(539, 358);
            Controls.Add(tabControl1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMain";
            Text = "Gestion de Inventario";
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            tpbAgregar.ResumeLayout(false);
            tpbAgregar.PerformLayout();
            tpbModificar.ResumeLayout(false);
            tpbModificar.PerformLayout();
            gpbBuscarModificar.ResumeLayout(false);
            gpbBuscarModificar.PerformLayout();
            tpbEliminar.ResumeLayout(false);
            tpbEliminar.PerformLayout();
            gpbBuscar_eliminar.ResumeLayout(false);
            gpbBuscar_eliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpbAgregar;
        private Label lblCategorias;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblCodigo;
        private TabPage tpbModificar;
        private TabPage tpbEliminar;
        private TabPage tpbReporte;
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
        private TextBox txtCategoriaModificar;
        private TextBox txtStockModificar;
        private TextBox txtPrecioModificar;
        private TextBox txtNombreModificar;
        private TextBox txtCodigoModificar;
        private TextBox txtDescripcionModificar;
        private Label lblCatModificar;
        private Label lblStockModificar;
        private Label lblPrecioModificar;
        private Label lblDescModificar;
        private Label lblNombreModificar;
        private Label lblCodModificar;
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
        private Label lblBuscarEliminar;
        private TextBox txtBuscar_eliminar;
        private Label lblTituloAgregar;
        private ComboBox cmbCategoriasAgregar;
    }
}