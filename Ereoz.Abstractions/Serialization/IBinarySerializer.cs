using System;

namespace Ereoz.Abstractions.Serialization
{
    /// <summary>
    /// Defines a contract for serialization and deserialization operations,
    /// where serialized data is presented in binary format.
    /// </summary>
    public interface IBinarySerializer
    {
        /// <summary>
        /// Serializes an object into the text format.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="objectForSerialization">The object to serialize.</param>
        /// <returns>The serialized representation of the object.</returns>
        byte[] Serialize<T>(T objectForSerialization);

        /// <summary>
        /// Deserializes a serialized object back into its original type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize into.</typeparam>
        /// <param name="serializedObject">The serialized object representation.</param>
        /// <returns>The deserialized object of type T.</returns>
        T Deserialize<T>(byte[] serializedObject);

        /// <summary>
        /// Deserializes a serialized object into a specific target type, when the target type is not known at compile time.
        /// </summary>
        /// <param name="serializedObject">The serialized object representation.</param>
        /// <param name="targetType">The type to deserialize the object into.</param>
        /// <returns>The deserialized object as an <see cref="object"/>.</returns>
        object Deserialize(byte[] serializedObject, Type targetType);
    }
}
