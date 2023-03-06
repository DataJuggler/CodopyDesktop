namespace CodopyDesktop
{
    partial class MainForm
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
            SourceControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            ResultsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            FormatButton = new DataJuggler.Win.Controls.Button();
            CopyButton = new DataJuggler.Win.Controls.Button();
            SuspendLayout();
            // 
            // SourceControl
            // 
            SourceControl.BackColor = Color.Transparent;
            SourceControl.BottomMargin = 0;
            SourceControl.Editable = true;
            SourceControl.Encrypted = false;
            SourceControl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SourceControl.Inititialized = true;
            SourceControl.LabelBottomMargin = 0;
            SourceControl.LabelColor = Color.LemonChiffon;
            SourceControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SourceControl.LabelText = "Source:";
            SourceControl.LabelTopMargin = 0;
            SourceControl.LabelWidth = 120;
            SourceControl.Location = new Point(58, 22);
            SourceControl.MultiLine = true;
            SourceControl.Name = "SourceControl";
            SourceControl.OnTextChangedListener = null;
            SourceControl.PasswordMode = false;
            SourceControl.ScrollBars = ScrollBars.None;
            SourceControl.Size = new Size(1277, 300);
            SourceControl.TabIndex = 0;
            SourceControl.TextBoxBottomMargin = 0;
            SourceControl.TextBoxDisabledColor = Color.LightGray;
            SourceControl.TextBoxEditableColor = Color.White;
            SourceControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SourceControl.TextBoxTopMargin = 0;
            SourceControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ResultsControl
            // 
            ResultsControl.BackColor = Color.Transparent;
            ResultsControl.BottomMargin = 0;
            ResultsControl.Editable = true;
            ResultsControl.Encrypted = false;
            ResultsControl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResultsControl.Inititialized = true;
            ResultsControl.LabelBottomMargin = 0;
            ResultsControl.LabelColor = Color.LemonChiffon;
            ResultsControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResultsControl.LabelText = "Source:";
            ResultsControl.LabelTopMargin = 0;
            ResultsControl.LabelWidth = 120;
            ResultsControl.Location = new Point(58, 352);
            ResultsControl.MultiLine = true;
            ResultsControl.Name = "ResultsControl";
            ResultsControl.OnTextChangedListener = null;
            ResultsControl.PasswordMode = false;
            ResultsControl.ScrollBars = ScrollBars.None;
            ResultsControl.Size = new Size(1277, 300);
            ResultsControl.TabIndex = 1;
            ResultsControl.TextBoxBottomMargin = 0;
            ResultsControl.TextBoxDisabledColor = Color.LightGray;
            ResultsControl.TextBoxEditableColor = Color.White;
            ResultsControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResultsControl.TextBoxTopMargin = 0;
            ResultsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FormatButton
            // 
            FormatButton.BackColor = Color.Transparent;
            FormatButton.ButtonText = "Format";
            FormatButton.FlatStyle = FlatStyle.Flat;
            FormatButton.ForeColor = Color.LemonChiffon;
            FormatButton.Location = new Point(1358, 28);
            FormatButton.Name = "FormatButton";
            FormatButton.Size = new Size(120, 44);
            FormatButton.TabIndex = 2;
            FormatButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            FormatButton.Click += FormatButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.Transparent;
            CopyButton.ButtonText = "Copy";
            CopyButton.FlatStyle = FlatStyle.Flat;
            CopyButton.ForeColor = Color.LemonChiffon;
            CopyButton.Location = new Point(1358, 352);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(120, 44);
            CopyButton.TabIndex = 3;
            CopyButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            CopyButton.Click += CopyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1517, 725);
            Controls.Add(CopyButton);
            Controls.Add(FormatButton);
            Controls.Add(ResultsControl);
            Controls.Add(SourceControl);
            DoubleBuffered = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codopy Desktop";
            ResumeLayout(false);
        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxControl SourceControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl ResultsControl;
        private DataJuggler.Win.Controls.Button FormatButton;
        private DataJuggler.Win.Controls.Button CopyButton;
    }
}