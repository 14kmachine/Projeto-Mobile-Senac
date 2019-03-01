using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcademia
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        [MaxLength(50), NotNull]
        public string Nome { get; set; }

        [MaxLength(100), NotNull]
        public string Email { get; set; }

        [MaxLength(255), NotNull]
        public string Senha { get; set; }

        [MaxLength(255), NotNull]
        public string Numero1 { get; set; }

        [MaxLength(255), NotNull]
        public string PesoSerie1 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso1 { get; set; }

        [MaxLength(255), NotNull]
        public string Numero2 { get; set; }

        [MaxLength(255), NotNull]
        public string PesoSerie2 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso2 { get; set; }

        [MaxLength(255), NotNull]
        public string Numero3 { get; set; }

        [MaxLength(255), NotNull]
        public string PesoSerie3 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso3 { get; set; }

        [MaxLength(255), NotNull]
        public string Numero4 { get; set; }

        [MaxLength(255), NotNull]
        public string PesoSerie4 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso4 { get; set; }

        [MaxLength(255), NotNull]
        public string Numero5 { get; set; }

        [MaxLength(255), NotNull]
        public string Serie5 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso5 { get; set; }

        [MaxLength(255), NotNull]
        public string numero6{ get; set; }

        [MaxLength(255), NotNull]
        public string Serie6 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso6 { get; set; }

        [MaxLength(255), NotNull]
        public string numero7 { get; set; }

        [MaxLength(255), NotNull]
        public string Serie7 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso7 { get; set; }

        [MaxLength(255), NotNull]
        public string numero8 { get; set; }

        [MaxLength(255), NotNull]
        public string Serie8 { get; set; }

        [MaxLength(255), NotNull]
        public string Peso8 { get; set; }

        [MaxLength(255), NotNull]

        public string agendarnome { get; set; }
        [MaxLength(255), NotNull]
        public string dia { get; set; }

        [MaxLength(255), NotNull]
        public string hora { get; set; }

        [MaxLength(255), NotNull]
        public string digite{ get; set; }

        [MaxLength(255), NotNull]
        public string dicas{ get; set; }

        [MaxLength(255), NotNull]
        public string quemsomos { get; set; }

        [MaxLength(255), NotNull]
        public string feedback { get; set; }








    }
}
