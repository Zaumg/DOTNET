using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosHeranca
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando uma notificação genérica.");
        }
    }
}