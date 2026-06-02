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

            Grid_EnEspera.AutoGenerateColumns = false;
            Grid_Bloqueados.AutoGenerateColumns = false;
            Grid_Terminados.AutoGenerateColumns = false;

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

            CA.ProcesosEnEspera = new BindingList<Proceso>(CA.GenerarLote());
            Grid_EnEspera.DataSource = CA.ProcesosEnEspera;
        }

        private void btn_CambiarAlgoritmo_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;
        }

        private void SetBindings()
        {
            np_MinBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxIOBurstTime.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxIOBurstTime), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MinPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MinPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_MaxPrioridad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_MaxPrioridad), false, DataSourceUpdateMode.OnPropertyChanged);
            np_Cantidad.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_Cantidad), false, DataSourceUpdateMode.OnPropertyChanged);
            cmb_Tick.DataBindings.Add("SelectedValue", CA.FormData, nameof(CAT.FormData.cmb_Tick), false, DataSourceUpdateMode.OnPropertyChanged);
            np_TiempoLlegada.DataBindings.Add("Value", CA.FormData, nameof(CAT.FormData.np_TiempoLlegada), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
