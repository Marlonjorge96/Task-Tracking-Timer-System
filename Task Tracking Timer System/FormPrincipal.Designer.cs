namespace Task_Tracking_Timer_System
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.LISTA = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipotareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new Task_Tracking_Timer_System.sistemaDataSet();
            this.tareasTableAdapter = new Task_Tracking_Timer_System.sistemaDataSetTableAdapters.tareasTableAdapter();
            this.agregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.busca = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LISTA
            // 
            this.LISTA.AutoSize = true;
            this.LISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTA.Location = new System.Drawing.Point(182, 107);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(401, 20);
            this.LISTA.TabIndex = 0;
            this.LISTA.Text = "LISTA DE TAREAS A SELECIONAR POR USUARIOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtarea,
            this.tipotareaDataGridViewTextBoxColumn,
            this.codtareaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tareasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // idtarea
            // 
            this.idtarea.DataPropertyName = "idtarea";
            this.idtarea.HeaderText = "idtarea";
            this.idtarea.Name = "idtarea";
            this.idtarea.ReadOnly = true;
            // 
            // tipotareaDataGridViewTextBoxColumn
            // 
            this.tipotareaDataGridViewTextBoxColumn.DataPropertyName = "tipo_tarea";
            this.tipotareaDataGridViewTextBoxColumn.HeaderText = "tipo_tarea";
            this.tipotareaDataGridViewTextBoxColumn.Name = "tipotareaDataGridViewTextBoxColumn";
            // 
            // codtareaDataGridViewTextBoxColumn
            // 
            this.codtareaDataGridViewTextBoxColumn.DataPropertyName = "codtarea";
            this.codtareaDataGridViewTextBoxColumn.HeaderText = "codtarea";
            this.codtareaDataGridViewTextBoxColumn.Name = "codtareaDataGridViewTextBoxColumn";
            // 
            // tareasBindingSource
            // 
            this.tareasBindingSource.DataMember = "tareas";
            this.tareasBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(128, 163);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 6;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(128, 192);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(419, 193);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 8;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // busca
            // 
            this.busca.Location = new System.Drawing.Point(500, 194);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(100, 20);
            this.busca.TabIndex = 9;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(614, 32);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LISTA);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LISTA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private sistemaDataSetTableAdapters.tareasTableAdapter tareasTableAdapter;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipotareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox busca;
        private System.Windows.Forms.Button Salir;
    }
}