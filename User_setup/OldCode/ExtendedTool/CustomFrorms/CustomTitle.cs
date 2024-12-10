using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.OldCode.ExtendedTool.CustomFrorms
{
    internal static class CustomTitle
    {


        internal static void CreateCustomTitleBar(Form form)
        {
            Panel TitleBar = new Panel
            {
                Height = 40,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(4, 32, 44)

            };




            form.Controls.Add(TitleBar);

            Button button = new Button
            {
                Text = "X",
                Font = new Font("Montserrat", 18),
                ForeColor = Color.White,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat,
                Width = 40,
            };
            button.FlatAppearance.BorderSize = 0;

            TitleBar.Controls.Add(button);

        }









    }
}
