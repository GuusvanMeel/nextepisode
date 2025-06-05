namespace Next_Episode
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
            AllEpisodesView = new ListBox();
            BtChooseFilePath = new Button();
            BTvlcpath = new Button();
            BtPlayNextEp = new Button();
            BtChoosecurrentep = new Button();
            label1 = new Label();
            LblCurEp = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // AllEpisodesView
            // 
            AllEpisodesView.FormattingEnabled = true;
            AllEpisodesView.Location = new Point(29, 47);
            AllEpisodesView.Margin = new Padding(3, 4, 3, 4);
            AllEpisodesView.Name = "AllEpisodesView";
            AllEpisodesView.Size = new Size(305, 484);
            AllEpisodesView.TabIndex = 1;
            AllEpisodesView.MouseClick += AllEpisodesView_MouseClick;
            // 
            // BtChooseFilePath
            // 
            BtChooseFilePath.Location = new Point(672, 4);
            BtChooseFilePath.Margin = new Padding(3, 4, 3, 4);
            BtChooseFilePath.Name = "BtChooseFilePath";
            BtChooseFilePath.Size = new Size(136, 88);
            BtChooseFilePath.TabIndex = 2;
            BtChooseFilePath.Text = "Choosefilepath";
            BtChooseFilePath.UseVisualStyleBackColor = true;
            BtChooseFilePath.Click += BtChooseFilePath_Click;
            // 
            // BTvlcpath
            // 
            BTvlcpath.Location = new Point(457, 4);
            BTvlcpath.Margin = new Padding(3, 4, 3, 4);
            BTvlcpath.Name = "BTvlcpath";
            BTvlcpath.Size = new Size(127, 88);
            BTvlcpath.TabIndex = 3;
            BTvlcpath.Text = "Choose vlc exe";
            BTvlcpath.UseVisualStyleBackColor = true;
            BTvlcpath.Click += BTvlcpath_Click;
            // 
            // BtPlayNextEp
            // 
            BtPlayNextEp.Location = new Point(574, 286);
            BtPlayNextEp.Margin = new Padding(3, 4, 3, 4);
            BtPlayNextEp.Name = "BtPlayNextEp";
            BtPlayNextEp.Size = new Size(210, 116);
            BtPlayNextEp.TabIndex = 4;
            BtPlayNextEp.Text = "Play Current Episode";
            BtPlayNextEp.UseVisualStyleBackColor = true;
            BtPlayNextEp.Click += BtPlayNextEp_Click;
            // 
            // BtChoosecurrentep
            // 
            BtChoosecurrentep.Location = new Point(574, 212);
            BtChoosecurrentep.Margin = new Padding(3, 4, 3, 4);
            BtChoosecurrentep.Name = "BtChoosecurrentep";
            BtChoosecurrentep.Size = new Size(210, 42);
            BtChoosecurrentep.TabIndex = 5;
            BtChoosecurrentep.Text = "Choose current episode";
            BtChoosecurrentep.UseVisualStyleBackColor = true;
            BtChoosecurrentep.Click += BtChoosecurrentep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 512);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 7;
            label1.Text = "Current Episode is:";
            // 
            // LblCurEp
            // 
            LblCurEp.AutoSize = true;
            LblCurEp.Location = new Point(461, 512);
            LblCurEp.Name = "LblCurEp";
            LblCurEp.Size = new Size(0, 20);
            LblCurEp.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mkv", "mp4" });
            comboBox1.Location = new Point(461, 100);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(58, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "File Format:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(LblCurEp);
            Controls.Add(label1);
            Controls.Add(BtChoosecurrentep);
            Controls.Add(BtPlayNextEp);
            Controls.Add(BTvlcpath);
            Controls.Add(BtChooseFilePath);
            Controls.Add(AllEpisodesView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox AllEpisodesView;
        private Button BtChooseFilePath;
        private Button BTvlcpath;
        private Button BtPlayNextEp;
        private Button BtChoosecurrentep;
        private Label label1;
        private Label LblCurEp;
        private ComboBox comboBox1;
        private Label label2;
    }
}
