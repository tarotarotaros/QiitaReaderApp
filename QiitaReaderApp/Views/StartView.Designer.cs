using System.Drawing;
using System.Windows.Forms;

namespace QiitaReaderApp.View
{
    partial class StartView
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
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.UserNamelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.UserNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ApitokenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ApitokenTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.IsSaveSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.SpacePanel = new System.Windows.Forms.Panel();
            this.SpacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(466, 131);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartButton.Size = new System.Drawing.Size(67, 36);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // UserNamelTextBox
            // 
            this.UserNamelTextBox.AnimateReadOnly = false;
            this.UserNamelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNamelTextBox.Depth = 0;
            this.UserNamelTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserNamelTextBox.LeadingIcon = null;
            this.UserNamelTextBox.Location = new System.Drawing.Point(104, 8);
            this.UserNamelTextBox.MaxLength = 50;
            this.UserNamelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UserNamelTextBox.Multiline = false;
            this.UserNamelTextBox.Name = "UserNamelTextBox";
            this.UserNamelTextBox.Size = new System.Drawing.Size(429, 50);
            this.UserNamelTextBox.TabIndex = 2;
            this.UserNamelTextBox.Text = "";
            this.UserNamelTextBox.TrailingIcon = null;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameLabel.Depth = 0;
            this.UserNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserNameLabel.Location = new System.Drawing.Point(16, 22);
            this.UserNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 19);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "UserName：";
            // 
            // ApitokenLabel
            // 
            this.ApitokenLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ApitokenLabel.Depth = 0;
            this.ApitokenLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ApitokenLabel.Location = new System.Drawing.Point(18, 85);
            this.ApitokenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApitokenLabel.Name = "ApitokenLabel";
            this.ApitokenLabel.Size = new System.Drawing.Size(80, 19);
            this.ApitokenLabel.TabIndex = 3;
            this.ApitokenLabel.Text = "API Token：";
            // 
            // ApitokenTextBox
            // 
            this.ApitokenTextBox.AnimateReadOnly = false;
            this.ApitokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApitokenTextBox.Depth = 0;
            this.ApitokenTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ApitokenTextBox.LeadingIcon = null;
            this.ApitokenTextBox.Location = new System.Drawing.Point(104, 70);
            this.ApitokenTextBox.MaxLength = 50;
            this.ApitokenTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ApitokenTextBox.Multiline = false;
            this.ApitokenTextBox.Name = "ApitokenTextBox";
            this.ApitokenTextBox.Size = new System.Drawing.Size(429, 50);
            this.ApitokenTextBox.TabIndex = 4;
            this.ApitokenTextBox.Text = "";
            this.ApitokenTextBox.TrailingIcon = null;
            // 
            // IsSaveSwitch
            // 
            this.IsSaveSwitch.AutoSize = true;
            this.IsSaveSwitch.BackColor = System.Drawing.SystemColors.Window;
            this.IsSaveSwitch.Depth = 0;
            this.IsSaveSwitch.Location = new System.Drawing.Point(104, 132);
            this.IsSaveSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.IsSaveSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSaveSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSaveSwitch.Name = "IsSaveSwitch";
            this.IsSaveSwitch.Ripple = true;
            this.IsSaveSwitch.Size = new System.Drawing.Size(93, 37);
            this.IsSaveSwitch.TabIndex = 5;
            this.IsSaveSwitch.Text = "Save";
            this.IsSaveSwitch.UseVisualStyleBackColor = false;
            // 
            // SpacePanel
            // 
            this.SpacePanel.BackColor = System.Drawing.Color.Transparent;
            this.SpacePanel.Controls.Add(this.UserNameLabel);
            this.SpacePanel.Controls.Add(this.IsSaveSwitch);
            this.SpacePanel.Controls.Add(this.StartButton);
            this.SpacePanel.Controls.Add(this.ApitokenLabel);
            this.SpacePanel.Controls.Add(this.UserNamelTextBox);
            this.SpacePanel.Controls.Add(this.ApitokenTextBox);
            this.SpacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpacePanel.Location = new System.Drawing.Point(3, 68);
            this.SpacePanel.Name = "SpacePanel";
            this.SpacePanel.Size = new System.Drawing.Size(541, 152);
            this.SpacePanel.TabIndex = 0;
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 223);
            this.Controls.Add(this.SpacePanel);
            this.Font = new System.Drawing.Font("游ゴシック", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StartView";
            this.Padding = new System.Windows.Forms.Padding(3, 68, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SpacePanel.ResumeLayout(false);
            this.SpacePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialTextBox UserNamelTextBox;
        private MaterialSkin.Controls.MaterialLabel UserNameLabel;
        private MaterialSkin.Controls.MaterialLabel ApitokenLabel;
        private MaterialSkin.Controls.MaterialTextBox ApitokenTextBox;
        private MaterialSkin.Controls.MaterialSwitch IsSaveSwitch;
        private Panel SpacePanel;
    }
}