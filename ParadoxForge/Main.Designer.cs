namespace ParadoxForge
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            launch_btn = new Button();
            priority_cmb = new ComboBox();
            main_pnl = new Panel();
            modmenu_pnl = new Panel();
            feature6_btn = new Button();
            feature5_btn = new Button();
            feature4_btn = new Button();
            feature3_btn = new Button();
            feature2_btn = new Button();
            feature1_btn = new Button();
            updateinfo_lbl = new Label();
            inject_chb = new CheckBox();
            closegame_chb = new CheckBox();
            label1 = new Label();
            main_pnl.SuspendLayout();
            modmenu_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // launch_btn
            // 
            launch_btn.BackColor = Color.FromArgb(53, 0, 211);
            launch_btn.FlatStyle = FlatStyle.Flat;
            launch_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            launch_btn.Location = new Point(650, 448);
            launch_btn.Name = "launch_btn";
            launch_btn.Size = new Size(138, 41);
            launch_btn.TabIndex = 0;
            launch_btn.Text = "Launch";
            launch_btn.UseVisualStyleBackColor = false;
            launch_btn.Click += launch_btn_Click;
            // 
            // priority_cmb
            // 
            priority_cmb.BackColor = Color.FromArgb(36, 0, 144);
            priority_cmb.DisplayMember = "0";
            priority_cmb.FlatStyle = FlatStyle.Popup;
            priority_cmb.ForeColor = Color.White;
            priority_cmb.FormattingEnabled = true;
            priority_cmb.Items.AddRange(new object[] { "Idle", "BelowNormal", "Normal", "AboveNormal", "High", "Realtime" });
            priority_cmb.Location = new Point(650, 12);
            priority_cmb.Name = "priority_cmb";
            priority_cmb.Size = new Size(138, 27);
            priority_cmb.TabIndex = 1;
            priority_cmb.Text = "Normal";
            priority_cmb.SelectedIndexChanged += priority_cmb_SelectedIndexChanged;
            // 
            // main_pnl
            // 
            main_pnl.BackColor = Color.FromArgb(36, 0, 144);
            main_pnl.Controls.Add(modmenu_pnl);
            main_pnl.Controls.Add(updateinfo_lbl);
            main_pnl.Controls.Add(inject_chb);
            main_pnl.Controls.Add(closegame_chb);
            main_pnl.Controls.Add(label1);
            main_pnl.Location = new Point(12, 12);
            main_pnl.Name = "main_pnl";
            main_pnl.Size = new Size(619, 477);
            main_pnl.TabIndex = 2;
            // 
            // modmenu_pnl
            // 
            modmenu_pnl.BackColor = Color.FromArgb(53, 0, 211);
            modmenu_pnl.Controls.Add(feature6_btn);
            modmenu_pnl.Controls.Add(feature5_btn);
            modmenu_pnl.Controls.Add(feature4_btn);
            modmenu_pnl.Controls.Add(feature3_btn);
            modmenu_pnl.Controls.Add(feature2_btn);
            modmenu_pnl.Controls.Add(feature1_btn);
            modmenu_pnl.Location = new Point(12, 92);
            modmenu_pnl.Name = "modmenu_pnl";
            modmenu_pnl.Size = new Size(309, 191);
            modmenu_pnl.TabIndex = 5;
            // 
            // feature6_btn
            // 
            feature6_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature6_btn.FlatStyle = FlatStyle.Flat;
            feature6_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature6_btn.Location = new Point(156, 128);
            feature6_btn.Name = "feature6_btn";
            feature6_btn.Size = new Size(138, 41);
            feature6_btn.TabIndex = 8;
            feature6_btn.Text = "Feature 6";
            feature6_btn.UseVisualStyleBackColor = false;
            // 
            // feature5_btn
            // 
            feature5_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature5_btn.FlatStyle = FlatStyle.Flat;
            feature5_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature5_btn.Location = new Point(156, 70);
            feature5_btn.Name = "feature5_btn";
            feature5_btn.Size = new Size(138, 41);
            feature5_btn.TabIndex = 7;
            feature5_btn.Text = "Feature 5";
            feature5_btn.UseVisualStyleBackColor = false;
            // 
            // feature4_btn
            // 
            feature4_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature4_btn.FlatStyle = FlatStyle.Flat;
            feature4_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature4_btn.Location = new Point(156, 11);
            feature4_btn.Name = "feature4_btn";
            feature4_btn.Size = new Size(138, 41);
            feature4_btn.TabIndex = 6;
            feature4_btn.Text = "Feature 4";
            feature4_btn.UseVisualStyleBackColor = false;
            // 
            // feature3_btn
            // 
            feature3_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature3_btn.FlatStyle = FlatStyle.Flat;
            feature3_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature3_btn.Location = new Point(12, 128);
            feature3_btn.Name = "feature3_btn";
            feature3_btn.Size = new Size(138, 41);
            feature3_btn.TabIndex = 5;
            feature3_btn.Text = "Feature 3";
            feature3_btn.UseVisualStyleBackColor = false;
            // 
            // feature2_btn
            // 
            feature2_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature2_btn.FlatStyle = FlatStyle.Flat;
            feature2_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature2_btn.Location = new Point(12, 70);
            feature2_btn.Name = "feature2_btn";
            feature2_btn.Size = new Size(138, 41);
            feature2_btn.TabIndex = 4;
            feature2_btn.Text = "Feature 2";
            feature2_btn.UseVisualStyleBackColor = false;
            feature2_btn.Click += feature2_btn_Click;
            // 
            // feature1_btn
            // 
            feature1_btn.BackColor = Color.FromArgb(53, 0, 211);
            feature1_btn.FlatStyle = FlatStyle.Flat;
            feature1_btn.Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            feature1_btn.Location = new Point(12, 11);
            feature1_btn.Name = "feature1_btn";
            feature1_btn.Size = new Size(138, 41);
            feature1_btn.TabIndex = 3;
            feature1_btn.Text = "Feature 1";
            feature1_btn.UseVisualStyleBackColor = false;
            feature1_btn.Click += feature1_btn_Click;
            // 
            // updateinfo_lbl
            // 
            updateinfo_lbl.AutoSize = true;
            updateinfo_lbl.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            updateinfo_lbl.Location = new Point(12, 311);
            updateinfo_lbl.Name = "updateinfo_lbl";
            updateinfo_lbl.Size = new Size(154, 24);
            updateinfo_lbl.TabIndex = 4;
            updateinfo_lbl.Text = "Update 1.0.0";
            // 
            // inject_chb
            // 
            inject_chb.AutoSize = true;
            inject_chb.Location = new Point(12, 48);
            inject_chb.Name = "inject_chb";
            inject_chb.Size = new Size(127, 23);
            inject_chb.TabIndex = 2;
            inject_chb.Text = "Inject game";
            inject_chb.UseVisualStyleBackColor = true;
            // 
            // closegame_chb
            // 
            closegame_chb.AutoSize = true;
            closegame_chb.Checked = true;
            closegame_chb.CheckState = CheckState.Checked;
            closegame_chb.Location = new Point(12, 19);
            closegame_chb.Name = "closegame_chb";
            closegame_chb.Size = new Size(280, 23);
            closegame_chb.TabIndex = 1;
            closegame_chb.Text = "Synchronized game completion";
            closegame_chb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 8.75F, FontStyle.Bold);
            label1.Location = new Point(12, 353);
            label1.Name = "label1";
            label1.Size = new Size(595, 112);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(25, 0, 97);
            ClientSize = new Size(800, 502);
            Controls.Add(main_pnl);
            Controls.Add(priority_cmb);
            Controls.Add(launch_btn);
            Font = new Font("Consolas", 11.75F, FontStyle.Bold);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 541);
            MinimumSize = new Size(816, 541);
            Name = "Main";
            Text = "Paradox Forge 1.0.0";
            FormClosing += Main_FormClosing;
            main_pnl.ResumeLayout(false);
            main_pnl.PerformLayout();
            modmenu_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button launch_btn;
        private ComboBox priority_cmb;
        private Panel main_pnl;
        private Label label1;
        private CheckBox closegame_chb;
        private CheckBox inject_chb;
        private Label updateinfo_lbl;
        private Panel modmenu_pnl;
        private Button feature6_btn;
        private Button feature5_btn;
        private Button feature4_btn;
        private Button feature3_btn;
        private Button feature2_btn;
        private Button feature1_btn;
    }
}
