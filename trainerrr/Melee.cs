using Siticone.UI.WinForms.Suite;
using Swed64;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainerrr
{
    public partial class Melee : Form
    {
        Swed swed;
        IntPtr moduleBase;
        public Melee()
        {
            InitializeComponent();
        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(siticoneToggleSwitch1.Checked)
            {
                swed.Nop(moduleBase, 0x124CEF3, 8);
            }
            else
            {
                swed.WriteBytes(moduleBase, 0x124CEF3, "F3 0F 11 B7 A8 00 00 00");
            }
        }

        private void Melee_Load(object sender, EventArgs e)
        {
            try {
                panel2.Hide();
                swed = new Swed("DyingLightGame_x64_rwdi");
                moduleBase = swed.GetModuleBase("gamedll_ph_x64_rwdi.dll");
            }
            catch
            {
                MessageBox.Show("DyingLight 2 Not running");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                siticoneTransition2.Hide(panel2);
                panel2.SendToBack();
            }
            else
            {
                panel2.BringToFront();
                siticoneTransition2.Show(panel2);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            siticoneTransition2.Hide(panel2);
            panel2.SendToBack();
        }
    }
}
