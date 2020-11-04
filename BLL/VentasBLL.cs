using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Alvarado_P2_AP2.DAL;
using Alvarado_P2_AP2.Models;

namespace Alvarado_P2_AP2.BLL{
    public class VentasBLL{
        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> venta)
        {
            List<Ventas> Lista = new List<Ventas>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Ventas.Where(venta).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}