using System;
using System.Collections.Generic;
using System.Linq;


namespace DesafioMaeil
{
    interface ILista
    {
        bool Insert(Row row);

        bool Update(Row row);

        bool Delete(Row row);

        List<Row> Search(string referencia);

        void Show();
    }

    public class Lista : ILista
    {
        public List<Row> listaRow; 
        private Log log;

        public Lista()
        {
           log = new Log();
        }



        public bool Insert(Row row)
        {
            listaRow.Add(row);
            log.Output($"referencia {row.referencia} adicionada");
            return true;
        }

        public bool Delete(Row row)
        {
           /* bool search = Search(row.Referencia);
            if (search)
            {
                listaRow.Remove(row);
                log.Output("referencia {row.referencia} eliminada");
                return true;
            }
           */
            return false; 
        }

        private void VerifyNull(Row listaRow)
        {
            if (listaRow.Referencia == null)
                listaRow.Referencia = "";
            if (listaRow.Cliente == null)
                listaRow.Cliente = "";
            if (listaRow.Estado == null)
                listaRow.Estado = "";
            if (listaRow.Tipo == null)
                listaRow.Tipo = "";
            if (listaRow.Matricula == null)
                listaRow.Matricula = "";
            if (listaRow.TipoCarga == null)
                listaRow.TipoCarga = "";
            if (listaRow.Prioridade == null)
                listaRow.Prioridade = "";
            if (listaRow.DataRegisto == null)
                listaRow.DataRegisto = "";
            if (listaRow.BlockedTime == null)
                listaRow.BlockedTime = "";
            if (listaRow.Pod == null)
                listaRow.Pod = "";
            if (listaRow.Parque == null)
                listaRow.Parque = "";
            if (listaRow.TipoEquipamento == null)
                listaRow.TipoEquipamento = "";
            if (listaRow.DepotIdBlocking == null)
                listaRow.DepotIdBlocking = "";
            if (listaRow.DataAtribExp == null)
                listaRow.DataAtribExp = "";
            if (listaRow.Vessel == null)
                listaRow.Vessel = "";
            if (listaRow.Voyage == null)
                listaRow.Voyage = "";
            if (listaRow.Pol == null)
                listaRow.Pol = "";
        }

        /// <summary>
        /// Search for a reference, and prints
        /// If doesnt contains any search, doesnt return a value
        /// </summary>
        /// <param name="referencia"></param>
        /// <returns>list of references </returns>
        public List<Row> Search(string referencia)
        {
            var res = listaRow.Where(x => x.referencia.Equals(referencia));
            List<Row> l = res.ToList();
           
            for (int i = 0; i < l.Count; i++)
                PrintList(l[i]);

            return l;
        }

        private void PrintList(Row listaRow)
        {
            VerifyNull(listaRow);
            log.Output($"referencia: {listaRow.Referencia} | cliente: {listaRow.Cliente} | estado: {listaRow.Estado} | tipo: {listaRow.Tipo} | matricula: {listaRow.Matricula}" +
                    $" | tipoCarga: {listaRow.TipoCarga} | prioridade: {listaRow.Prioridade} | dataRegisto: {listaRow.DataRegisto} | blockedTime: {listaRow.BlockedTime} " +
                    $"| pod: {listaRow.Pod} | parque: {listaRow.Parque} | tipoEquipamento: {listaRow.TipoEquipamento} | DepotIdBlocking: {listaRow.DepotIdBlocking} | " +
                    $" dataAtribExp: {listaRow.DataAtribExp} | vessel: {listaRow.Vessel} | voyage: {listaRow.Voyage} | pol: {listaRow.Pol}");
        }


        public bool Update(Row row)
        {
            //lista.Where(x => x.Referencia.Equals(row.Referencia)).Update(x => x.Referencia = row.Referencia);
            log.Output("referencia {row.referencia} alterada");
            return true;
        }

        /// <summary>
        /// Show all the values in the list
        /// </summary>
        public void Show()
        {
            for(int i = 0; i < listaRow.Count; i++)
            {
                PrintList(listaRow[i]);
            }
        }
    }

    public static class LinqUpdates
    {

        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}
