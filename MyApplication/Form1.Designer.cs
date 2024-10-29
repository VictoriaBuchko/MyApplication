namespace MyApplication
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
            buttonClick = new Button();
            ModalWindowButton = new Button();
            NoModalWindowButton = new Button();
            SuspendLayout();
            // 
            // buttonClick
            // 
            buttonClick.BackColor = SystemColors.MenuHighlight;
            buttonClick.Location = new Point(124, 45);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(134, 66);
            buttonClick.TabIndex = 0;
            buttonClick.Text = "Показати повідомлення";
            buttonClick.UseVisualStyleBackColor = false;
            buttonClick.Click += buttonClick_Click;
            // 
            // ModalWindowButton
            // 
            ModalWindowButton.Location = new Point(56, 181);
            ModalWindowButton.Name = "ModalWindowButton";
            ModalWindowButton.Size = new Size(103, 59);
            ModalWindowButton.TabIndex = 1;
            ModalWindowButton.Text = "Модальне вікно";
            ModalWindowButton.UseVisualStyleBackColor = true;
            // 
            // NoModalWindowButton
            // 
            NoModalWindowButton.Location = new Point(219, 179);
            NoModalWindowButton.Name = "NoModalWindowButton";
            NoModalWindowButton.Size = new Size(117, 61);
            NoModalWindowButton.TabIndex = 2;
            NoModalWindowButton.Text = "Не модальне вікно";
            NoModalWindowButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(382, 253);
            Controls.Add(NoModalWindowButton);
            Controls.Add(ModalWindowButton);
            Controls.Add(buttonClick);
            Name = "Form1";
            Text = "My Application";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClick;
        private Button ModalWindowButton;
        private Button NoModalWindowButton;
    }
}
