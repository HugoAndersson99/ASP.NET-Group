namespace Client_GruppForms
{
    partial class AdminPage
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
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 9);
            label2.Name = "label2";
            label2.Size = new Size(213, 28);
            label2.TabIndex = 1;
            label2.Text = "Welcome Admin";
            // 
            // panel1
            // 
            panel1.Location = new Point(56, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 281);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 44);
            button1.Name = "button1";
            button1.Size = new Size(85, 38);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 445);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button button1;
    }
}