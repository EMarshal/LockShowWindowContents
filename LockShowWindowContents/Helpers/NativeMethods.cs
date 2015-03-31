// <copyright file="NativeMethods.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents.Helpers
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contains native methods for SystemParametersInfo to use for SPI_SETDRAGFULLWINDOWS and SPI_GETDRAGFULLWINDOWS
    /// </summary>
    public static class NativeMethods
    {
        /// <summary>
        /// Constant 0x01.
        /// </summary>
        public const short SPIF_UPDATEINIFILE = 0x01;

        /// <summary>
        /// Constant 0x02.
        /// </summary>
        public const short SPIF_SENDCHANGE = 0x02;

        /// <summary>
        /// Constant 0x25.
        /// </summary>
        public const short SPI_SETDRAGFULLWINDOWS = 0x25;

        /// <summary>
        /// Constant 0x26.
        /// </summary>
        public const short SPI_GETDRAGFULLWINDOWS = 0x26;

        /// <summary>
        /// SystemParametersInfo call.
        /// </summary>
        /// <param name="uAction">System parameter to query or set.</param>
        /// <param name="uParam">Depends on system parameter.</param>
        /// <param name="lpvParam">Depends on system parameter.</param>
        /// <param name="fuWinIni">WIN.INI update flag.</param>
        /// <returns>True if successful</returns>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1625:ElementDocumentationMustNotBeCopiedAndPasted",
            Justification = "Standard documentation.")]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SystemParametersInfo(int uAction, int uParam, ref bool lpvParam, int fuWinIni);

        /// <summary>
        /// SystemParametersInfo call.
        /// </summary>
        /// <param name="uAction">System parameter to query or set.</param>
        /// <param name="uParam">Depends on system parameter.</param>
        /// <param name="lpvParam">Depends on system parameter.</param>
        /// <param name="fuWinIni">WIN.INI update flag.</param>
        /// <returns>True if successful</returns>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1625:ElementDocumentationMustNotBeCopiedAndPasted",
            Justification = "Standard documentation.")]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool SystemParametersInfo(int uAction, bool uParam, string lpvParam, int fuWinIni);
    }
}
