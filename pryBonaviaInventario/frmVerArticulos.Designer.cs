namespace pryBonaviaInventario
{
    partial class frmVerArticulos
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
            gpbBuscarArticuloVer = new GroupBox();
            btnBuscarVer = new Button();
            txtArticuloVer = new TextBox();
            lblArticuloVer = new Label();
            dataGridView1 = new DataGridView();
            clmArticulo = new DataGridViewTextBoxColumn();
            clmMarca = new DataGridViewTextBoxColumn();
            clmTemporada = new DataGridViewTextBoxColumn();
            clmAa = new DataGridViewTextBoxColumn();
            clmSexo = new DataGridViewTextBoxColumn();
            clmRubro = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmPrecioCosto = new DataGridViewTextBoxColumn();
            clmMenor = new DataGridViewTextBoxColumn();
            clmMayor = new DataGridViewTextBoxColumn();
            clmArtViejo = new DataGridViewTextBoxColumn();
            clmPromocion = new DataGridViewTextBoxColumn();
            clmEstado = new DataGridViewTextBoxColumn();
            gpbBuscarArticuloVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gpbBuscarArticuloVer
            // 
            gpbBuscarArticuloVer.Controls.Add(btnBuscarVer);
            gpbBuscarArticuloVer.Controls.Add(txtArticuloVer);
            gpbBuscarArticuloVer.Controls.Add(lblArticuloVer);
            gpbBuscarArticuloVer.Location = new Point(12, 12);
            gpbBuscarArticuloVer.Name = "gpbBuscarArticuloVer";
            gpbBuscarArticuloVer.Size = new Size(506, 72);
            gpbBuscarArticuloVer.TabIndex = 0;
            gpbBuscarArticuloVer.TabStop = false;
            gpbBuscarArticuloVer.Text = "Buscar Artículo";
            // 
            // btnBuscarVer
            // 
            btnBuscarVer.Location = new Point(329, 34);
            btnBuscarVer.Name = "btnBuscarVer";
            btnBuscarVer.Size = new Size(171, 27);
            btnBuscarVer.TabIndex = 2;
            btnBuscarVer.Text = "Buscar";
            btnBuscarVer.UseVisualStyleBackColor = true;
            // 
            // txtArticuloVer
            // 
            txtArticuloVer.Location = new Point(160, 34);
            txtArticuloVer.Name = "txtArticuloVer";
            txtArticuloVer.Size = new Size(163, 27);
            txtArticuloVer.TabIndex = 1;
            // 
            // lblArticuloVer
            // 
            lblArticuloVer.AutoSize = true;
            lblArticuloVer.Location = new Point(6, 37);
            lblArticuloVer.Name = "lblArticuloVer";
            lblArticuloVer.Size = new Size(138, 20);
            lblArticuloVer.TabIndex = 0;
            lblArticuloVer.Text = "Codigo de Artículo:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmArticulo, clmMarca, clmTemporada, clmAa, clmSexo, clmRubro, clmNombre, clmPrecioCosto, clmMenor, clmMayor, clmArtViejo, clmPromocion, clmEstado });
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1270, 410);
            dataGridView1.TabIndex = 1;
            // 
            // clmArticulo
            // 
            clmArticulo.HeaderText = "Artículo";
            clmArticulo.MinimumWidth = 6;
            clmArticulo.Name = "clmArticulo";
            clmArticulo.ReadOnly = true;
            clmArticulo.Width = 125;
            // 
            // clmMarca
            // 
            clmMarca.HeaderText = "Marca";
            clmMarca.MinimumWidth = 6;
            clmMarca.Name = "clmMarca";
            clmMarca.ReadOnly = true;
            clmMarca.Width = 125;
            // 
            // clmTemporada
            // 
            clmTemporada.HeaderText = "Temporada";
            clmTemporada.MinimumWidth = 6;
            clmTemporada.Name = "clmTemporada";
            clmTemporada.ReadOnly = true;
            clmTemporada.Width = 125;
            // 
            // clmAa
            // 
            clmAa.HeaderText = "Aa";
            clmAa.MinimumWidth = 6;
            clmAa.Name = "clmAa";
            clmAa.ReadOnly = true;
            clmAa.Width = 125;
            // 
            // clmSexo
            // 
            clmSexo.HeaderText = "Sexo";
            clmSexo.MinimumWidth = 6;
            clmSexo.Name = "clmSexo";
            clmSexo.ReadOnly = true;
            clmSexo.Width = 50;
            // 
            // clmRubro
            // 
            clmRubro.HeaderText = "Rubro";
            clmRubro.MinimumWidth = 6;
            clmRubro.Name = "clmRubro";
            clmRubro.ReadOnly = true;
            clmRubro.Width = 125;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.MinimumWidth = 6;
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 125;
            // 
            // clmPrecioCosto
            // 
            clmPrecioCosto.HeaderText = "Costo";
            clmPrecioCosto.MinimumWidth = 6;
            clmPrecioCosto.Name = "clmPrecioCosto";
            clmPrecioCosto.ReadOnly = true;
            clmPrecioCosto.Width = 125;
            // 
            // clmMenor
            // 
            clmMenor.HeaderText = "Precio X menor";
            clmMenor.MinimumWidth = 6;
            clmMenor.Name = "clmMenor";
            clmMenor.ReadOnly = true;
            clmMenor.Width = 125;
            // 
            // clmMayor
            // 
            clmMayor.HeaderText = "Precio X mayor";
            clmMayor.MinimumWidth = 6;
            clmMayor.Name = "clmMayor";
            clmMayor.ReadOnly = true;
            clmMayor.Width = 125;
            // 
            // clmArtViejo
            // 
            clmArtViejo.HeaderText = "Artículo viejo";
            clmArtViejo.MinimumWidth = 6;
            clmArtViejo.Name = "clmArtViejo";
            clmArtViejo.ReadOnly = true;
            clmArtViejo.Width = 125;
            // 
            // clmPromocion
            // 
            clmPromocion.HeaderText = "Promoción";
            clmPromocion.MinimumWidth = 6;
            clmPromocion.Name = "clmPromocion";
            clmPromocion.ReadOnly = true;
            clmPromocion.Width = 85;
            // 
            // clmEstado
            // 
            clmEstado.HeaderText = "Estado";
            clmEstado.MinimumWidth = 6;
            clmEstado.Name = "clmEstado";
            clmEstado.ReadOnly = true;
            clmEstado.Width = 80;
            // 
            // frmVerArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 512);
            Controls.Add(dataGridView1);
            Controls.Add(gpbBuscarArticuloVer);
            Name = "frmVerArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Artículos";
            gpbBuscarArticuloVer.ResumeLayout(false);
            gpbBuscarArticuloVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbBuscarArticuloVer;
        private Label lblArticuloVer;
        private Button btnBuscarVer;
        private TextBox txtArticuloVer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmArticulo;
        private DataGridViewTextBoxColumn clmMarca;
        private DataGridViewTextBoxColumn clmTemporada;
        private DataGridViewTextBoxColumn clmAa;
        private DataGridViewTextBoxColumn clmSexo;
        private DataGridViewTextBoxColumn clmRubro;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmPrecioCosto;
        private DataGridViewTextBoxColumn clmMenor;
        private DataGridViewTextBoxColumn clmMayor;
        private DataGridViewTextBoxColumn clmArtViejo;
        private DataGridViewTextBoxColumn clmPromocion;
        private DataGridViewTextBoxColumn clmEstado;
    }
}