using Metapsi.Syntax;

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

    public interface IHtmlProps
    {

    }

    public interface IHtmlPropsBuilder : IStyleBuilder
    {
        /// <summary>
        /// Sets HTML attribute to specific value
        /// </summary>
        /// <param name="attribute">The attribute to set</param>
        /// <param name="value">The value</param>
        void SetAttribute(string attribute, string value);

        /// <summary>
        /// Sets boolean attribute
        /// <para>Note that boolean attributes have no 'false' value. If they exist, they are true</para>
        /// </summary>
        /// <param name="attribute">The attribute to enable</param>
        void SetAttribute(string attribute);

        void AddClass(string className);

        void AddStyle(string property, Var<string> value);

        Var<IHtmlProps> GetProps();
    }

    public interface IHtmlPropsBuilder<T> : IHtmlPropsBuilder
    {
        
    }
}