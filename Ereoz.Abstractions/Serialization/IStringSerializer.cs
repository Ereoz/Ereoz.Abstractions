using System;

namespace Ereoz.Abstractions.Serialization
{
    /// <summary>
    /// Defines a contract for serialization and deserialization operations,
    /// where serialized data is presented in text format.
    /// </summary>
    public interface IStringSerializer
    {
        /// <summary>
        /// Serializes an object into the text format.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="objectForSerialization">The object to serialize.</param>
        /// <param name="formattingIndented">A value indicating whether to format the serialized output with indentation (e.g., for readability).</param>
        /// <returns></returns>
        string Serialize<T>(T objectForSerialization, bool formattingIndented = false);

        /// <summary>
        /// Deserializes a serialized object back into its original type.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize into.</typeparam>
        /// <param name="serializedObject">The serialized object representation.</param>
        /// <returns>The deserialized object of type T.</returns>
        T Deserialize<T>(string serializedObject);

        /// <summary>
        /// Deserializes a serialized object into a specific target type, when the target type is not known at compile time.
        /// </summary>
        /// <param name="serializedObject">The serialized object representation.</param>
        /// <param name="targetType">The type to deserialize the object into.</param>
        /// <returns>The deserialized object as an <see cref="object"/>.</returns>
        object Deserialize(string serializedObject, Type targetType);
    }
}
