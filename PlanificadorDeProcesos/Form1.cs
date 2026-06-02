namespace PlanificadorDeProcesos
{
    using System.ComponentModel;
    using CAT = Class_PlanificadorDeProcesos;
    public partial class Form1 : Form
    {
        CAT CA = new CAT();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Tick.DataSource = CA.ComboValues.ToList();
            cmb_Tick.ValueMember = "Key";
            cmb_Tick.DisplayMember = "Value";

            Grid_Listo.AutoGenerateColumns = false;
            Grid_Bloqueados.AutoGenerateColumns = false;
            Grid_Terminados.AutoGenerateColumns = false;

            Grid_Bloqueados.DataSource = CA.ProcesosBloqueados;
            Grid_Terminados.DataSource = CA.ProcesosTerminados;
            Grid_Listo.DataSource = CA.ProcesosListos;

            SetBindings();

            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = true;
            pnl_ProcesoActual.Visible = true;

            CA.ProcesosBloqueados.Clear();
            CA.ProcesosTerminados.Clear();
            CA.GenerarLote();

            timer.Interval = CA.FormData.cmb_Tick;
            timer.Start();
        }

        private void btn_CambiarAlgoritmo_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;
        }

        private BindingSource bsProceso = new BindingSource();
        private void SetBindings()
        {

            bsProceso.DataSource = new Proceso();

            // Panel Parametros
            np_MinBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_Cantidad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_Cantidad), false, DataSourceUpdateMode.OnPropertyChanged);
            cmb_Tick.DataBindings.Add("SelectedValue", CA.FormData, nameof(CAT.FormData.cmb_Tick), false, DataSourceUpdateMode.OnPropertyChanged);         
            np_TiempoLlegada.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_TiempoLlegada), false, DataSourceUpdateMode.OnPropertyChanged);

            //Panel Estadisticas
            lbl_UsoProcesador.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_UsoProcesador), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromEspera.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromEspera), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromBloqueo.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromBloqueo), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoPromEjecucion.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoPromEjecucion), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_ProcesosCompletados.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_ProcesosCompletados), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_ProcesosPorPaso.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_ProcesosPorPaso), false, DataSourceUpdateMode.OnPropertyChanged);
            lbl_TiempoTotal.DataBindings.Add("Text", CA.FormData, nameof(CAT.FormData.lbl_TiempoTotal), false, DataSourceUpdateMode.OnPropertyChanged);

            //Panel Proceso Actual
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
        }

        private int tickActual = 0;
        private int ticksCPUOcupada = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            tickActual++;

            for (int i = CA.ProcesosBloqueados.Count - 1; i >= 0; i--)
            {
                var p = CA.ProcesosBloqueados[i];
                p.TiempoRestanteIO--;
                p.TiempoBloqueadoAcumulado++;

                if (p.TiempoRestanteIO == 0)
                {
                    p.Estado = PlanificadorDeProcesos.Estado.Listo;
                    CA.ProcesosListos.Add(p);
                    CA.ProcesosBloqueados.RemoveAt(i);
                }
            }

            if (CA.ProcesoEnCPU != null)
            {
                CA.ProcesoEnCPU.TiempoRestanteCPU--;
                ticksCPUOcupada++;

                int momentoDeIO = CA.ProcesoEnCPU.BurstTime / 2;
                if (momentoDeIO == 0) momentoDeIO = 1;

                if (CA.ProcesoEnCPU.IOBurstTime > 0 &&
                    !CA.ProcesoEnCPU.YaHizoIO &&
                    CA.ProcesoEnCPU.TiempoRestanteCPU == momentoDeIO)
                {
                    CA.ProcesoEnCPU.Estado = PlanificadorDeProcesos.Estado.Bloqueado;
                    CA.ProcesosBloqueados.Add(CA.ProcesoEnCPU);
                    CA.ProcesoEnCPU.YaHizoIO = true;
                    CA.ProcesoEnCPU = null;
                }

                else if (CA.ProcesoEnCPU.TiempoRestanteCPU == 0)
                {
                    CA.ProcesoEnCPU.Estado = PlanificadorDeProcesos.Estado.Terminado;
                    CA.ProcesoEnCPU.TickFinalizacion = tickActual;
                    CA.ProcesosTerminados.Add(CA.ProcesoEnCPU);
                    CA.ProcesoEnCPU = null;
                }
            }

            if (CA.ProcesoEnCPU == null && CA.ProcesosListos.Count > 0)
            {
                CA.ProcesoEnCPU = CA.ProcesosListos[0];
                CA.ProcesosListos.RemoveAt(0);
                CA.ProcesoEnCPU.Estado = PlanificadorDeProcesos.Estado.Ejecutando;
            }

            foreach (var p in CA.ProcesosListos)
            {
                p.TiempoEspera++;
            }

            if(CA.ProcesoEnCPU != null)
            {
                bsProceso.DataSource = CA.ProcesoEnCPU;
            }

            if (CA.ProcesoEnCPU == null && CA.ProcesosListos.Count == 0 && CA.ProcesosBloqueados.Count == 0)
            {
                timer.Stop();
                MessageBox.Show($"Simulación finalizada en tick {tickActual}", "Fin simulación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CalcularEstadisticas();

                tickActual = 0;
                ticksCPUOcupada = 0;

            }
        }

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
    }
}
