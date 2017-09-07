using OsuApi.Model;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace OsuApi
{
    internal static class Extensions
    {
        public static T Deserialize<T>(this string json) where T : class
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return serializer.ReadObject(stream) as T;
            }
        }

        public static int ToInt(this Mods mods)
        {
            if (mods.HasFlag(Mods.NC))
            {
                mods |= Mods.DT;
            }
            return (int)mods;
        }

        public static Mods ToMods(this int number)
        {
            Mods result = (Mods)number;
            if (result.HasFlag(Mods.NC))
            {
                result ^= Mods.DT;
            }
            return result;
        }
    }
}