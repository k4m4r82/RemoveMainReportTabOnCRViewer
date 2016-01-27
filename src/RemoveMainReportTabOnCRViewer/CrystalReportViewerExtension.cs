using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace RemoveMainReportTabOnCRViewer
{
    public static class CrystalReportViewerExtension
    {
        /// <summary>
        /// Ini adalah contoh extension method
        /// </summary>
        /// <param name="crv"></param>
        public static void RemoveMainTab(this CrystalReportViewer crv)
        {
            foreach (Control ct in crv.Controls)
            {
                if (ct is PageView)
                {
                    foreach (var c in ct.Controls)
                    {
                        if (c is TabControl)
                        {
                            var tab = (TabControl)((PageView)ct).Controls[0];

                            tab.ItemSize = new System.Drawing.Size(0, 1);
                            tab.SizeMode = TabSizeMode.Fixed;
                            tab.Appearance = TabAppearance.Buttons;
                        }
                    }
                }
            }
        }
    }
}
