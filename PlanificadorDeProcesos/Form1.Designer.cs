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
            label21 = new Label();
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
            btn_Generar = new Button();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            cb_Tick = new ComboBox();
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
            Grid_EnEspera = new DataGridView();
            panel1 = new Panel();
            label15 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            Grid_Bloqueados = new DataGridView();
            panel2 = new Panel();
            label18 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            Grid_Terminados = new DataGridView();
            panel3 = new Panel();
            label19 = new Label();
            toolTip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnl_Algoritmos.SuspendLayout();
            pnl_ProcesoActual.SuspendLayout();
            pnl_Generador.SuspendLayout();
            pnl_Estadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_EnEspera).BeginInit();
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
            tableLayoutPanel1.Size = new Size(2043, 785);
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6996155F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3003845F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(935, 779);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
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
            pnl_Algoritmos.Location = new Point(3, 3);
            pnl_Algoritmos.Name = "pnl_Algoritmos";
            pnl_Algoritmos.Size = new Size(929, 350);
            pnl_Algoritmos.TabIndex = 0;
            // 
            // pnl_ProcesoActual
            // 
            pnl_ProcesoActual.Controls.Add(label21);
            pnl_ProcesoActual.Controls.Add(label22);
            pnl_ProcesoActual.Controls.Add(label20);
            pnl_ProcesoActual.Dock = DockStyle.Fill;
            pnl_ProcesoActual.Location = new Point(0, 0);
            pnl_ProcesoActual.Name = "pnl_ProcesoActual";
            pnl_ProcesoActual.Size = new Size(927, 348);
            pnl_ProcesoActual.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(176, 72);
            label21.Name = "label21";
            label21.Size = new Size(65, 28);
            label21.TabIndex = 17;
            label21.Text = "label6";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label22.ForeColor = Color.RoyalBlue;
            label22.Location = new Point(31, 72);
            label22.Name = "label22";
            label22.Size = new Size(118, 28);
            label22.TabIndex = 16;
            label22.Text = "ID proceso:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.DarkBlue;
            label20.Location = new Point(324, 13);
            label20.Name = "label20";
            label20.Size = new Size(237, 45);
            label20.TabIndex = 14;
            label20.Text = "Proceso actual";
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
            pnl_Generador.BorderStyle = BorderStyle.FixedSingle;
            pnl_Generador.Controls.Add(pnl_Estadisticas);
            pnl_Generador.Controls.Add(btn_Limpiar);
            pnl_Generador.Controls.Add(btn_Generar);
            pnl_Generador.Controls.Add(numericUpDown1);
            pnl_Generador.Controls.Add(label14);
            pnl_Generador.Controls.Add(cb_Tick);
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
            pnl_Generador.Location = new Point(3, 359);
            pnl_Generador.Name = "pnl_Generador";
            pnl_Generador.Size = new Size(929, 417);
            pnl_Generador.TabIndex = 1;
            pnl_Generador.Paint += pnl_Generador_Paint;
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
            pnl_Estadisticas.Size = new Size(927, 415);
            pnl_Estadisticas.TabIndex = 2;
            // 
            // btn_Reiniciar
            // 
            btn_Reiniciar.Location = new Point(430, 341);
            btn_Reiniciar.Name = "btn_Reiniciar";
            btn_Reiniciar.Size = new Size(199, 49);
            btn_Reiniciar.TabIndex = 29;
            btn_Reiniciar.Text = "Reiniciar prueba";
            btn_Reiniciar.UseVisualStyleBackColor = true;
            btn_Reiniciar.Click += btn_Reiniciar_Click;
            // 
            // btn_CambiarAlgoritmo
            // 
            btn_CambiarAlgoritmo.Location = new Point(214, 341);
            btn_CambiarAlgoritmo.Name = "btn_CambiarAlgoritmo";
            btn_CambiarAlgoritmo.Size = new Size(199, 49);
            btn_CambiarAlgoritmo.TabIndex = 28;
            btn_CambiarAlgoritmo.Text = "Cambiar algoritmo";
            btn_CambiarAlgoritmo.UseVisualStyleBackColor = true;
            btn_CambiarAlgoritmo.Click += btn_CambiarAlgoritmo_Click;
            // 
            // lbl_TiempoTotal
            // 
            lbl_TiempoTotal.AutoSize = true;
            lbl_TiempoTotal.Font = new Font("Segoe UI", 10F);
            lbl_TiempoTotal.Location = new Point(635, 217);
            lbl_TiempoTotal.Name = "lbl_TiempoTotal";
            lbl_TiempoTotal.Size = new Size(65, 28);
            lbl_TiempoTotal.TabIndex = 27;
            lbl_TiempoTotal.Text = "label6";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(468, 217);
            label16.Name = "label16";
            label16.Size = new Size(134, 28);
            label16.TabIndex = 26;
            label16.Text = "Tiempo total";
            // 
            // lbl_ProcesosPorPaso
            // 
            lbl_ProcesosPorPaso.AutoSize = true;
            lbl_ProcesosPorPaso.Font = new Font("Segoe UI", 10F);
            lbl_ProcesosPorPaso.Location = new Point(850, 165);
            lbl_ProcesosPorPaso.Name = "lbl_ProcesosPorPaso";
            lbl_ProcesosPorPaso.Size = new Size(65, 28);
            lbl_ProcesosPorPaso.TabIndex = 25;
            lbl_ProcesosPorPaso.Text = "label6";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label17.ForeColor = Color.RoyalBlue;
            label17.Location = new Point(468, 164);
            label17.Name = "label17";
            label17.Size = new Size(351, 28);
            label17.TabIndex = 24;
            label17.Text = "Arribo de nuevos procesos por paso";
            // 
            // lbl_ProcesosCompletados
            // 
            lbl_ProcesosCompletados.AutoSize = true;
            lbl_ProcesosCompletados.Font = new Font("Segoe UI", 10F);
            lbl_ProcesosCompletados.Location = new Point(774, 108);
            lbl_ProcesosCompletados.Name = "lbl_ProcesosCompletados";
            lbl_ProcesosCompletados.Size = new Size(65, 28);
            lbl_ProcesosCompletados.TabIndex = 23;
            lbl_ProcesosCompletados.Text = "label6";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(468, 108);
            label10.Name = "label10";
            label10.Size = new Size(275, 28);
            label10.TabIndex = 22;
            label10.Text = "Total procesos completados";
            // 
            // lbl_TiempoPromEjecucion
            // 
            lbl_TiempoPromEjecucion.AutoSize = true;
            lbl_TiempoPromEjecucion.Font = new Font("Segoe UI", 10F);
            lbl_TiempoPromEjecucion.Location = new Point(367, 271);
            lbl_TiempoPromEjecucion.Name = "lbl_TiempoPromEjecucion";
            lbl_TiempoPromEjecucion.Size = new Size(65, 28);
            lbl_TiempoPromEjecucion.TabIndex = 21;
            lbl_TiempoPromEjecucion.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(21, 271);
            label6.Name = "label6";
            label6.Size = new Size(305, 28);
            label6.TabIndex = 20;
            label6.Text = "Tiempo promedio de ejecución";
            // 
            // lbl_TiempoPromBloqueo
            // 
            lbl_TiempoPromBloqueo.AutoSize = true;
            lbl_TiempoPromBloqueo.Font = new Font("Segoe UI", 10F);
            lbl_TiempoPromBloqueo.Location = new Point(348, 214);
            lbl_TiempoPromBloqueo.Name = "lbl_TiempoPromBloqueo";
            lbl_TiempoPromBloqueo.Size = new Size(65, 28);
            lbl_TiempoPromBloqueo.TabIndex = 19;
            lbl_TiempoPromBloqueo.Text = "label6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(21, 214);
            label9.Name = "label9";
            label9.Size = new Size(292, 28);
            label9.TabIndex = 18;
            label9.Text = "Tiempo promedio de bloqueo";
            // 
            // lbl_TiempoPromEspera
            // 
            lbl_TiempoPromEspera.AutoSize = true;
            lbl_TiempoPromEspera.Font = new Font("Segoe UI", 10F);
            lbl_TiempoPromEspera.Location = new Point(339, 161);
            lbl_TiempoPromEspera.Name = "lbl_TiempoPromEspera";
            lbl_TiempoPromEspera.Size = new Size(65, 28);
            lbl_TiempoPromEspera.TabIndex = 17;
            lbl_TiempoPromEspera.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(21, 161);
            label7.Name = "label7";
            label7.Size = new Size(277, 28);
            label7.TabIndex = 16;
            label7.Text = "Tiempo promedio de espera";
            // 
            // lbl_UsoProcesador
            // 
            lbl_UsoProcesador.AutoSize = true;
            lbl_UsoProcesador.Font = new Font("Segoe UI", 10F);
            lbl_UsoProcesador.Location = new Point(248, 105);
            lbl_UsoProcesador.Name = "lbl_UsoProcesador";
            lbl_UsoProcesador.Size = new Size(65, 28);
            lbl_UsoProcesador.TabIndex = 15;
            lbl_UsoProcesador.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(21, 105);
            label5.Name = "label5";
            label5.Size = new Size(193, 28);
            label5.TabIndex = 14;
            label5.Text = "Uso del procesador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(268, 19);
            label4.Name = "label4";
            label4.Size = new Size(348, 45);
            label4.TabIndex = 13;
            label4.Text = "Estadísticas algoritmo";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(749, 159);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(133, 49);
            btn_Limpiar.TabIndex = 35;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_Generar
            // 
            btn_Generar.Location = new Point(749, 76);
            btn_Generar.Name = "btn_Generar";
            btn_Generar.Size = new Size(133, 49);
            btn_Generar.TabIndex = 34;
            btn_Generar.Text = "Generar";
            btn_Generar.UseVisualStyleBackColor = true;
            btn_Generar.Click += btn_Generar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(379, 327);
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
            label14.Location = new Point(379, 289);
            label14.Name = "label14";
            label14.Size = new Size(177, 25);
            label14.TabIndex = 32;
            label14.Text = "Tiempo de llegada";
            // 
            // cb_Tick
            // 
            cb_Tick.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Tick.FormattingEnabled = true;
            cb_Tick.Location = new Point(379, 220);
            cb_Tick.Name = "cb_Tick";
            cb_Tick.Size = new Size(198, 33);
            cb_Tick.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.RoyalBlue;
            label13.Location = new Point(379, 183);
            label13.Name = "label13";
            label13.Size = new Size(151, 25);
            label13.TabIndex = 30;
            label13.Text = "Tiempo del tick";
            // 
            // np_Cantidad
            // 
            np_Cantidad.Location = new Point(379, 113);
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
            label12.Location = new Point(379, 75);
            label12.Name = "label12";
            label12.Size = new Size(292, 25);
            label12.TabIndex = 28;
            label12.Text = "Cantidad de procesos a generar";
            // 
            // np_MaxPrioridad
            // 
            np_MaxPrioridad.Location = new Point(176, 327);
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
            np_MinPrioridad.Location = new Point(21, 327);
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
            // np_MaxIOBurstTime
            // 
            np_MaxIOBurstTime.Location = new Point(176, 221);
            np_MaxIOBurstTime.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            np_MaxIOBurstTime.Name = "np_MaxIOBurstTime";
            np_MaxIOBurstTime.Size = new Size(90, 31);
            np_MaxIOBurstTime.TabIndex = 21;
            toolTip.SetToolTip(np_MaxIOBurstTime, "Max");
            // 
            // np_MinIOBurstTime
            // 
            np_MinIOBurstTime.Location = new Point(21, 221);
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
            // np_MaxBurstTime
            // 
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
            np_MinBurstTime.Location = new Point(21, 113);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(944, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(1096, 779);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Grid_EnEspera, 0, 1);
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1090, 253);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // Grid_EnEspera
            // 
            Grid_EnEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_EnEspera.Dock = DockStyle.Fill;
            Grid_EnEspera.Location = new Point(3, 48);
            Grid_EnEspera.Name = "Grid_EnEspera";
            Grid_EnEspera.RowHeadersWidth = 62;
            Grid_EnEspera.Size = new Size(1084, 202);
            Grid_EnEspera.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label15);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 39);
            panel1.TabIndex = 1;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.MediumVioletRed;
            label15.Location = new Point(492, 2);
            label15.Name = "label15";
            label15.Size = new Size(125, 32);
            label15.TabIndex = 0;
            label15.Text = "En espera";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(Grid_Bloqueados, 0, 1);
            tableLayoutPanel5.Controls.Add(panel2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 262);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1090, 253);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // Grid_Bloqueados
            // 
            Grid_Bloqueados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Bloqueados.Dock = DockStyle.Fill;
            Grid_Bloqueados.Location = new Point(3, 48);
            Grid_Bloqueados.Name = "Grid_Bloqueados";
            Grid_Bloqueados.RowHeadersWidth = 62;
            Grid_Bloqueados.Size = new Size(1084, 202);
            Grid_Bloqueados.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label18);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 39);
            panel2.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(489, 3);
            label18.Name = "label18";
            label18.Size = new Size(144, 32);
            label18.TabIndex = 1;
            label18.Text = "En bloqueo";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(Grid_Terminados, 0, 1);
            tableLayoutPanel6.Controls.Add(panel3, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 521);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1090, 255);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // Grid_Terminados
            // 
            Grid_Terminados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Terminados.Dock = DockStyle.Fill;
            Grid_Terminados.Location = new Point(3, 48);
            Grid_Terminados.Name = "Grid_Terminados";
            Grid_Terminados.RowHeadersWidth = 62;
            Grid_Terminados.Size = new Size(1084, 204);
            Grid_Terminados.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label19);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 39);
            panel3.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Green;
            label19.Location = new Point(479, 3);
            label19.Name = "label19";
            label19.Size = new Size(152, 32);
            label19.TabIndex = 2;
            label19.Text = "Terminados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2043, 785);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinPrioridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinIOBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MaxBurstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)np_MinBurstTime).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_EnEspera).EndInit();
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
        private NumericUpDown numericUpDown1;
        private Label label14;
        private ComboBox cb_Tick;
        private Label label13;
        private Button btn_Limpiar;
        private Button btn_Generar;
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
        private Label label21;
        private Label label22;
        private Button btn_Reiniciar;
        private Button btn_CambiarAlgoritmo;
    }
}
