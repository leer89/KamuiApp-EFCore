using System;
using System.Collections.Generic;
using System.Text;

namespace KakashiApp.Domain
{
    class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Genin Genin { get; set; }
        public int GeninId { get; set; }
    }
}
