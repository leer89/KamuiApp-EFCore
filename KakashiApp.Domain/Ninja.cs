using System;
using System.Collections.Generic;
using System.Text;

namespace KakashiApp.Domain
{
    public class Ninja
    {
        public Ninja()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } // famous quotes from pervy genin
        public Clan Clan { get; set; }
    }
}
