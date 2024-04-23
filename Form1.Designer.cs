namespace PressureConverter
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
            label2 = new Label();
            label3 = new Label();
            textBoxkPa = new TextBox();
            textBoxpsi = new TextBox();
            textBoxbar = new TextBox();
            buttonLaske = new Button();
            buttonTyhjenna = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Paine kPa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Paine psi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 32);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Paine bar";
            // 
            // textBoxkPa
            // 
            textBoxkPa.Location = new Point(48, 72);
            textBoxkPa.Name = "textBoxkPa";
            textBoxkPa.Size = new Size(100, 23);
            textBoxkPa.TabIndex = 3;
            textBoxkPa.Leave += textBoxkPa_Leave;
            // 
            // textBoxpsi
            // 
            textBoxpsi.Location = new Point(192, 72);
            textBoxpsi.Name = "textBoxpsi";
            textBoxpsi.Size = new Size(100, 23);
            textBoxpsi.TabIndex = 4;
            // 
            // textBoxbar
            // 
            textBoxbar.Location = new Point(328, 72);
            textBoxbar.Name = "textBoxbar";
            textBoxbar.Size = new Size(100, 23);
            textBoxbar.TabIndex = 5;
            // 
            // buttonLaske
            // 
            buttonLaske.Enabled = false;
            buttonLaske.Location = new Point(192, 144);
            buttonLaske.Name = "buttonLaske";
            buttonLaske.Size = new Size(104, 23);
            buttonLaske.TabIndex = 6;
            buttonLaske.Text = "Laske";
            buttonLaske.UseVisualStyleBackColor = true;
            buttonLaske.Click += buttonLaske_Click;
            // 
            // buttonTyhjenna
            // 
            buttonTyhjenna.Location = new Point(192, 184);
            buttonTyhjenna.Name = "buttonTyhjenna";
            buttonTyhjenna.Size = new Size(104, 23);
            buttonTyhjenna.TabIndex = 7;
            buttonTyhjenna.Text = "Tyhjennä";
            buttonTyhjenna.UseVisualStyleBackColor = true;
            buttonTyhjenna.Click += buttonTyhjenna_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 266);
            Controls.Add(buttonTyhjenna);
            Controls.Add(buttonLaske);
            Controls.Add(textBoxbar);
            Controls.Add(textBoxpsi);
            Controls.Add(textBoxkPa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxkPa;
        private TextBox textBoxpsi;
        private TextBox textBoxbar;
        private Button buttonLaske;
        private Button buttonTyhjenna;
    }
}
