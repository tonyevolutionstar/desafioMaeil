using System;
using System.Collections.Generic;
using System.Linq;


namespace DesafioMaeil
{
    interface ILista
    {
        void Insert(Row row);

        void Update(Row oldRow, Row newRow);

        void Delete(Row row);

        List<Row> Search(string referencia);

    }

    public class Lista : ILista
    {
        public List<Row> listaRow; 
        private Log log;

        public Lista()
        {
            listaRow = new List<Row>();
            log = new Log();
        }


        public void Insert(Row row)
        {
            listaRow.Add(row);
        }

        /// <summary>
        /// update based on old reference
        /// </summary>
        /// <param name="oldRow"></param>
        /// <param name="newRow"></param>
        public void Update(Row oldRow, Row newRow)
        {
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Referencia = newRow.Referencia);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Cliente = newRow.Cliente);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Estado = newRow.Estado);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Tipo = newRow.Tipo);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Matricula = newRow.Matricula);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.TipoCarga = newRow.TipoCarga);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Prioridade = newRow.Prioridade);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.DataRegisto = newRow.DataRegisto);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.BlockedTime = newRow.BlockedTime);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Pod = newRow.Pod);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Parque = newRow.Parque);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.TipoEquipamento = newRow.TipoEquipamento);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.DepotIdBlocking = newRow.DepotIdBlocking);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.DataAtribExp = newRow.DataAtribExp);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Vessel = newRow.Vessel);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Voyage = newRow.Voyage);
            listaRow.Where(x => x.Referencia.Equals(oldRow.Referencia)).Update(x => x.Pol = newRow.Pol);
        }

        public void Delete(Row row)
        {
            List<Row> delRes = listaRow.Where(x => x.Referencia.Equals(row.Referencia)).ToList();
            
            for(int i = 0; i < delRes.Count; i++)
            {
                log.Output($"delRes[i]: {delRes[i]}");
                listaRow.Remove(delRes[i]);
            }
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
