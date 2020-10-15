using MetroFramework.Forms;

namespace Calculator_GUI
{
    partial class Form1 : MetroForm
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
            this.txtNumOne = new MetroFramework.Controls.MetroTextBox();
            this.txtNumTwo = new MetroFramework.Controls.MetroTextBox();
            this.txtRes = new MetroFramework.Controls.MetroTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMulti = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSub = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSign = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(47, 158);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.Size = new System.Drawing.Size(111, 23);
            this.txtNumOne.TabIndex = 0;
            this.txtNumOne.TextChanged += new System.EventHandler(this.txtNumOne_TextChanged);
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(202, 158);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.Size = new System.Drawing.Size(111, 23);
            this.txtNumTwo.TabIndex = 0;
            this.txtNumTwo.TextChanged += new System.EventHandler(this.txtNumTwo_TextChanged);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(378, 158);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(111, 23);
            this.txtRes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectModeToolStripMenuItem
            // 
            this.selectModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMulti,
            this.mnuDiv,
            this.mnuAdd,
            this.mnuSub});
            this.selectModeToolStripMenuItem.Name = "selectModeToolStripMenuItem";
            this.selectModeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.selectModeToolStripMenuItem.Text = "Select Mode";
            // 
            // mnuMulti
            // 
            this.mnuMulti.Name = "mnuMulti";
            this.mnuMulti.Size = new System.Drawing.Size(148, 22);
            this.mnuMulti.Text = "Multiplication";
            this.mnuMulti.Click += new System.EventHandler(this.mnuMulti_Click);
            // 
            // mnuDiv
            // 
            this.mnuDiv.Name = "mnuDiv";
            this.mnuDiv.Size = new System.Drawing.Size(148, 22);
            this.mnuDiv.Text = "Division";
            this.mnuDiv.Click += new System.EventHandler(this.mnuDiv_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(148, 22);
            this.mnuAdd.Text = "Addition";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuSub
            // 
            this.mnuSub.Name = "mnuSub";
            this.mnuSub.Size = new System.Drawing.Size(148, 22);
            this.mnuSub.Text = "Subtraction";
            this.mnuSub.Click += new System.EventHandler(this.mnuSub_Click);
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(173, 161);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(15, 19);
            this.lblSign.TabIndex = 2;
            this.lblSign.Text = "x";
            this.lblSign.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 282);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumOne);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Calculator - rondDev";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNumOne;
        private MetroFramework.Controls.MetroTextBox txtNumTwo;
        private MetroFramework.Controls.MetroTextBox txtRes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMulti;
        private System.Windows.Forms.ToolStripMenuItem mnuDiv;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuSub;
        private MetroFramework.Controls.MetroLabel lblSign;
    }
}