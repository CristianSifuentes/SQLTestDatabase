using System;
using System.Linq;

namespace SQLTestDatabase
{
    class Program
    {


        static void Main(string[] args)
        {


            using (var context = new Context())
            {

                //El chofer que más viajes ha realizado en el último mes.
                long TipoChofer = context.TipoPersona.Where(z => z.Nombre == "chofer").FirstOrDefault().Id;
                long TipoCte = context.TipoPersona.Where(z => z.Nombre == "cliente").FirstOrDefault().Id;


                var startOfTthisMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var firstDay = startOfTthisMonth.AddMonths(-1);
                var lastDay = startOfTthisMonth.AddDays(-1);

                IQueryable<Viaje> viajesultimomes = context.Viaje.Where(x => x.FechaFin >= firstDay &&
                      x.FechaFin <= lastDay);


                //Los 5 clientes más lejanos
                var items = context.Persona.Where(x=> x.TipoPersonaId == TipoCte).OrderByDescending(u => u.FechaCreacion).Take(5);


                //Los 5 clientes frecuentes(con más pedidos hechos)
                var frecuentes = context.PedidoCte.GroupBy(a => a.PersonaId).Where(grp => grp.Count() > 1).SelectMany(grp => grp.Select(r => r)).Take(5);

                //Un listado de los últimos 10 pedidos, sabiendo de qué cliente son, qué chofer llevó el pedido y qué camioneta se utilizó.

                var ultimospedidos = context.PedidoCte.OrderByDescending(z => z.FechaPedido).GroupBy(a => a.PersonaId).Where(grp => grp.Count() > 1).SelectMany(grp => grp.Select(r => r)).Take(10);

            }

        }
    }
}
