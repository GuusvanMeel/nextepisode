namespace Next_Episode
{
    partial class Form2
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
            RemainingEplist = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // RemainingEplist
            // 
            RemainingEplist.FormattingEnabled = true;
            RemainingEplist.ItemHeight = 25;
            RemainingEplist.Location = new Point(123, 55);
            RemainingEplist.Margin = new Padding(4, 5, 4, 5);
            RemainingEplist.Name = "RemainingEplist";
            RemainingEplist.Size = new Size(428, 579);
            RemainingEplist.TabIndex = 0;
            RemainingEplist.MouseDoubleClick += RemainingEplist_MouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(561, 55);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(566, 581);
            button1.TabIndex = 1;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(RemainingEplist);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox RemainingEplist;
        private Button button1;
    }
}