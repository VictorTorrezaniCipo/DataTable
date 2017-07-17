using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Entities
{
    public class Aluno
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual int IdMateria { get; set; }

        public virtual Materia Materia { get; set; }
    }
}