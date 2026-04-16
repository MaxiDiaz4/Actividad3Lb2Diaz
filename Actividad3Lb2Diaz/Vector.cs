using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3Lb2Diaz
{
    internal class Vector
    {
        //declaracion de un registro
        public struct RegCli
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }
        //Declaracion del vector

        static public RegCli[] Clientes = new RegCli[10];

        //Declaracion del indice

        static public Int32 IND = 0;

        static public void OrdenarPorCodigoAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)

                    if (Clientes[i].Codigo > Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                i++;
            }
            c++;
        }
        static public void OrdenarPorCodigoDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)

                    if (Clientes[i].Codigo < Clientes[i + 1].Codigo)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                i++;
            }
            c++;
        }

        static public void OrdenarPorNombreAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) > 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarPorNombreDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Usuario.CompareTo(Clientes[i + 1].Usuario) < 0)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }

        }
        static public void OrdenarPorLimiteAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarPorLimiteDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Limite > Clientes[i + 1].Limite)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;

                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarDeudaAscendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;
            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }
        static public void OrdenarPorDeudeDescendente()
        {
            Int32 c = 0;
            Int32 i = 0;
            RegCli Aux;

            while (c < IND - 1)
            {
                i = 0;

                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        Aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = Aux;
                    }
                    i++;
                }
                c++;
            }
        }

    }
}
   

        
        
                
        
    
