namespace trainerrr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.AnimatorNS.Animation animation1 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            panel9 = new Panel();
            siticoneButton5 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            panel1 = new Panel();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.Controls.Add(siticoneHtmlLabel1);
            panel2.Controls.Add(siticoneControlBox2);
            panel2.Controls.Add(siticoneControlBox1);
            siticoneTransition1.SetDecoration(panel2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 43);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.BorderStyle = BorderStyle.FixedSingle;
            siticoneTransition1.SetDecoration(siticoneHtmlLabel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneHtmlLabel1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneHtmlLabel1.ForeColor = Color.White;
            siticoneHtmlLabel1.Location = new Point(6, 9);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(161, 27);
            siticoneHtmlLabel1.TabIndex = 3;
            siticoneHtmlLabel1.Text = "DyingLight Trainer";
            siticoneHtmlLabel1.Click += siticoneHtmlLabel1_Click;
            // 
            // siticoneControlBox2
            // 
            siticoneControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            siticoneTransition1.SetDecoration(siticoneControlBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneControlBox2.FillColor = Color.FromArgb(24, 24, 24);
            siticoneControlBox2.IconColor = Color.White;
            siticoneControlBox2.Location = new Point(190, 0);
            siticoneControlBox2.Name = "siticoneControlBox2";
            siticoneControlBox2.Size = new Size(45, 43);
            siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            siticoneTransition1.SetDecoration(siticoneControlBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneControlBox1.FillColor = Color.FromArgb(24, 24, 24);
            siticoneControlBox1.HoverState.FillColor = Color.FromArgb(192, 0, 0);
            siticoneControlBox1.IconColor = Color.White;
            siticoneControlBox1.Location = new Point(239, 0);
            siticoneControlBox1.Name = "siticoneControlBox1";
            siticoneControlBox1.Size = new Size(45, 43);
            siticoneControlBox1.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(24, 24, 24);
            panel9.Controls.Add(siticoneButton5);
            panel9.Controls.Add(siticoneButton4);
            panel9.Controls.Add(siticoneHtmlLabel2);
            siticoneTransition1.SetDecoration(panel9, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(1, 45);
            panel9.Name = "panel9";
            panel9.Size = new Size(286, 401);
            panel9.TabIndex = 0;
            // 
            // siticoneButton5
            // 
            siticoneButton5.BackColor = Color.FromArgb(32, 32, 32);
            siticoneTransition1.SetDecoration(siticoneButton5, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneButton5.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton5.FillColor = Color.FromArgb(32, 32, 32);
            siticoneButton5.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneButton5.ForeColor = Color.White;
            siticoneButton5.Location = new Point(85, 242);
            siticoneButton5.Name = "siticoneButton5";
            siticoneButton5.Size = new Size(107, 38);
            siticoneButton5.TabIndex = 6;
            siticoneButton5.Text = "Update";
            siticoneButton5.Click += siticoneButton5_Click;
            // 
            // siticoneButton4
            // 
            siticoneButton4.BackColor = Color.FromArgb(32, 32, 32);
            siticoneTransition1.SetDecoration(siticoneButton4, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton4.FillColor = Color.FromArgb(32, 32, 32);
            siticoneButton4.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneButton4.ForeColor = Color.White;
            siticoneButton4.Location = new Point(85, 178);
            siticoneButton4.Name = "siticoneButton4";
            siticoneButton4.Size = new Size(107, 38);
            siticoneButton4.TabIndex = 5;
            siticoneButton4.Text = "Open";
            siticoneButton4.Click += siticoneButton4_Click;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.BorderStyle = BorderStyle.FixedSingle;
            siticoneTransition1.SetDecoration(siticoneHtmlLabel2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneHtmlLabel2.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneHtmlLabel2.ForeColor = Color.White;
            siticoneHtmlLabel2.Location = new Point(40, 21);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(202, 33);
            siticoneHtmlLabel2.TabIndex = 4;
            siticoneHtmlLabel2.Text = "DyingLight Trainer";
            // 
            // panel1
            // 
            siticoneTransition1.SetDecoration(panel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(10, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 343);
            panel1.TabIndex = 4;
            // 
            // siticoneButton1
            // 
            siticoneTransition1.SetDecoration(siticoneButton1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.FromArgb(24, 24, 24);
            siticoneButton1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.White;
            siticoneButton1.Location = new Point(10, 49);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.Size = new Size(74, 23);
            siticoneButton1.TabIndex = 0;
            siticoneButton1.Text = "Melee";
            siticoneButton1.Click += siticoneButton1_Click;
            // 
            // siticoneButton2
            // 
            siticoneTransition1.SetDecoration(siticoneButton2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.FillColor = Color.FromArgb(24, 24, 24);
            siticoneButton2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.White;
            siticoneButton2.Location = new Point(86, 49);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.Size = new Size(74, 23);
            siticoneButton2.TabIndex = 5;
            siticoneButton2.Text = "Range";
            // 
            // siticoneButton3
            // 
            siticoneTransition1.SetDecoration(siticoneButton3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton3.FillColor = Color.FromArgb(24, 24, 24);
            siticoneButton3.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            siticoneButton3.ForeColor = Color.White;
            siticoneButton3.Location = new Point(162, 49);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.Size = new Size(74, 23);
            siticoneButton3.TabIndex = 6;
            siticoneButton3.Text = "Misc";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            siticoneTransition1.SetDecoration(panel3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 447);
            panel3.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 24, 24);
            siticoneTransition1.SetDecoration(panel4, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel4.Location = new Point(1, 422);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 32);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 128);
            siticoneTransition1.SetDecoration(panel5, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(1, 446);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 1);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 192, 192);
            siticoneTransition1.SetDecoration(panel6, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(287, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 446);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 255, 192);
            siticoneTransition1.SetDecoration(panel7, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(1, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(286, 1);
            panel7.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 192);
            siticoneTransition1.SetDecoration(panel8, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(286, 1);
            panel8.TabIndex = 9;
            // 
            // siticoneTransition1
            // 
            siticoneTransition1.AnimationType = Siticone.Desktop.UI.AnimatorNS.AnimationType.VertSlide;
            siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            siticoneTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(288, 447);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(siticoneButton3);
            Controls.Add(siticoneButton2);
            Controls.Add(siticoneButton1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            siticoneTransition1.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;
        private Panel panel9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
    }
}