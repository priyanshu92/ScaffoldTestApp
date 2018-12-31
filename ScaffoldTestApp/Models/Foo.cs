using System.Collections.Generic;

namespace ScaffoldTestApp.Models
{
    public class Foo
    {
        public string Name { get; set; } = string.Empty;
        public List<Bar> Bars { get; set; } = new List<Bar>();
    }

    public class Bar
    {
        public string Name { get; set; } = string.Empty;
    }
}