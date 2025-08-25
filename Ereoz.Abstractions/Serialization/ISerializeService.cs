using System;

namespace Ereoz.Abstractions.Serialization
{
    public interface ISerializeService<StringOrByteArray>
    {
        StringOrByteArray Serialize<T>(T objectForSerialization, bool formattingIndented = false);

        T Deserialize<T>(StringOrByteArray serializedObject);

        object Deserialize(Type targetType, StringOrByteArray serializedObject);
    }
}
