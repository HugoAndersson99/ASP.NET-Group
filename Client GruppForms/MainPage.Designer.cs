using System.Linq.Expressions;

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
            userPanel = new Panel();
            userLabel = new Label();
            logOutButton = new Button();
            goToLibraryButton = new Button();
            panel2 = new Panel();
            seriesListBox = new ListBox();
            label2 = new Label();
            panel1 = new Panel();
            moviesListBox = new ListBox();
            label1 = new Label();
            mediaPanel = new Panel();
            changeLengthLabel = new Label();
            lengthTextLabel = new Label();
            yearTextLabel = new Label();
            genreTextLabel = new Label();
            titleLabel = new Label();
            label5 = new Label();
            changeGenreLabel = new Label();
            addToLibraryButton = new Button();
            descriptionLabel = new Label();
            pictureBox1 = new PictureBox();
            adminPanel = new Panel();
            userPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            mediaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userPanel
            // 
            userPanel.Controls.Add(userLabel);
            userPanel.Controls.Add(logOutButton);
            userPanel.Controls.Add(goToLibraryButton);
            userPanel.Controls.Add(panel2);
            userPanel.Controls.Add(panel1);
            userPanel.Controls.Add(mediaPanel);
            userPanel.Location = new Point(12, 12);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(776, 426);
            userPanel.TabIndex = 1;
            userPanel.Visible = false;
            // 
            // userLabel
            // 
            userLabel.AutoEllipsis = true;
            userLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold | FontStyle.Underline);
            userLabel.Location = new Point(251, 9);
            userLabel.Name = "userLabel";
            userLabel.RightToLeft = RightToLeft.No;
            userLabel.Size = new Size(250, 27);
            userLabel.TabIndex = 11;
            userLabel.Text = "UserName";
            userLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutButton.Location = new Point(650, 4);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(123, 36);
            logOutButton.TabIndex = 8;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
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
            // mediaPanel
            // 
            mediaPanel.Controls.Add(changeLengthLabel);
            mediaPanel.Controls.Add(lengthTextLabel);
            mediaPanel.Controls.Add(yearTextLabel);
            mediaPanel.Controls.Add(genreTextLabel);
            mediaPanel.Controls.Add(titleLabel);
            mediaPanel.Controls.Add(label5);
            mediaPanel.Controls.Add(changeGenreLabel);
            mediaPanel.Controls.Add(addToLibraryButton);
            mediaPanel.Controls.Add(descriptionLabel);
            mediaPanel.Controls.Add(pictureBox1);
            mediaPanel.Location = new Point(198, 39);
            mediaPanel.Name = "mediaPanel";
            mediaPanel.Size = new Size(363, 381);
            mediaPanel.TabIndex = 3;
            mediaPanel.Visible = false;
            // 
            // changeLengthLabel
            // 
            changeLengthLabel.AutoEllipsis = true;
            changeLengthLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeLengthLabel.Location = new Point(90, 312);
            changeLengthLabel.Name = "changeLengthLabel";
            changeLengthLabel.RightToLeft = RightToLeft.No;
            changeLengthLabel.Size = new Size(169, 27);
            changeLengthLabel.TabIndex = 14;
            changeLengthLabel.Text = "Length(Minutes)";
            changeLengthLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lengthTextLabel
            // 
            lengthTextLabel.AutoEllipsis = true;
            lengthTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lengthTextLabel.Location = new Point(140, 342);
            lengthTextLabel.Name = "lengthTextLabel";
            lengthTextLabel.RightToLeft = RightToLeft.No;
            lengthTextLabel.Size = new Size(63, 27);
            lengthTextLabel.TabIndex = 13;
            lengthTextLabel.Text = "100";
            lengthTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // yearTextLabel
            // 
            yearTextLabel.AutoEllipsis = true;
            yearTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearTextLabel.Location = new Point(190, 285);
            yearTextLabel.Name = "yearTextLabel";
            yearTextLabel.RightToLeft = RightToLeft.No;
            yearTextLabel.Size = new Size(153, 27);
            yearTextLabel.TabIndex = 14;
            yearTextLabel.Text = "Year";
            yearTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // genreTextLabel
            // 
            genreTextLabel.AutoEllipsis = true;
            genreTextLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genreTextLabel.Location = new Point(20, 285);
            genreTextLabel.Name = "genreTextLabel";
            genreTextLabel.RightToLeft = RightToLeft.No;
            genreTextLabel.Size = new Size(123, 27);
            genreTextLabel.TabIndex = 12;
            genreTextLabel.Text = "genre";
            genreTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            titleLabel.AutoEllipsis = true;
            titleLabel.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold | FontStyle.Underline);
            titleLabel.Location = new Point(53, 156);
            titleLabel.Name = "titleLabel";
            titleLabel.RightToLeft = RightToLeft.No;
            titleLabel.Size = new Size(250, 27);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 265);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 5;
            label5.Text = "Release Year";
            // 
            // changeGenreLabel
            // 
            changeGenreLabel.AutoSize = true;
            changeGenreLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            changeGenreLabel.Location = new Point(53, 265);
            changeGenreLabel.Name = "changeGenreLabel";
            changeGenreLabel.Size = new Size(58, 19);
            changeGenreLabel.TabIndex = 4;
            changeGenreLabel.Text = "Genre";
            // 
            // addToLibraryButton
            // 
            addToLibraryButton.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToLibraryButton.Location = new Point(237, 342);
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
            descriptionLabel.Location = new Point(20, 183);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.RightToLeft = RightToLeft.No;
            descriptionLabel.Size = new Size(323, 82);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            descriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(90, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mediaPanel.ResumeLayout(false);
            mediaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel userPanel;
        private Panel adminPanel;
        private Panel panel1;
        private Label label1;
        private Panel mediaPanel;
        private Panel panel2;
        private ListBox seriesListBox;
        private Label label2;
        private ListBox moviesListBox;
        private PictureBox pictureBox1;
        private Label descriptionLabel;
        private Label label5;
        private Label changeGenreLabel;
        private Button addToLibraryButton;
        private Button goToLibraryButton;
        private Button logOutButton;
        private Label titleLabel;
        private Label userLabel;
        private Label genreTextLabel;
        private Label lengthTextLabel;
        private Label yearTextLabel;
        private Label changeLengthLabel;
    }
}