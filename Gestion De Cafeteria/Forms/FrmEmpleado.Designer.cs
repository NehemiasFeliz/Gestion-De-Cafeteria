﻿namespace Gestion_De_Cafeteria
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empleadoGridView = new System.Windows.Forms.DataGridView();
            this.idEMpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.gestionCafeteriaDataSet = new Gestion_De_Cafeteria.GestionCafeteriaDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.gestionCafeteriaDataSet)).BeginInit();
          //  this.SuspendLayout();
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(641, 38);
            this.CmdAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(100, 59);
            this.CmdAgregar.TabIndex = 3;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            //this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.Location = new System.Drawing.Point(533, 38);
            this.CmdBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(100, 59);
            this.CmdBuscar.TabIndex = 2;
            this.CmdBuscar.Text = "Buscar";
            this.CmdBuscar.UseVisualStyleBackColor = true;
            //this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(97, 56);
            this.txtBuscarPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(199, 22);
            this.txtBuscarPor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmdAgregar);
            this.groupBox1.Controls.Add(this.txtBuscarPor);
            this.groupBox1.Location = new System.Drawing.Point(57, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // empleadoGridView
            // 
            this.empleadoGridView.AllowUserToAddRows = false;
            this.empleadoGridView.AllowUserToDeleteRows = false;
            this.empleadoGridView.AutoGenerateColumns = false;
            this.empleadoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEMpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
            this.empleadoGridView.DataSource = this.empleadoBindingSource;
            this.empleadoGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.empleadoGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.empleadoGridView.Location = new System.Drawing.Point(67, 202);
            this.empleadoGridView.Name = "empleadoGridView";
            this.empleadoGridView.ReadOnly = true;
            this.empleadoGridView.RowHeadersWidth = 51;
            this.empleadoGridView.RowTemplate.Height = 24;
            this.empleadoGridView.Size = new System.Drawing.Size(731, 247);
            this.empleadoGridView.TabIndex = 5;
            //this.empleadoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadoGridView_CellContentClick);
            //this.empleadoGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadoGridView_CellDoubleClick);
            //// 
            // idEMpleadoDataGridViewTextBoxColumn
            // 
            this.idEMpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEMpleado";
            this.idEMpleadoDataGridViewTextBoxColumn.HeaderText = "IdEMpleado";
            this.idEMpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEMpleadoDataGridViewTextBoxColumn.Name = "idEMpleadoDataGridViewTextBoxColumn";
            this.idEMpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEMpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            //this.empleadoBindingSource.DataSource = this.gestionCafeteriaDataSet;
            // 
            // gestionCafeteriaDataSet
            // 
            //this.gestionCafeteriaDataSet.DataSetName = "GestionCafeteriaDataSet";
            //this.gestionCafeteriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // empleadoTableAdapter
            // 
           // this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmpleado
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(863, 461);
            //this.Controls.Add(this.empleadoGridView);
            //this.Controls.Add(this.groupBox1);
            //this.Name = "FrmEmpleado";
            //this.Text = "FrmEmpleado";
            //this.Activated += new System.EventHandler(this.FrmEmpleado_Load);
            //this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.gestionCafeteriaDataSet)).EndInit();
           // this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView empleadoGridView;
        //private GestionCafeteriaDataSet gestionCafeteriaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
//        private DataSource.GestionCafeteriaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEMpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
    }
}