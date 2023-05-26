using Dapper;
using System;
using System.Data;

namespace Metapsi.Sqlite
{
    public static class Converters
    {
        public static void RegisterAll()
        {
            IdConverter.Register();
            DateTimeConverter.Register();
        }
    }

    public class IdConverter : SqlMapper.TypeHandler<Guid>
    {
        public override Guid Parse(object value)
        {
            if (value is String)
                return Guid.Parse(Convert.ToString(value));

            return (Guid)value;
        }

        public override void SetValue(IDbDataParameter parameter, Guid value)
        {
            switch (parameter.DbType)
            {
                case DbType.String:
                    parameter.Value = value.ToString();
                    break;
                default:
                    parameter.Value = value;
                    break;
            }
        }

        public static void Register()
        {
            SqlMapper.AddTypeHandler(new IdConverter());
            SqlMapper.RemoveTypeMap(typeof(Guid));
            SqlMapper.RemoveTypeMap(typeof(Guid?));
        }
    }

    public class DateTimeConverter : SqlMapper.TypeHandler<DateTime>
    {
        public override DateTime Parse(object value)
        {
            if (value is String)
            {
                return DateTime.ParseExact(value as String, "O", System.Globalization.CultureInfo.InvariantCulture);
            }
            return (DateTime)value;
        }

        public override void SetValue(IDbDataParameter parameter, DateTime value)
        {
            switch (parameter.DbType)
            {
                case DbType.String:
                    parameter.Value = value.ToString("O");
                    break;
                default:
                    parameter.Value = value;
                    break;
            }
        }

        public static void Register()
        {
            SqlMapper.AddTypeHandler(new DateTimeConverter());
            SqlMapper.RemoveTypeMap(typeof(DateTime));
            SqlMapper.RemoveTypeMap(typeof(DateTime?));
        }
    }

    public static class Scalar
    {
        public static object GetConvertedValue(ChangedItemProperty changedItemProperty)
        {
            switch (changedItemProperty.ScalarTypeName)
            {
                case "Id":
                    return Guid.Parse(changedItemProperty.PropertyValue);
                case "String":
                    return changedItemProperty.PropertyValue;
                case "Int":
                    return Convert.ToInt32(changedItemProperty.PropertyValue);
                case "Boolean":
                    return Convert.ToBoolean(changedItemProperty.PropertyValue);
                case "Timestamp":
                    return DateTime.ParseExact(changedItemProperty.PropertyValue, "o", System.Globalization.CultureInfo.InvariantCulture);
            }
            throw new NotSupportedException();
        }
    }

}
