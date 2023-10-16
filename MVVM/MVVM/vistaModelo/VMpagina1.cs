﻿using MVVM.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace MVVM.vistaModelo
{
    public class VMpagina1 : BaseViewModel
    {

        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        #endregion
        #region Contructor
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion
        #region PROCESOS
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);
            r = n1 + n2;
            R = r.ToString();
        }

        public async Task Procesoasync()
        {

        }
        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand Procesoasynccommand => new Command(async () => await Procesoasync());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion

    }
}
