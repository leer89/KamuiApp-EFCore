using System;
using System.Collections.Generic;
using System.Text;

namespace KakashiApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Ninja Genin { get; set; }
        public int GeninId { get; set; }
    }
}
