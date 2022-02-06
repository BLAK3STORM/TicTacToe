namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pvPModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pvEModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.xWin = new System.Windows.Forms.Label();
            this.drwCount = new System.Windows.Forms.Label();
            this.oWin = new System.Windows.Forms.Label();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameButton,
            this.pvPModeToolStripMenuItem,
            this.pvEModeToolStripMenuItem,
            this.resetCountersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.fileToolStripMenuItem.Text = "Game";
            // 
            // newGameButton
            // 
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameButton.Size = new System.Drawing.Size(246, 26);
            this.newGameButton.Text = "New Game";
            this.newGameButton.Click += new System.EventHandler(this.newGame_Click);
            // 
            // pvPModeToolStripMenuItem
            // 
            this.pvPModeToolStripMenuItem.Name = "pvPModeToolStripMenuItem";
            this.pvPModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pvPModeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.pvPModeToolStripMenuItem.Text = "PvP Mode";
            this.pvPModeToolStripMenuItem.Click += new System.EventHandler(this.pvpMode_Click);
            // 
            // pvEModeToolStripMenuItem
            // 
            this.pvEModeToolStripMenuItem.Name = "pvEModeToolStripMenuItem";
            this.pvEModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.pvEModeToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.pvEModeToolStripMenuItem.Text = "PvE Mode";
            this.pvEModeToolStripMenuItem.Click += new System.EventHandler(this.pveMode_click);
            // 
            // resetCountersToolStripMenuItem
            // 
            this.resetCountersToolStripMenuItem.Name = "resetCountersToolStripMenuItem";
            this.resetCountersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetCountersToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.resetCountersToolStripMenuItem.Text = "Reset Counters";
            this.resetCountersToolStripMenuItem.Click += new System.EventHandler(this.resetCounters_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn11.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn11.Location = new System.Drawing.Point(12, 40);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(150, 150);
            this.btn11.TabIndex = 1;
            this.btn11.TabStop = false;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.button_click);
            this.btn11.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn11.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn13.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn13.Location = new System.Drawing.Point(324, 40);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(150, 150);
            this.btn13.TabIndex = 2;
            this.btn13.TabStop = false;
            this.btn13.UseVisualStyleBackColor = false;
            this.btn13.Click += new System.EventHandler(this.button_click);
            this.btn13.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn13.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn12.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn12.Location = new System.Drawing.Point(168, 40);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(150, 150);
            this.btn12.TabIndex = 3;
            this.btn12.TabStop = false;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.button_click);
            this.btn12.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn12.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn21.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn21.Location = new System.Drawing.Point(12, 196);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(150, 150);
            this.btn21.TabIndex = 1;
            this.btn21.TabStop = false;
            this.btn21.UseVisualStyleBackColor = false;
            this.btn21.Click += new System.EventHandler(this.button_click);
            this.btn21.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn21.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn23
            // 
            this.btn23.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn23.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn23.Location = new System.Drawing.Point(324, 196);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(150, 150);
            this.btn23.TabIndex = 2;
            this.btn23.TabStop = false;
            this.btn23.UseVisualStyleBackColor = false;
            this.btn23.Click += new System.EventHandler(this.button_click);
            this.btn23.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn23.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn22.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn22.Location = new System.Drawing.Point(168, 196);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(150, 150);
            this.btn22.TabIndex = 3;
            this.btn22.TabStop = false;
            this.btn22.UseVisualStyleBackColor = false;
            this.btn22.Click += new System.EventHandler(this.button_click);
            this.btn22.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn22.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn31
            // 
            this.btn31.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn31.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn31.Location = new System.Drawing.Point(12, 352);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(150, 150);
            this.btn31.TabIndex = 1;
            this.btn31.TabStop = false;
            this.btn31.UseVisualStyleBackColor = false;
            this.btn31.Click += new System.EventHandler(this.button_click);
            this.btn31.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn31.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn33
            // 
            this.btn33.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn33.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn33.Location = new System.Drawing.Point(324, 352);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(150, 150);
            this.btn33.TabIndex = 2;
            this.btn33.TabStop = false;
            this.btn33.UseVisualStyleBackColor = false;
            this.btn33.Click += new System.EventHandler(this.button_click);
            this.btn33.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn33.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // btn32
            // 
            this.btn32.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn32.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn32.Location = new System.Drawing.Point(168, 352);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(150, 150);
            this.btn32.TabIndex = 3;
            this.btn32.TabStop = false;
            this.btn32.UseVisualStyleBackColor = false;
            this.btn32.Click += new System.EventHandler(this.button_click);
            this.btn32.MouseEnter += new System.EventHandler(this.btn_enter);
            this.btn32.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // player1Label
            // 
            this.player1Label.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(12, 519);
            this.player1Label.MaximumSize = new System.Drawing.Size(150, 23);
            this.player1Label.MinimumSize = new System.Drawing.Size(150, 23);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(150, 23);
            this.player1Label.TabIndex = 4;
            this.player1Label.Text = "X Win Count";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Draw Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Label
            // 
            this.player2Label.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(321, 519);
            this.player2Label.MaximumSize = new System.Drawing.Size(150, 23);
            this.player2Label.MinimumSize = new System.Drawing.Size(150, 23);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(150, 23);
            this.player2Label.TabIndex = 4;
            this.player2Label.Text = "O Win Count";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xWin
            // 
            this.xWin.BackColor = System.Drawing.SystemColors.MenuText;
            this.xWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xWin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWin.ForeColor = System.Drawing.Color.Lime;
            this.xWin.Location = new System.Drawing.Point(63, 547);
            this.xWin.Margin = new System.Windows.Forms.Padding(3);
            this.xWin.Name = "xWin";
            this.xWin.Size = new System.Drawing.Size(43, 43);
            this.xWin.TabIndex = 5;
            this.xWin.Text = "0";
            this.xWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drwCount
            // 
            this.drwCount.BackColor = System.Drawing.SystemColors.MenuText;
            this.drwCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drwCount.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drwCount.ForeColor = System.Drawing.Color.Lime;
            this.drwCount.Location = new System.Drawing.Point(220, 547);
            this.drwCount.Margin = new System.Windows.Forms.Padding(3);
            this.drwCount.Name = "drwCount";
            this.drwCount.Size = new System.Drawing.Size(43, 43);
            this.drwCount.TabIndex = 5;
            this.drwCount.Text = "0";
            this.drwCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oWin
            // 
            this.oWin.BackColor = System.Drawing.SystemColors.MenuText;
            this.oWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oWin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWin.ForeColor = System.Drawing.Color.Lime;
            this.oWin.Location = new System.Drawing.Point(378, 547);
            this.oWin.Margin = new System.Windows.Forms.Padding(3);
            this.oWin.Name = "oWin";
            this.oWin.Size = new System.Drawing.Size(43, 43);
            this.oWin.TabIndex = 5;
            this.oWin.Text = "0";
            this.oWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manual_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(484, 607);
            this.Controls.Add(this.oWin);
            this.Controls.Add(this.drwCount);
            this.Controls.Add(this.xWin);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label xWin;
        private System.Windows.Forms.Label drwCount;
        private System.Windows.Forms.Label oWin;
        private System.Windows.Forms.ToolStripMenuItem resetCountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pvPModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pvEModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
    }
}

