using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio11_xamarin.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor3;
        public int Valor3
        {
            get { return valor3; }
            set
            {
                if (valor3 != value)
                {
                    valor3 = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoMultiplicacion;
        public int ResultadoMultiplicacion
        {
            get { return resultadoMultiplicacion; }
            set
            {
                if (resultadoMultiplicacion != value)
                {
                    resultadoMultiplicacion = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Sumar { get; set; }
        public ICommand Multiplicar { get; set; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = Valor1 + Valor2 + Valor3;
            });
            Multiplicar = new Command(() =>
            {
                ResultadoMultiplicacion = Valor1 * Valor2 * Valor3;
            });
        }
    }
}
