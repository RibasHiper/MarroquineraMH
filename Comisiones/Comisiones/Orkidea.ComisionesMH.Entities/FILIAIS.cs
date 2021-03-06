//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orkidea.ComisionesMH.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FILIAIS
    {
        public string FILIAL { get; set; }
        public int EMPRESA { get; set; }
        public string CONTA_CONTABIL { get; set; }
        public string TIPO_ESTOQUE_IDEAL { get; set; }
        public string COD_FILIAL { get; set; }
        public string TIPO_FILIAL { get; set; }
        public string CLIFOR { get; set; }
        public bool FILIAL_PROPRIA { get; set; }
        public string CGC_CPF { get; set; }
        public string MATRIZ { get; set; }
        public string REGIAO { get; set; }
        public bool ESTOQUE_CTRL_PECA_UNICA { get; set; }
        public bool ESTOQUE_CTRL_PECA { get; set; }
        public string SEQUENCIA_PECAS { get; set; }
        public byte[] TIMESTAMP { get; set; }
        public Nullable<short> TEMPO_ATENDIMENTO { get; set; }
        public Nullable<System.DateTime> DATA_PARA_TRANSFERENCIA { get; set; }
        public string REDE_LOJAS { get; set; }
        public Nullable<short> NAO_GERA_ENTRADA_LOJA_AUTO { get; set; }
        public Nullable<decimal> FATOR_CUSTO_LOJA { get; set; }
        public bool PERMITE_EST_NEGATIVO { get; set; }
        public bool CTRL_ESTOQUE_MATERIAL { get; set; }
        public bool CTRL_ESTOQUE_PRODUTO { get; set; }
        public bool CTRL_LOJA_VAREJO { get; set; }
        public bool CTRL_PRODUCAO_PRODUTO { get; set; }
        public bool CTRL_VENDA_PRODUTO { get; set; }
        public bool CTRL_VENDA_MATERIAL { get; set; }
        public bool CTRL_PRODUCAO_MATERIAL { get; set; }
        public Nullable<int> AREA_M2 { get; set; }
        public string VENDEDOR_PADRAO_FRANQUIA { get; set; }
        public string FORMA_PGTO_PADRAO_FRANQUIA { get; set; }
        public string CLIENTE_VAREJO_PADRAO_FRANQUIA { get; set; }
        public string RECEBER_PADRAO_FRANQUIA { get; set; }
        public Nullable<short> EXPORTA_PGTOS_FRANQUIA { get; set; }
        public bool INDICA_ARMAZEM { get; set; }
        public bool INDICA_SEGUNDA_QUALIDADE { get; set; }
        public bool INDICA_BENEFICIADOR { get; set; }
        public string REGIAO_SUPERVISAO { get; set; }
        public bool INDICA_FRANQUIA { get; set; }
        public string MATRIZ_FISCAL { get; set; }
        public string CTB_CONTA_CONTABIL { get; set; }
        public bool SOMENTE_ARMAZEM { get; set; }
        public bool INDICA_CFOP_SOMENTE_REVENDA { get; set; }
        public string SEQUENCIA_MAPA_RESUMO { get; set; }
        public Nullable<byte> FATOR_P { get; set; }
        public Nullable<byte> FATOR_Q { get; set; }
        public Nullable<byte> FATOR_F { get; set; }
        public string COD_FORMA_PGTO_FLUXO { get; set; }
        public bool FECHA_CUSTO_MEDIO { get; set; }
        public bool FECHA_CM_AJUSTE_INFLACAO { get; set; }
        public string CODIGO_CONTATO { get; set; }
        public string TIPO_ESTOQUE_IDEAL_MIN { get; set; }
        public string TIPO_ESTOQUE_IDEAL_MAX { get; set; }
        public Nullable<byte> FATOR_S { get; set; }
        public Nullable<byte> FATOR_W { get; set; }
    }
}
