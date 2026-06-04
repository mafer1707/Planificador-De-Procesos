namespace PlanificadorDeProcesos
{
    using System.ComponentModel;
    using CAT = Class_PlanificadorDeProcesos;
    public partial class Form1 : Form
    {
        #region Variables

        CAT CA = new CAT();

        AlgoritmoPlanificacion algoritmoSeleccionado;
        private BindingSource bsProceso = new BindingSource();
        private int tickActual = 0;
        private int ticksCPUOcupada = 0;
        private int quantumRestanteActual = 0;
        private Random generadorAleatorio = new Random();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Tick.DataSource = CA.ComboValues.ToList();
            cmb_Tick.ValueMember = "Key";
            cmb_Tick.DisplayMember = "Value";

            np_MinPrioridad.Enabled = np_MaxPrioridad.Enabled = rb_PrioridadesExpulsivo.Checked;
            np_Quantum.Enabled = rb_RoundRobin.Checked;

            GridConfig();
            SetToolTips();
            SetBindings();

            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;
        }

        #region Button Events
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            LimpiarEstadisticas();
            btn_Simular.PerformClick();
        }
        private void btn_Simular_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = true;
            pnl_ProcesoActual.Visible = true;

            ConfigurarColumnasGrid();

            LimpiarTodo();
            CA.GenerarLote();

            if (rb_FCFS.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.FCFS;
            else if (rb_SJF.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.SJF;
            else if (rb_SeleccionAleatoria.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.Aleatorio;
            else if (rb_PrioridadesNoExpulsivo.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.PrioridadNoExpulsiva;
            else if (rb_RoundRobin.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.RoundRobin;
            else if (rb_SRTF.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.SRTF;
            else if (rb_PrioridadesExpulsivo.Checked) algoritmoSeleccionado = AlgoritmoPlanificacion.PrioridadExpulsiva;

            timer.Interval = CA.FormData.cmb_Tick;
            timer.Start();
        }
        private void btn_CambiarAlgoritmo_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;

            timer.Stop();
            LimpiarTodo();
            LimpiarEstadisticas();
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            CA.FormData.np_MinBurstTime = 1;
            CA.FormData.np_MaxBurstTime = 5;
            CA.FormData.np_MinIOBurstTime = 0;
            CA.FormData.np_MaxIOBurstTime = 0;
            CA.FormData.np_MinPrioridad = 1;
            CA.FormData.np_MaxPrioridad = 5;
            CA.FormData.np_Cantidad = 5;
            CA.FormData.np_Quantum = 1;
            CA.FormData.cmb_Tick = 100;
            CA.FormData.np_MinTiempoLlegada = 0;
            CA.FormData.np_MaxTiempoLlegada = 0;
        }

        #endregion

        #region RadButton Events
        private void rb_RoundRobin_CheckedChanged(object sender, EventArgs e)
        {
            np_Quantum.Enabled = rb_RoundRobin.Checked;
        }
        private void rb_PrioridadesExpulsivo_CheckedChanged(object sender, EventArgs e)
        {
            np_MinPrioridad.Enabled = np_MaxPrioridad.Enabled = rb_PrioridadesExpulsivo.Checked;
        }
        private void rb_PrioridadesNoExpulsivo_CheckedChanged(object sender, EventArgs e)
        {
            np_MinPrioridad.Enabled = np_MaxPrioridad.Enabled = rb_PrioridadesNoExpulsivo.Checked;
        }

        #endregion

        #region Functions
        private void CalcularEstadisticas()
        {
            if (CA.ProcesosTerminados.Count == 0 || tickActual == 0) return;

            CA.FormData.lbl_TiempoTotal = $"{tickActual} ticks";
            CA.FormData.lbl_ProcesosCompletados = CA.ProcesosTerminados.Count;
            CA.FormData.lbl_UsoProcesador = $"{Math.Round(((double)ticksCPUOcupada / tickActual) * 100, 2)} %";
            CA.FormData.lbl_TiempoPromEspera = $"{Math.Round(CA.ProcesosTerminados.Average(p => p.TiempoEspera), 2)} ticks";
            CA.FormData.lbl_TiempoPromBloqueo = $"{Math.Round(CA.ProcesosTerminados.Average(p => p.TiempoBloqueadoAcumulado), 2)} ticks";
            CA.FormData.lbl_TiempoPromEjecucion = $"{Math.Round(CA.ProcesosTerminados.Average(p => p.TickFinalizacion - p.TiempoLlegada), 2)} ticks";
            CA.FormData.lbl_ProcesosPorPaso = Math.Round((double)CA.ProcesosTerminados.Count / tickActual, 3);
        }
        private void SetBindings()
        {
            bsProceso.DataSource = new Proceso();

            #region Panel Parametros

            np_MinBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_Cantidad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_Cantidad), false, DataSourceUpdateMode.OnPropertyChanged);
            cmb_Tick.DataBindings.Add("SelectedValue", CA.FormData, nameof(CAT.FormData.cmb_Tick), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinTiempoLlegada.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinTiempoLlegada), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxTiempoLlegada.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxTiempoLlegada), false, DataSourceUpdateMode.OnPropertyChanged);
            np_Quantum.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_Quantum), false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion

            # region Panel Estadisticas

            lbl_UsoProcesador.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_UsoProcesador), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromEspera.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromEspera), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromBloqueo.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromBloqueo), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromEjecucion.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromEjecucion), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_ProcesosCompletados.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_ProcesosCompletados), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_ProcesosPorPaso.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_ProcesosPorPaso), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoTotal.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoTotal), false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion

            # region Panel Proceso Actual

            lbl_ID.DataBindings.Add("Text", bsProceso, "ID", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoLlegada.DataBindings.Add("Text", bsProceso, "TiempoLlegada", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_BurstTime.DataBindings.Add("Text", bsProceso, "BurstTime", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_IOBurstTime.DataBindings.Add("Text", bsProceso, "IOBurstTime", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_Prioridad.DataBindings.Add("Text", bsProceso, "Prioridad", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_YaHizoIO.DataBindings.Add("Text", bsProceso, "YaHizoIO", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoCPU.DataBindings.Add("Text", bsProceso, "TiempoRestanteCPU", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoIO.DataBindings.Add("Text", bsProceso, "TiempoRestanteIO", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoEspera.DataBindings.Add("Text", bsProceso, "TiempoEspera", false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_Estado.DataBindings.Add("Text", bsProceso, "Estado", true, DataSourceUpdateMode.OnPropertyChanged);

            #endregion
        }
        private void LimpiarEstadisticas()
        {
            CA.FormData.lbl_TiempoTotal = "0 ticks";
            CA.FormData.lbl_ProcesosCompletados = 0;
            CA.FormData.lbl_UsoProcesador = "0 %";
            CA.FormData.lbl_TiempoPromEspera = "0 ticks";
            CA.FormData.lbl_TiempoPromBloqueo = "0 ticks";
            CA.FormData.lbl_TiempoPromEjecucion = "0 ticks";
            CA.FormData.lbl_ProcesosPorPaso = 0;
        }
        private void ConfigurarColumnasGrid()
        {
            Grid_Nuevos.Columns["PrioridadNuevos"]!.Visible = rb_PrioridadesExpulsivo.Checked || rb_PrioridadesNoExpulsivo.Checked;
            Grid_Listo.Columns["Prioridad"]!.Visible = rb_PrioridadesExpulsivo.Checked || rb_PrioridadesNoExpulsivo.Checked;
            Grid_Bloqueados.Columns["PrioridadBloqueados"]!.Visible = rb_PrioridadesExpulsivo.Checked || rb_PrioridadesNoExpulsivo.Checked;
            Grid_Terminados.Columns["PrioridadTerminados"]!.Visible = rb_PrioridadesExpulsivo.Checked || rb_PrioridadesNoExpulsivo.Checked;
        }
        private void LimpiarTodo()
        {
            tickActual = 0;
            ticksCPUOcupada = 0;
            quantumRestanteActual = 0;

            CA.ProcesosBloqueados.Clear();
            CA.ProcesosTerminados.Clear();
            CA.ProcesosListos.Clear();
        }
        private void SetToolTips()
        {
            toolTip.SetToolTip(lb_BurstTime, CAT.tp_BurstTime);
            toolTip.SetToolTip(lb_BurstTimeIO, CAT.tp_BurstTimeIO);
            toolTip.SetToolTip(lb_Prioridad, CAT.tp_Prioridad);
            toolTip.SetToolTip(lb_Quantum, CAT.tp_Quantum);
            toolTip.SetToolTip(lb_Cantidad, CAT.tp_CantidadProcesos);
            toolTip.SetToolTip(lb_TiempoTick, CAT.tp_TiempoTick);
            toolTip.SetToolTip(lb_TiempoLlegada, CAT.tp_TiempoLlegada);

            toolTip.SetToolTip(rb_FCFS, CAT.tp_FCFS);
            toolTip.SetToolTip(rb_SJF, CAT.tp_SJF);
            toolTip.SetToolTip(rb_SeleccionAleatoria, CAT.tp_Aleatorio);
            toolTip.SetToolTip(rb_PrioridadesNoExpulsivo, CAT.tp_PrioridadNoExpulsiva);
            toolTip.SetToolTip(rb_RoundRobin, CAT.tp_RoundRobin);
            toolTip.SetToolTip(rb_SRTF, CAT.tp_SRTF);
            toolTip.SetToolTip(rb_PrioridadesExpulsivo, CAT.tp_PrioridadExpulsivo);
        }
        private void GridConfig()
        {
            Grid_Listo.AutoGenerateColumns = false;
            Grid_Bloqueados.AutoGenerateColumns = false;
            Grid_Terminados.AutoGenerateColumns = false;
            Grid_Nuevos.AutoGenerateColumns = false;

            Grid_Bloqueados.DataSource = CA.ProcesosBloqueados;
            Grid_Terminados.DataSource = CA.ProcesosTerminados;
            Grid_Listo.DataSource = CA.ProcesosListos;
            Grid_Nuevos.DataSource = CA.ProcesosNuevos;
        }

        #endregion
        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = CA.ProcesosNuevos.Count - 1; i >= 0; i--)
            {
                if (CA.ProcesosNuevos[i].TiempoLlegada == tickActual)
                {
                    CA.ProcesosNuevos[i].Estado = Estado.Listo;
                    CA.ProcesosListos.Add(CA.ProcesosNuevos[i]);
                    CA.ProcesosNuevos.RemoveAt(i);
                }
            }

            for (int i = CA.ProcesosBloqueados.Count - 1; i >= 0; i--)
            {
                var p = CA.ProcesosBloqueados[i];
                p.TiempoRestanteIO--;
                p.TiempoBloqueadoAcumulado++;

                if (p.TiempoRestanteIO == 0)
                {
                    p.Estado = Estado.Listo;
                    CA.ProcesosListos.Add(p);
                    CA.ProcesosBloqueados.RemoveAt(i);
                }
            }

            # region Control de expulsion del SRTF y prioridad expulsiva

            if (CA.ProcesoEnCPU != null && CA.ProcesosListos.Count > 0)
            {
                if (algoritmoSeleccionado == AlgoritmoPlanificacion.SRTF)
                {
                    var mejorEnCola = CA.ProcesosListos.OrderBy(p => p.TiempoRestanteCPU).ThenBy(p => p.TiempoLlegada).First();

                    if (mejorEnCola.TiempoRestanteCPU < CA.ProcesoEnCPU.TiempoRestanteCPU)
                    {
                        CA.ProcesoEnCPU.Estado = Estado.Listo;
                        CA.ProcesosListos.Add(CA.ProcesoEnCPU);
                        CA.ProcesoEnCPU = null;
                    }
                }

                else if (algoritmoSeleccionado == AlgoritmoPlanificacion.PrioridadExpulsiva)
                {
                    var mejorEnCola = CA.ProcesosListos.OrderBy(p => p.Prioridad).ThenBy(p => p.TiempoLlegada).First();

                    if (mejorEnCola.Prioridad < CA.ProcesoEnCPU.Prioridad)
                    {
                        CA.ProcesoEnCPU.Estado = Estado.Listo;
                        CA.ProcesosListos.Add(CA.ProcesoEnCPU);
                        CA.ProcesoEnCPU = null;
                    }
                }
            }

            #endregion

            #region Asignacion de la CPU (Algoritmos de planificacion)

            if (CA.ProcesoEnCPU == null && CA.ProcesosListos.Count > 0)
            {
                switch (algoritmoSeleccionado)
                {
                    case AlgoritmoPlanificacion.FCFS:
                        CA.ProcesoEnCPU = CA.ProcesosListos[0];
                        CA.ProcesosListos.RemoveAt(0);
                        break;

                    case AlgoritmoPlanificacion.SJF:
                        var sjf = CA.ProcesosListos.OrderBy(p => p.TiempoRestanteCPU).ThenBy(p => p.TiempoLlegada).First();
                        CA.ProcesoEnCPU = sjf;
                        CA.ProcesosListos.Remove(sjf);
                        break;

                    case AlgoritmoPlanificacion.Aleatorio:
                        int indiceAleatorio = generadorAleatorio.Next(0, CA.ProcesosListos.Count);
                        var procesoAlAzar = CA.ProcesosListos[indiceAleatorio];
                        CA.ProcesoEnCPU = procesoAlAzar;
                        CA.ProcesosListos.RemoveAt(indiceAleatorio);
                        break;

                    case AlgoritmoPlanificacion.PrioridadNoExpulsiva:
                        var procesoPrioritario = CA.ProcesosListos.OrderBy(p => p.Prioridad).ThenBy(p => p.TiempoLlegada).First();
                        CA.ProcesoEnCPU = procesoPrioritario;
                        CA.ProcesosListos.Remove(procesoPrioritario);
                        break;

                    case AlgoritmoPlanificacion.RoundRobin:
                        CA.ProcesoEnCPU = CA.ProcesosListos[0];
                        CA.ProcesosListos.RemoveAt(0);
                        quantumRestanteActual = CA.FormData.np_Quantum;
                        break;

                    case AlgoritmoPlanificacion.SRTF:
                        var masCortoSRTF = CA.ProcesosListos.OrderBy(p => p.TiempoRestanteCPU).ThenBy(p => p.TiempoLlegada).First();
                        CA.ProcesoEnCPU = masCortoSRTF;
                        CA.ProcesosListos.Remove(masCortoSRTF);
                        break;

                    case AlgoritmoPlanificacion.PrioridadExpulsiva:
                        var prioritarioExpulsivo = CA.ProcesosListos.OrderBy(p => p.Prioridad).ThenBy(p => p.TiempoLlegada).First();
                        CA.ProcesoEnCPU = prioritarioExpulsivo;
                        CA.ProcesosListos.Remove(prioritarioExpulsivo);
                        break;
                }

                CA.ProcesoEnCPU.Estado = Estado.Ejecutando;

            }

            #endregion

            #region Trabajo de la CPU

            if (CA.ProcesoEnCPU != null)
            {
                CA.ProcesoEnCPU.TiempoRestanteCPU--;
                ticksCPUOcupada++;

                if (algoritmoSeleccionado == AlgoritmoPlanificacion.RoundRobin)
                {
                    quantumRestanteActual--;
                }

                int momentoDeIO = CA.ProcesoEnCPU.BurstTime / 2;
                if (momentoDeIO == 0) momentoDeIO = 1;

                if (CA.ProcesoEnCPU.IOBurstTime > 0 && !CA.ProcesoEnCPU.YaHizoIO && CA.ProcesoEnCPU.TiempoRestanteCPU == momentoDeIO)
                {
                    CA.ProcesoEnCPU.Estado = Estado.Bloqueado;
                    CA.ProcesosBloqueados.Add(CA.ProcesoEnCPU);
                    CA.ProcesoEnCPU.YaHizoIO = true;
                    CA.ProcesoEnCPU = null;
                }

                else if (CA.ProcesoEnCPU.TiempoRestanteCPU == 0)
                {
                    CA.ProcesoEnCPU.Estado = Estado.Terminado;
                    CA.ProcesoEnCPU.TickFinalizacion = tickActual;
                    CA.ProcesosTerminados.Add(CA.ProcesoEnCPU);
                    CA.ProcesoEnCPU = null;
                }

                else if (algoritmoSeleccionado == AlgoritmoPlanificacion.RoundRobin && quantumRestanteActual == 0)
                {
                    CA.ProcesoEnCPU.Estado = Estado.Listo;
                    CA.ProcesosListos.Add(CA.ProcesoEnCPU);
                    CA.ProcesoEnCPU = null;
                }
            }

            #endregion
            
            foreach (var p in CA.ProcesosListos)
            {
                p.TiempoEspera++;
            }

            if (CA.ProcesoEnCPU != null)
            {
                bsProceso.DataSource = CA.ProcesoEnCPU;
            }

            tickActual++;

            if (CA.ProcesoEnCPU == null && CA.ProcesosListos.Count == 0 && CA.ProcesosBloqueados.Count == 0 && CA.ProcesosNuevos.Count == 0)
            {
                timer.Stop();
                MessageBox.Show($"Simulación finalizada en tick {tickActual}", "Fin simulación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CalcularEstadisticas();
            }
        }
    }
}
