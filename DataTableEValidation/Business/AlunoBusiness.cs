using DataTableEValidation.Data;
using DataTableEValidation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEValidation.Business
{
    public class AlunoBusiness
    {
        internal IEnumerable<Aluno> CarregarTodos()
        {
            var data = new AlunoData();
            return data.CarregaTodos();
        }
    }
}