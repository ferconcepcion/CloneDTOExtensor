using Newtonsoft.Json;

namespace CloneExtensor
{
    /// <summary>
    /// Class with extender properties to clone or convert objetc using
    /// Newtonsoft library.
    /// 
    /// Author:
    /// Fernando Concepción Gutiérrez
    /// http://www.fconcepcion.com
    /// </summary>
    public static class CloneExtensor
    {
        #region Clone

        /// <summary>
        /// Clones the DTO object.
        /// </summary>
        /// <typeparam name="T">DTO class or type.</typeparam>
        /// <param name="dto">DTO to clone.</param>
        /// <returns>Cloned DTO.</returns>
        public static T Clone<T>(this T dto)
        {
            var serializate = JsonConvert.SerializeObject(dto);
            return JsonConvert.DeserializeObject<T>(serializate);
        }

        /// <summary>
        /// Clones the DTO object.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <typeparam name="T">DTO class or type.</typeparam>
        /// <param name="dto">DTO to clone.</param>
        /// <param name="cloneResult">Cloned DTO.</param>
        /// <returns>True if DTO was cloned successfully; otherwise, false.</returns>
        public static bool TryClone<T>(this T dto, out T cloneResult)
        {
            try
            {
                cloneResult = dto.Clone(); 
                return true;
            }
            catch
            {
                cloneResult = default(T);
                return false;
            }
        }

        #endregion

        #region Convert

        /// <summary>
        /// Converts the DTO object to a different DTO type.
        /// </summary>
        /// <typeparam name="T">DTO class or type to get.</typeparam>
        /// <typeparam name="Y">DTO class or type to convert.</typeparam>
        /// <param name="dto">DTO to convert.</param>
        /// <returns>Converted DTO.</returns>
        public static T Convert<T, Y>(this Y dto)
        {
            var serializate = JsonConvert.SerializeObject(dto);
            return JsonConvert.DeserializeObject<T>(serializate);
        }

        /// <summary>
        /// Converts the DTO object to a different DTO type.
        /// A return value indicates whether the conversion succeeded.
        /// </summary>
        /// <typeparam name="T">DTO class or type to get.</typeparam>
        /// <typeparam name="Y">DTO class or type to convert.</typeparam>
        /// <param name="dto">DTO to convert.</param>
        /// <param name="convertResult">Converted DTO.</param>
        /// <returns>True if DTO was cloned successfully; otherwise, false.</returns>
        public static bool TryConvert<T, Y>(this Y dto, out T convertResult)
        {
            try
            {
                convertResult = dto.Convert<T, Y>();
                return true;
            }
            catch
            {
                convertResult = default(T);
                return false;
            }
        }

        #endregion
    }
}
