namespace Metapsi
{
    public interface ITypeWrapper
    {
        void Set(object o);
        object Get();
    }

    public class GenericTypedWrapper<T>  : ITypeWrapper
    {
        public string TypeName { get; set; }
        public T Content { get; set; }

        public object Get()
        {
            return Content;
        }

        public void Set(object o)
        {
            Content = (T)o;
        }
    }

    public class ObjectTypeWrapper : ITypeWrapper
    {
        public string TypeName { get; set; }
        public object Content { get; set; }

        public object Get()
        {
            return Content;
        }

        public void Set(object o)
        {
            Content = o;
            TypeName = o.GetType().AssemblyQualifiedName;
        }
    }
}
