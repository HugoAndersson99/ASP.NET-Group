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
            goToLibraryButton = new Button();
            mediaPanel = new Panel();
            lengthTextLabel = new Label();
            yearTextLabel = new Label();
            genreTextLabel = new Label();
            changeLengthLabel = new Label();
            label5 = new Label();
            changeGenreLabel = new Label();
            addToLibraryButton = new Button();
            descriptionLabel = new Label();
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            seriesListBox = new ListBox();
            label2 = new Label();
            panel1 = new Panel();
            moviesListBox = new ListBox();
            label1 = new Label();
            adminPanel = new Panel();
            userPanel.SuspendLayout();
            mediaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            userPanel.Controls.Add(goToLibraryButton);
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
            // goToLibraryButton
            // 
            goToLibraryButton.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goToLibraryButton.Location = new Point(650, 384);
            goToLibraryButton.Name = "goToLibraryButton";
            goToLibraryButton.Size = new Size(123, 36);
            goToLibraryButton.TabIndex = 7;
            goToLibraryButton.Text = "My Library";
            goToLibraryButton.UseVisualStyleBackColor = true;
            goToLibraryButton.Click += goToLibraryButton_Click;
            // 
            // mediaPanel
            // 
            mediaPanel.Controls.Add(lengthTextLabel);
            mediaPanel.Controls.Add(yearTextLabel);
            mediaPanel.Controls.Add(genreTextLabel);
            mediaPanel.Controls.Add(changeLengthLabel);
            mediaPanel.Controls.Add(label5);
            mediaPanel.Controls.Add(changeGenreLabel);
            mediaPanel.Controls.Add(addToLibraryButton);
            mediaPanel.Controls.Add(descriptionLabel);
            mediaPanel.Controls.Add(titleLabel);
            mediaPanel.Controls.Add(pictureBox1);
            mediaPanel.Location = new Point(198, 39);
            mediaPanel.Name = "mediaPanel";
            mediaPanel.Size = new Size(363, 351);
            mediaPanel.TabIndex = 3;
            mediaPanel.Visible = false;
            // 
            // lengthTextLabel
            // 
            lengthTextLabel.AutoSize = true;
            lengthTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            lengthTextLabel.Location = new Point(152, 312);
            lengthTextLabel.Name = "lengthTextLabel";
            lengthTextLabel.Size = new Size(58, 19);
            lengthTextLabel.TabIndex = 9;
            lengthTextLabel.Text = "label7";
            // 
            // yearTextLabel
            // 
            yearTextLabel.AutoSize = true;
            yearTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            yearTextLabel.Location = new Point(237, 271);
            yearTextLabel.Name = "yearTextLabel";
            yearTextLabel.Size = new Size(58, 19);
            yearTextLabel.TabIndex = 8;
            yearTextLabel.Text = "label7";
            // 
            // genreTextLabel
            // 
            genreTextLabel.AutoSize = true;
            genreTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            genreTextLabel.Location = new Point(53, 271);
            genreTextLabel.Name = "genreTextLabel";
            genreTextLabel.Size = new Size(58, 19);
            genreTextLabel.TabIndex = 7;
            genreTextLabel.Text = "label7";
            // 
            // changeLengthLabel
            // 
            changeLengthLabel.AutoSize = true;
            changeLengthLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeLengthLabel.Location = new Point(3, 312);
            changeLengthLabel.Name = "changeLengthLabel";
            changeLengthLabel.Size = new Size(156, 19);
            changeLengthLabel.TabIndex = 6;
            changeLengthLabel.Text = "Length(Minutes): ";
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
            // changeGenreLabel
            // 
            changeGenreLabel.AutoSize = true;
            changeGenreLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeGenreLabel.Location = new Point(53, 243);
            changeGenreLabel.Name = "changeGenreLabel";
            changeGenreLabel.Size = new Size(58, 19);
            changeGenreLabel.TabIndex = 4;
            changeGenreLabel.Text = "Genre";
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
            addToLibraryButton.Click += addToLibraryButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoEllipsis = true;
            descriptionLabel.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(53, 183);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.RightToLeft = RightToLeft.Yes;
            descriptionLabel.Size = new Size(250, 50);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            descriptionLabel.TextAlign = ContentAlignment.TopCenter;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(seriesListBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 201);
            panel2.TabIndex = 2;
            // 
            // seriesListBox
            // 
            seriesListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            seriesListBox.FormattingEnabled = true;
            seriesListBox.Location = new Point(3, 29);
            seriesListBox.Name = "seriesListBox";
            seriesListBox.Size = new Size(138, 164);
            seriesListBox.TabIndex = 2;
            seriesListBox.SelectedIndexChanged += seriesListBox_SelectedIndexChanged;
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
            // panel1
            // 
            panel1.Controls.Add(moviesListBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 213);
            panel1.TabIndex = 1;
            // 
            // moviesListBox
            // 
            moviesListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moviesListBox.FormattingEnabled = true;
            moviesListBox.Location = new Point(3, 36);
            moviesListBox.Name = "moviesListBox";
            moviesListBox.Size = new Size(138, 164);
            moviesListBox.TabIndex = 1;
            moviesListBox.SelectedIndexChanged += moviesListBox_SelectedIndexChanged;
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
            // adminPanel
            // 
            adminPanel.Location = new Point(12, 12);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(776, 426);
            adminPanel.TabIndex = 2;
            adminPanel.Visible = false;
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
            mediaPanel.ResumeLayout(false);
            mediaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label descriptionLabel;
        private Label changeLengthLabel;
        private Label label5;
        private Label changeGenreLabel;
        private Button addToLibraryButton;
        private Button goToLibraryButton;
        private Label genreTextLabel;
        private Label lengthTextLabel;
        private Label yearTextLabel;
    }
}