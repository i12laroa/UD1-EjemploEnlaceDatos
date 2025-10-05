namespace UD1_EjemploEnlaceDatos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreCiudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionCiudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisCiudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJEMPLOS ENLACES DE DATOS";
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(143, 102);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(180, 24);
            this.cmbCiudades.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudades";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AutoGenerateColumns = false;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCiudadDataGridViewTextBoxColumn,
            this.poblacionCiudadDataGridViewTextBoxColumn,
            this.paisCiudadDataGridViewTextBoxColumn});
            this.dgvCiudades.DataSource = this.ciudadBindingSource;
            this.dgvCiudades.Location = new System.Drawing.Point(154, 149);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.RowHeadersWidth = 51;
            this.dgvCiudades.RowTemplate.Height = 24;
            this.dgvCiudades.Size = new System.Drawing.Size(647, 150);
            this.dgvCiudades.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(154, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Añadir Lucena";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(367, 337);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(166, 47);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "Quitar Sevilla";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataSource = typeof(UD1_EjemploEnlaceDatos.Ciudad);
            // 
            // nombreCiudadDataGridViewTextBoxColumn
            // 
            this.nombreCiudadDataGridViewTextBoxColumn.DataPropertyName = "NombreCiudad";
            this.nombreCiudadDataGridViewTextBoxColumn.HeaderText = "NombreCiudad";
            this.nombreCiudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCiudadDataGridViewTextBoxColumn.Name = "nombreCiudadDataGridViewTextBoxColumn";
            this.nombreCiudadDataGridViewTextBoxColumn.Width = 125;
            // 
            // poblacionCiudadDataGridViewTextBoxColumn
            // 
            this.poblacionCiudadDataGridViewTextBoxColumn.DataPropertyName = "PoblacionCiudad";
            this.poblacionCiudadDataGridViewTextBoxColumn.HeaderText = "PoblacionCiudad";
            this.poblacionCiudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poblacionCiudadDataGridViewTextBoxColumn.Name = "poblacionCiudadDataGridViewTextBoxColumn";
            this.poblacionCiudadDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisCiudadDataGridViewTextBoxColumn
            // 
            this.paisCiudadDataGridViewTextBoxColumn.DataPropertyName = "PaisCiudad";
            this.paisCiudadDataGridViewTextBoxColumn.HeaderText = "PaisCiudad";
            this.paisCiudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paisCiudadDataGridViewTextBoxColumn.Name = "paisCiudadDataGridViewTextBoxColumn";
            this.paisCiudadDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 554);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudades);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCiudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionCiudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisCiudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ciudadBindingSource;
    }
}

