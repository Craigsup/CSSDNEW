using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModifiedTicketingSystem {
    /// <summary>
    /// Class to contain functions to persist and retrieve persisted data.
    /// Used many times throughout the applications.
    /// </summary>
    public class Persister {
        /// <summary>
        /// Empty constructer as no attributes to initialise.
        /// </summary>
        public Persister() {

        }

        /// <summary>
        /// This is a dynamic serialiser that uses a template to read in from a specified file and convert to the given type.
        /// </summary>
        /// <typeparam name="T">The type to convert the data to</typeparam>
        /// <param name="filePath">The filepath to open</param>
        /// <returns>The deserialised data in the given type</returns>
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Persists the given object to file.
        /// Used for various objects such as custom classes, lists, etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">The path to the file location</param>
        /// <param name="objectToWrite">The object to persist</param>
        /// <param name="append">Bool to append to the end of the file</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
    }
}
