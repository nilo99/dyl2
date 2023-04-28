using RGB_Fade;
using Siticone.Desktop.UI.WinForms;
using Swed64;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;

namespace trainerrr
{
    public partial class Form1 : Form
    {
        Swed swed;
        IntPtr moduleBase;
        public Form1()
        {
            InitializeComponent();
        }
        private SiticoneButton bativo;
        private Form fativo;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ativo(object btnSender)
        {
            if (btnSender != null)
            {
                if (bativo != (SiticoneButton)btnSender)
                {
                    bativo = (SiticoneButton)btnSender;
                }
            }
        }

        public void ochildform(Form childForm, object btnSender)
        {
            if (fativo != null)
            {
                fativo.Close();
            }
            ativo(btnSender);
            fativo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            panel9.BringToFront();
            try
            {
                if (webClient.DownloadString("https://pastebin.com/raw/pHWRJV81").Contains("1.0.0"))
                {
                    siticoneButton5.Hide();
                }

            }
            catch
            {

            }
            //swed = new Swed("DyingLightGame_x64_rwdi");
            //moduleBase = swed.GetModuleBase("gamedll_ph_x64_rwdi.dll");
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RGBEffect.RgbMode();
            panel3.BackColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
            panel5.BackColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
            panel6.BackColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
            panel7.BackColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
            panel8.BackColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
            siticoneHtmlLabel1.ForeColor = Color.FromArgb(RGBEffect.A, RGBEffect.R, RGBEffect.G);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            ochildform(new Melee(), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            siticoneTransition1.Hide(panel9);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                client.DownloadFile("yourfilelink", @"Demo.zip");
                Process.Start(@".\Demo.exe");
                this.Close();
            }
            catch
            {
                MessageBox.Show("No Internet");
            }
        }
    }
}