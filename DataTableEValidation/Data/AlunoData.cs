using DataTableEValidation.Entities;
using NHibernate;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Data
{
    public class AlunoData
    {
        internal IEnumerable<Aluno> CarregaTodos()
        {
            using (var session = NHibernateHelper.AbrirSessao())
            {
                return session.QueryOver<Aluno>()
                    .Fetch(x => x.Materia).Eager
                    .TransformUsing(Transformers.DistinctRootEntity)
                    .List<Aluno>();
            }
        }
    }
}