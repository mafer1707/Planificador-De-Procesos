namespace PlanificadorDeProcesos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnl_Algoritmos = new Panel();
            lbl_Expulsivos = new Label();
            lbl_NoExpulsivos = new Label();
            label1 = new Label();
            rb_PrioridadesExpulsivo = new RadioButton();
            rb_SRTF = new RadioButton();
            rb_RoundRobin = new RadioButton();
            rb_Prioridades = new RadioButton();
            rb_SeleccionAleatoria = new RadioButton();
            rb_SJF = new RadioButton();
            rb_FCFS = new RadioButton();
            pnl_Generador = new Panel();
            btn_Limpiar = new Button();
            btn_Generar = new Button();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            cb_Tick = new ComboBox();
            label13 = new Label();
            np_Cantidad = new NumericUpDown();
            label12 = new Label();
            label9 = new Label();
            np_MaxPrioridad = new NumericUpDown();
            label10 = new Label();
            np_MinPrioridad = new NumericUpDown();
            label11 = new Label();
            label6 = new Label();
            np_MaxIOBurstTime = new NumericUpDown();
            label7 = new Label();
            np_MinIOBurstTime = new NumericUpDown();
            label8 = new Label();
            label5 = new Label();
            np_MaxBurstTime = new NumericUpDown();
            label4 = new Label();
            np_MinBurstTime = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            pnl_Estadisticas = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            Grid_EnEspera = new DataGridView();
            Grid_Bloqueados = new DataGridView();
            Grid_Terminados = new DataGridView();
            toolTip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnl_Algoritmos.SuspendLayout();
            pnl_Generador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_EnEspera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.10577F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.89423F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(2080, 1105);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(pnl_Algoritmos, 0, 0);
            tableLayoutPanel2.Controls.Add(pnl_Generador, 0, 1);
            tableLayoutPanel2.Controls.Add(pnl_Estadisticas, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.2101917F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.67516F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.1146488F));
            tableLayoutPanel2.Size = new Size(953, 1099);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnl_Algoritmos
            // 
            pnl_Algoritmos.Controls.Add(lbl_Expulsivos);
            pnl_Algoritmos.Controls.Add(lbl_NoExpulsivos);
            pnl_Algoritmos.Controls.Add(label1);
            pnl_Algoritmos.Controls.Add(rb_PrioridadesExpulsivo);
            pnl_Algoritmos.Controls.Add(rb_SRTF);
            pnl_Algoritmos.Controls.Add(rb_RoundRobin);
            pnl_Algoritmos.Controls.Add(rb_Prioridades);
            pnl_Algoritmos.Controls.Add(rb_SeleccionAleatoria);
            pnl_Algoritmos.Controls.Add(rb_SJF);
            pnl_Algoritmos.Controls.Add(rb_FCFS);
            pnl_Algoritmos.Dock = DockStyle.Fill;
            pnl_Algoritmos.Location = new Point(3, 3);
            pnl_Algoritmos.Name = "pnl_Algoritmos";
            pnl_Algoritmos.Size = new Size(947, 337);
            pnl_Algoritmos.TabIndex = 0;
            // 
            // lbl_Expulsivos
            // 
            lbl_Expulsivos.AutoSize = true;
            lbl_Expulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Expulsivos.ForeColor = Color.RoyalBlue;
            lbl_Expulsivos.Location = new Point(522, 83);
            lbl_Expulsivos.Name = "lbl_Expulsivos";
            lbl_Expulsivos.Size = new Size(137, 30);
            lbl_Expulsivos.TabIndex = 13;
            lbl_Expulsivos.Text = "Expulsivos:";
            // 
            // lbl_NoExpulsivos
            // 
            lbl_NoExpulsivos.AutoSize = true;
            lbl_NoExpulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NoExpulsivos.ForeColor = Color.RoyalBlue;
            lbl_NoExpulsivos.Location = new Point(31, 83);
            lbl_NoExpulsivos.Name = "lbl_NoExpulsivos";
            lbl_NoExpulsivos.Size = new Size(175, 30);
            lbl_NoExpulsivos.TabIndex = 12;
            lbl_NoExpulsivos.Text = "No expulsivos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(225, 13);
            label1.Name = "label1";
            label1.Size = new Size(434, 45);
            label1.TabIndex = 11;
            label1.Text = "Algoritmos de planificación";
            // 
            // rb_PrioridadesExpulsivo
            // 
            rb_PrioridadesExpulsivo.AutoSize = true;
            rb_PrioridadesExpulsivo.Location = new Point(522, 231);
            rb_PrioridadesExpulsivo.Name = "rb_PrioridadesExpulsivo";
            rb_PrioridadesExpulsivo.Size = new Size(315, 29);
            rb_PrioridadesExpulsivo.TabIndex = 10;
            rb_PrioridadesExpulsivo.TabStop = true;
            rb_PrioridadesExpulsivo.Text = "Planificacion basada en prioridades";
            rb_PrioridadesExpulsivo.UseVisualStyleBackColor = true;
            // 
            // rb_SRTF
            // 
            rb_SRTF.AutoSize = true;
            rb_SRTF.Location = new Point(522, 179);
            rb_SRTF.Name = "rb_SRTF";
            rb_SRTF.Size = new Size(382, 29);
            rb_SRTF.TabIndex = 9;
            rb_SRTF.TabStop = true;
            rb_SRTF.Text = "Primero el de menor tiempo restante (SRTF)";
            rb_SRTF.UseVisualStyleBackColor = true;
            // 
            // rb_RoundRobin
            // 
            rb_RoundRobin.AutoSize = true;
            rb_RoundRobin.Location = new Point(522, 127);
            rb_RoundRobin.Name = "rb_RoundRobin";
            rb_RoundRobin.Size = new Size(272, 29);
            rb_RoundRobin.TabIndex = 8;
            rb_RoundRobin.TabStop = true;
            rb_RoundRobin.Text = "Turno Rotativo (Round Robin)";
            rb_RoundRobin.UseVisualStyleBackColor = true;
            // 
            // rb_Prioridades
            // 
            rb_Prioridades.AutoSize = true;
            rb_Prioridades.Location = new Point(31, 283);
            rb_Prioridades.Name = "rb_Prioridades";
            rb_Prioridades.Size = new Size(315, 29);
            rb_Prioridades.TabIndex = 7;
            rb_Prioridades.TabStop = true;
            rb_Prioridades.Text = "Planificación basada en prioridades";
            rb_Prioridades.UseVisualStyleBackColor = true;
            // 
            // rb_SeleccionAleatoria
            // 
            rb_SeleccionAleatoria.AutoSize = true;
            rb_SeleccionAleatoria.Location = new Point(31, 231);
            rb_SeleccionAleatoria.Name = "rb_SeleccionAleatoria";
            rb_SeleccionAleatoria.Size = new Size(185, 29);
            rb_SeleccionAleatoria.TabIndex = 6;
            rb_SeleccionAleatoria.TabStop = true;
            rb_SeleccionAleatoria.Text = "Seleccion Aleatoria";
            rb_SeleccionAleatoria.UseVisualStyleBackColor = true;
            // 
            // rb_SJF
            // 
            rb_SJF.AutoSize = true;
            rb_SJF.Location = new Point(31, 179);
            rb_SJF.Name = "rb_SJF";
            rb_SJF.Size = new Size(303, 29);
            rb_SJF.TabIndex = 5;
            rb_SJF.TabStop = true;
            rb_SJF.Text = "Primero el trabajo más corto (SJF)";
            rb_SJF.UseVisualStyleBackColor = true;
            // 
            // rb_FCFS
            // 
            rb_FCFS.AutoSize = true;
            rb_FCFS.Location = new Point(31, 127);
            rb_FCFS.Name = "rb_FCFS";
            rb_FCFS.Size = new Size(400, 29);
            rb_FCFS.TabIndex = 4;
            rb_FCFS.TabStop = true;
            rb_FCFS.Text = "Primero en llegar primero en ejecutarse (FCFS)";
            rb_FCFS.UseVisualStyleBackColor = true;
            // 
            // pnl_Generador
            // 
            pnl_Generador.Controls.Add(btn_Limpiar);
            pnl_Generador.Controls.Add(btn_Generar);
            pnl_Generador.Controls.Add(numericUpDown1);
            pnl_Generador.Controls.Add(label14);
            pnl_Generador.Controls.Add(cb_Tick);
            pnl_Generador.Controls.Add(label13);
            pnl_Generador.Controls.Add(np_Cantidad);
            pnl_Generador.Controls.Add(label12);
            pnl_Generador.Controls.Add(label9);
            pnl_Generador.Controls.Add(np_MaxPrioridad);
            pnl_Generador.Controls.Add(label10);
            pnl_Generador.Controls.Add(np_MinPrioridad);
            pnl_Generador.Controls.Add(label11);
            pnl_Generador.Controls.Add(label6);
            pnl_Generador.Controls.Add(np_MaxIOBurstTime);
            pnl_Generador.Controls.Add(label7);
            pnl_Generador.Controls.Add(np_MinIOBurstTime);
            pnl_Generador.Controls.Add(label8);
            pnl_Generador.Controls.Add(label5);
            pnl_Generador.Controls.Add(np_MaxBurstTime);
            pnl_Generador.Controls.Add(label4);
            pnl_Generador.Controls.Add(np_MinBurstTime);
            pnl_Generador.Controls.Add(label3);
            pnl_Generador.Controls.Add(label2);
            pnl_Generador.Dock = DockStyle.Fill;
            pnl_Generador.Location = new Point(3, 346);
            pnl_Generador.Name = "pnl_Generador";
            pnl_Generador.Size = new Size(947, 463);
            pnl_Generador.TabIndex = 1;
            pnl_Generador.Paint += pnl_Generador_Paint;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(202, 408);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 34);
            btn_Limpiar.TabIndex = 35;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Generar
            // 
            btn_Generar.Location = new Point(21, 408);
            btn_Generar.Name = "btn_Generar";
            btn_Generar.Size = new Size(112, 34);
            btn_Generar.TabIndex = 34;
            btn_Generar.Text = "Generar";
            btn_Generar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(504, 327);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 31);
            numericUpDown1.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(504, 289);
            label14.Name = "label14";
            label14.Size = new Size(177, 25);
            label14.TabIndex = 32;
            label14.Text = "Tiempo de llegada";
            // 
            // cb_Tick
            // 
            cb_Tick.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Tick.FormattingEnabled = true;
            cb_Tick.Location = new Point(504, 220);
            cb_Tick.Name = "cb_Tick";
            cb_Tick.Size = new Size(198, 33);
            cb_Tick.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(504, 183);
            label13.Name = "label13";
            label13.Size = new Size(151, 25);
            label13.TabIndex = 30;
            label13.Text = "Tiempo del tick";
            // 
            // np_Cantidad
            // 
            np_Cantidad.Location = new Point(504, 113);
            np_Cantidad.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            np_Cantidad.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            np_Cantidad.Name = "np_Cantidad";
            np_Cantidad.Size = new Size(90, 31);
            np_Cantidad.TabIndex = 29;
            np_Cantidad.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(504, 75);
            label12.Name = "label12";
            label12.Size = new Size(292, 25);
            label12.TabIndex = 28;
            label12.Text = "Cantidad de procesos a generar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 330);
            label9.Name = "label9";
            label9.Size = new Size(49, 25);
            label9.TabIndex = 27;
            label9.Text = "Max.";
            // 
            // np_MaxPrioridad
            // 
            np_MaxPrioridad.Location = new Point(257, 327);
            np_MaxPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxPrioridad.Name = "np_MaxPrioridad";
            np_MaxPrioridad.Size = new Size(90, 31);
            np_MaxPrioridad.TabIndex = 26;
            toolTip.SetToolTip(np_MaxPrioridad, "Max");
            np_MaxPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 330);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 25;
            label10.Text = "Min.";
            // 
            // np_MinPrioridad
            // 
            np_MinPrioridad.Location = new Point(76, 327);
            np_MinPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinPrioridad.Name = "np_MinPrioridad";
            np_MinPrioridad.Size = new Size(90, 31);
            np_MinPrioridad.TabIndex = 24;
            toolTip.SetToolTip(np_MinPrioridad, "MIn");
            np_MinPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(21, 289);
            label11.Name = "label11";
            label11.Size = new Size(97, 25);
            label11.TabIndex = 23;
            label11.Text = "Prioridad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 224);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 22;
            label6.Text = "Max.";
            // 
            // np_MaxIOBurstTime
            // 
            np_MaxIOBurstTime.Location = new Point(257, 221);
            np_MaxIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxIOBurstTime.Name = "np_MaxIOBurstTime";
            np_MaxIOBurstTime.Size = new Size(90, 31);
            np_MaxIOBurstTime.TabIndex = 21;
            toolTip.SetToolTip(np_MaxIOBurstTime, "Max");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 224);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 20;
            label7.Text = "Min.";
            // 
            // np_MinIOBurstTime
            // 
            np_MinIOBurstTime.Location = new Point(76, 221);
            np_MinIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinIOBurstTime.Name = "np_MinIOBurstTime";
            np_MinIOBurstTime.Size = new Size(90, 31);
            np_MinIOBurstTime.TabIndex = 19;
            toolTip.SetToolTip(np_MinIOBurstTime, "MIn");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(21, 183);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 18;
            label8.Text = "I/O Burst Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 116);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 17;
            label5.Text = "Max.";
            // 
            // np_MaxBurstTime
            // 
            np_MaxBurstTime.Location = new Point(257, 113);
            np_MaxBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxBurstTime.Name = "np_MaxBurstTime";
            np_MaxBurstTime.Size = new Size(90, 31);
            np_MaxBurstTime.TabIndex = 16;
            toolTip.SetToolTip(np_MaxBurstTime, "Max");
            np_MaxBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 116);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 15;
            label4.Text = "Min.";
            // 
            // np_MinBurstTime
            // 
            np_MinBurstTime.Location = new Point(76, 113);
            np_MinBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinBurstTime.Name = "np_MinBurstTime";
            np_MinBurstTime.Size = new Size(90, 31);
            np_MinBurstTime.TabIndex = 14;
            toolTip.SetToolTip(np_MinBurstTime, "Min");
            np_MinBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(21, 75);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 13;
            label3.Text = "Burst Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(237, 10);
            label2.Name = "label2";
            label2.Size = new Size(411, 45);
            label2.TabIndex = 12;
            label2.Text = "Parámetros del generador";
            // 
            // pnl_Estadisticas
            // 
            pnl_Estadisticas.Dock = DockStyle.Fill;
            pnl_Estadisticas.Location = new Point(3, 815);
            pnl_Estadisticas.Name = "pnl_Estadisticas";
            pnl_Estadisticas.Size = new Size(947, 281);
            pnl_Estadisticas.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(Grid_EnEspera, 0, 0);
            tableLayoutPanel3.Controls.Add(Grid_Bloqueados, 0, 1);
            tableLayoutPanel3.Controls.Add(Grid_Terminados, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(962, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(1115, 1099);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Grid_EnEspera
            // 
            Grid_EnEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_EnEspera.Dock = DockStyle.Fill;
            Grid_EnEspera.Location = new Point(3, 3);
            Grid_EnEspera.Name = "Grid_EnEspera";
            Grid_EnEspera.RowHeadersWidth = 62;
            Grid_EnEspera.Size = new Size(1109, 360);
            Grid_EnEspera.TabIndex = 0;
            // 
            // Grid_Bloqueados
            // 
            Grid_Bloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Bloqueados.Dock = DockStyle.Fill;
            Grid_Bloqueados.Location = new Point(3, 369);
            Grid_Bloqueados.Name = "Grid_Bloqueados";
            Grid_Bloqueados.RowHeadersWidth = 62;
            Grid_Bloqueados.Size = new Size(1109, 360);
            Grid_Bloqueados.TabIndex = 1;
            // 
            // Grid_Terminados
            // 
            Grid_Terminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Terminados.Dock = DockStyle.Fill;
            Grid_Terminados.Location = new Point(3, 735);
            Grid_Terminados.Name = "Grid_Terminados";
            Grid_Terminados.RowHeadersWidth = 62;
            Grid_Terminados.Size = new Size(1109, 361);
            Grid_Terminados.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2080, 1105);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Planificador de procesos";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnl_Algoritmos.ResumeLayout(false);
            pnl_Algoritmos.PerformLayout();
            pnl_Generador.ResumeLayout(false);
            pnl_Generador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_EnEspera).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnl_Algoritmos;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView Grid_EnEspera;
        private DataGridView Grid_Bloqueados;
        private DataGridView Grid_Terminados;
        private RadioButton rb_SRTF;
        private RadioButton rb_RoundRobin;
        private RadioButton rb_Prioridades;
        private RadioButton rb_SeleccionAleatoria;
        private RadioButton rb_SJF;
        private RadioButton rb_FCFS;
        private Label label1;
        private RadioButton rb_PrioridadesExpulsivo;
        private Label lbl_Expulsivos;
        private Label lbl_NoExpulsivos;
        private Panel pnl_Generador;
        private Label label2;
        private Panel pnl_Estadisticas;
        private Label label4;
        private NumericUpDown np_MinBurstTime;
        private Label label3;
        private Label label6;
        private NumericUpDown np_MaxIOBurstTime;
        private Label label7;
        private NumericUpDown np_MinIOBurstTime;
        private Label label8;
        private Label label5;
        private NumericUpDown np_MaxBurstTime;
        private Label label9;
        private NumericUpDown np_MaxPrioridad;
        private Label label10;
        private NumericUpDown np_MinPrioridad;
        private Label label11;
        private NumericUpDown np_Cantidad;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Label label14;
        private ComboBox cb_Tick;
        private Label label13;
        private Button btn_Limpiar;
        private Button btn_Generar;
        private ToolTip toolTip;
    }
}
