using Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Contexto())
            {
                var categorias = context.Clientes.ToList();                
            }
        }
    }
}
