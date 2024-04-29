namespace Client_GruppForms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            userLabel = new Label();
            userPanel = new Panel();
            adminPanel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            moviesListBox = new ListBox();
            panel2 = new Panel();
            label2 = new Label();
            seriesListBox = new ListBox();
            mediaPanel = new Panel();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            label3 = new Label();
            addToLibraryButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            userPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            mediaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(359, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(18, 30);
            userLabel.TabIndex = 0;
            userLabel.Text = ".";
            // 
            // userPanel
            // 
            userPanel.Controls.Add(mediaPanel);
            userPanel.Controls.Add(panel2);
            userPanel.Controls.Add(panel1);
            userPanel.Controls.Add(userLabel);
            userPanel.Location = new Point(12, 12);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(776, 426);
            userPanel.TabIndex = 1;
            userPanel.Visible = false;
            // 
            // adminPanel
            // 
            adminPanel.Location = new Point(12, 12);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(776, 426);
            adminPanel.TabIndex = 2;
            adminPanel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(moviesListBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 213);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 6);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 0;
            label1.Text = "Movies";
            // 
            // moviesListBox
            // 
            moviesListBox.FormattingEnabled = true;
            moviesListBox.ItemHeight = 15;
            moviesListBox.Location = new Point(3, 36);
            moviesListBox.Name = "moviesListBox";
            moviesListBox.Size = new Size(138, 169);
            moviesListBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(seriesListBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 201);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 4);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 1;
            label2.Text = "Series";
            // 
            // seriesListBox
            // 
            seriesListBox.FormattingEnabled = true;
            seriesListBox.ItemHeight = 15;
            seriesListBox.Location = new Point(3, 29);
            seriesListBox.Name = "seriesListBox";
            seriesListBox.Size = new Size(138, 169);
            seriesListBox.TabIndex = 2;
            // 
            // mediaPanel
            // 
            mediaPanel.Controls.Add(label6);
            mediaPanel.Controls.Add(label5);
            mediaPanel.Controls.Add(label4);
            mediaPanel.Controls.Add(addToLibraryButton);
            mediaPanel.Controls.Add(label3);
            mediaPanel.Controls.Add(titleLabel);
            mediaPanel.Controls.Add(pictureBox1);
            mediaPanel.Location = new Point(198, 39);
            mediaPanel.Name = "mediaPanel";
            mediaPanel.Size = new Size(363, 351);
            mediaPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(152, 156);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(56, 22);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(250, 50);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // addToLibraryButton
            // 
            addToLibraryButton.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToLibraryButton.Location = new Point(237, 312);
            addToLibraryButton.Name = "addToLibraryButton";
            addToLibraryButton.Size = new Size(123, 36);
            addToLibraryButton.TabIndex = 3;
            addToLibraryButton.Text = "Add To Library";
            addToLibraryButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 243);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 4;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 243);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 5;
            label5.Text = "Release Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 312);
            label6.Name = "label6";
            label6.Size = new Size(156, 19);
            label6.TabIndex = 6;
            label6.Text = "Length(Minutes): ";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userPanel);
            Controls.Add(adminPanel);
            Name = "MainPage";
            Text = "MainPage";
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mediaPanel.ResumeLayout(false);
            mediaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label userLabel;
        private Panel userPanel;
        private Panel adminPanel;
        private Panel panel1;
        private Label label1;
        private Panel mediaPanel;
        private Panel panel2;
        private ListBox seriesListBox;
        private Label label2;
        private ListBox moviesListBox;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button addToLibraryButton;
    }
}