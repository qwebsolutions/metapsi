using System;


namespace Metapsi.Live.Db
{
    public class Input : IRecord
    {
        public Guid Id { get; set; }
        public string InputName { get; set; }
        public string RendererName { get; set; }
        public string Json { get; set; } = "{}";
    }

    public class Solution : IRecord
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
    }
}
