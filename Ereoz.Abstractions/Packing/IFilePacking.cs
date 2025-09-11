namespace Ereoz.Abstractions.Packing
{
    /// <summary>
    /// Defines an abstraction for packing and unpacking files and directories.
    /// </summary>
    public interface IFilePacking
    {
        /// <summary>
        /// Packs the specified source (either a file or all contents of a directory) into an archive.
        /// </summary>
        /// <param name="sourcePath">
        /// The path to the source entity to be packed. This can be a single file
        /// or a directory. If a directory is provided, its entire contents will be included in the archive.
        /// </param>
        /// <param name="zipFile">
        /// The output archive file. If not specified, it will be generated as the source name plus a specific extension
        /// and to the same location where the sourse is located.
        /// </param>
        /// <param name="isCompress">Specifies whether the contents should be compressed. Defaults to <see langword="true" />.</param>
        void Pack(string sourcePath, string zipFile = null, bool isCompress = true);

        /// <summary>
        /// Unpacks the contents of an archive file to a specified destination directory.
        /// </summary>
        /// <param name="zipFile">The path to the archive file to be unpacked.</param>
        /// <param name="destinationPath">
        /// The path where the archive contents will be extracted.
        /// If not specified, it will be extracted to the same location where the archive file is located.
        /// </param>
        void Unpack(string zipFile, string destinationPath = null);
    }
}
