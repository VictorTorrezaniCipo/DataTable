using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Entities.Maps
{
    public class MateriaMap : ClassMap<Materia>
    {
        public MateriaMap()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Descricao).Column("Descricao");
            Table("Materias");
        }
    }
}