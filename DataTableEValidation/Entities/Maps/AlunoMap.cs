using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Entities.Maps
{
    public class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Nome).Column("Nome");
            Map(x => x.IdMateria).Column("IdMateria");
            Table("Alunos");

            References(x => x.Materia)
                .Column("IdMateria");
        }
    }
}