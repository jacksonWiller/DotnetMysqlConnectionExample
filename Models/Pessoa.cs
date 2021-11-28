using System;
using System.ComponentModel.DataAnnotations;

namespace MysqlConection.Models
{
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set;}
        public string Nome { get; set;}
        public int idade {get; set;}

    }
}