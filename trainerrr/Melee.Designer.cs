namespace trainerrr
{
    partial class Melee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.AnimatorNS.Animation animation1 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Melee));
            Siticone.Desktop.UI.AnimatorNS.Animation animation2 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            siticoneElipse1 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(components);
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            siticoneToggleSwitch1 = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            label2 = new Label();
            siticoneElipse2 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(components);
            siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            siticoneTransition2 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            siticoneElipse3 = new Siticone.Desktop.UI.WinForms.SiticoneElipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            siticoneTransition2.SetDecoration(panel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition1.SetDecoration(panel1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 49);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            siticoneTransition1.SetDecoration(pictureBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition2.SetDecoration(pictureBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            siticoneTransition1.SetDecoration(label1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition2.SetDecoration(label1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "Melee Options";
            // 
            // siticoneElipse1
            // 
            siticoneElipse1.TargetControl = panel1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            siticoneTransition2.SetDecoration(panel2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition1.SetDecoration(panel2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 297);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            siticoneTransition1.SetDecoration(pictureBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition2.SetDecoration(pictureBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(214, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 32, 32);
            panel3.Controls.Add(siticoneToggleSwitch1);
            panel3.Controls.Add(label2);
            siticoneTransition2.SetDecoration(panel3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition1.SetDecoration(panel3, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            panel3.Location = new Point(8, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 46);
            panel3.TabIndex = 1;
            // 
            // siticoneToggleSwitch1
            // 
            siticoneToggleSwitch1.CheckedState.BorderColor = Color.Lime;
            siticoneToggleSwitch1.CheckedState.FillColor = Color.Lime;
            siticoneToggleSwitch1.CheckedState.InnerBorderColor = Color.Black;
            siticoneToggleSwitch1.CheckedState.InnerColor = Color.Black;
            siticoneTransition2.SetDecoration(siticoneToggleSwitch1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition1.SetDecoration(siticoneToggleSwitch1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneToggleSwitch1.Location = new Point(192, 14);
            siticoneToggleSwitch1.Name = "siticoneToggleSwitch1";
            siticoneToggleSwitch1.Size = new Size(35, 20);
            siticoneToggleSwitch1.TabIndex = 1;
            siticoneToggleSwitch1.UncheckedState.BorderColor = Color.Red;
            siticoneToggleSwitch1.UncheckedState.FillColor = Color.Red;
            siticoneToggleSwitch1.UncheckedState.InnerBorderColor = Color.Black;
            siticoneToggleSwitch1.UncheckedState.InnerColor = Color.Black;
            siticoneToggleSwitch1.CheckedChanged += siticoneToggleSwitch1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            siticoneTransition1.SetDecoration(label2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition2.SetDecoration(label2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(172, 19);
            label2.TabIndex = 0;
            label2.Text = "Unbreakable Weapons";
            // 
            // siticoneElipse2
            // 
            siticoneElipse2.BorderRadius = 20;
            siticoneElipse2.TargetControl = panel2;
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
            // siticoneTransition2
            // 
            siticoneTransition2.AnimationType = Siticone.Desktop.UI.AnimatorNS.AnimationType.VertSlide;
            siticoneTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            siticoneTransition2.DefaultAnimation = animation2;
            // 
            // siticoneElipse3
            // 
            siticoneElipse3.TargetControl = panel3;
            // 
            // Melee
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(277, 320);
            Controls.Add(panel2);
            Controls.Add(panel1);
            siticoneTransition2.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            siticoneTransition1.SetDecoration(this, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Melee";
            Text = "Melee";
            Load += Melee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse2;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitch1;
        private PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;
        private Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition2;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse siticoneElipse3;
    }
}