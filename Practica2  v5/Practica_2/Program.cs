using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAcopladas
{
    class Acopladas
    {
        static void Main(string[] args)
        {
            observador obj = new observador();
            obj.funciona();
            obj.funciona2();
        }
    }


    class observador
    {
        TrabajoDuro tb;

        public observador() 
        { 
            tb = new TrabajoDuro(); 
            tb.callback += InformeAvance;
            tb.callback += InformeAvance2;
        }

        public void funciona()
        {
            Console.WriteLine("Vamos a probar el informe");
            tb.ATrabajar();
            Console.WriteLine("Terminado");
        }

        public void funciona2()
        {
            Console.WriteLine("Vamos a probar el informe");
            tb.ATrabajar();
            Console.WriteLine("Terminado");
        }

        /*puede ser privada puesto que la invocacion se hace desde esta misma clase*/
        /*a las funciones evento siempre le pasamos estos dos parametros:
         * object el que llama al evento
         * EventArgs los argumentos*/
        private void InformeAvance(object sender, PorcentajeHechoEventArgs ph)
        {
            string str = String.Format("Ya llevamos el {0}", ph.PorcentajeHecho);
            Console.WriteLine(str);
        }

        /*puede ser privada puesto que la invocacion se hace desde esta misma clase*/
        private void InformeAvance2(object sender, PorcentajeHechoEventArgs ph)
        {
            string str = String.Format("Ya llevamos el {0}", ph.PorcentajeHecho);
            Console.WriteLine(str);
        }
    }

    class PorcentajeHechoEventArgs : EventArgs
    {
        public int PorcentajeHecho
        {
            get;
            set;
        }
    }


    class TrabajoDuro
    {
        int PocentajeHecho;

        public event EventHandler<PorcentajeHechoEventArgs> callback;

        public TrabajoDuro()
        {
            PocentajeHecho = 0;
        }

        protected virtual void OnPorcentajeHecho(PorcentajeHechoEventArgs e)
        {
            /*los eventos siempre envian el remitente como primer parametro, y luego la informacion
             * del parametro en e*/
            callback?.Invoke(this, e);
        }

        public void ATrabajar()
        {
            int i;
            PorcentajeHechoEventArgs ph = new PorcentajeHechoEventArgs();

            for (i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(1); //Hacemos el trabajo
                switch (i)
                {
                    case 125:
                        PocentajeHecho = 25;

                        ph.PorcentajeHecho = this.PocentajeHecho;
                        OnPorcentajeHecho(ph);

                        break;
                    case 250:
                        PocentajeHecho = 50;

                        ph.PorcentajeHecho = this.PocentajeHecho;
                        OnPorcentajeHecho(ph);

                        break;
                    case 375:
                        PocentajeHecho = 75;

                        ph.PorcentajeHecho = this.PocentajeHecho;
                        OnPorcentajeHecho(ph);

                        break;
                }
            }
        }
    }
}
