namespace QiitaEditorApp.View
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
            StartButton = new MaterialSkin.Controls.MaterialButton();
            UserNamelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            UserNameLabel = new MaterialSkin.Controls.MaterialLabel();
            ApitokenLabel = new MaterialSkin.Controls.MaterialLabel();
            ApitokenTextBox = new MaterialSkin.Controls.MaterialTextBox();
            IsSaveCheckBox = new MaterialSkin.Controls.MaterialCheckbox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            StartButton.Depth = 0;
            StartButton.HighEmphasis = true;
            StartButton.Icon = null;
            StartButton.Location = new Point(478, 157);
            StartButton.Margin = new Padding(4, 6, 4, 6);
            StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            StartButton.Name = "StartButton";
            StartButton.NoAccentTextColor = Color.Empty;
            StartButton.Size = new Size(67, 36);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            StartButton.UseAccentColor = false;
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += startButton_Click;
            // 
            // UserNamelTextBox
            // 
            UserNamelTextBox.AnimateReadOnly = false;
            UserNamelTextBox.BorderStyle = BorderStyle.None;
            UserNamelTextBox.Depth = 0;
            UserNamelTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserNamelTextBox.LeadingIcon = null;
            UserNamelTextBox.Location = new Point(116, 34);
            UserNamelTextBox.MaxLength = 50;
            UserNamelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            UserNamelTextBox.Multiline = false;
            UserNamelTextBox.Name = "UserNamelTextBox";
            UserNamelTextBox.Size = new Size(429, 50);
            UserNamelTextBox.TabIndex = 2;
            UserNamelTextBox.Text = "";
            UserNamelTextBox.TrailingIcon = null;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Depth = 0;
            UserNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserNameLabel.Location = new Point(28, 48);
            UserNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(82, 19);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "UserName：";
            // 
            // ApitokenLabel
            // 
            ApitokenLabel.AutoSize = true;
            ApitokenLabel.Depth = 0;
            ApitokenLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ApitokenLabel.Location = new Point(30, 109);
            ApitokenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ApitokenLabel.Name = "ApitokenLabel";
            ApitokenLabel.Size = new Size(80, 19);
            ApitokenLabel.TabIndex = 5;
            ApitokenLabel.Text = "API Token：";
            // 
            // ApitokenTextBox
            // 
            ApitokenTextBox.AnimateReadOnly = false;
            ApitokenTextBox.BorderStyle = BorderStyle.None;
            ApitokenTextBox.Depth = 0;
            ApitokenTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ApitokenTextBox.LeadingIcon = null;
            ApitokenTextBox.Location = new Point(116, 96);
            ApitokenTextBox.MaxLength = 50;
            ApitokenTextBox.MouseState = MaterialSkin.MouseState.OUT;
            ApitokenTextBox.Multiline = false;
            ApitokenTextBox.Name = "ApitokenTextBox";
            ApitokenTextBox.Size = new Size(429, 50);
            ApitokenTextBox.TabIndex = 4;
            ApitokenTextBox.Text = "";
            ApitokenTextBox.TrailingIcon = null;
            // 
            // IsSaveCheckBox
            // 
            IsSaveCheckBox.AutoSize = true;
            IsSaveCheckBox.Depth = 0;
            IsSaveCheckBox.Location = new Point(116, 156);
            IsSaveCheckBox.Margin = new Padding(0);
            IsSaveCheckBox.MouseLocation = new Point(-1, -1);
            IsSaveCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            IsSaveCheckBox.Name = "IsSaveCheckBox";
            IsSaveCheckBox.ReadOnly = false;
            IsSaveCheckBox.Ripple = true;
            IsSaveCheckBox.Size = new Size(70, 37);
            IsSaveCheckBox.TabIndex = 6;
            IsSaveCheckBox.Text = "Save";
            IsSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(582, 232);
            Controls.Add(IsSaveCheckBox);
            Controls.Add(ApitokenLabel);
            Controls.Add(ApitokenTextBox);
            Controls.Add(UserNameLabel);
            Controls.Add(UserNamelTextBox);
            Controls.Add(StartButton);
            Font = new Font("游ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "StartView";
            Padding = new Padding(3, 68, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialTextBox UserNamelTextBox;
        private MaterialSkin.Controls.MaterialLabel UserNameLabel;
        private MaterialSkin.Controls.MaterialLabel ApitokenLabel;
        private MaterialSkin.Controls.MaterialTextBox ApitokenTextBox;
        private MaterialSkin.Controls.MaterialCheckbox IsSaveCheckBox;
    }
}