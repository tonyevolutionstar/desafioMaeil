namespace DesafioMaeil
{
    /// <summary>
    /// Columns of excel file
    /// </summary>
    public class Row
    {
        public string referencia;
        public string cliente;
        public string estado;
        public string tipo;
        public string matricula;
        public string tipoCarga;
        public string prioridade;
        public string dataRegisto;
        public string blockedTime;
        public string pod;
        public string parque;
        public string tipoEquipamento;
        public int depositIdBlocking;
        public string dataAtribExp;
        public string vessel;
        public string voyage;
        public string pol;

        public string Referencia { get => referencia; set => referencia = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string TipoCarga { get => tipoCarga; set => tipoCarga = value; }
        public string Prioridade { get => prioridade; set => prioridade = value; }
        public string DataRegisto { get => dataRegisto; set => dataRegisto = value; }
        public string BlockedTime { get => blockedTime; set => blockedTime = value; }
        public string Pod { get => pod; set => pod = value; }
        public string Parque { get => parque; set => parque = value; }
        public string TipoEquipamento { get => tipoEquipamento; set => tipoEquipamento = value; }
        public int DepositIdBlocking { get => depositIdBlocking; set => depositIdBlocking = value; }
        public string DataAtribExp { get => dataAtribExp; set => dataAtribExp = value; }
        public string Vessel { get => vessel; set => vessel = value; }
        public string Voyage { get => voyage; set => voyage = value; }
        public string Pol { get => pol; set => pol = value; }


        public Row(string referencia, string cliente, string estado, string tipo, string matricula, string tipoCarga, string prioridade, string dataRegisto, string blockedTime, string pod, string parque, string tipoEquipamento, int depositIdBlocking, string dataAtribExp, string vessel, string voyage, string pol)
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

    }
}
