namespace Metapsi
{
    public interface IStyleBuilder
    {
        /// <summary>
        /// Adds a specific style
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public void AddStyle(string property, string value);
    }

    public interface IHtmlAttributesBuilder : IStyleBuilder
    {
        /// <summary>
        /// Sets HTML attribute to specific value
        /// </summary>
        /// <param name="attribute">The attribute to set</param>
        /// <param name="value">The value</param>
        public void SetAttribute(string attribute, string value);
        
        /// <summary>
        /// Sets boolean attribute
        /// <para>Note that boolean attributes have no 'false' value. If they exist, they are true</para>
        /// </summary>
        /// <param name="attribute">The attribute to enable</param>
        public void SetAttribute(string attribute);

        public void AddClass(string className);
    }
}