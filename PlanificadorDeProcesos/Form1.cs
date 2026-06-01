namespace PlanificadorDeProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnl_Generador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        }

        private void btn_CambiarAlgoritmo_Click(object sender, EventArgs e)
        {
            pnl_Estadisticas.Visible = false;
            pnl_ProcesoActual.Visible = false;
        }
    }
}
