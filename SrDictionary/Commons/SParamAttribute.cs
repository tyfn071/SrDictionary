using System.Data;
using System.Runtime.CompilerServices;

namespace SrDictionary.Commons
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class SParamAttribute : Attribute
    {
        public SParamAttribute([CallerMemberName] string? name = null, SqlDbType type = SqlDbType.Int, int length = 0)
        {
            Name = name;
            Length = length;
        }
        public string? Name { get; private set; }
        public SqlDbType Type { get; private set; }
        public int Length { get; private set; }
    }
}
