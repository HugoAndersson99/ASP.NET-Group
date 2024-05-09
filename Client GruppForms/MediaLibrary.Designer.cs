namespace Client_GruppForms
{
    partial class MediaLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaLibrary));
            moviesLibraryListBox = new ListBox();
            seriesLibraryListBox = new ListBox();
            moviesLabel = new Label();
            seriesLabel = new Label();
            LibraryText = new Label();
            pictureBox = new PictureBox();
            SignOutButton = new Button();
            changeGenreLabel = new Label();
            yearLabel = new Label();
            descriptionText = new Label();
            backButton = new Button();
            descriptionLabel = new Label();
            yearText = new Label();
            titleLabel = new Label();
            changeLengthLabel = new Label();
            userLabel = new Label();
            genreText = new Label();
            lengthText = new Label();
            removeFromLibraryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // moviesLibraryListBox
            // 
            moviesLibraryListBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            moviesLibraryListBox.FormattingEnabled = true;
            moviesLibraryListBox.Location = new Point(21, 46);
            moviesLibraryListBox.Name = "moviesLibraryListBox";
            moviesLibraryListBox.Size = new Size(138, 164);
            moviesLibraryListBox.TabIndex = 2;
            moviesLibraryListBox.SelectedIndexChanged += moviesLibraryListBox_SelectedIndexChanged_1;
            // 
            // seriesLibraryListBox
            // 
            seriesLibraryListBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            seriesLibraryListBox.FormattingEnabled = true;
            seriesLibraryListBox.Location = new Point(21, 260);
            seriesLibraryListBox.Name = "seriesLibraryListBox";
            seriesLibraryListBox.Size = new Size(138, 164);
            seriesLibraryListBox.TabIndex = 3;
            seriesLibraryListBox.SelectedIndexChanged += seriesLibraryListBox_SelectedIndexChanged_1;
            // 
            // moviesLabel
            // 
            moviesLabel.AutoSize = true;
            moviesLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moviesLabel.Location = new Point(50, 21);
            moviesLabel.Name = "moviesLabel";
            moviesLabel.Size = new Size(76, 24);
            moviesLabel.TabIndex = 4;
            moviesLabel.Text = "Movies";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seriesLabel.Location = new Point(50, 235);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new Size(69, 24);
            seriesLabel.TabIndex = 5;
            seriesLabel.Text = "Series";
            // 
            // LibraryText
            // 
            LibraryText.AutoSize = true;
            LibraryText.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LibraryText.Location = new Point(165, 9);
            LibraryText.Name = "LibraryText";
            LibraryText.Size = new Size(190, 31);
            LibraryText.TabIndex = 6;
            LibraryText.Text = "Media Library";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(265, 44);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(208, 157);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // SignOutButton
            // 
            SignOutButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOutButton.Location = new Point(681, 23);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(90, 25);
            SignOutButton.TabIndex = 9;
            SignOutButton.Text = "Sign Out";
            SignOutButton.UseVisualStyleBackColor = true;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // changeGenreLabel
            // 
            changeGenreLabel.AutoSize = true;
            changeGenreLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeGenreLabel.Location = new Point(206, 336);
            changeGenreLabel.Name = "changeGenreLabel";
            changeGenreLabel.Size = new Size(59, 20);
            changeGenreLabel.TabIndex = 11;
            changeGenreLabel.Text = "Genre";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            yearLabel.Location = new Point(411, 336);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(118, 20);
            yearLabel.TabIndex = 12;
            yearLabel.Text = "Release Year";
            // 
            // descriptionText
            // 
            descriptionText.AutoEllipsis = true;
            descriptionText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionText.Location = new Point(206, 255);
            descriptionText.Name = "descriptionText";
            descriptionText.RightToLeft = RightToLeft.No;
            descriptionText.Size = new Size(329, 81);
            descriptionText.TabIndex = 15;
            descriptionText.Text = resources.GetString("descriptionText.Text");
            descriptionText.TextAlign = ContentAlignment.TopCenter;
            descriptionText.Visible = false;
            // 
            // backButton
            // 
            backButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            backButton.Location = new Point(681, 56);
            backButton.Name = "backButton";
            backButton.Size = new Size(90, 23);
            backButton.TabIndex = 19;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoEllipsis = true;
            descriptionLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(250, 229);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.RightToLeft = RightToLeft.No;
            descriptionLabel.Size = new Size(223, 26);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // yearText
            // 
            yearText.AutoEllipsis = true;
            yearText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearText.Location = new Point(405, 363);
            yearText.Name = "yearText";
            yearText.RightToLeft = RightToLeft.No;
            yearText.Size = new Size(123, 27);
            yearText.TabIndex = 21;
            yearText.Text = "Year";
            yearText.TextAlign = ContentAlignment.TopCenter;
            yearText.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoEllipsis = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(201, 204);
            titleLabel.Name = "titleLabel";
            titleLabel.RightToLeft = RightToLeft.No;
            titleLabel.Size = new Size(327, 25);
            titleLabel.TabIndex = 22;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // changeLengthLabel
            // 
            changeLengthLabel.AutoEllipsis = true;
            changeLengthLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeLengthLabel.Location = new Point(265, 390);
            changeLengthLabel.Name = "changeLengthLabel";
            changeLengthLabel.RightToLeft = RightToLeft.No;
            changeLengthLabel.Size = new Size(208, 27);
            changeLengthLabel.TabIndex = 24;
            changeLengthLabel.Text = "Length(Minutes) ";
            changeLengthLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userLabel
            // 
            userLabel.AutoEllipsis = true;
            userLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(368, 15);
            userLabel.Name = "userLabel";
            userLabel.RightToLeft = RightToLeft.No;
            userLabel.Size = new Size(307, 27);
            userLabel.TabIndex = 25;
            userLabel.Text = "UserName";
            userLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // genreText
            // 
            genreText.AutoEllipsis = true;
            genreText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreText.Location = new Point(165, 356);
            genreText.Name = "genreText";
            genreText.RightToLeft = RightToLeft.No;
            genreText.Size = new Size(144, 34);
            genreText.TabIndex = 26;
            genreText.Text = "genre";
            genreText.TextAlign = ContentAlignment.TopCenter;
            genreText.Visible = false;
            // 
            // lengthText
            // 
            lengthText.AutoEllipsis = true;
            lengthText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lengthText.Location = new Point(303, 417);
            lengthText.Name = "lengthText";
            lengthText.RightToLeft = RightToLeft.No;
            lengthText.Size = new Size(123, 27);
            lengthText.TabIndex = 27;
            lengthText.Text = "180";
            lengthText.TextAlign = ContentAlignment.TopCenter;
            lengthText.Visible = false;
            // 
            // removeFromLibraryButton
            // 
            removeFromLibraryButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeFromLibraryButton.Location = new Point(479, 393);
            removeFromLibraryButton.Name = "removeFromLibraryButton";
            removeFromLibraryButton.Size = new Size(123, 52);
            removeFromLibraryButton.TabIndex = 28;
            removeFromLibraryButton.Text = "Remove From Library";
            removeFromLibraryButton.UseVisualStyleBackColor = true;
            removeFromLibraryButton.Click += removeFromLibraryButton_Click;
            // 
            // MediaLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeFromLibraryButton);
            Controls.Add(lengthText);
            Controls.Add(genreText);
            Controls.Add(userLabel);
            Controls.Add(changeLengthLabel);
            Controls.Add(titleLabel);
            Controls.Add(yearText);
            Controls.Add(descriptionLabel);
            Controls.Add(backButton);
            Controls.Add(descriptionText);
            Controls.Add(yearLabel);
            Controls.Add(changeGenreLabel);
            Controls.Add(SignOutButton);
            Controls.Add(pictureBox);
            Controls.Add(LibraryText);
            Controls.Add(seriesLabel);
            Controls.Add(moviesLabel);
            Controls.Add(seriesLibraryListBox);
            Controls.Add(moviesLibraryListBox);
            Name = "MediaLibrary";
            Text = "MediaLibrary";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox moviesLibraryListBox;
        private ListBox seriesLibraryListBox;
        private Label moviesLabel;
        private Label seriesLabel;
        private Label LibraryText;
        private PictureBox pictureBox;
        private Button SignOutButton;
        private Label descriptionLabel;
        private Label changeGenreLabel;
        private Label yearLabel;
        private Label descriptionText;
        private Label genreText;
        private Label yearText;
        private Button backButton;
        
        private Label titleLabel;
        private Label userLabel;
        private Label genreTextLabel;
        private Label lengthText;
        private Label changeLengthLabel;
        private Button removeFromLibraryButton;
    }
}