using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvOnline.Modelo
{
    /// <summary>
    /// Classe para os canais a serem armazenados e exibidos
    /// </summary>
    [Table("canal")]
    public class Canal
    {
        //atributos private da classe
        private int _numero;
        private string _nome;
        private string _tvUrl;
        private string _logoUrl;
        private string _grupo;
        private string _pais;
        //private bool _parentControl;  //implementação futura
        //private string _parentSenha;  //implementação futura


        //Construtores
        public Canal()
        {

        }

        public Canal(int number, string name, string link)
        {
            this.Numero = number;
            this.Nome = name;
            this.TvUrl = link;
        }


        //propriedades public
        [Key, Column("numero"), ]
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        } 

        [Column("nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        [Column("tvUrl")]
        public string TvUrl
        {
            get { return _tvUrl; }
            set { _tvUrl = value; }
        }

        [Column("logoUrl")]
        public string LogoUrl
        {
            get { return _logoUrl; }
            set { _logoUrl = value; }
        }

        [Column("grupo")]
        public string Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        [Column("pais")]
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        ////implementação futura
        //public bool ParentControl
        //{
        //    get { return _parentControl; }
        //    set { _parentControl = value; }
        //}

        ////implementação futura
        //public string ParentSenha
        //{
        //    get { return _parentSenha; }
        //    set { _parentSenha = value; }
        //}
    }
}
