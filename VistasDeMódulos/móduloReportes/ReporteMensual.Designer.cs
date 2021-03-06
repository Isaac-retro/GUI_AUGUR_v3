﻿namespace GUI_AUGUR_V3.VistasDeMódulos.móduloReportes
{
    partial class ReporteMensual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.platoVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTit = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPlatosComprados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(443, 390);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(171, 85);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "Salir";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ventas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.cedulaCliente,
            this.cantidadPlatosComprados});
            this.dataGridView2.Location = new System.Drawing.Point(714, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(311, 189);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platoVendido,
            this.precioPlato,
            this.cantidadPlato});
            this.dataGridView1.Location = new System.Drawing.Point(73, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 189);
            this.dataGridView1.TabIndex = 20;
            // 
            // platoVendido
            // 
            this.platoVendido.Frozen = true;
            this.platoVendido.HeaderText = "Plato de comida";
            this.platoVendido.Name = "platoVendido";
            this.platoVendido.ReadOnly = true;
            // 
            // precioPlato
            // 
            this.precioPlato.Frozen = true;
            this.precioPlato.HeaderText = "Precio";
            this.precioPlato.Name = "precioPlato";
            this.precioPlato.ReadOnly = true;
            // 
            // cantidadPlato
            // 
            this.cantidadPlato.Frozen = true;
            this.cantidadPlato.HeaderText = "cantidad";
            this.cantidadPlato.Name = "cantidadPlato";
            this.cantidadPlato.ReadOnly = true;
            // 
            // labelTit
            // 
            this.labelTit.AutoSize = true;
            this.labelTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTit.Location = new System.Drawing.Point(383, 56);
            this.labelTit.Name = "labelTit";
            this.labelTit.Size = new System.Drawing.Size(231, 36);
            this.labelTit.TabIndex = 19;
            this.labelTit.Text = "Reporte del mes";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Frozen = true;
            this.nombreCliente.HeaderText = "Nombre del cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            // 
            // cedulaCliente
            // 
            this.cedulaCliente.Frozen = true;
            this.cedulaCliente.HeaderText = "Cédula del cliente";
            this.cedulaCliente.Name = "cedulaCliente";
            this.cedulaCliente.ReadOnly = true;
            // 
            // cantidadPlatosComprados
            // 
            this.cantidadPlatosComprados.Frozen = true;
            this.cantidadPlatosComprados.HeaderText = "Cantidad de Compras";
            this.cantidadPlatosComprados.Name = "cantidadPlatosComprados";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(374, 152);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(334, 217);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // ReporteMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 548);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTit);
            this.Name = "ReporteMensual";
            this.Text = "ReporteMensual";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn platoVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPlato;
        private System.Windows.Forms.Label labelTit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPlatosComprados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}