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
            tb.ATrabajar(InformeAvance);
            Console.WriteLine("Terminado");
        }

        public void funciona2()
        {
            Console.WriteLine("Vamos a probar el informe");
            tb.ATrabajar(InformeAvance2);
            Console.WriteLine("Terminado");
        }

        /*puede ser privada puesto que la invocacion se hace desde esta misma clase*/
        private void InformeAvance(int x)
        {
            string str = String.Format("Ya llevamos el {0}", x);
            Console.WriteLine(str);
        }

        /*puede ser privada puesto que la invocacion se hace desde esta misma clase*/
        private void InformeAvance2(int x)
        {
            string str = String.Format("Ya llevamos el {0}", x);
            Console.WriteLine(str);
        }
    }


    //Creamos un delegado que devuelve void (nada) y se le pasa como parametro un int
    delegate void TipoAviso(int x);
    /*El nombre asignado es un tipo de dato (TipoAviso)*/

    class TrabajoDuro
    {
        int PorcentajeHecho;
        /*cada evento se corresponde con una delegacion*/
        public event TipoAviso callback;

        public TrabajoDuro()
        {
            PorcentajeHecho = 0;
        }

        public void ATrabajar(TipoAviso callback)
        {
            int i;
            for (i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(1); //Hacemos el trabajo
                switch (i)
                {
                    case 125:
                        PorcentajeHecho = 25;
                        if(callback != null)
                        {
                            callback(PorcentajeHecho);
                        }
                        break;
                    case 250:
                        PorcentajeHecho = 50;
                        if(callback != null)
                        {
                            callback(PorcentajeHecho);
                        }
                        break;
                    case 375:
                        PorcentajeHecho = 75;
                        if(callback != null)
                        {
                            callback(PorcentajeHecho);
                            //callback?.Invoke(PorcentajeHecho);
                            /*si callback es distinto de null invoca lo referenciado por el delegado
                             * y le pasamos como parametro el PorcentajeHecho*/
                        }
                        break;
                }
            }
        }
    }
}
