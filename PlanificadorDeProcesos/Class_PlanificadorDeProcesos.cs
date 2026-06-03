using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlanificadorDeProcesos
{
    internal class Class_PlanificadorDeProcesos
    {
        public BindingList<Proceso> ProcesosListos { get; set; } = new BindingList<Proceso>();
        public List<Proceso> ProcesosNuevos { get; set; } = new List<Proceso>();
        public BindingList<Proceso> ProcesosBloqueados { get; set; } = new BindingList<Proceso>();
        public BindingList<Proceso> ProcesosTerminados { get; set; } = new BindingList<Proceso>();

        public Proceso ProcesoEnCPU = null;

        public Dictionary<int, string> ComboValues = new Dictionary<int, string>()
        {
            { 100, "100 ms"},
            { 500, "500 ms"},
            { 1000, "1000 ms"}
        };

        public FormData FormData { get; set; } = new FormData()
        {
            np_MinBurstTime = 1,
            np_MaxBurstTime = 5,
            np_MinIOBurstTime = 0,
            np_MaxIOBurstTime = 0,
            np_MinPrioridad = 1,
            np_MaxPrioridad = 5,
            np_Cantidad = 5,
            cmb_Tick = 100,
            np_MinTiempoLlegada = 0
        };

        private Random random = new Random();
        public void GenerarLote()
        {
            //List<Proceso> nuevosProcesos = new List<Proceso>();
            ProcesosNuevos.Clear();
            int contadorId = 1;

            for (int i = 0; i < FormData.np_Cantidad; i++)
            {
                Proceso p = new Proceso();
                p.ID = contadorId++;
                p.TiempoLlegada = random.Next(FormData.np_MinTiempoLlegada, FormData.np_MaxTiempoLlegada + 1);

                p.BurstTime = random.Next(FormData.np_MinBurstTime, FormData.np_MaxBurstTime + 1);
                p.IOBurstTime = random.Next(FormData.np_MinIOBurstTime, FormData.np_MaxIOBurstTime + 1);
                p.Prioridad = random.Next(FormData.np_MinPrioridad, FormData.np_MaxPrioridad + 1);

                // Inicializamos los valores de ejecución
                p.TiempoRestanteCPU = p.BurstTime;
                p.TiempoRestanteIO = p.IOBurstTime;
                p.Estado = Estado.Listo;
                p.YaHizoIO = false;

                ProcesosNuevos.Add(p);
            }

        }

    }

    public enum Estado
    {
        Listo,
        Ejecutando,
        Bloqueado,
        Terminado
    }
    public enum AlgoritmoPlanificacion
    {
        FCFS,
        SJF,
        Aleatorio,
        PrioridadNoExpulsiva,
        RoundRobin,
        SRTF,
        PrioridadExpulsiva
    }
    public class Proceso : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private int _ID;
        public int ID 
        { 
            get { return _ID; } 
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TiempoLlegada;
        public int TiempoLlegada
        {
            get { return _TiempoLlegada; }
            set
            {
                if (_TiempoLlegada != value)
                {
                    _TiempoLlegada = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _BurstTime;
        public int BurstTime 
        { 
            get { return _BurstTime; } 
            set
            {
                if (_BurstTime != value)
                {
                    _BurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _IOBurstTime;
        public int IOBurstTime 
        { 
            get { return _IOBurstTime; } 
            set
            {
                if (_IOBurstTime != value)
                {
                    _IOBurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _Prioridad;
        public int Prioridad 
        { 
            get { return _Prioridad; } 
            set
            {
                if (_Prioridad != value)
                {
                    _Prioridad = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool _YaHizoIO;
        public bool YaHizoIO 
        { 
            get { return _YaHizoIO; } 
            set
            {
                if (_YaHizoIO != value)
                {
                    _YaHizoIO = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TiempoRestanteCPU;
        public int TiempoRestanteCPU 
        { 
            get { return _TiempoRestanteCPU; } 
            set
            {
                if (_TiempoRestanteCPU != value)
                {
                    _TiempoRestanteCPU = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TiempoRestanteIO;
        public int TiempoRestanteIO 
        { 
            get { return _TiempoRestanteIO; } 
            set
            {
                if (_TiempoRestanteIO != value)
                {
                    _TiempoRestanteIO = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TiempoEspera;
        public int TiempoEspera 
        { 
            get { return _TiempoEspera; } 
            set
            {
                if (_TiempoEspera != value)
                {
                    _TiempoEspera = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TiempoBloqueadoAcumulado;
        public int TiempoBloqueadoAcumulado 
        { 
            get { return _TiempoBloqueadoAcumulado; } 
            set
            {
                if (_TiempoBloqueadoAcumulado != value)
                {
                    _TiempoBloqueadoAcumulado = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _TickFinalizacion;
        public int TickFinalizacion 
        { 
            get { return _TickFinalizacion; } 
            set
            {
                if (_TickFinalizacion != value)
                {
                    _TickFinalizacion = value;
                    OnPropertyChanged();
                }
            }
        }

        private Estado _Estado;
        public Estado Estado 
        { 
            get { return _Estado; } 
            set
            {
                if (_Estado != value)
                {
                    _Estado = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class FormData: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _np_MinBurstTime;
        public int np_MinBurstTime
        {
            get { return _np_MinBurstTime; }
            set 
            {
                if (_np_MinBurstTime != value)
                {
                    _np_MinBurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MaxBurstTime;
        public int np_MaxBurstTime
        {
            get { return _np_MaxBurstTime; }
            set
            {
                if (_np_MaxBurstTime != value)
                {
                    _np_MaxBurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MinIOBurstTime;
        public int np_MinIOBurstTime
        {
            get { return _np_MinIOBurstTime; }
            set
            {
                if (_np_MinIOBurstTime != value)
                {
                    _np_MinIOBurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MaxIOBurstTime;
        public int np_MaxIOBurstTime
        {
            get { return _np_MaxIOBurstTime; }
            set
            {
                if (_np_MaxIOBurstTime != value)
                {
                    _np_MaxIOBurstTime = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MinPrioridad;
        public int np_MinPrioridad
        {
            get { return _np_MinPrioridad; }
            set
            {
                if (_np_MinPrioridad != value)
                {
                    _np_MinPrioridad = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MaxPrioridad;
        public int np_MaxPrioridad
        {
            get { return _np_MaxPrioridad; }
            set
            {
                if (_np_MaxPrioridad != value)
                {
                    _np_MaxPrioridad = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_Cantidad;
        public int np_Cantidad
        {
            get { return _np_Cantidad; }
            set
            {
                if (_np_Cantidad != value)
                {
                    _np_Cantidad = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _cmb_Tick;
        public int cmb_Tick
        {
            get { return _cmb_Tick; }
            set
            {
                if (_cmb_Tick != value)
                {
                    _cmb_Tick = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MinTiempoLlegada;
        public int np_MinTiempoLlegada
        {
            get { return _np_MinTiempoLlegada; }
            set
            {
                if (_np_MinTiempoLlegada != value)
                {
                    _np_MinTiempoLlegada = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_MaxTiempoLlegada;
        public int np_MaxTiempoLlegada
        {
            get { return _np_MaxTiempoLlegada; }
            set
            {
                if (_np_MaxTiempoLlegada != value)
                {
                    _np_MaxTiempoLlegada = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _np_Quantum;
        public int np_Quantum
        {
            get { return _np_Quantum; }
            set
            {
                if (_np_Quantum != value)
                {
                    _np_Quantum = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lbl_UsoProcesador;
        public string lbl_UsoProcesador
        {
            get { return _lbl_UsoProcesador; }
            set
            {
                if (_lbl_UsoProcesador != value)
                {
                    _lbl_UsoProcesador = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lbl_TiempoPromEspera;
        public string lbl_TiempoPromEspera
        {
            get { return _lbl_TiempoPromEspera; }
            set
            {
                if (_lbl_TiempoPromEspera != value)
                {
                    _lbl_TiempoPromEspera = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lbl_TiempoPromBloqueo;
        public string lbl_TiempoPromBloqueo
        {
            get { return _lbl_TiempoPromBloqueo; }
            set
            {
                if (_lbl_TiempoPromBloqueo != value)
                {
                    _lbl_TiempoPromBloqueo = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lbl_TiempoPromEjecucion;
        public string lbl_TiempoPromEjecucion
        {
            get { return _lbl_TiempoPromEjecucion; }
            set
            {
                if (_lbl_TiempoPromEjecucion != value)
                {
                    _lbl_TiempoPromEjecucion = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _lbl_ProcesosCompletados;
        public double lbl_ProcesosCompletados
        {
            get { return _lbl_ProcesosCompletados; }
            set
            {
                if (_lbl_ProcesosCompletados != value)
                {
                    _lbl_ProcesosCompletados = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _lbl_ProcesosPorPaso;
        public double lbl_ProcesosPorPaso
        {
            get { return _lbl_ProcesosPorPaso; }
            set
            {
                if (_lbl_ProcesosPorPaso != value)
                {
                    _lbl_ProcesosPorPaso = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _lbl_TiempoTotal;
        public string lbl_TiempoTotal
        {
            get { return _lbl_TiempoTotal; }
            set
            {
                if (_lbl_TiempoTotal != value)
                {
                    _lbl_TiempoTotal = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
