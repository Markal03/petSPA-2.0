using System;
using System.ComponentModel.DataAnnotations;

namespace PetSPA.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type {get; set;}
    }
}