using System;

namespace Ereoz.Abstractions.Serialization
{
    public interface ISerializator<SerializedType>
    {
        SerializedType Serialize<T>(T objectForSerialization, bool formattingIndented = false);

        T Deserialize<T>(SerializedType serializedObject);

        object Deserialize(Type targetType, SerializedType serializedObject);
    }
}
