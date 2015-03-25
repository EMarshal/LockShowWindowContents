// <copyright file="ShowWindowContents.cs" company="Éli Marshal">
//     Copyright (c) Éli Marshal. All rights reserved.
// </copyright>

namespace LockShowWindowContents
{
    /// <summary>
    /// This program enables the "Show window contents while dragging" setting if it isn't already enabled.
    /// </summary>
    public static class ShowWindowContents
    {
        /// <summary>
        /// Enables "Show window contents" if it isn't already enabled.
        /// </summary>
        public static void SetShowWindowContents()
        {
            if (!IsShowDragEnabled())
            {
                NativeMethods.SystemParametersInfo(NativeMethods.SPI_SETDRAGFULLWINDOWS, true, null, NativeMethods.SPIF_UPDATEINIFILE | NativeMethods.SPIF_SENDCHANGE);
            }
        }

        /// <summary>
        /// Checks if "Show window contents while dragging" is enabled.
        /// </summary>
        /// <returns>True if "Show window contents while dragging" is enabled, false otherwise.</returns>
        private static bool IsShowDragEnabled()
        {
            bool returnValue = false;
            NativeMethods.SystemParametersInfo(NativeMethods.SPI_GETDRAGFULLWINDOWS, 0, ref returnValue, 0);
            return returnValue;
        }
    }
}
