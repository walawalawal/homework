namespace CMSWinFormsApp
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            workerToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            jobDetailsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 194);
            label1.Name = "label1";
            label1.Size = new Size(595, 48);
            label1.TabIndex = 0;
            label1.Text = "Customer Maintenance Protect";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workerToolStripMenuItem, customerToolStripMenuItem, jobDetailsToolStripMenuItem, reportsToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            workerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            workerToolStripMenuItem.Size = new Size(77, 24);
            workerToolStripMenuItem.Text = "&Worker";
            workerToolStripMenuItem.Click += workerToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            customerToolStripMenuItem.Size = new Size(94, 24);
            customerToolStripMenuItem.Text = "&Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // jobDetailsToolStripMenuItem
            // 
            jobDetailsToolStripMenuItem.Name = "jobDetailsToolStripMenuItem";
            jobDetailsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.J;
            jobDetailsToolStripMenuItem.Size = new Size(102, 24);
            jobDetailsToolStripMenuItem.Text = "&Job Details";
            jobDetailsToolStripMenuItem.Click += jobDetailsToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
            reportsToolStripMenuItem.Size = new Size(81, 24);
            reportsToolStripMenuItem.Text = "&Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            exitToolStripMenuItem.Size = new Size(49, 24);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 490);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem workerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem jobDetailsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
