using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PracticaFinal_Alberto_Gomez_Garcia.Model
{
    public class Configuracion : INotifyPropertyChanged
    {
        private readonly static Configuracion shared = new Configuracion();
        private Configuracion() { }

        public static Configuracion Shared
        {
            get => shared;
        }

        private TipoGrafico tipoGrafica;

        public TipoGrafico TipoGrafica
        {
            get { return tipoGrafica; }
            set { tipoGrafica = value; RaisePropertyChange(); }
        }

        private Brush colorCanvas;
        public Brush ColorCanvas
        {
            get => colorCanvas;
            set { colorCanvas = value; RaisePropertyChange(); }
        }

        // EJES

        private double grosorEjes;

        public double GrosorEjes
        {
            get { return grosorEjes; }
            set { grosorEjes = value; RaisePropertyChange(); }
        }

        private Brush colorEjes;

        public Brush ColorEjes
        {
            get { return colorEjes; }
            set { colorEjes = value; RaisePropertyChange(); }
        }


        // LINEAS

        private Brush colorLinea;

        public Brush ColorLinea
        {
            get { return colorLinea; }
            set { colorLinea = value; RaisePropertyChange(); }
        }

        private double grosorLinea;

        public double GrosorLinea
        {
            get { return grosorLinea; }
            set { grosorLinea = value; RaisePropertyChange(); }
        }

        // LINEAS


        // BARRAS

        private double grosorBarras;

        public double GrosorBarras
        {
            get { return grosorBarras; }
            set { grosorBarras = value; RaisePropertyChange(); }
        }

        private Brush brush;

        public Brush ColorBarras
        {
            get { return brush; }
            set { brush = value; RaisePropertyChange(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }

}
