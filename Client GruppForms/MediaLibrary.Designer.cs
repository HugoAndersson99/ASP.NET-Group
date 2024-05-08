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
            titleLabel = new Label();
            SignOutButton = new Button();
            descriptionLabel = new Label();
            changeGenreLabel = new Label();
            yearLabel = new Label();
            changeLengthLabel = new Label();
            userLabel = new Label();
            descriptionText = new Label();
            genreText = new Label();
            yearText = new Label();
            lengthText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // moviesLibraryListBox
            // 
            moviesLibraryListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            moviesLibraryListBox.FormattingEnabled = true;
            moviesLibraryListBox.Location = new Point(21, 46);
            moviesLibraryListBox.Name = "moviesLibraryListBox";
            moviesLibraryListBox.Size = new Size(138, 164);
            moviesLibraryListBox.TabIndex = 2;
            moviesLibraryListBox.SelectedIndexChanged += moviesLibraryListBox_SelectedIndexChanged_1;
            // 
            // seriesLibraryListBox
            // 
            seriesLibraryListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
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
            moviesLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moviesLabel.Location = new Point(50, 21);
            moviesLabel.Name = "moviesLabel";
            moviesLabel.Size = new Size(77, 22);
            moviesLabel.TabIndex = 4;
            moviesLabel.Text = "Movies";
            // 
            // seriesLabel
            // 
            seriesLabel.AutoSize = true;
            seriesLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seriesLabel.Location = new Point(50, 235);
            seriesLabel.Name = "seriesLabel";
            seriesLabel.Size = new Size(71, 22);
            seriesLabel.TabIndex = 5;
            seriesLabel.Text = "Series";
            // 
            // LibraryText
            // 
            LibraryText.AutoSize = true;
            LibraryText.Font = new Font("Bookman Old Style", 30F, FontStyle.Bold);
            LibraryText.Location = new Point(279, 21);
            LibraryText.Name = "LibraryText";
            LibraryText.Size = new Size(304, 47);
            LibraryText.TabIndex = 6;
            LibraryText.Text = "Media Library";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(589, 260);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(182, 160);
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(206, 107);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(62, 22);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Title:";
            // 
            // SignOutButton
            // 
            SignOutButton.Location = new Point(696, 23);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(75, 23);
            SignOutButton.TabIndex = 9;
            SignOutButton.Text = "Sign Out";
            SignOutButton.UseVisualStyleBackColor = true;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(206, 167);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(129, 22);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // changeGenreLabel
            // 
            changeGenreLabel.AutoSize = true;
            changeGenreLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeGenreLabel.Location = new Point(206, 296);
            changeGenreLabel.Name = "changeGenreLabel";
            changeGenreLabel.Size = new Size(63, 19);
            changeGenreLabel.TabIndex = 11;
            changeGenreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            yearLabel.Location = new Point(411, 296);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(117, 19);
            yearLabel.TabIndex = 12;
            yearLabel.Text = "Release Year:";
            // 
            // changeLengthLabel
            // 
            changeLengthLabel.AutoSize = true;
            changeLengthLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeLengthLabel.Location = new Point(206, 401);
            changeLengthLabel.Name = "changeLengthLabel";
            changeLengthLabel.Size = new Size(156, 19);
            changeLengthLabel.TabIndex = 13;
            changeLengthLabel.Text = "Length(Minutes): ";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(344, 68);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(18, 30);
            userLabel.TabIndex = 14;
            userLabel.Text = ".";
            // 
            // descriptionText
            // 
            descriptionText.AutoEllipsis = true;
            descriptionText.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionText.Location = new Point(206, 200);
            descriptionText.Name = "descriptionText";
            descriptionText.RightToLeft = RightToLeft.No;
            descriptionText.Size = new Size(329, 81);
            descriptionText.TabIndex = 15;
            descriptionText.Text = resources.GetString("descriptionText.Text");
            descriptionText.TextAlign = ContentAlignment.TopCenter;
            descriptionText.Visible = false;
            // 
            // genreText
            // 
            genreText.AutoSize = true;
            genreText.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            genreText.Location = new Point(206, 331);
            genreText.Name = "genreText";
            genreText.Size = new Size(58, 19);
            genreText.TabIndex = 16;
            genreText.Text = "label7";
            genreText.Visible = false;
            // 
            // yearText
            // 
            yearText.AutoSize = true;
            yearText.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            yearText.Location = new Point(436, 331);
            yearText.Name = "yearText";
            yearText.Size = new Size(58, 19);
            yearText.TabIndex = 17;
            yearText.Text = "label7";
            yearText.Visible = false;
            // 
            // lengthText
            // 
            lengthText.AutoSize = true;
            lengthText.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            lengthText.Location = new Point(368, 401);
            lengthText.Name = "lengthText";
            lengthText.Size = new Size(58, 19);
            lengthText.TabIndex = 18;
            lengthText.Text = "label7";
            lengthText.Visible = false;
            // 
            // MediaLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lengthText);
            Controls.Add(yearText);
            Controls.Add(genreText);
            Controls.Add(descriptionText);
            Controls.Add(userLabel);
            Controls.Add(changeLengthLabel);
            Controls.Add(yearLabel);
            Controls.Add(changeGenreLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(SignOutButton);
            Controls.Add(titleLabel);
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
        private Label titleLabel;
        private Button SignOutButton;
        private Label descriptionLabel;
        private Label changeGenreLabel;
        private Label yearLabel;
        private Label changeLengthLabel;
        private Label userLabel;
        private Label descriptionText;
        private Label genreText;
        private Label yearText;
        private Label lengthText;
    }
}