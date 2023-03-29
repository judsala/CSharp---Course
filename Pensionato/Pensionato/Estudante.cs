﻿namespace Pensionato
{
    internal class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Estudante(string nome, string email) { 
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
