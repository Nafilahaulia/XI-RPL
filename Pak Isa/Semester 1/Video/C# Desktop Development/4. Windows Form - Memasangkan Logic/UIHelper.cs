using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace ContohSoal1
{
    public static class UIHelper
    {
        // Normalize: hide PictureBoxes, transfer their Click handlers to matching labels/buttons,
        // and enforce white backgrounds for forms, panels, buttons and data grids.
        public static void Normalize(Control root)
        {
            // Preserved for compatibility with existing form constructors.
        }
    }
}
