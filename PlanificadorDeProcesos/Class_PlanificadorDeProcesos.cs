using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlanificadorDeProcesos
{
    internal class Class_PlanificadorDeProcesos
    {
        #region Consts

        public static string tp_BurstTime = "Tiempo total (en ticks) que el proceso necesita usar el procesador (CPU) para terminar su tarea.";
        public static string tp_BurstTimeIO = "Tiempo (en ticks) que el proceso pasará bloqueado simulando operaciones\nde Entrada/Salida (como leer un disco duro o esperar al usuario).";
        public static string tp_Prioridad = "Nivel de importancia del proceso. Generalmente, un número más bajo indica una mayor urgencia.";
        public static string tp_Quantum = "Tiempo máximo continuo que un proceso puede usar la CPU antes de ser expulsado\ny devuelto a la fila. Exclusivo del algoritmo Round Robin.";
        public static string tp_CantidadProcesos = "El número total de procesos aleatorios que se crearán para esta ejecución de la simulación.";
        public static string tp_TiempoTick = "Velocidad visual de la simulación. Define cuántos milisegundos de la vida real\ntoma procesar un \"paso\" o tick del algoritmo.";
        public static string tp_TiempoLlegada = "El momento (o rango de ticks) en el que los procesos \"nacen\"\ne ingresan al sistema para comenzar a competir por la CPU.";
        
        public static string tp_FCFS = "Atiende a los procesos en el orden exacto en el que van llegando a la cola.\nNo interrumpe a nadie hasta que terminan o se bloquean.";
        public static string tp_SJF = "Busca en la fila y ejecuta primero al proceso que requiera la menor cantidad de tiempo total de CPU.";
        public static string tp_Aleatorio = "El planificador elige el siguiente proceso a ejecutar de forma completamente al azar, ignorando tiempos de llegada, ráfagas o prioridades.";
        public static string tp_PrioridadNoExpulsiva = "Ejecuta primero al proceso con el nivel de prioridad más urgente (número más bajo). Una vez asignada la CPU, el proceso no puede ser interrumpido.";
        public static string tp_RoundRobin = "Atiende en orden de llegada, pero asigna un tiempo máximo estricto (Quantum) a cada proceso.\nSi el tiempo se acaba, expulsa al proceso y lo manda al final de la fila.";
        public static string tp_SRTF = "Versión expulsiva del SJF. Vigila constantemente la cola; si llega un proceso nuevo\nque terminaría más rápido que el actual, interrumpe la CPU y mete al nuevo.";
        public static string tp_PrioridadExpulsivo = "El sistema siempre ejecuta el proceso más importante. Si la CPU está ocupada y llega\nun proceso con mejor prioridad, expulsa inmediatamente al proceso actual para darle paso al VIP.";

        #endregion

        #region Variables
        public BindingList<Proceso> ProcesosListos { get; set; } = new BindingList<Proceso>();
        public BindingList<Proceso> ProcesosNuevos { get; set; } = new BindingList<Proceso>();
        public BindingList<Proceso> ProcesosBloqueados { get; set; } = new BindingList<Proceso>();
        public BindingList<Proceso> ProcesosTerminados { get; set; } = new BindingList<Proceso>();

        public Proceso ProcesoEnCPU = null;

        public Dictionary<int, string> ComboValues = new Dictionary<int, string>()
        {
            { 100, "100 ms"},
            { 500, "500 ms"},
            { 1000, "1000 ms"},
            { 1500, "1500 ms"},
            { 2000, "2000 ms"}
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
            np_Quantum = 1,
            cmb_Tick = 100,
            np_MinTiempoLlegada = 0,
            np_MaxTiempoLlegada = 0,
            lbl_TiempoTotal = "0 ticks",
            lbl_ProcesosCompletados = 0,
            lbl_UsoProcesador = "0 %",
            lbl_TiempoPromEspera = "0 ticks",
            lbl_TiempoPromBloqueo = "0 ticks",
            lbl_TiempoPromEjecucion = "0 ticks",
            lbl_ProcesosPorPaso = 0,
        };

        #endregion

        private Random random = new Random();
        public void GenerarLote()
        {
            ProcesosNuevos.Clear();
            List<Proceso> nuevosProcesos = new List<Proceso>();

            int contadorId = 1;

            for (int i = 0; i < FormData.np_Cantidad; i++)
            {
                Proceso p = new Proceso();
                p.ID = contadorId++;
                p.TiempoLlegada = random.Next(FormData.np_MinTiempoLlegada, FormData.np_MaxTiempoLlegada + 1);

                p.BurstTime = random.Next(FormData.np_MinBurstTime, FormData.np_MaxBurstTime + 1);
                p.IOBurstTime = random.Next(FormData.np_MinIOBurstTime, FormData.np_MaxIOBurstTime + 1);
                p.Prioridad = random.Next(FormData.np_MinPrioridad, FormData.np_MaxPrioridad + 1);

                p.TiempoRestanteCPU = p.BurstTime;
                p.TiempoRestanteIO = p.IOBurstTime;
                p.Estado = Estado.Nuevo;
                p.YaHizoIO = false;

                nuevosProcesos.Add(p);
            }

            nuevosProcesos.Reverse();

            foreach(var p in nuevosProcesos)
            {
                ProcesosNuevos.Add(p);
            }
        }
    }

    public enum Estado
    {
        Nuevo,
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
