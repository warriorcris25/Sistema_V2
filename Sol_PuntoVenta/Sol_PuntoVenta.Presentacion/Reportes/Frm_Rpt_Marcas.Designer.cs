﻿namespace Sol_PuntoVenta.Presentacion.Reportes
{
    partial class Frm_Rpt_Marcas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_DatosMaestros = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestros();
            this.uSPListadomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_maTableAdapter = new Sol_PuntoVenta.Presentacion.Reportes.DataSet_DatosMaestrosTableAdapters.USP_Listado_maTableAdapter();
            this.Txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadomaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_PuntoVenta.Presentacion.Reportes.Rpt_Marcas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1945, 1318);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_DatosMaestros
            // 
            this.dataSet_DatosMaestros.DataSetName = "DataSet_DatosMaestros";
            this.dataSet_DatosMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadomaBindingSource
            // 
            this.uSPListadomaBindingSource.DataMember = "USP_Listado_ma";
            this.uSPListadomaBindingSource.DataSource = this.dataSet_DatosMaestros;
            // 
            // uSP_Listado_maTableAdapter
            // 
            this.uSP_Listado_maTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_p1
            // 
            this.Txt_p1.Location = new System.Drawing.Point(27, 60);
            this.Txt_p1.Name = "Txt_p1";
            this.Txt_p1.Size = new System.Drawing.Size(150, 22);
            this.Txt_p1.TabIndex = 3;
            this.Txt_p1.Visible = false;
            // 
            // Frm_Rpt_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1945, 1318);
            this.Controls.Add(this.Txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Marcas";
            this.Text = "Frm_Rpt_Marcas";
            this.Load += new System.EventHandler(this.Frm_Rpt_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadomaBindingSource;
        private DataSet_DatosMaestros dataSet_DatosMaestros;
        private DataSet_DatosMaestrosTableAdapters.USP_Listado_maTableAdapter uSP_Listado_maTableAdapter;
        internal System.Windows.Forms.TextBox Txt_p1;
    }
}