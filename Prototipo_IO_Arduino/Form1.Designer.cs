namespace Prototipo_IO_Arduino
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metrocmbPuertos = new MetroFramework.Controls.MetroComboBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.chartHumedad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lstSalidaPrediccion = new System.Windows.Forms.ListBox();
            this.timerDesencolar = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lstExportados = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerEncolador = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbEstados = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerActualizacion = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumedad)).BeginInit();
            this.gbValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.metrocmbPuertos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(27, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexion Serial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar arduino";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metrocmbPuertos
            // 
            this.metrocmbPuertos.FormattingEnabled = true;
            this.metrocmbPuertos.ItemHeight = 24;
            this.metrocmbPuertos.Location = new System.Drawing.Point(297, 55);
            this.metrocmbPuertos.Name = "metrocmbPuertos";
            this.metrocmbPuertos.Size = new System.Drawing.Size(121, 30);
            this.metrocmbPuertos.TabIndex = 33;
            this.metrocmbPuertos.UseSelectable = true;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTemperatura.Location = new System.Drawing.Point(238, 340);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(145, 34);
            this.txtTemperatura.TabIndex = 17;
            // 
            // txtHumedad
            // 
            this.txtHumedad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtHumedad.Location = new System.Drawing.Point(739, 340);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(145, 34);
            this.txtHumedad.TabIndex = 18;
            // 
            // chartHumedad
            // 
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MinorTickMark.Enabled = true;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "%";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.chartHumedad.ChartAreas.Add(chartArea3);
            this.chartHumedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartHumedad.Legends.Add(legend3);
            this.chartHumedad.Location = new System.Drawing.Point(527, 38);
            this.chartHumedad.Name = "chartHumedad";
            this.chartHumedad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "temperatura";
            series3.SmartLabelStyle.CalloutLineWidth = 5;
            series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartHumedad.Series.Add(series3);
            this.chartHumedad.Size = new System.Drawing.Size(472, 270);
            this.chartHumedad.TabIndex = 19;
            this.chartHumedad.Text = "chartHumedad";
            title5.Name = "Title1";
            title6.Name = "Title2";
            this.chartHumedad.Titles.Add(title5);
            this.chartHumedad.Titles.Add(title6);
            // 
            // lstSalidaPrediccion
            // 
            this.lstSalidaPrediccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSalidaPrediccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSalidaPrediccion.FormattingEnabled = true;
            this.lstSalidaPrediccion.ItemHeight = 28;
            this.lstSalidaPrediccion.Location = new System.Drawing.Point(616, 497);
            this.lstSalidaPrediccion.MultiColumn = true;
            this.lstSalidaPrediccion.Name = "lstSalidaPrediccion";
            this.lstSalidaPrediccion.Size = new System.Drawing.Size(850, 58);
            this.lstSalidaPrediccion.TabIndex = 24;
            // 
            // timerDesencolar
            // 
            this.timerDesencolar.Enabled = true;
            this.timerDesencolar.Interval = 300000;
            this.timerDesencolar.Tick += new System.EventHandler(this.timerDesencolar_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(962, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Dato en proceso";
            // 
            // lstExportados
            // 
            this.lstExportados.Enabled = false;
            this.lstExportados.FormattingEnabled = true;
            this.lstExportados.ItemHeight = 16;
            this.lstExportados.Location = new System.Drawing.Point(11, 571);
            this.lstExportados.Name = "lstExportados";
            this.lstExportados.Size = new System.Drawing.Size(30, 116);
            this.lstExportados.TabIndex = 30;
            this.lstExportados.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportar.Location = new System.Drawing.Point(48, 282);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(130, 68);
            this.btnExportar.TabIndex = 31;
            this.btnExportar.Text = "Carpeta a exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // gbValores
            // 
            this.gbValores.AutoSize = true;
            this.gbValores.Controls.Add(this.label3);
            this.gbValores.Controls.Add(this.label2);
            this.gbValores.Controls.Add(this.chartTemperatura);
            this.gbValores.Controls.Add(this.txtTemperatura);
            this.gbValores.Controls.Add(this.txtHumedad);
            this.gbValores.Controls.Add(this.chartHumedad);
            this.gbValores.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gbValores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbValores.Location = new System.Drawing.Point(507, 27);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(1030, 425);
            this.gbValores.TabIndex = 32;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Valores del invernadero";
            this.gbValores.Enter += new System.EventHandler(this.gbValores_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(690, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Humedad relativa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(206, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Temperatura";
            // 
            // chartTemperatura
            // 
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.Maximum = 40D;
            chartArea4.AxisY.Minimum = 20D;
            chartArea4.AxisY.MinorTickMark.Enabled = true;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "C°";
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.Name = "ChartArea1";
            this.chartTemperatura.ChartAreas.Add(chartArea4);
            this.chartTemperatura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartTemperatura.Legends.Add(legend4);
            this.chartTemperatura.Location = new System.Drawing.Point(32, 38);
            this.chartTemperatura.Name = "chartTemperatura";
            this.chartTemperatura.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartTemperatura.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "temperatura";
            series4.SmartLabelStyle.CalloutLineWidth = 5;
            series4.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartTemperatura.Series.Add(series4);
            this.chartTemperatura.Size = new System.Drawing.Size(489, 270);
            this.chartTemperatura.TabIndex = 20;
            this.chartTemperatura.Text = "chart1";
            title7.Name = "Title1";
            title8.Name = "Title2";
            this.chartTemperatura.Titles.Add(title7);
            this.chartTemperatura.Titles.Add(title8);
            // 
            // timerEncolador
            // 
            this.timerEncolador.Interval = 240000;
            this.timerEncolador.Tick += new System.EventHandler(this.timerEncolador_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(178, 631);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 28);
            this.lblMensaje.TabIndex = 33;
            // 
            // pbEstados
            // 
            this.pbEstados.Location = new System.Drawing.Point(207, 481);
            this.pbEstados.Name = "pbEstados";
            this.pbEstados.Size = new System.Drawing.Size(119, 114);
            this.pbEstados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstados.TabIndex = 35;
            this.pbEstados.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // timerActualizacion
            // 
            this.timerActualizacion.Enabled = true;
            this.timerActualizacion.Interval = 240099;
            this.timerActualizacion.Tick += new System.EventHandler(this.timerActualizacion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1622, 699);
            this.Controls.Add(this.pbEstados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lstExportados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSalidaPrediccion);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Panel de control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumedad)).EndInit();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumedad;
        private System.Windows.Forms.ListBox lstSalidaPrediccion;
        private System.Windows.Forms.Timer timerDesencolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstExportados;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.Timer timerEncolador;
        private MetroFramework.Controls.MetroComboBox metrocmbPuertos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbEstados;
        private System.Windows.Forms.Timer timerActualizacion;
    }
}

