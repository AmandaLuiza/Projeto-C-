using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank2
{
   public class Cliente
    {
        private string _cpf;

        internal string nome;
        public string Nome { get; set; }
        public string cpf { 
            
            get
            {
                return _cpf;
            } set
            {
                //Escrevo minha logica de validação de CPF
                _cpf = value;
            } }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   nome == cliente.nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nome);
        }
    }
}
