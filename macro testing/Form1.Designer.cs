namespace macro_testing
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
            btnClickMacro = new Button();
            SuspendLayout();
            // 
            // btnClickMacro
            // 
            btnClickMacro.Location = new Point(57, 50);
            btnClickMacro.Name = "btnClickMacro";
            btnClickMacro.Size = new Size(94, 29);
            btnClickMacro.TabIndex = 0;
            btnClickMacro.Text = "button1";
            btnClickMacro.UseVisualStyleBackColor = true;
            btnClickMacro.Click += btnClickMacro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 114);
            Controls.Add(btnClickMacro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMacro;
    }
}
