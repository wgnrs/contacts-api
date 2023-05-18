using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos.Domain.Models
{
    public class ContatoService
    {
        private readonly IRepository<Contato> _contatoRepository;

        public ContatoService(IRepository<Contato> _contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public void Save(int id, string nome, string email)
        {
            var contato = _contatoRepository.GetById(id);

            if(contato == null)
            {
                contato = new Contato(nome, email);
                _contatoRepository.Save(contato);
            }
            else
                contato.Update(nome, email);
        }


    }
}