using System;
using System.Collections.Generic;
using System.Text;

namespace KakashiApp.Domain
{
    class Genin
    {
        public Genin()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } // famous quotes from pervy genin
        public Clan Clan { get; set; }
    }
}
