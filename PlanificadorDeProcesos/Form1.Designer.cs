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
            pnl_ProcesoActual = new Panel();
            lbl_Estado = new Label();
            label31 = new Label();
            lbl_TiempoEspera = new Label();
            label30 = new Label();
            lbl_TiempoIO = new Label();
            label29 = new Label();
            lbl_TiempoCPU = new Label();
            label28 = new Label();
            lbl_YaHizoIO = new Label();
            label27 = new Label();
            lbl_Prioridad = new Label();
            label26 = new Label();
            lbl_IOBurstTime = new Label();
            label25 = new Label();
            lbl_BurstTime = new Label();
            label23 = new Label();
            lbl_TiempoLlegada = new Label();
            label24 = new Label();
            lbl_ID = new Label();
            label22 = new Label();
            label20 = new Label();
            lbl_NoExpulsivos = new Label();
            label1 = new Label();
            rb_PrioridadesExpulsivo = new RadioButton();
            rb_SRTF = new RadioButton();
            rb_RoundRobin = new RadioButton();
            rb_PrioridadesNoExpulsivo = new RadioButton();
            rb_SeleccionAleatoria = new RadioButton();
            rb_SJF = new RadioButton();
            lbl_Expulsivos = new Label();
            rb_FCFS = new RadioButton();
            pnl_Generador = new Panel();
            pnl_Estadisticas = new Panel();
            btn_Reiniciar = new Button();
            btn_CambiarAlgoritmo = new Button();
            lbl_TiempoTotal = new Label();
            label16 = new Label();
            lbl_ProcesosPorPaso = new Label();
            label17 = new Label();
            lbl_ProcesosCompletados = new Label();
            label10 = new Label();
            lbl_TiempoPromEjecucion = new Label();
            label6 = new Label();
            lbl_TiempoPromBloqueo = new Label();
            label9 = new Label();
            lbl_TiempoPromEspera = new Label();
            label7 = new Label();
            lbl_UsoProcesador = new Label();
            label5 = new Label();
            label4 = new Label();
            np_Quantum = new NumericUpDown();
            lb_Quantum = new Label();
            np_MaxTiempoLlegada = new NumericUpDown();
            btn_Limpiar = new Button();
            btn_Simular = new Button();
            np_MinTiempoLlegada = new NumericUpDown();
            lb_TiempoLlegada = new Label();
            cmb_Tick = new ComboBox();
            lb_TiempoTick = new Label();
            np_Cantidad = new NumericUpDown();
            lb_Cantidad = new Label();
            np_MaxPrioridad = new NumericUpDown();
            np_MinPrioridad = new NumericUpDown();
            lb_Prioridad = new Label();
            np_MaxIOBurstTime = new NumericUpDown();
            np_MinIOBurstTime = new NumericUpDown();
            lb_BurstTimeIO = new Label();
            np_MaxBurstTime = new NumericUpDown();
            np_MinBurstTime = new NumericUpDown();
            lb_BurstTime = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            Grid_Bloqueados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            TiempoRestanteCPUBloqueo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            PrioridadBloqueados = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label18 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            Grid_Nuevos = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            PrioridadNuevos = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label32 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            Grid_Listo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TiempoLlegada = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            TiempoRestanteCPU = new DataGridViewTextBoxColumn();
            IOBurstTime = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label15 = new Label();
            panel4 = new Panel();
            Grid_Terminados = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            PrioridadTerminados = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label19 = new Label();
            toolTip = new ToolTip(components);
            timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnl_Algoritmos.SuspendLayout();
            pnl_ProcesoActual.SuspendLayout();
            pnl_Generador.SuspendLayout();
            pnl_Estadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)np_Quantum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxTiempoLlegada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinTiempoLlegada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Nuevos).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Listo).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.3645134F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.6354866F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1959, 873);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnl_Algoritmos, 0, 0);
            tableLayoutPanel2.Controls.Add(pnl_Generador, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56.25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(921, 867);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnl_Algoritmos
            // 
            pnl_Algoritmos.BorderStyle = BorderStyle.FixedSingle;
            pnl_Algoritmos.Controls.Add(pnl_ProcesoActual);
            pnl_Algoritmos.Controls.Add(lbl_NoExpulsivos);
            pnl_Algoritmos.Controls.Add(label1);
            pnl_Algoritmos.Controls.Add(rb_PrioridadesExpulsivo);
            pnl_Algoritmos.Controls.Add(rb_SRTF);
            pnl_Algoritmos.Controls.Add(rb_RoundRobin);
            pnl_Algoritmos.Controls.Add(rb_PrioridadesNoExpulsivo);
            pnl_Algoritmos.Controls.Add(rb_SeleccionAleatoria);
            pnl_Algoritmos.Controls.Add(rb_SJF);
            pnl_Algoritmos.Controls.Add(lbl_Expulsivos);
            pnl_Algoritmos.Controls.Add(rb_FCFS);
            pnl_Algoritmos.Dock = DockStyle.Fill;
            pnl_Algoritmos.Location = new Point(3, 3);
            pnl_Algoritmos.Name = "pnl_Algoritmos";
            pnl_Algoritmos.Size = new Size(915, 373);
            pnl_Algoritmos.TabIndex = 0;
            // 
            // pnl_ProcesoActual
            // 
            pnl_ProcesoActual.Controls.Add(lbl_Estado);
            pnl_ProcesoActual.Controls.Add(label31);
            pnl_ProcesoActual.Controls.Add(lbl_TiempoEspera);
            pnl_ProcesoActual.Controls.Add(label30);
            pnl_ProcesoActual.Controls.Add(lbl_TiempoIO);
            pnl_ProcesoActual.Controls.Add(label29);
            pnl_ProcesoActual.Controls.Add(lbl_TiempoCPU);
            pnl_ProcesoActual.Controls.Add(label28);
            pnl_ProcesoActual.Controls.Add(lbl_YaHizoIO);
            pnl_ProcesoActual.Controls.Add(label27);
            pnl_ProcesoActual.Controls.Add(lbl_Prioridad);
            pnl_ProcesoActual.Controls.Add(label26);
            pnl_ProcesoActual.Controls.Add(lbl_IOBurstTime);
            pnl_ProcesoActual.Controls.Add(label25);
            pnl_ProcesoActual.Controls.Add(lbl_BurstTime);
            pnl_ProcesoActual.Controls.Add(label23);
            pnl_ProcesoActual.Controls.Add(lbl_TiempoLlegada);
            pnl_ProcesoActual.Controls.Add(label24);
            pnl_ProcesoActual.Controls.Add(lbl_ID);
            pnl_ProcesoActual.Controls.Add(label22);
            pnl_ProcesoActual.Controls.Add(label20);
            pnl_ProcesoActual.Dock = DockStyle.Fill;
            pnl_ProcesoActual.Location = new Point(0, 0);
            pnl_ProcesoActual.Name = "pnl_ProcesoActual";
            pnl_ProcesoActual.Size = new Size(913, 371);
            pnl_ProcesoActual.TabIndex = 14;
            // 
            // lbl_Estado
            // 
            lbl_Estado.Anchor = AnchorStyles.None;
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 10F);
            lbl_Estado.Location = new Point(769, 293);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(65, 28);
            lbl_Estado.TabIndex = 35;
            lbl_Estado.Text = "label6";
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.None;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label31.ForeColor = Color.RoyalBlue;
            label31.Location = new Point(519, 293);
            label31.Name = "label31";
            label31.Size = new Size(80, 28);
            label31.TabIndex = 34;
            label31.Text = "Estado:";
            // 
            // lbl_TiempoEspera
            // 
            lbl_TiempoEspera.Anchor = AnchorStyles.None;
            lbl_TiempoEspera.AutoSize = true;
            lbl_TiempoEspera.Font = new Font("Segoe UI", 10F);
            lbl_TiempoEspera.Location = new Point(769, 242);
            lbl_TiempoEspera.Name = "lbl_TiempoEspera";
            lbl_TiempoEspera.Size = new Size(65, 28);
            lbl_TiempoEspera.TabIndex = 33;
            lbl_TiempoEspera.Text = "label6";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.None;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label30.ForeColor = Color.RoyalBlue;
            label30.Location = new Point(519, 242);
            label30.Name = "label30";
            label30.Size = new Size(185, 28);
            label30.TabIndex = 32;
            label30.Text = "Tiempo de espera:";
            // 
            // lbl_TiempoIO
            // 
            lbl_TiempoIO.Anchor = AnchorStyles.None;
            lbl_TiempoIO.AutoSize = true;
            lbl_TiempoIO.Font = new Font("Segoe UI", 10F);
            lbl_TiempoIO.Location = new Point(769, 190);
            lbl_TiempoIO.Name = "lbl_TiempoIO";
            lbl_TiempoIO.Size = new Size(65, 28);
            lbl_TiempoIO.TabIndex = 31;
            lbl_TiempoIO.Text = "label6";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.None;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label29.ForeColor = Color.RoyalBlue;
            label29.Location = new Point(519, 190);
            label29.Name = "label29";
            label29.Size = new Size(228, 28);
            label29.TabIndex = 30;
            label29.Text = "Tiempo restante de IO:";
            // 
            // lbl_TiempoCPU
            // 
            lbl_TiempoCPU.Anchor = AnchorStyles.None;
            lbl_TiempoCPU.AutoSize = true;
            lbl_TiempoCPU.Font = new Font("Segoe UI", 10F);
            lbl_TiempoCPU.Location = new Point(769, 138);
            lbl_TiempoCPU.Name = "lbl_TiempoCPU";
            lbl_TiempoCPU.Size = new Size(65, 28);
            lbl_TiempoCPU.TabIndex = 29;
            lbl_TiempoCPU.Text = "label6";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.None;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label28.ForeColor = Color.RoyalBlue;
            label28.Location = new Point(519, 138);
            label28.Name = "label28";
            label28.Size = new Size(245, 28);
            label28.TabIndex = 28;
            label28.Text = "Tiempo restante de CPU:";
            // 
            // lbl_YaHizoIO
            // 
            lbl_YaHizoIO.Anchor = AnchorStyles.None;
            lbl_YaHizoIO.AutoSize = true;
            lbl_YaHizoIO.Font = new Font("Segoe UI", 10F);
            lbl_YaHizoIO.Location = new Point(769, 82);
            lbl_YaHizoIO.Name = "lbl_YaHizoIO";
            lbl_YaHizoIO.Size = new Size(65, 28);
            lbl_YaHizoIO.TabIndex = 27;
            lbl_YaHizoIO.Text = "label6";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.None;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label27.ForeColor = Color.RoyalBlue;
            label27.Location = new Point(519, 82);
            label27.Name = "label27";
            label27.Size = new Size(156, 28);
            label27.TabIndex = 26;
            label27.Text = "IO completado:";
            // 
            // lbl_Prioridad
            // 
            lbl_Prioridad.Anchor = AnchorStyles.None;
            lbl_Prioridad.AutoSize = true;
            lbl_Prioridad.Font = new Font("Segoe UI", 10F);
            lbl_Prioridad.Location = new Point(254, 293);
            lbl_Prioridad.Name = "lbl_Prioridad";
            lbl_Prioridad.Size = new Size(65, 28);
            lbl_Prioridad.TabIndex = 25;
            lbl_Prioridad.Text = "label6";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label26.ForeColor = Color.RoyalBlue;
            label26.Location = new Point(57, 293);
            label26.Name = "label26";
            label26.Size = new Size(104, 28);
            label26.TabIndex = 24;
            label26.Text = "Prioridad:";
            // 
            // lbl_IOBurstTime
            // 
            lbl_IOBurstTime.Anchor = AnchorStyles.None;
            lbl_IOBurstTime.AutoSize = true;
            lbl_IOBurstTime.Font = new Font("Segoe UI", 10F);
            lbl_IOBurstTime.Location = new Point(254, 242);
            lbl_IOBurstTime.Name = "lbl_IOBurstTime";
            lbl_IOBurstTime.Size = new Size(65, 28);
            lbl_IOBurstTime.TabIndex = 23;
            lbl_IOBurstTime.Text = "label6";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.None;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label25.ForeColor = Color.RoyalBlue;
            label25.Location = new Point(57, 242);
            label25.Name = "label25";
            label25.Size = new Size(147, 28);
            label25.TabIndex = 22;
            label25.Text = "IO Burst Time:";
            // 
            // lbl_BurstTime
            // 
            lbl_BurstTime.Anchor = AnchorStyles.None;
            lbl_BurstTime.AutoSize = true;
            lbl_BurstTime.Font = new Font("Segoe UI", 10F);
            lbl_BurstTime.Location = new Point(254, 190);
            lbl_BurstTime.Name = "lbl_BurstTime";
            lbl_BurstTime.Size = new Size(65, 28);
            lbl_BurstTime.TabIndex = 21;
            lbl_BurstTime.Text = "label6";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.None;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label23.ForeColor = Color.RoyalBlue;
            label23.Location = new Point(57, 190);
            label23.Name = "label23";
            label23.Size = new Size(120, 28);
            label23.TabIndex = 20;
            label23.Text = "Burst Time:";
            // 
            // lbl_TiempoLlegada
            // 
            lbl_TiempoLlegada.Anchor = AnchorStyles.None;
            lbl_TiempoLlegada.AutoSize = true;
            lbl_TiempoLlegada.Font = new Font("Segoe UI", 10F);
            lbl_TiempoLlegada.Location = new Point(254, 138);
            lbl_TiempoLlegada.Name = "lbl_TiempoLlegada";
            lbl_TiempoLlegada.Size = new Size(65, 28);
            lbl_TiempoLlegada.TabIndex = 19;
            lbl_TiempoLlegada.Text = "label6";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.None;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label24.ForeColor = Color.RoyalBlue;
            label24.Location = new Point(57, 138);
            label24.Name = "label24";
            label24.Size = new Size(192, 28);
            label24.TabIndex = 18;
            label24.Text = "Tiempo de llegada:";
            // 
            // lbl_ID
            // 
            lbl_ID.Anchor = AnchorStyles.None;
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 10F);
            lbl_ID.Location = new Point(254, 82);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(65, 28);
            lbl_ID.TabIndex = 17;
            lbl_ID.Text = "label6";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.None;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label22.ForeColor = Color.RoyalBlue;
            label22.Location = new Point(57, 82);
            label22.Name = "label22";
            label22.Size = new Size(118, 28);
            label22.TabIndex = 16;
            label22.Text = "ID proceso:";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.DarkBlue;
            label20.Location = new Point(324, 13);
            label20.Name = "label20";
            label20.Size = new Size(237, 45);
            label20.TabIndex = 14;
            label20.Text = "Proceso actual";
            // 
            // lbl_NoExpulsivos
            // 
            lbl_NoExpulsivos.Anchor = AnchorStyles.None;
            lbl_NoExpulsivos.AutoSize = true;
            lbl_NoExpulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NoExpulsivos.ForeColor = Color.RoyalBlue;
            lbl_NoExpulsivos.Location = new Point(31, 95);
            lbl_NoExpulsivos.Name = "lbl_NoExpulsivos";
            lbl_NoExpulsivos.Size = new Size(175, 30);
            lbl_NoExpulsivos.TabIndex = 12;
            lbl_NoExpulsivos.Text = "No expulsivos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(226, 25);
            label1.Name = "label1";
            label1.Size = new Size(434, 45);
            label1.TabIndex = 11;
            label1.Text = "Algoritmos de planificación";
            // 
            // rb_PrioridadesExpulsivo
            // 
            rb_PrioridadesExpulsivo.Anchor = AnchorStyles.None;
            rb_PrioridadesExpulsivo.AutoSize = true;
            rb_PrioridadesExpulsivo.Location = new Point(521, 244);
            rb_PrioridadesExpulsivo.Name = "rb_PrioridadesExpulsivo";
            rb_PrioridadesExpulsivo.Size = new Size(315, 29);
            rb_PrioridadesExpulsivo.TabIndex = 10;
            rb_PrioridadesExpulsivo.TabStop = true;
            rb_PrioridadesExpulsivo.Text = "Planificacion basada en prioridades";
            rb_PrioridadesExpulsivo.UseVisualStyleBackColor = true;
            rb_PrioridadesExpulsivo.CheckedChanged += rb_PrioridadesExpulsivo_CheckedChanged;
            // 
            // rb_SRTF
            // 
            rb_SRTF.Anchor = AnchorStyles.None;
            rb_SRTF.AutoSize = true;
            rb_SRTF.Location = new Point(521, 190);
            rb_SRTF.Name = "rb_SRTF";
            rb_SRTF.Size = new Size(382, 29);
            rb_SRTF.TabIndex = 9;
            rb_SRTF.TabStop = true;
            rb_SRTF.Text = "Primero el de menor tiempo restante (SRTF)";
            rb_SRTF.UseVisualStyleBackColor = true;
            // 
            // rb_RoundRobin
            // 
            rb_RoundRobin.Anchor = AnchorStyles.None;
            rb_RoundRobin.AutoSize = true;
            rb_RoundRobin.Location = new Point(521, 139);
            rb_RoundRobin.Name = "rb_RoundRobin";
            rb_RoundRobin.Size = new Size(272, 29);
            rb_RoundRobin.TabIndex = 8;
            rb_RoundRobin.TabStop = true;
            rb_RoundRobin.Text = "Turno Rotativo (Round Robin)";
            rb_RoundRobin.UseVisualStyleBackColor = true;
            rb_RoundRobin.CheckedChanged += rb_RoundRobin_CheckedChanged;
            // 
            // rb_PrioridadesNoExpulsivo
            // 
            rb_PrioridadesNoExpulsivo.Anchor = AnchorStyles.None;
            rb_PrioridadesNoExpulsivo.AutoSize = true;
            rb_PrioridadesNoExpulsivo.Location = new Point(31, 295);
            rb_PrioridadesNoExpulsivo.Name = "rb_PrioridadesNoExpulsivo";
            rb_PrioridadesNoExpulsivo.Size = new Size(315, 29);
            rb_PrioridadesNoExpulsivo.TabIndex = 7;
            rb_PrioridadesNoExpulsivo.TabStop = true;
            rb_PrioridadesNoExpulsivo.Text = "Planificación basada en prioridades";
            rb_PrioridadesNoExpulsivo.UseVisualStyleBackColor = true;
            rb_PrioridadesNoExpulsivo.CheckedChanged += rb_PrioridadesNoExpulsivo_CheckedChanged;
            // 
            // rb_SeleccionAleatoria
            // 
            rb_SeleccionAleatoria.Anchor = AnchorStyles.None;
            rb_SeleccionAleatoria.AutoSize = true;
            rb_SeleccionAleatoria.Location = new Point(31, 244);
            rb_SeleccionAleatoria.Name = "rb_SeleccionAleatoria";
            rb_SeleccionAleatoria.Size = new Size(185, 29);
            rb_SeleccionAleatoria.TabIndex = 6;
            rb_SeleccionAleatoria.TabStop = true;
            rb_SeleccionAleatoria.Text = "Seleccion Aleatoria";
            rb_SeleccionAleatoria.UseVisualStyleBackColor = true;
            // 
            // rb_SJF
            // 
            rb_SJF.Anchor = AnchorStyles.None;
            rb_SJF.AutoSize = true;
            rb_SJF.Location = new Point(31, 190);
            rb_SJF.Name = "rb_SJF";
            rb_SJF.Size = new Size(303, 29);
            rb_SJF.TabIndex = 5;
            rb_SJF.TabStop = true;
            rb_SJF.Text = "Primero el trabajo más corto (SJF)";
            rb_SJF.UseVisualStyleBackColor = true;
            // 
            // lbl_Expulsivos
            // 
            lbl_Expulsivos.Anchor = AnchorStyles.None;
            lbl_Expulsivos.AutoSize = true;
            lbl_Expulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Expulsivos.ForeColor = Color.RoyalBlue;
            lbl_Expulsivos.Location = new Point(521, 95);
            lbl_Expulsivos.Name = "lbl_Expulsivos";
            lbl_Expulsivos.Size = new Size(137, 30);
            lbl_Expulsivos.TabIndex = 13;
            lbl_Expulsivos.Text = "Expulsivos:";
            // 
            // rb_FCFS
            // 
            rb_FCFS.Anchor = AnchorStyles.None;
            rb_FCFS.AutoSize = true;
            rb_FCFS.Location = new Point(31, 139);
            rb_FCFS.Name = "rb_FCFS";
            rb_FCFS.Size = new Size(400, 29);
            rb_FCFS.TabIndex = 4;
            rb_FCFS.TabStop = true;
            rb_FCFS.Text = "Primero en llegar primero en ejecutarse (FCFS)";
            rb_FCFS.UseVisualStyleBackColor = true;
            // 
            // pnl_Generador
            // 
            pnl_Generador.BorderStyle = BorderStyle.FixedSingle;
            pnl_Generador.Controls.Add(pnl_Estadisticas);
            pnl_Generador.Controls.Add(np_Quantum);
            pnl_Generador.Controls.Add(lb_Quantum);
            pnl_Generador.Controls.Add(np_MaxTiempoLlegada);
            pnl_Generador.Controls.Add(btn_Limpiar);
            pnl_Generador.Controls.Add(btn_Simular);
            pnl_Generador.Controls.Add(np_MinTiempoLlegada);
            pnl_Generador.Controls.Add(lb_TiempoLlegada);
            pnl_Generador.Controls.Add(cmb_Tick);
            pnl_Generador.Controls.Add(lb_TiempoTick);
            pnl_Generador.Controls.Add(np_Cantidad);
            pnl_Generador.Controls.Add(lb_Cantidad);
            pnl_Generador.Controls.Add(np_MaxPrioridad);
            pnl_Generador.Controls.Add(np_MinPrioridad);
            pnl_Generador.Controls.Add(lb_Prioridad);
            pnl_Generador.Controls.Add(np_MaxIOBurstTime);
            pnl_Generador.Controls.Add(np_MinIOBurstTime);
            pnl_Generador.Controls.Add(lb_BurstTimeIO);
            pnl_Generador.Controls.Add(np_MaxBurstTime);
            pnl_Generador.Controls.Add(np_MinBurstTime);
            pnl_Generador.Controls.Add(lb_BurstTime);
            pnl_Generador.Controls.Add(label2);
            pnl_Generador.Dock = DockStyle.Fill;
            pnl_Generador.Location = new Point(3, 382);
            pnl_Generador.Name = "pnl_Generador";
            pnl_Generador.Size = new Size(915, 482);
            pnl_Generador.TabIndex = 1;
            // 
            // pnl_Estadisticas
            // 
            pnl_Estadisticas.BorderStyle = BorderStyle.FixedSingle;
            pnl_Estadisticas.Controls.Add(btn_Reiniciar);
            pnl_Estadisticas.Controls.Add(btn_CambiarAlgoritmo);
            pnl_Estadisticas.Controls.Add(lbl_TiempoTotal);
            pnl_Estadisticas.Controls.Add(label16);
            pnl_Estadisticas.Controls.Add(lbl_ProcesosPorPaso);
            pnl_Estadisticas.Controls.Add(label17);
            pnl_Estadisticas.Controls.Add(lbl_ProcesosCompletados);
            pnl_Estadisticas.Controls.Add(label10);
            pnl_Estadisticas.Controls.Add(lbl_TiempoPromEjecucion);
            pnl_Estadisticas.Controls.Add(label6);
            pnl_Estadisticas.Controls.Add(lbl_TiempoPromBloqueo);
            pnl_Estadisticas.Controls.Add(label9);
            pnl_Estadisticas.Controls.Add(lbl_TiempoPromEspera);
            pnl_Estadisticas.Controls.Add(label7);
            pnl_Estadisticas.Controls.Add(lbl_UsoProcesador);
            pnl_Estadisticas.Controls.Add(label5);
            pnl_Estadisticas.Controls.Add(label4);
            pnl_Estadisticas.Dock = DockStyle.Fill;
            pnl_Estadisticas.Location = new Point(0, 0);
            pnl_Estadisticas.Name = "pnl_Estadisticas";
            pnl_Estadisticas.Size = new Size(913, 480);
            pnl_Estadisticas.TabIndex = 2;
            // 
            // btn_Reiniciar
            // 
            btn_Reiniciar.Anchor = AnchorStyles.None;
            btn_Reiniciar.Location = new Point(432, 362);
            btn_Reiniciar.Name = "btn_Reiniciar";
            btn_Reiniciar.Padding = new Padding(0, 2, 0, 2);
            btn_Reiniciar.Size = new Size(199, 48);
            btn_Reiniciar.TabIndex = 29;
            btn_Reiniciar.Text = "Reiniciar prueba";
            btn_Reiniciar.UseVisualStyleBackColor = true;
            btn_Reiniciar.Click += btn_Reiniciar_Click;
            // 
            // btn_CambiarAlgoritmo
            // 
            btn_CambiarAlgoritmo.Anchor = AnchorStyles.None;
            btn_CambiarAlgoritmo.Location = new Point(216, 362);
            btn_CambiarAlgoritmo.Name = "btn_CambiarAlgoritmo";
            btn_CambiarAlgoritmo.Padding = new Padding(0, 2, 0, 2);
            btn_CambiarAlgoritmo.Size = new Size(199, 48);
            btn_CambiarAlgoritmo.TabIndex = 28;
            btn_CambiarAlgoritmo.Text = "Cambiar algoritmo";
            btn_CambiarAlgoritmo.UseVisualStyleBackColor = true;
            btn_CambiarAlgoritmo.Click += btn_CambiarAlgoritmo_Click;
            // 
            // lbl_TiempoTotal
            // 
            lbl_TiempoTotal.Anchor = AnchorStyles.None;
            lbl_TiempoTotal.AutoSize = true;
            lbl_TiempoTotal.Font = new Font("Segoe UI", 9F);
            lbl_TiempoTotal.Location = new Point(594, 236);
            lbl_TiempoTotal.Name = "lbl_TiempoTotal";
            lbl_TiempoTotal.Size = new Size(59, 25);
            lbl_TiempoTotal.TabIndex = 27;
            lbl_TiempoTotal.Text = "label6";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(450, 236);
            label16.Name = "label16";
            label16.Size = new Size(121, 25);
            label16.TabIndex = 26;
            label16.Text = "Tiempo total";
            // 
            // lbl_ProcesosPorPaso
            // 
            lbl_ProcesosPorPaso.Anchor = AnchorStyles.None;
            lbl_ProcesosPorPaso.AutoSize = true;
            lbl_ProcesosPorPaso.Font = new Font("Segoe UI", 9F);
            lbl_ProcesosPorPaso.Location = new Point(779, 184);
            lbl_ProcesosPorPaso.Name = "lbl_ProcesosPorPaso";
            lbl_ProcesosPorPaso.Size = new Size(59, 25);
            lbl_ProcesosPorPaso.TabIndex = 25;
            lbl_ProcesosPorPaso.Text = "label6";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.ForeColor = Color.RoyalBlue;
            label17.Location = new Point(450, 182);
            label17.Name = "label17";
            label17.Size = new Size(317, 25);
            label17.TabIndex = 24;
            label17.Text = "Arribo de nuevos procesos por paso";
            // 
            // lbl_ProcesosCompletados
            // 
            lbl_ProcesosCompletados.Anchor = AnchorStyles.None;
            lbl_ProcesosCompletados.AutoSize = true;
            lbl_ProcesosCompletados.Font = new Font("Segoe UI", 9F);
            lbl_ProcesosCompletados.Location = new Point(757, 127);
            lbl_ProcesosCompletados.Name = "lbl_ProcesosCompletados";
            lbl_ProcesosCompletados.Size = new Size(59, 25);
            lbl_ProcesosCompletados.TabIndex = 23;
            lbl_ProcesosCompletados.Text = "label6";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(450, 127);
            label10.Name = "label10";
            label10.Size = new Size(248, 25);
            label10.TabIndex = 22;
            label10.Text = "Total procesos completados";
            // 
            // lbl_TiempoPromEjecucion
            // 
            lbl_TiempoPromEjecucion.Anchor = AnchorStyles.None;
            lbl_TiempoPromEjecucion.AutoSize = true;
            lbl_TiempoPromEjecucion.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromEjecucion.Location = new Point(309, 291);
            lbl_TiempoPromEjecucion.Name = "lbl_TiempoPromEjecucion";
            lbl_TiempoPromEjecucion.Size = new Size(59, 25);
            lbl_TiempoPromEjecucion.TabIndex = 21;
            lbl_TiempoPromEjecucion.Text = "label6";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(21, 291);
            label6.Name = "label6";
            label6.Size = new Size(275, 25);
            label6.TabIndex = 20;
            label6.Text = "Tiempo promedio de ejecución";
            // 
            // lbl_TiempoPromBloqueo
            // 
            lbl_TiempoPromBloqueo.Anchor = AnchorStyles.None;
            lbl_TiempoPromBloqueo.AutoSize = true;
            lbl_TiempoPromBloqueo.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromBloqueo.Location = new Point(309, 232);
            lbl_TiempoPromBloqueo.Name = "lbl_TiempoPromBloqueo";
            lbl_TiempoPromBloqueo.Size = new Size(59, 25);
            lbl_TiempoPromBloqueo.TabIndex = 19;
            lbl_TiempoPromBloqueo.Text = "label6";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(21, 232);
            label9.Name = "label9";
            label9.Size = new Size(264, 25);
            label9.TabIndex = 18;
            label9.Text = "Tiempo promedio de bloqueo";
            // 
            // lbl_TiempoPromEspera
            // 
            lbl_TiempoPromEspera.Anchor = AnchorStyles.None;
            lbl_TiempoPromEspera.AutoSize = true;
            lbl_TiempoPromEspera.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromEspera.Location = new Point(309, 181);
            lbl_TiempoPromEspera.Name = "lbl_TiempoPromEspera";
            lbl_TiempoPromEspera.Size = new Size(59, 25);
            lbl_TiempoPromEspera.TabIndex = 17;
            lbl_TiempoPromEspera.Text = "label6";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(21, 181);
            label7.Name = "label7";
            label7.Size = new Size(250, 25);
            label7.TabIndex = 16;
            label7.Text = "Tiempo promedio de espera";
            // 
            // lbl_UsoProcesador
            // 
            lbl_UsoProcesador.Anchor = AnchorStyles.None;
            lbl_UsoProcesador.AutoSize = true;
            lbl_UsoProcesador.Font = new Font("Segoe UI", 9F);
            lbl_UsoProcesador.Location = new Point(214, 124);
            lbl_UsoProcesador.Name = "lbl_UsoProcesador";
            lbl_UsoProcesador.Size = new Size(59, 25);
            lbl_UsoProcesador.TabIndex = 15;
            lbl_UsoProcesador.Text = "label6";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(21, 124);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 14;
            label5.Text = "Uso del procesador";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(269, 37);
            label4.Name = "label4";
            label4.Size = new Size(348, 45);
            label4.TabIndex = 13;
            label4.Text = "Estadísticas algoritmo";
            // 
            // np_Quantum
            // 
            np_Quantum.Anchor = AnchorStyles.None;
            np_Quantum.Location = new Point(21, 398);
            np_Quantum.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_Quantum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_Quantum.Name = "np_Quantum";
            np_Quantum.Size = new Size(90, 31);
            np_Quantum.TabIndex = 38;
            np_Quantum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lb_Quantum
            // 
            lb_Quantum.Anchor = AnchorStyles.None;
            lb_Quantum.AutoSize = true;
            lb_Quantum.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lb_Quantum.ForeColor = Color.RoyalBlue;
            lb_Quantum.Location = new Point(21, 359);
            lb_Quantum.Name = "lb_Quantum";
            lb_Quantum.Size = new Size(94, 25);
            lb_Quantum.TabIndex = 37;
            lb_Quantum.Text = "Quantum";
            // 
            // np_MaxTiempoLlegada
            // 
            np_MaxTiempoLlegada.Anchor = AnchorStyles.None;
            np_MaxTiempoLlegada.Location = new Point(530, 304);
            np_MaxTiempoLlegada.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxTiempoLlegada.Name = "np_MaxTiempoLlegada";
            np_MaxTiempoLlegada.Size = new Size(90, 31);
            np_MaxTiempoLlegada.TabIndex = 36;
            toolTip.SetToolTip(np_MaxTiempoLlegada, "Max");
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Anchor = AnchorStyles.None;
            btn_Limpiar.Location = new Point(729, 175);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Padding = new Padding(0, 2, 0, 2);
            btn_Limpiar.Size = new Size(133, 48);
            btn_Limpiar.TabIndex = 35;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Simular
            // 
            btn_Simular.Anchor = AnchorStyles.None;
            btn_Simular.Location = new Point(729, 268);
            btn_Simular.Name = "btn_Simular";
            btn_Simular.Padding = new Padding(0, 2, 0, 2);
            btn_Simular.Size = new Size(133, 48);
            btn_Simular.TabIndex = 34;
            btn_Simular.Text = "Simular";
            btn_Simular.UseVisualStyleBackColor = true;
            btn_Simular.Click += btn_Simular_Click;
            // 
            // np_MinTiempoLlegada
            // 
            np_MinTiempoLlegada.Anchor = AnchorStyles.None;
            np_MinTiempoLlegada.Location = new Point(379, 304);
            np_MinTiempoLlegada.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinTiempoLlegada.Name = "np_MinTiempoLlegada";
            np_MinTiempoLlegada.Size = new Size(90, 31);
            np_MinTiempoLlegada.TabIndex = 33;
            toolTip.SetToolTip(np_MinTiempoLlegada, "MIn");
            // 
            // lb_TiempoLlegada
            // 
            lb_TiempoLlegada.Anchor = AnchorStyles.None;
            lb_TiempoLlegada.AutoSize = true;
            lb_TiempoLlegada.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TiempoLlegada.ForeColor = Color.RoyalBlue;
            lb_TiempoLlegada.Location = new Point(379, 265);
            lb_TiempoLlegada.Name = "lb_TiempoLlegada";
            lb_TiempoLlegada.Size = new Size(177, 25);
            lb_TiempoLlegada.TabIndex = 32;
            lb_TiempoLlegada.Text = "Tiempo de llegada";
            // 
            // cmb_Tick
            // 
            cmb_Tick.Anchor = AnchorStyles.None;
            cmb_Tick.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tick.FormattingEnabled = true;
            cmb_Tick.Location = new Point(379, 200);
            cmb_Tick.Name = "cmb_Tick";
            cmb_Tick.Size = new Size(198, 33);
            cmb_Tick.TabIndex = 31;
            // 
            // lb_TiempoTick
            // 
            lb_TiempoTick.Anchor = AnchorStyles.None;
            lb_TiempoTick.AutoSize = true;
            lb_TiempoTick.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_TiempoTick.ForeColor = Color.RoyalBlue;
            lb_TiempoTick.Location = new Point(379, 163);
            lb_TiempoTick.Name = "lb_TiempoTick";
            lb_TiempoTick.Size = new Size(151, 25);
            lb_TiempoTick.TabIndex = 30;
            lb_TiempoTick.Text = "Tiempo del tick";
            // 
            // np_Cantidad
            // 
            np_Cantidad.Anchor = AnchorStyles.None;
            np_Cantidad.Location = new Point(379, 113);
            np_Cantidad.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            np_Cantidad.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            np_Cantidad.Name = "np_Cantidad";
            np_Cantidad.Size = new Size(90, 31);
            np_Cantidad.TabIndex = 29;
            np_Cantidad.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lb_Cantidad
            // 
            lb_Cantidad.Anchor = AnchorStyles.None;
            lb_Cantidad.AutoSize = true;
            lb_Cantidad.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Cantidad.ForeColor = Color.RoyalBlue;
            lb_Cantidad.Location = new Point(379, 75);
            lb_Cantidad.Name = "lb_Cantidad";
            lb_Cantidad.Size = new Size(292, 25);
            lb_Cantidad.TabIndex = 28;
            lb_Cantidad.Text = "Cantidad de procesos a generar";
            // 
            // np_MaxPrioridad
            // 
            np_MaxPrioridad.Anchor = AnchorStyles.None;
            np_MaxPrioridad.Location = new Point(176, 304);
            np_MaxPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxPrioridad.Name = "np_MaxPrioridad";
            np_MaxPrioridad.Size = new Size(90, 31);
            np_MaxPrioridad.TabIndex = 26;
            toolTip.SetToolTip(np_MaxPrioridad, "Max");
            np_MaxPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // np_MinPrioridad
            // 
            np_MinPrioridad.Anchor = AnchorStyles.None;
            np_MinPrioridad.Location = new Point(21, 304);
            np_MinPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinPrioridad.Name = "np_MinPrioridad";
            np_MinPrioridad.Size = new Size(90, 31);
            np_MinPrioridad.TabIndex = 24;
            toolTip.SetToolTip(np_MinPrioridad, "MIn");
            np_MinPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lb_Prioridad
            // 
            lb_Prioridad.Anchor = AnchorStyles.None;
            lb_Prioridad.AutoSize = true;
            lb_Prioridad.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lb_Prioridad.ForeColor = Color.RoyalBlue;
            lb_Prioridad.Location = new Point(21, 265);
            lb_Prioridad.Name = "lb_Prioridad";
            lb_Prioridad.Size = new Size(97, 25);
            lb_Prioridad.TabIndex = 23;
            lb_Prioridad.Text = "Prioridad";
            // 
            // np_MaxIOBurstTime
            // 
            np_MaxIOBurstTime.Anchor = AnchorStyles.None;
            np_MaxIOBurstTime.Location = new Point(176, 202);
            np_MaxIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxIOBurstTime.Name = "np_MaxIOBurstTime";
            np_MaxIOBurstTime.Size = new Size(90, 31);
            np_MaxIOBurstTime.TabIndex = 21;
            toolTip.SetToolTip(np_MaxIOBurstTime, "Max");
            // 
            // np_MinIOBurstTime
            // 
            np_MinIOBurstTime.Anchor = AnchorStyles.None;
            np_MinIOBurstTime.Location = new Point(21, 202);
            np_MinIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinIOBurstTime.Name = "np_MinIOBurstTime";
            np_MinIOBurstTime.Size = new Size(90, 31);
            np_MinIOBurstTime.TabIndex = 19;
            toolTip.SetToolTip(np_MinIOBurstTime, "MIn");
            // 
            // lb_BurstTimeIO
            // 
            lb_BurstTimeIO.Anchor = AnchorStyles.None;
            lb_BurstTimeIO.AutoSize = true;
            lb_BurstTimeIO.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lb_BurstTimeIO.ForeColor = Color.RoyalBlue;
            lb_BurstTimeIO.Location = new Point(21, 163);
            lb_BurstTimeIO.Name = "lb_BurstTimeIO";
            lb_BurstTimeIO.Size = new Size(143, 25);
            lb_BurstTimeIO.TabIndex = 18;
            lb_BurstTimeIO.Text = "I/O Burst Time";
            // 
            // np_MaxBurstTime
            // 
            np_MaxBurstTime.Anchor = AnchorStyles.None;
            np_MaxBurstTime.Location = new Point(176, 113);
            np_MaxBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxBurstTime.Name = "np_MaxBurstTime";
            np_MaxBurstTime.Size = new Size(90, 31);
            np_MaxBurstTime.TabIndex = 16;
            toolTip.SetToolTip(np_MaxBurstTime, "Max");
            np_MaxBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // np_MinBurstTime
            // 
            np_MinBurstTime.Anchor = AnchorStyles.None;
            np_MinBurstTime.Location = new Point(21, 113);
            np_MinBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinBurstTime.Name = "np_MinBurstTime";
            np_MinBurstTime.Size = new Size(90, 31);
            np_MinBurstTime.TabIndex = 14;
            toolTip.SetToolTip(np_MinBurstTime, "Min");
            np_MinBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lb_BurstTime
            // 
            lb_BurstTime.Anchor = AnchorStyles.None;
            lb_BurstTime.AutoSize = true;
            lb_BurstTime.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_BurstTime.ForeColor = Color.RoyalBlue;
            lb_BurstTime.Location = new Point(21, 75);
            lb_BurstTime.Name = "lb_BurstTime";
            lb_BurstTime.Size = new Size(109, 25);
            lb_BurstTime.TabIndex = 13;
            lb_BurstTime.Text = "Burst Time";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(237, 10);
            label2.Name = "label2";
            label2.Size = new Size(411, 45);
            label2.TabIndex = 12;
            label2.Text = "Parámetros del generador";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(panel4, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(930, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(1026, 867);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(Grid_Bloqueados, 0, 1);
            tableLayoutPanel6.Controls.Add(panel3, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 435);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1020, 210);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // Grid_Bloqueados
            // 
            Grid_Bloqueados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Bloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Bloqueados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, TiempoRestanteCPUBloqueo, dataGridViewTextBoxColumn4, PrioridadBloqueados, dataGridViewTextBoxColumn6 });
            Grid_Bloqueados.Dock = DockStyle.Fill;
            Grid_Bloqueados.Location = new Point(3, 48);
            Grid_Bloqueados.Name = "Grid_Bloqueados";
            Grid_Bloqueados.ReadOnly = true;
            Grid_Bloqueados.RowHeadersVisible = false;
            Grid_Bloqueados.RowHeadersWidth = 62;
            Grid_Bloqueados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Bloqueados.ShowEditingIcon = false;
            Grid_Bloqueados.ShowRowErrors = false;
            Grid_Bloqueados.Size = new Size(1014, 159);
            Grid_Bloqueados.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TiempoLlegada";
            dataGridViewTextBoxColumn2.HeaderText = "Tiempo de llegada";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "BurstTime";
            dataGridViewTextBoxColumn3.HeaderText = "Burst Time";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TiempoRestanteCPUBloqueo
            // 
            TiempoRestanteCPUBloqueo.DataPropertyName = "TiempoRestanteCPU";
            TiempoRestanteCPUBloqueo.HeaderText = "Tiempo Restante CPU";
            TiempoRestanteCPUBloqueo.MinimumWidth = 8;
            TiempoRestanteCPUBloqueo.Name = "TiempoRestanteCPUBloqueo";
            TiempoRestanteCPUBloqueo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "IOBurstTime";
            dataGridViewTextBoxColumn4.HeaderText = "IO Burst Time";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // PrioridadBloqueados
            // 
            PrioridadBloqueados.DataPropertyName = "Prioridad";
            PrioridadBloqueados.HeaderText = "Prioridad";
            PrioridadBloqueados.MinimumWidth = 8;
            PrioridadBloqueados.Name = "PrioridadBloqueados";
            PrioridadBloqueados.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label18);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 39);
            panel3.TabIndex = 3;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(438, 3);
            label18.Name = "label18";
            label18.Size = new Size(144, 32);
            label18.TabIndex = 2;
            label18.Text = "En bloqueo";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Grid_Nuevos, 0, 1);
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1020, 210);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // Grid_Nuevos
            // 
            Grid_Nuevos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Nuevos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Nuevos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, PrioridadNuevos, dataGridViewTextBoxColumn12 });
            Grid_Nuevos.Dock = DockStyle.Fill;
            Grid_Nuevos.Location = new Point(3, 48);
            Grid_Nuevos.Name = "Grid_Nuevos";
            Grid_Nuevos.ReadOnly = true;
            Grid_Nuevos.RowHeadersVisible = false;
            Grid_Nuevos.RowHeadersWidth = 62;
            Grid_Nuevos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Nuevos.ShowEditingIcon = false;
            Grid_Nuevos.ShowRowErrors = false;
            Grid_Nuevos.Size = new Size(1014, 159);
            Grid_Nuevos.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            dataGridViewTextBoxColumn7.HeaderText = "ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "TiempoLlegada";
            dataGridViewTextBoxColumn8.HeaderText = "Tiempo de llegada";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "BurstTime";
            dataGridViewTextBoxColumn9.HeaderText = "Burst Time";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "IOBurstTime";
            dataGridViewTextBoxColumn10.HeaderText = "IO Burst Time";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // PrioridadNuevos
            // 
            PrioridadNuevos.DataPropertyName = "Prioridad";
            PrioridadNuevos.HeaderText = "Prioridad";
            PrioridadNuevos.MinimumWidth = 8;
            PrioridadNuevos.Name = "PrioridadNuevos";
            PrioridadNuevos.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn12.HeaderText = "Estado";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label32);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 39);
            panel1.TabIndex = 1;
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.None;
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.Blue;
            label32.Location = new Point(459, 3);
            label32.Name = "label32";
            label32.Size = new Size(102, 32);
            label32.TabIndex = 2;
            label32.Text = "Nuevos";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(Grid_Listo, 0, 1);
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 219);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1020, 210);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // Grid_Listo
            // 
            Grid_Listo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Listo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Listo.Columns.AddRange(new DataGridViewColumn[] { ID, TiempoLlegada, BurstTime, TiempoRestanteCPU, IOBurstTime, Prioridad, Estado });
            Grid_Listo.Dock = DockStyle.Fill;
            Grid_Listo.Location = new Point(3, 48);
            Grid_Listo.Name = "Grid_Listo";
            Grid_Listo.ReadOnly = true;
            Grid_Listo.RowHeadersVisible = false;
            Grid_Listo.RowHeadersWidth = 62;
            Grid_Listo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Listo.ShowEditingIcon = false;
            Grid_Listo.ShowRowErrors = false;
            Grid_Listo.Size = new Size(1014, 159);
            Grid_Listo.TabIndex = 3;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TiempoLlegada
            // 
            TiempoLlegada.DataPropertyName = "TiempoLlegada";
            TiempoLlegada.HeaderText = "Tiempo de llegada";
            TiempoLlegada.MinimumWidth = 8;
            TiempoLlegada.Name = "TiempoLlegada";
            TiempoLlegada.ReadOnly = true;
            // 
            // BurstTime
            // 
            BurstTime.DataPropertyName = "BurstTime";
            BurstTime.HeaderText = "Burst Time";
            BurstTime.MinimumWidth = 8;
            BurstTime.Name = "BurstTime";
            BurstTime.ReadOnly = true;
            // 
            // TiempoRestanteCPU
            // 
            TiempoRestanteCPU.DataPropertyName = "TiempoRestanteCPU";
            TiempoRestanteCPU.HeaderText = "Tiempo Restante CPU";
            TiempoRestanteCPU.MinimumWidth = 8;
            TiempoRestanteCPU.Name = "TiempoRestanteCPU";
            TiempoRestanteCPU.ReadOnly = true;
            // 
            // IOBurstTime
            // 
            IOBurstTime.DataPropertyName = "IOBurstTime";
            IOBurstTime.HeaderText = "IO Burst Time";
            IOBurstTime.MinimumWidth = 8;
            IOBurstTime.Name = "IOBurstTime";
            IOBurstTime.ReadOnly = true;
            // 
            // Prioridad
            // 
            Prioridad.DataPropertyName = "Prioridad";
            Prioridad.HeaderText = "Prioridad";
            Prioridad.MinimumWidth = 8;
            Prioridad.Name = "Prioridad";
            Prioridad.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 39);
            panel2.TabIndex = 2;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Goldenrod;
            label15.Location = new Point(469, 3);
            label15.Name = "label15";
            label15.Size = new Size(83, 32);
            label15.TabIndex = 1;
            label15.Text = "Listos";
            // 
            // panel4
            // 
            panel4.Controls.Add(Grid_Terminados);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 651);
            panel4.Name = "panel4";
            panel4.Size = new Size(1020, 213);
            panel4.TabIndex = 7;
            // 
            // Grid_Terminados
            // 
            Grid_Terminados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Terminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Terminados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, PrioridadTerminados, dataGridViewTextBoxColumn21 });
            Grid_Terminados.Dock = DockStyle.Fill;
            Grid_Terminados.Location = new Point(0, 44);
            Grid_Terminados.Name = "Grid_Terminados";
            Grid_Terminados.ReadOnly = true;
            Grid_Terminados.RowHeadersVisible = false;
            Grid_Terminados.RowHeadersWidth = 62;
            Grid_Terminados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Terminados.ShowEditingIcon = false;
            Grid_Terminados.ShowRowErrors = false;
            Grid_Terminados.Size = new Size(1020, 169);
            Grid_Terminados.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "ID";
            dataGridViewTextBoxColumn13.HeaderText = "ID";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "TiempoEspera";
            dataGridViewTextBoxColumn14.HeaderText = "Tiempo de espera";
            dataGridViewTextBoxColumn14.MinimumWidth = 8;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "TiempoBloqueadoAcumulado";
            dataGridViewTextBoxColumn15.HeaderText = "Tiempo de bloqueo total";
            dataGridViewTextBoxColumn15.MinimumWidth = 8;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "TickFinalizacion";
            dataGridViewTextBoxColumn16.HeaderText = "Tick finalizacion";
            dataGridViewTextBoxColumn16.MinimumWidth = 8;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "TiempoLlegada";
            dataGridViewTextBoxColumn17.HeaderText = "Tiempo de llegada";
            dataGridViewTextBoxColumn17.MinimumWidth = 8;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "BurstTime";
            dataGridViewTextBoxColumn18.HeaderText = "Burst Time";
            dataGridViewTextBoxColumn18.MinimumWidth = 8;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "IOBurstTime";
            dataGridViewTextBoxColumn19.HeaderText = "IO Burst Time";
            dataGridViewTextBoxColumn19.MinimumWidth = 8;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // PrioridadTerminados
            // 
            PrioridadTerminados.DataPropertyName = "Prioridad";
            PrioridadTerminados.HeaderText = "Prioridad";
            PrioridadTerminados.MinimumWidth = 8;
            PrioridadTerminados.Name = "PrioridadTerminados";
            PrioridadTerminados.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn21.HeaderText = "Estado";
            dataGridViewTextBoxColumn21.MinimumWidth = 8;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label19);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1020, 44);
            panel5.TabIndex = 0;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Green;
            label19.Location = new Point(434, 5);
            label19.Name = "label19";
            label19.Size = new Size(152, 32);
            label19.TabIndex = 3;
            label19.Text = "Terminados";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1959, 873);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Planificador de procesos";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnl_Algoritmos.ResumeLayout(false);
            pnl_Algoritmos.PerformLayout();
            pnl_ProcesoActual.ResumeLayout(false);
            pnl_ProcesoActual.PerformLayout();
            pnl_Generador.ResumeLayout(false);
            pnl_Generador.PerformLayout();
            pnl_Estadisticas.ResumeLayout(false);
            pnl_Estadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)np_Quantum).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxTiempoLlegada).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinTiempoLlegada).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Nuevos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Listo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnl_Algoritmos;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton rb_SRTF;
        private RadioButton rb_RoundRobin;
        private RadioButton rb_PrioridadesNoExpulsivo;
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
        private NumericUpDown np_MinBurstTime;
        private Label lb_BurstTime;
        private NumericUpDown np_MaxIOBurstTime;
        private NumericUpDown np_MinIOBurstTime;
        private Label lb_BurstTimeIO;
        private NumericUpDown np_MaxBurstTime;
        private NumericUpDown np_MaxPrioridad;
        private NumericUpDown np_MinPrioridad;
        private Label lb_Prioridad;
        private NumericUpDown np_Cantidad;
        private Label lb_Cantidad;
        private NumericUpDown np_MinTiempoLlegada;
        private Label lb_TiempoLlegada;
        private ComboBox cmb_Tick;
        private Label lb_TiempoTick;
        private Button btn_Limpiar;
        private Button btn_Simular;
        private ToolTip toolTip;
        private Label lbl_UsoProcesador;
        private Label label5;
        private Label label4;
        private Label lbl_TiempoPromEjecucion;
        private Label label6;
        private Label lbl_TiempoPromBloqueo;
        private Label label9;
        private Label lbl_TiempoPromEspera;
        private Label label7;
        private Label lbl_ProcesosPorPaso;
        private Label label17;
        private Label lbl_ProcesosCompletados;
        private Label label10;
        private Label lbl_TiempoTotal;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private Panel pnl_ProcesoActual;
        private Label label20;
        private Label lbl_ID;
        private Label label22;
        private Button btn_Reiniciar;
        private Button btn_CambiarAlgoritmo;
        private Label lbl_TiempoLlegada;
        private Label label24;
        private Label lbl_TiempoCPU;
        private Label label28;
        private Label lbl_YaHizoIO;
        private Label label27;
        private Label lbl_Prioridad;
        private Label label26;
        private Label lbl_IOBurstTime;
        private Label label25;
        private Label lbl_BurstTime;
        private Label label23;
        private Label lbl_Estado;
        private Label label31;
        private Label lbl_TiempoEspera;
        private Label label30;
        private Label lbl_TiempoIO;
        private Label label29;
        private System.Windows.Forms.Timer timer;
        private NumericUpDown np_MaxTiempoLlegada;
        private NumericUpDown np_Quantum;
        private Label lb_Quantum;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView Grid_Terminados;
        private DataGridViewTextBoxColumn TiempoEspera;
        private DataGridViewTextBoxColumn TiempoBloqueadoAcumulado;
        private DataGridViewTextBoxColumn TickFinalizacion;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView Grid_Bloqueados;
        private Label label18;
        private DataGridView Grid_Nuevos;
        private Label label32;
        private DataGridView Grid_Listo;
        private Label label15;
        private Label label19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn PrioridadNuevos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn PrioridadTerminados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn TiempoRestanteCPUBloqueo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn PrioridadBloqueados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TiempoLlegada;
        private DataGridViewTextBoxColumn BurstTime;
        private DataGridViewTextBoxColumn TiempoRestanteCPU;
        private DataGridViewTextBoxColumn IOBurstTime;
        private DataGridViewTextBoxColumn Prioridad;
        private DataGridViewTextBoxColumn Estado;
    }
}
