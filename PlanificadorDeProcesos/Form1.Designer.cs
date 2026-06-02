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
            btn_Limpiar = new Button();
            btn_Simular = new Button();
            np_TiempoLlegada = new NumericUpDown();
            label14 = new Label();
            cmb_Tick = new ComboBox();
            label13 = new Label();
            np_Cantidad = new NumericUpDown();
            label12 = new Label();
            np_MaxPrioridad = new NumericUpDown();
            np_MinPrioridad = new NumericUpDown();
            label11 = new Label();
            np_MaxIOBurstTime = new NumericUpDown();
            np_MinIOBurstTime = new NumericUpDown();
            label8 = new Label();
            np_MaxBurstTime = new NumericUpDown();
            np_MinBurstTime = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            Grid_Listo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TiempoLlegada = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            IOBurstTime = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label15 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            Grid_Bloqueados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label18 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            Grid_Terminados = new DataGridView();
            panel3 = new Panel();
            label19 = new Label();
            toolTip = new ToolTip(components);
            timer = new System.Windows.Forms.Timer(components);
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            TiempoEspera = new DataGridViewTextBoxColumn();
            TiempoBloqueadoAcumulado = new DataGridViewTextBoxColumn();
            TickFinalizacion = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnl_Algoritmos.SuspendLayout();
            pnl_ProcesoActual.SuspendLayout();
            pnl_Generador.SuspendLayout();
            pnl_Estadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)np_TiempoLlegada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Listo).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).BeginInit();
            panel3.SuspendLayout();
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
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(1371, 471);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnl_Algoritmos, 0, 0);
            tableLayoutPanel2.Controls.Add(pnl_Generador, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6996155F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3003845F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel2.Size = new Size(645, 467);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnl_Algoritmos
            // 
            pnl_Algoritmos.BorderStyle = BorderStyle.FixedSingle;
            pnl_Algoritmos.Controls.Add(pnl_ProcesoActual);
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
            pnl_Algoritmos.Location = new Point(2, 2);
            pnl_Algoritmos.Margin = new Padding(2);
            pnl_Algoritmos.Name = "pnl_Algoritmos";
            pnl_Algoritmos.Size = new Size(641, 209);
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
            pnl_ProcesoActual.Margin = new Padding(2);
            pnl_ProcesoActual.Name = "pnl_ProcesoActual";
            pnl_ProcesoActual.Size = new Size(639, 207);
            pnl_ProcesoActual.TabIndex = 14;
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 10F);
            lbl_Estado.Location = new Point(538, 176);
            lbl_Estado.Margin = new Padding(2, 0, 2, 0);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(45, 19);
            lbl_Estado.TabIndex = 35;
            lbl_Estado.Text = "label6";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label31.ForeColor = Color.RoyalBlue;
            label31.Location = new Point(363, 176);
            label31.Margin = new Padding(2, 0, 2, 0);
            label31.Name = "label31";
            label31.Size = new Size(57, 19);
            label31.TabIndex = 34;
            label31.Text = "Estado:";
            // 
            // lbl_TiempoEspera
            // 
            lbl_TiempoEspera.AutoSize = true;
            lbl_TiempoEspera.Font = new Font("Segoe UI", 10F);
            lbl_TiempoEspera.Location = new Point(538, 145);
            lbl_TiempoEspera.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoEspera.Name = "lbl_TiempoEspera";
            lbl_TiempoEspera.Size = new Size(45, 19);
            lbl_TiempoEspera.TabIndex = 33;
            lbl_TiempoEspera.Text = "label6";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label30.ForeColor = Color.RoyalBlue;
            label30.Location = new Point(363, 145);
            label30.Margin = new Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new Size(134, 19);
            label30.TabIndex = 32;
            label30.Text = "Tiempo de espera:";
            // 
            // lbl_TiempoIO
            // 
            lbl_TiempoIO.AutoSize = true;
            lbl_TiempoIO.Font = new Font("Segoe UI", 10F);
            lbl_TiempoIO.Location = new Point(538, 114);
            lbl_TiempoIO.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoIO.Name = "lbl_TiempoIO";
            lbl_TiempoIO.Size = new Size(45, 19);
            lbl_TiempoIO.TabIndex = 31;
            lbl_TiempoIO.Text = "label6";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label29.ForeColor = Color.RoyalBlue;
            label29.Location = new Point(363, 114);
            label29.Margin = new Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new Size(162, 19);
            label29.TabIndex = 30;
            label29.Text = "Tiempo restante de IO:";
            // 
            // lbl_TiempoCPU
            // 
            lbl_TiempoCPU.AutoSize = true;
            lbl_TiempoCPU.Font = new Font("Segoe UI", 10F);
            lbl_TiempoCPU.Location = new Point(538, 83);
            lbl_TiempoCPU.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoCPU.Name = "lbl_TiempoCPU";
            lbl_TiempoCPU.Size = new Size(45, 19);
            lbl_TiempoCPU.TabIndex = 29;
            lbl_TiempoCPU.Text = "label6";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label28.ForeColor = Color.RoyalBlue;
            label28.Location = new Point(363, 83);
            label28.Margin = new Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new Size(175, 19);
            label28.TabIndex = 28;
            label28.Text = "Tiempo restante de CPU:";
            // 
            // lbl_YaHizoIO
            // 
            lbl_YaHizoIO.AutoSize = true;
            lbl_YaHizoIO.Font = new Font("Segoe UI", 10F);
            lbl_YaHizoIO.Location = new Point(538, 49);
            lbl_YaHizoIO.Margin = new Padding(2, 0, 2, 0);
            lbl_YaHizoIO.Name = "lbl_YaHizoIO";
            lbl_YaHizoIO.Size = new Size(45, 19);
            lbl_YaHizoIO.TabIndex = 27;
            lbl_YaHizoIO.Text = "label6";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label27.ForeColor = Color.RoyalBlue;
            label27.Location = new Point(363, 49);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(113, 19);
            label27.TabIndex = 26;
            label27.Text = "IO completado:";
            // 
            // lbl_Prioridad
            // 
            lbl_Prioridad.AutoSize = true;
            lbl_Prioridad.Font = new Font("Segoe UI", 10F);
            lbl_Prioridad.Location = new Point(178, 176);
            lbl_Prioridad.Margin = new Padding(2, 0, 2, 0);
            lbl_Prioridad.Name = "lbl_Prioridad";
            lbl_Prioridad.Size = new Size(45, 19);
            lbl_Prioridad.TabIndex = 25;
            lbl_Prioridad.Text = "label6";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label26.ForeColor = Color.RoyalBlue;
            label26.Location = new Point(40, 176);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(77, 19);
            label26.TabIndex = 24;
            label26.Text = "Prioridad:";
            // 
            // lbl_IOBurstTime
            // 
            lbl_IOBurstTime.AutoSize = true;
            lbl_IOBurstTime.Font = new Font("Segoe UI", 10F);
            lbl_IOBurstTime.Location = new Point(178, 145);
            lbl_IOBurstTime.Margin = new Padding(2, 0, 2, 0);
            lbl_IOBurstTime.Name = "lbl_IOBurstTime";
            lbl_IOBurstTime.Size = new Size(45, 19);
            lbl_IOBurstTime.TabIndex = 23;
            lbl_IOBurstTime.Text = "label6";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label25.ForeColor = Color.RoyalBlue;
            label25.Location = new Point(40, 145);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(103, 19);
            label25.TabIndex = 22;
            label25.Text = "IO Burst Time:";
            // 
            // lbl_BurstTime
            // 
            lbl_BurstTime.AutoSize = true;
            lbl_BurstTime.Font = new Font("Segoe UI", 10F);
            lbl_BurstTime.Location = new Point(178, 114);
            lbl_BurstTime.Margin = new Padding(2, 0, 2, 0);
            lbl_BurstTime.Name = "lbl_BurstTime";
            lbl_BurstTime.Size = new Size(45, 19);
            lbl_BurstTime.TabIndex = 21;
            lbl_BurstTime.Text = "label6";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label23.ForeColor = Color.RoyalBlue;
            label23.Location = new Point(40, 114);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(84, 19);
            label23.TabIndex = 20;
            label23.Text = "Burst Time:";
            // 
            // lbl_TiempoLlegada
            // 
            lbl_TiempoLlegada.AutoSize = true;
            lbl_TiempoLlegada.Font = new Font("Segoe UI", 10F);
            lbl_TiempoLlegada.Location = new Point(178, 83);
            lbl_TiempoLlegada.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoLlegada.Name = "lbl_TiempoLlegada";
            lbl_TiempoLlegada.Size = new Size(45, 19);
            lbl_TiempoLlegada.TabIndex = 19;
            lbl_TiempoLlegada.Text = "label6";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label24.ForeColor = Color.RoyalBlue;
            label24.Location = new Point(40, 83);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(139, 19);
            label24.TabIndex = 18;
            label24.Text = "Tiempo de llegada:";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 10F);
            lbl_ID.Location = new Point(178, 49);
            lbl_ID.Margin = new Padding(2, 0, 2, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(45, 19);
            lbl_ID.TabIndex = 17;
            lbl_ID.Text = "label6";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label22.ForeColor = Color.RoyalBlue;
            label22.Location = new Point(40, 49);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(85, 19);
            label22.TabIndex = 16;
            label22.Text = "ID proceso:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.DarkBlue;
            label20.Location = new Point(227, 8);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(164, 30);
            label20.TabIndex = 14;
            label20.Text = "Proceso actual";
            // 
            // lbl_Expulsivos
            // 
            lbl_Expulsivos.AutoSize = true;
            lbl_Expulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Expulsivos.ForeColor = Color.RoyalBlue;
            lbl_Expulsivos.Location = new Point(365, 50);
            lbl_Expulsivos.Margin = new Padding(2, 0, 2, 0);
            lbl_Expulsivos.Name = "lbl_Expulsivos";
            lbl_Expulsivos.Size = new Size(93, 20);
            lbl_Expulsivos.TabIndex = 13;
            lbl_Expulsivos.Text = "Expulsivos:";
            // 
            // lbl_NoExpulsivos
            // 
            lbl_NoExpulsivos.AutoSize = true;
            lbl_NoExpulsivos.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NoExpulsivos.ForeColor = Color.RoyalBlue;
            lbl_NoExpulsivos.Location = new Point(22, 50);
            lbl_NoExpulsivos.Margin = new Padding(2, 0, 2, 0);
            lbl_NoExpulsivos.Name = "lbl_NoExpulsivos";
            lbl_NoExpulsivos.Size = new Size(119, 20);
            lbl_NoExpulsivos.TabIndex = 12;
            lbl_NoExpulsivos.Text = "No expulsivos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(158, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 30);
            label1.TabIndex = 11;
            label1.Text = "Algoritmos de planificación";
            // 
            // rb_PrioridadesExpulsivo
            // 
            rb_PrioridadesExpulsivo.AutoSize = true;
            rb_PrioridadesExpulsivo.Location = new Point(365, 139);
            rb_PrioridadesExpulsivo.Margin = new Padding(2);
            rb_PrioridadesExpulsivo.Name = "rb_PrioridadesExpulsivo";
            rb_PrioridadesExpulsivo.Size = new Size(211, 19);
            rb_PrioridadesExpulsivo.TabIndex = 10;
            rb_PrioridadesExpulsivo.TabStop = true;
            rb_PrioridadesExpulsivo.Text = "Planificacion basada en prioridades";
            rb_PrioridadesExpulsivo.UseVisualStyleBackColor = true;
            // 
            // rb_SRTF
            // 
            rb_SRTF.AutoSize = true;
            rb_SRTF.Location = new Point(365, 107);
            rb_SRTF.Margin = new Padding(2);
            rb_SRTF.Name = "rb_SRTF";
            rb_SRTF.Size = new Size(254, 19);
            rb_SRTF.TabIndex = 9;
            rb_SRTF.TabStop = true;
            rb_SRTF.Text = "Primero el de menor tiempo restante (SRTF)";
            rb_SRTF.UseVisualStyleBackColor = true;
            // 
            // rb_RoundRobin
            // 
            rb_RoundRobin.AutoSize = true;
            rb_RoundRobin.Location = new Point(365, 76);
            rb_RoundRobin.Margin = new Padding(2);
            rb_RoundRobin.Name = "rb_RoundRobin";
            rb_RoundRobin.Size = new Size(183, 19);
            rb_RoundRobin.TabIndex = 8;
            rb_RoundRobin.TabStop = true;
            rb_RoundRobin.Text = "Turno Rotativo (Round Robin)";
            rb_RoundRobin.UseVisualStyleBackColor = true;
            // 
            // rb_Prioridades
            // 
            rb_Prioridades.AutoSize = true;
            rb_Prioridades.Location = new Point(22, 170);
            rb_Prioridades.Margin = new Padding(2);
            rb_Prioridades.Name = "rb_Prioridades";
            rb_Prioridades.Size = new Size(211, 19);
            rb_Prioridades.TabIndex = 7;
            rb_Prioridades.TabStop = true;
            rb_Prioridades.Text = "Planificación basada en prioridades";
            rb_Prioridades.UseVisualStyleBackColor = true;
            // 
            // rb_SeleccionAleatoria
            // 
            rb_SeleccionAleatoria.AutoSize = true;
            rb_SeleccionAleatoria.Location = new Point(22, 139);
            rb_SeleccionAleatoria.Margin = new Padding(2);
            rb_SeleccionAleatoria.Name = "rb_SeleccionAleatoria";
            rb_SeleccionAleatoria.Size = new Size(125, 19);
            rb_SeleccionAleatoria.TabIndex = 6;
            rb_SeleccionAleatoria.TabStop = true;
            rb_SeleccionAleatoria.Text = "Seleccion Aleatoria";
            rb_SeleccionAleatoria.UseVisualStyleBackColor = true;
            // 
            // rb_SJF
            // 
            rb_SJF.AutoSize = true;
            rb_SJF.Location = new Point(22, 107);
            rb_SJF.Margin = new Padding(2);
            rb_SJF.Name = "rb_SJF";
            rb_SJF.Size = new Size(202, 19);
            rb_SJF.TabIndex = 5;
            rb_SJF.TabStop = true;
            rb_SJF.Text = "Primero el trabajo más corto (SJF)";
            rb_SJF.UseVisualStyleBackColor = true;
            // 
            // rb_FCFS
            // 
            rb_FCFS.AutoSize = true;
            rb_FCFS.Location = new Point(22, 76);
            rb_FCFS.Margin = new Padding(2);
            rb_FCFS.Name = "rb_FCFS";
            rb_FCFS.Size = new Size(269, 19);
            rb_FCFS.TabIndex = 4;
            rb_FCFS.TabStop = true;
            rb_FCFS.Text = "Primero en llegar primero en ejecutarse (FCFS)";
            rb_FCFS.UseVisualStyleBackColor = true;
            // 
            // pnl_Generador
            // 
            pnl_Generador.BorderStyle = BorderStyle.FixedSingle;
            pnl_Generador.Controls.Add(pnl_Estadisticas);
            pnl_Generador.Controls.Add(btn_Limpiar);
            pnl_Generador.Controls.Add(btn_Simular);
            pnl_Generador.Controls.Add(np_TiempoLlegada);
            pnl_Generador.Controls.Add(label14);
            pnl_Generador.Controls.Add(cmb_Tick);
            pnl_Generador.Controls.Add(label13);
            pnl_Generador.Controls.Add(np_Cantidad);
            pnl_Generador.Controls.Add(label12);
            pnl_Generador.Controls.Add(np_MaxPrioridad);
            pnl_Generador.Controls.Add(np_MinPrioridad);
            pnl_Generador.Controls.Add(label11);
            pnl_Generador.Controls.Add(np_MaxIOBurstTime);
            pnl_Generador.Controls.Add(np_MinIOBurstTime);
            pnl_Generador.Controls.Add(label8);
            pnl_Generador.Controls.Add(np_MaxBurstTime);
            pnl_Generador.Controls.Add(np_MinBurstTime);
            pnl_Generador.Controls.Add(label3);
            pnl_Generador.Controls.Add(label2);
            pnl_Generador.Dock = DockStyle.Fill;
            pnl_Generador.Location = new Point(2, 215);
            pnl_Generador.Margin = new Padding(2);
            pnl_Generador.Name = "pnl_Generador";
            pnl_Generador.Size = new Size(641, 250);
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
            pnl_Estadisticas.Margin = new Padding(2);
            pnl_Estadisticas.Name = "pnl_Estadisticas";
            pnl_Estadisticas.Size = new Size(639, 248);
            pnl_Estadisticas.TabIndex = 2;
            // 
            // btn_Reiniciar
            // 
            btn_Reiniciar.Location = new Point(301, 205);
            btn_Reiniciar.Margin = new Padding(2);
            btn_Reiniciar.Name = "btn_Reiniciar";
            btn_Reiniciar.Padding = new Padding(0, 1, 0, 1);
            btn_Reiniciar.Size = new Size(139, 29);
            btn_Reiniciar.TabIndex = 29;
            btn_Reiniciar.Text = "Reiniciar prueba";
            btn_Reiniciar.UseVisualStyleBackColor = true;
            btn_Reiniciar.Click += btn_Reiniciar_Click;
            // 
            // btn_CambiarAlgoritmo
            // 
            btn_CambiarAlgoritmo.Location = new Point(150, 205);
            btn_CambiarAlgoritmo.Margin = new Padding(2);
            btn_CambiarAlgoritmo.Name = "btn_CambiarAlgoritmo";
            btn_CambiarAlgoritmo.Padding = new Padding(0, 1, 0, 1);
            btn_CambiarAlgoritmo.Size = new Size(139, 29);
            btn_CambiarAlgoritmo.TabIndex = 28;
            btn_CambiarAlgoritmo.Text = "Cambiar algoritmo";
            btn_CambiarAlgoritmo.UseVisualStyleBackColor = true;
            btn_CambiarAlgoritmo.Click += btn_CambiarAlgoritmo_Click;
            // 
            // lbl_TiempoTotal
            // 
            lbl_TiempoTotal.AutoSize = true;
            lbl_TiempoTotal.Font = new Font("Segoe UI", 9F);
            lbl_TiempoTotal.Location = new Point(416, 130);
            lbl_TiempoTotal.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoTotal.Name = "lbl_TiempoTotal";
            lbl_TiempoTotal.Size = new Size(38, 15);
            lbl_TiempoTotal.TabIndex = 27;
            lbl_TiempoTotal.Text = "label6";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(315, 130);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(78, 15);
            label16.TabIndex = 26;
            label16.Text = "Tiempo total";
            // 
            // lbl_ProcesosPorPaso
            // 
            lbl_ProcesosPorPaso.AutoSize = true;
            lbl_ProcesosPorPaso.Font = new Font("Segoe UI", 9F);
            lbl_ProcesosPorPaso.Location = new Point(530, 99);
            lbl_ProcesosPorPaso.Margin = new Padding(2, 0, 2, 0);
            lbl_ProcesosPorPaso.Name = "lbl_ProcesosPorPaso";
            lbl_ProcesosPorPaso.Size = new Size(38, 15);
            lbl_ProcesosPorPaso.TabIndex = 25;
            lbl_ProcesosPorPaso.Text = "label6";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.ForeColor = Color.RoyalBlue;
            label17.Location = new Point(315, 98);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(204, 15);
            label17.TabIndex = 24;
            label17.Text = "Arribo de nuevos procesos por paso";
            // 
            // lbl_ProcesosCompletados
            // 
            lbl_ProcesosCompletados.AutoSize = true;
            lbl_ProcesosCompletados.Font = new Font("Segoe UI", 9F);
            lbl_ProcesosCompletados.Location = new Point(530, 65);
            lbl_ProcesosCompletados.Margin = new Padding(2, 0, 2, 0);
            lbl_ProcesosCompletados.Name = "lbl_ProcesosCompletados";
            lbl_ProcesosCompletados.Size = new Size(38, 15);
            lbl_ProcesosCompletados.TabIndex = 23;
            lbl_ProcesosCompletados.Text = "label6";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(315, 65);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(160, 15);
            label10.TabIndex = 22;
            label10.Text = "Total procesos completados";
            // 
            // lbl_TiempoPromEjecucion
            // 
            lbl_TiempoPromEjecucion.AutoSize = true;
            lbl_TiempoPromEjecucion.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromEjecucion.Location = new Point(216, 163);
            lbl_TiempoPromEjecucion.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoPromEjecucion.Name = "lbl_TiempoPromEjecucion";
            lbl_TiempoPromEjecucion.Size = new Size(38, 15);
            lbl_TiempoPromEjecucion.TabIndex = 21;
            lbl_TiempoPromEjecucion.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(15, 163);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 15);
            label6.TabIndex = 20;
            label6.Text = "Tiempo promedio de ejecución";
            // 
            // lbl_TiempoPromBloqueo
            // 
            lbl_TiempoPromBloqueo.AutoSize = true;
            lbl_TiempoPromBloqueo.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromBloqueo.Location = new Point(216, 128);
            lbl_TiempoPromBloqueo.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoPromBloqueo.Name = "lbl_TiempoPromBloqueo";
            lbl_TiempoPromBloqueo.Size = new Size(38, 15);
            lbl_TiempoPromBloqueo.TabIndex = 19;
            lbl_TiempoPromBloqueo.Text = "label6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(15, 128);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(171, 15);
            label9.TabIndex = 18;
            label9.Text = "Tiempo promedio de bloqueo";
            // 
            // lbl_TiempoPromEspera
            // 
            lbl_TiempoPromEspera.AutoSize = true;
            lbl_TiempoPromEspera.Font = new Font("Segoe UI", 9F);
            lbl_TiempoPromEspera.Location = new Point(216, 97);
            lbl_TiempoPromEspera.Margin = new Padding(2, 0, 2, 0);
            lbl_TiempoPromEspera.Name = "lbl_TiempoPromEspera";
            lbl_TiempoPromEspera.Size = new Size(38, 15);
            lbl_TiempoPromEspera.TabIndex = 17;
            lbl_TiempoPromEspera.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(15, 97);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 16;
            label7.Text = "Tiempo promedio de espera";
            // 
            // lbl_UsoProcesador
            // 
            lbl_UsoProcesador.AutoSize = true;
            lbl_UsoProcesador.Font = new Font("Segoe UI", 9F);
            lbl_UsoProcesador.Location = new Point(150, 63);
            lbl_UsoProcesador.Margin = new Padding(2, 0, 2, 0);
            lbl_UsoProcesador.Name = "lbl_UsoProcesador";
            lbl_UsoProcesador.Size = new Size(38, 15);
            lbl_UsoProcesador.TabIndex = 15;
            lbl_UsoProcesador.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(15, 63);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 14;
            label5.Text = "Uso del procesador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(188, 11);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(242, 30);
            label4.TabIndex = 13;
            label4.Text = "Estadísticas algoritmo";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(510, 105);
            btn_Limpiar.Margin = new Padding(2);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Padding = new Padding(0, 1, 0, 1);
            btn_Limpiar.Size = new Size(93, 29);
            btn_Limpiar.TabIndex = 35;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Simular
            // 
            btn_Simular.Location = new Point(510, 161);
            btn_Simular.Margin = new Padding(2);
            btn_Simular.Name = "btn_Simular";
            btn_Simular.Padding = new Padding(0, 1, 0, 1);
            btn_Simular.Size = new Size(93, 29);
            btn_Simular.TabIndex = 34;
            btn_Simular.Text = "Simular";
            btn_Simular.UseVisualStyleBackColor = true;
            btn_Simular.Click += btn_Generar_Click;
            // 
            // np_TiempoLlegada
            // 
            np_TiempoLlegada.Location = new Point(265, 196);
            np_TiempoLlegada.Margin = new Padding(2);
            np_TiempoLlegada.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_TiempoLlegada.Name = "np_TiempoLlegada";
            np_TiempoLlegada.Size = new Size(63, 23);
            np_TiempoLlegada.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(265, 173);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(119, 15);
            label14.TabIndex = 32;
            label14.Text = "Tiempo de llegada";
            // 
            // cmb_Tick
            // 
            cmb_Tick.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tick.FormattingEnabled = true;
            cmb_Tick.Location = new Point(265, 132);
            cmb_Tick.Margin = new Padding(2);
            cmb_Tick.Name = "cmb_Tick";
            cmb_Tick.Size = new Size(140, 23);
            cmb_Tick.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(265, 110);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 30;
            label13.Text = "Tiempo del tick";
            // 
            // np_Cantidad
            // 
            np_Cantidad.Location = new Point(265, 68);
            np_Cantidad.Margin = new Padding(2);
            np_Cantidad.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            np_Cantidad.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            np_Cantidad.Name = "np_Cantidad";
            np_Cantidad.Size = new Size(63, 23);
            np_Cantidad.TabIndex = 29;
            np_Cantidad.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(265, 45);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(197, 15);
            label12.TabIndex = 28;
            label12.Text = "Cantidad de procesos a generar";
            // 
            // np_MaxPrioridad
            // 
            np_MaxPrioridad.Location = new Point(123, 196);
            np_MaxPrioridad.Margin = new Padding(2);
            np_MaxPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxPrioridad.Name = "np_MaxPrioridad";
            np_MaxPrioridad.Size = new Size(63, 23);
            np_MaxPrioridad.TabIndex = 26;
            toolTip.SetToolTip(np_MaxPrioridad, "Max");
            np_MaxPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // np_MinPrioridad
            // 
            np_MinPrioridad.Location = new Point(15, 196);
            np_MinPrioridad.Margin = new Padding(2);
            np_MinPrioridad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinPrioridad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinPrioridad.Name = "np_MinPrioridad";
            np_MinPrioridad.Size = new Size(63, 23);
            np_MinPrioridad.TabIndex = 24;
            toolTip.SetToolTip(np_MinPrioridad, "MIn");
            np_MinPrioridad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label11.ForeColor = Color.RoyalBlue;
            label11.Location = new Point(15, 173);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 23;
            label11.Text = "Prioridad";
            // 
            // np_MaxIOBurstTime
            // 
            np_MaxIOBurstTime.Location = new Point(123, 133);
            np_MaxIOBurstTime.Margin = new Padding(2);
            np_MaxIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxIOBurstTime.Name = "np_MaxIOBurstTime";
            np_MaxIOBurstTime.Size = new Size(63, 23);
            np_MaxIOBurstTime.TabIndex = 21;
            toolTip.SetToolTip(np_MaxIOBurstTime, "Max");
            // 
            // np_MinIOBurstTime
            // 
            np_MinIOBurstTime.Location = new Point(15, 133);
            np_MinIOBurstTime.Margin = new Padding(2);
            np_MinIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinIOBurstTime.Name = "np_MinIOBurstTime";
            np_MinIOBurstTime.Size = new Size(63, 23);
            np_MinIOBurstTime.TabIndex = 19;
            toolTip.SetToolTip(np_MinIOBurstTime, "MIn");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(15, 110);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 18;
            label8.Text = "I/O Burst Time";
            // 
            // np_MaxBurstTime
            // 
            np_MaxBurstTime.Location = new Point(123, 68);
            np_MaxBurstTime.Margin = new Padding(2);
            np_MaxBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MaxBurstTime.Name = "np_MaxBurstTime";
            np_MaxBurstTime.Size = new Size(63, 23);
            np_MaxBurstTime.TabIndex = 16;
            toolTip.SetToolTip(np_MaxBurstTime, "Max");
            np_MaxBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // np_MinBurstTime
            // 
            np_MinBurstTime.Location = new Point(15, 68);
            np_MinBurstTime.Margin = new Padding(2);
            np_MinBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MinBurstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            np_MinBurstTime.Name = "np_MinBurstTime";
            np_MinBurstTime.Size = new Size(63, 23);
            np_MinBurstTime.TabIndex = 14;
            toolTip.SetToolTip(np_MinBurstTime, "Min");
            np_MinBurstTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(15, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Burst Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(166, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 30);
            label2.TabIndex = 12;
            label2.Text = "Parámetros del generador";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(651, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(718, 467);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Grid_Listo, 0, 1);
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 2);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(714, 151);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // Grid_Listo
            // 
            Grid_Listo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Listo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Listo.Columns.AddRange(new DataGridViewColumn[] { ID, TiempoLlegada, BurstTime, IOBurstTime, Prioridad, Estado });
            Grid_Listo.Dock = DockStyle.Fill;
            Grid_Listo.Location = new Point(2, 29);
            Grid_Listo.Margin = new Padding(2);
            Grid_Listo.Name = "Grid_Listo";
            Grid_Listo.ReadOnly = true;
            Grid_Listo.RowHeadersVisible = false;
            Grid_Listo.RowHeadersWidth = 62;
            Grid_Listo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Listo.ShowEditingIcon = false;
            Grid_Listo.ShowRowErrors = false;
            Grid_Listo.Size = new Size(710, 120);
            Grid_Listo.TabIndex = 0;
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
            // panel1
            // 
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 23);
            panel1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Goldenrod;
            label15.Location = new Point(326, 1);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(57, 21);
            label15.TabIndex = 0;
            label15.Text = "Listos";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel5.Controls.Add(Grid_Bloqueados, 0, 1);
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(2, 157);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(714, 151);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // Grid_Bloqueados
            // 
            Grid_Bloqueados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Bloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Bloqueados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            Grid_Bloqueados.Dock = DockStyle.Fill;
            Grid_Bloqueados.Location = new Point(2, 29);
            Grid_Bloqueados.Margin = new Padding(2);
            Grid_Bloqueados.Name = "Grid_Bloqueados";
            Grid_Bloqueados.ReadOnly = true;
            Grid_Bloqueados.RowHeadersVisible = false;
            Grid_Bloqueados.RowHeadersWidth = 62;
            Grid_Bloqueados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Bloqueados.ShowEditingIcon = false;
            Grid_Bloqueados.ShowRowErrors = false;
            Grid_Bloqueados.Size = new Size(710, 120);
            Grid_Bloqueados.TabIndex = 3;
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
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "IOBurstTime";
            dataGridViewTextBoxColumn4.HeaderText = "IO Burst Time";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Prioridad";
            dataGridViewTextBoxColumn5.HeaderText = "Prioridad";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 23);
            panel2.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(302, 2);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(97, 21);
            label18.TabIndex = 1;
            label18.Text = "En bloqueo";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel6.Controls.Add(Grid_Terminados, 0, 1);
            tableLayoutPanel6.Controls.Add(panel3, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(2, 312);
            tableLayoutPanel6.Margin = new Padding(2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(714, 153);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // Grid_Terminados
            // 
            Grid_Terminados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_Terminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Terminados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, TiempoEspera, TiempoBloqueadoAcumulado, TickFinalizacion, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            Grid_Terminados.Dock = DockStyle.Fill;
            Grid_Terminados.Location = new Point(2, 29);
            Grid_Terminados.Margin = new Padding(2);
            Grid_Terminados.Name = "Grid_Terminados";
            Grid_Terminados.ReadOnly = true;
            Grid_Terminados.RowHeadersVisible = false;
            Grid_Terminados.RowHeadersWidth = 62;
            Grid_Terminados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Terminados.ShowEditingIcon = false;
            Grid_Terminados.ShowRowErrors = false;
            Grid_Terminados.Size = new Size(710, 122);
            Grid_Terminados.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(label19);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(710, 23);
            panel3.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Green;
            label19.Location = new Point(299, 2);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(103, 21);
            label19.TabIndex = 2;
            label19.Text = "Terminados";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            dataGridViewTextBoxColumn7.HeaderText = "ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // TiempoEspera
            // 
            TiempoEspera.DataPropertyName = "TiempoEspera";
            TiempoEspera.HeaderText = "Tiempo de espera";
            TiempoEspera.Name = "TiempoEspera";
            TiempoEspera.ReadOnly = true;
            // 
            // TiempoBloqueadoAcumulado
            // 
            TiempoBloqueadoAcumulado.DataPropertyName = "TiempoBloqueadoAcumulado";
            TiempoBloqueadoAcumulado.HeaderText = "Tiempo de bloqueo total";
            TiempoBloqueadoAcumulado.Name = "TiempoBloqueadoAcumulado";
            TiempoBloqueadoAcumulado.ReadOnly = true;
            // 
            // TickFinalizacion
            // 
            TickFinalizacion.DataPropertyName = "TickFinalizacion";
            TickFinalizacion.HeaderText = "Tick finalizacion";
            TickFinalizacion.Name = "TickFinalizacion";
            TickFinalizacion.ReadOnly = true;
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
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Prioridad";
            dataGridViewTextBoxColumn11.HeaderText = "Prioridad";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn12.HeaderText = "Estado";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 471);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)np_TiempoLlegada).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Listo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Bloqueados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Terminados).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnl_Algoritmos;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView Grid_Listo;
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
        private NumericUpDown np_MinBurstTime;
        private Label label3;
        private NumericUpDown np_MaxIOBurstTime;
        private NumericUpDown np_MinIOBurstTime;
        private Label label8;
        private NumericUpDown np_MaxBurstTime;
        private NumericUpDown np_MaxPrioridad;
        private NumericUpDown np_MinPrioridad;
        private Label label11;
        private NumericUpDown np_Cantidad;
        private Label label12;
        private NumericUpDown np_TiempoLlegada;
        private Label label14;
        private ComboBox cmb_Tick;
        private Label label13;
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
        private Label label15;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel2;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel3;
        private Label label19;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TiempoLlegada;
        private DataGridViewTextBoxColumn BurstTime;
        private DataGridViewTextBoxColumn IOBurstTime;
        private DataGridViewTextBoxColumn Prioridad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridView Grid_Bloqueados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridView Grid_Terminados;
        private System.Windows.Forms.Timer timer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn TiempoEspera;
        private DataGridViewTextBoxColumn TiempoBloqueadoAcumulado;
        private DataGridViewTextBoxColumn TickFinalizacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}
