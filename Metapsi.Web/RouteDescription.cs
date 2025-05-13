using System.Collections.Generic;

namespace Metapsi
{
    /// <summary>
    /// Describes routes. Used to find relative or absolute URLs when building page models
    /// </summary>
    public class RouteDescription
    {
        public string Name { get; internal set; }
        private Dictionary<string, string> Arguments { get; set; } = new Dictionary<string, string>();

        public RouteDescription(string name)
        {
            this.Name = name;
        }

        public static RouteDescription New(string name, System.Action<RouteDescription> setArguments = null)
        {
            RouteDescription result = new RouteDescription(name);
            if (setArguments != null)
            {
                setArguments(result);
            }

            return result;
        }

        public RouteDescription Add(string name, string value)
        {
            this.Arguments.Add(name, value);
            return this;
        }

        public string Get(string name)
        {
            this.Arguments.TryGetValue(name, out string value);
            return value;
        }
    }
}
