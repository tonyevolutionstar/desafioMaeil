using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMaeil
{
    interface ILista
    {
        bool Create(Row row);

        bool Delete(Row row);

        bool Update(Row row);

        bool Search(string referencia);
    }

    public class Lista : Row, ILista
    {
        List<Row> lista; 
        Log log;

        public Lista(string referencia, string cliente, string estado, string tipo, string matricula, string tipoCarga, string prioridade, string dataRegisto, string blockedTime, string pod, string parque, string tipoEquipamento, int depositIdBlocking, string dataAtribExp, string vessel, string voyage, string pol) : base(referencia, cliente, estado, tipo, matricula, tipoCarga, prioridade, dataRegisto, blockedTime, pod, parque, tipoEquipamento, depositIdBlocking, dataAtribExp, vessel, voyage, pol)
        {
            this.referencia = referencia;
            this.cliente = cliente;
            this.estado = estado;
            this.tipo = tipo;
            this.matricula = matricula;
            this.tipoCarga = tipoCarga;
            this.prioridade = prioridade;
            this.dataRegisto = dataRegisto;
            this.blockedTime = blockedTime;
            this.pod = pod;
            this.parque = parque;
            this.tipoEquipamento = tipoEquipamento;
            this.depositIdBlocking = depositIdBlocking;
            this.dataAtribExp = dataAtribExp;
            this.vessel = vessel;
            this.voyage = voyage;
            this.pol = pol;
        }



        public bool Create(Row row)
        {
            lista.Add(row);
            log.Output($"referencia {row.referencia} adicionada");
            return true;
        }

        public bool Delete(Row row)
        {
            bool search = Search(row.Referencia);
            if (search)
            {
                lista.Remove(row);
                log.Output("referencia {row.referencia} eliminada");
                return true;
            }
            return false; 
        }


        public bool Search(string referencia)
        {
            var res = lista.Find(x => x.referencia.Equals(referencia));
            if (!String.IsNullOrEmpty(res.referencia))
                return true;
            return false;
        }


        public bool Update(Row row)
        {
            lista.Where(x => x.Referencia.Equals(row.Referencia)).Update(x => x.Referencia = row.Referencia);
            log.Output("referencia {row.referencia} alterada");
            return true;
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
