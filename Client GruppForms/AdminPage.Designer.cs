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
            editSeriesPanel = new Panel();
            seasonsTextBox = new TextBox();
            serieRelYearTextBox = new TextBox();
            seireEpisodesTextBox = new TextBox();
            removeSerieButton = new Button();
            editSerieButton = new Button();
            addSerieButton = new Button();
            serieDescrTextBox = new TextBox();
            seasonsLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            serieTitleTextbox = new TextBox();
            editSelectedSerieButton = new Button();
            editSeriesListBox = new ListBox();
            editMoviesButton = new Button();
            editSeriesButton = new Button();
            editUsersButton = new Button();
            editUsersPanel = new Panel();
            userLastNameTextBox = new TextBox();
            userFirstNameTextBox = new TextBox();
            removeUserButton = new Button();
            editUserButton = new Button();
            addUserButton = new Button();
            userPasswordTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            userEmailTextBox = new TextBox();
            editSelectedUser = new Button();
            editUserListBox = new ListBox();
            editMoviesPanel = new Panel();
            movieLengthTextBox = new TextBox();
            movieRelYearTextBox = new TextBox();
            removeMovieButton = new Button();
            editMovieButton = new Button();
            addMovieButton = new Button();
            movieDescrTextBox = new TextBox();
            movieGenreTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            movieTitleTextBox = new TextBox();
            editSelectedMovieButton = new Button();
            editMoviesListBox = new ListBox();
            logOutButton = new Button();
            editSeriesPanel.SuspendLayout();
            editUsersPanel.SuspendLayout();
            editMoviesPanel.SuspendLayout();
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
            // editSeriesPanel
            // 
            editSeriesPanel.Controls.Add(seasonsTextBox);
            editSeriesPanel.Controls.Add(serieRelYearTextBox);
            editSeriesPanel.Controls.Add(seireEpisodesTextBox);
            editSeriesPanel.Controls.Add(removeSerieButton);
            editSeriesPanel.Controls.Add(editSerieButton);
            editSeriesPanel.Controls.Add(addSerieButton);
            editSeriesPanel.Controls.Add(serieDescrTextBox);
            editSeriesPanel.Controls.Add(seasonsLabel);
            editSeriesPanel.Controls.Add(label8);
            editSeriesPanel.Controls.Add(label9);
            editSeriesPanel.Controls.Add(label10);
            editSeriesPanel.Controls.Add(label11);
            editSeriesPanel.Controls.Add(serieTitleTextbox);
            editSeriesPanel.Controls.Add(editSelectedSerieButton);
            editSeriesPanel.Controls.Add(editSeriesListBox);
            editSeriesPanel.Location = new Point(56, 88);
            editSeriesPanel.Name = "editSeriesPanel";
            editSeriesPanel.Size = new Size(660, 281);
            editSeriesPanel.TabIndex = 2;
            editSeriesPanel.Visible = false;
            // 
            // seasonsTextBox
            // 
            seasonsTextBox.Location = new Point(510, 142);
            seasonsTextBox.Name = "seasonsTextBox";
            seasonsTextBox.Size = new Size(147, 23);
            seasonsTextBox.TabIndex = 37;
            // 
            // serieRelYearTextBox
            // 
            serieRelYearTextBox.Location = new Point(510, 109);
            serieRelYearTextBox.Name = "serieRelYearTextBox";
            serieRelYearTextBox.Size = new Size(147, 23);
            serieRelYearTextBox.TabIndex = 36;
            // 
            // seireEpisodesTextBox
            // 
            seireEpisodesTextBox.Location = new Point(510, 78);
            seireEpisodesTextBox.Name = "seireEpisodesTextBox";
            seireEpisodesTextBox.Size = new Size(147, 23);
            seireEpisodesTextBox.TabIndex = 35;
            // 
            // removeSerieButton
            // 
            removeSerieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSerieButton.Location = new Point(439, 170);
            removeSerieButton.Name = "removeSerieButton";
            removeSerieButton.Size = new Size(102, 40);
            removeSerieButton.TabIndex = 34;
            removeSerieButton.Text = "Remove Serie";
            removeSerieButton.UseVisualStyleBackColor = true;
            removeSerieButton.Click += removeSerieButton_Click;
            // 
            // editSerieButton
            // 
            editSerieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSerieButton.Location = new Point(555, 171);
            editSerieButton.Name = "editSerieButton";
            editSerieButton.Size = new Size(102, 40);
            editSerieButton.TabIndex = 30;
            editSerieButton.Text = "Edit Serie";
            editSerieButton.UseVisualStyleBackColor = true;
            editSerieButton.Click += editSerieButton_Click;
            // 
            // addSerieButton
            // 
            addSerieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addSerieButton.Location = new Point(494, 216);
            addSerieButton.Name = "addSerieButton";
            addSerieButton.Size = new Size(102, 46);
            addSerieButton.TabIndex = 29;
            addSerieButton.Text = "Add New Serie";
            addSerieButton.UseVisualStyleBackColor = true;
            addSerieButton.Click += addSerieButton_Click;
            // 
            // serieDescrTextBox
            // 
            serieDescrTextBox.Location = new Point(510, 44);
            serieDescrTextBox.Name = "serieDescrTextBox";
            serieDescrTextBox.Size = new Size(147, 23);
            serieDescrTextBox.TabIndex = 25;
            // 
            // seasonsLabel
            // 
            seasonsLabel.AutoSize = true;
            seasonsLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seasonsLabel.Location = new Point(411, 142);
            seasonsLabel.Name = "seasonsLabel";
            seasonsLabel.Size = new Size(80, 19);
            seasonsLabel.TabIndex = 24;
            seasonsLabel.Text = "Seasons:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(374, 109);
            label8.Name = "label8";
            label8.Size = new Size(117, 19);
            label8.TabIndex = 23;
            label8.Text = "Release Year:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(404, 76);
            label9.Name = "label9";
            label9.Size = new Size(87, 19);
            label9.TabIndex = 22;
            label9.Text = "Episodes:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(382, 45);
            label10.Name = "label10";
            label10.Size = new Size(109, 19);
            label10.TabIndex = 21;
            label10.Text = "Description:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(439, 17);
            label11.Name = "label11";
            label11.Size = new Size(52, 19);
            label11.TabIndex = 20;
            label11.Text = "Title:";
            // 
            // serieTitleTextbox
            // 
            serieTitleTextbox.Location = new Point(510, 13);
            serieTitleTextbox.Name = "serieTitleTextbox";
            serieTitleTextbox.Size = new Size(147, 23);
            serieTitleTextbox.TabIndex = 19;
            // 
            // editSelectedSerieButton
            // 
            editSelectedSerieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSelectedSerieButton.Location = new Point(164, 113);
            editSelectedSerieButton.Name = "editSelectedSerieButton";
            editSelectedSerieButton.Size = new Size(102, 57);
            editSelectedSerieButton.TabIndex = 18;
            editSelectedSerieButton.Text = "Edit Selected Serie";
            editSelectedSerieButton.UseVisualStyleBackColor = true;
            editSelectedSerieButton.Click += editSelectedSerieButton_Click;
            // 
            // editSeriesListBox
            // 
            editSeriesListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSeriesListBox.FormattingEnabled = true;
            editSeriesListBox.Location = new Point(3, 2);
            editSeriesListBox.Name = "editSeriesListBox";
            editSeriesListBox.Size = new Size(155, 276);
            editSeriesListBox.TabIndex = 17;
            // 
            // editMoviesButton
            // 
            editMoviesButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMoviesButton.Location = new Point(56, 44);
            editMoviesButton.Name = "editMoviesButton";
            editMoviesButton.Size = new Size(102, 38);
            editMoviesButton.TabIndex = 3;
            editMoviesButton.Text = "Edit Movies";
            editMoviesButton.UseVisualStyleBackColor = true;
            editMoviesButton.Click += editMoviesButton_Click;
            // 
            // editSeriesButton
            // 
            editSeriesButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSeriesButton.Location = new Point(164, 44);
            editSeriesButton.Name = "editSeriesButton";
            editSeriesButton.Size = new Size(102, 38);
            editSeriesButton.TabIndex = 4;
            editSeriesButton.Text = "Edit Series";
            editSeriesButton.UseVisualStyleBackColor = true;
            editSeriesButton.Click += editSeriesButton_Click;
            // 
            // editUsersButton
            // 
            editUsersButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editUsersButton.Location = new Point(272, 44);
            editUsersButton.Name = "editUsersButton";
            editUsersButton.Size = new Size(102, 38);
            editUsersButton.TabIndex = 5;
            editUsersButton.Text = "Edit Users";
            editUsersButton.UseVisualStyleBackColor = true;
            editUsersButton.Click += editUsersButton_Click;
            // 
            // editUsersPanel
            // 
            editUsersPanel.Controls.Add(userLastNameTextBox);
            editUsersPanel.Controls.Add(userFirstNameTextBox);
            editUsersPanel.Controls.Add(removeUserButton);
            editUsersPanel.Controls.Add(editUserButton);
            editUsersPanel.Controls.Add(addUserButton);
            editUsersPanel.Controls.Add(userPasswordTextBox);
            editUsersPanel.Controls.Add(label12);
            editUsersPanel.Controls.Add(label13);
            editUsersPanel.Controls.Add(label14);
            editUsersPanel.Controls.Add(label15);
            editUsersPanel.Controls.Add(userEmailTextBox);
            editUsersPanel.Controls.Add(editSelectedUser);
            editUsersPanel.Controls.Add(editUserListBox);
            editUsersPanel.Location = new Point(56, 88);
            editUsersPanel.Name = "editUsersPanel";
            editUsersPanel.Size = new Size(660, 281);
            editUsersPanel.TabIndex = 3;
            editUsersPanel.Visible = false;
            // 
            // userLastNameTextBox
            // 
            userLastNameTextBox.Location = new Point(510, 113);
            userLastNameTextBox.Name = "userLastNameTextBox";
            userLastNameTextBox.Size = new Size(147, 23);
            userLastNameTextBox.TabIndex = 51;
            // 
            // userFirstNameTextBox
            // 
            userFirstNameTextBox.Location = new Point(510, 82);
            userFirstNameTextBox.Name = "userFirstNameTextBox";
            userFirstNameTextBox.Size = new Size(147, 23);
            userFirstNameTextBox.TabIndex = 50;
            // 
            // removeUserButton
            // 
            removeUserButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeUserButton.Location = new Point(439, 170);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(102, 40);
            removeUserButton.TabIndex = 49;
            removeUserButton.Text = "Remove User";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // editUserButton
            // 
            editUserButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editUserButton.Location = new Point(555, 171);
            editUserButton.Name = "editUserButton";
            editUserButton.Size = new Size(102, 40);
            editUserButton.TabIndex = 45;
            editUserButton.Text = "Edit User";
            editUserButton.UseVisualStyleBackColor = true;
            editUserButton.Click += editUserButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUserButton.Location = new Point(494, 216);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(102, 46);
            addUserButton.TabIndex = 44;
            addUserButton.Text = "Add New User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Location = new Point(510, 44);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(147, 23);
            userPasswordTextBox.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(401, 113);
            label12.Name = "label12";
            label12.Size = new Size(100, 19);
            label12.TabIndex = 41;
            label12.Text = "Last Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(397, 82);
            label13.Name = "label13";
            label13.Size = new Size(104, 19);
            label13.TabIndex = 40;
            label13.Text = "First Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(409, 44);
            label14.Name = "label14";
            label14.Size = new Size(92, 19);
            label14.TabIndex = 39;
            label14.Text = "Password:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(439, 17);
            label15.Name = "label15";
            label15.Size = new Size(62, 19);
            label15.TabIndex = 38;
            label15.Text = "Email:";
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.Location = new Point(510, 13);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.Size = new Size(147, 23);
            userEmailTextBox.TabIndex = 37;
            // 
            // editSelectedUser
            // 
            editSelectedUser.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSelectedUser.Location = new Point(164, 113);
            editSelectedUser.Name = "editSelectedUser";
            editSelectedUser.Size = new Size(102, 57);
            editSelectedUser.TabIndex = 36;
            editSelectedUser.Text = "Edit Selected User";
            editSelectedUser.UseVisualStyleBackColor = true;
            editSelectedUser.Click += editSelectedUser_Click;
            // 
            // editUserListBox
            // 
            editUserListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editUserListBox.FormattingEnabled = true;
            editUserListBox.Location = new Point(3, 2);
            editUserListBox.Name = "editUserListBox";
            editUserListBox.Size = new Size(155, 276);
            editUserListBox.TabIndex = 35;
            // 
            // editMoviesPanel
            // 
            editMoviesPanel.Controls.Add(movieLengthTextBox);
            editMoviesPanel.Controls.Add(movieRelYearTextBox);
            editMoviesPanel.Controls.Add(removeMovieButton);
            editMoviesPanel.Controls.Add(editMovieButton);
            editMoviesPanel.Controls.Add(addMovieButton);
            editMoviesPanel.Controls.Add(movieDescrTextBox);
            editMoviesPanel.Controls.Add(movieGenreTextBox);
            editMoviesPanel.Controls.Add(label6);
            editMoviesPanel.Controls.Add(label5);
            editMoviesPanel.Controls.Add(label4);
            editMoviesPanel.Controls.Add(label3);
            editMoviesPanel.Controls.Add(label1);
            editMoviesPanel.Controls.Add(movieTitleTextBox);
            editMoviesPanel.Controls.Add(editSelectedMovieButton);
            editMoviesPanel.Controls.Add(editMoviesListBox);
            editMoviesPanel.Location = new Point(56, 88);
            editMoviesPanel.Name = "editMoviesPanel";
            editMoviesPanel.Size = new Size(660, 281);
            editMoviesPanel.TabIndex = 3;
            editMoviesPanel.Visible = false;
            // 
            // movieLengthTextBox
            // 
            movieLengthTextBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            movieLengthTextBox.Location = new Point(510, 143);
            movieLengthTextBox.Name = "movieLengthTextBox";
            movieLengthTextBox.Size = new Size(147, 23);
            movieLengthTextBox.TabIndex = 36;
            // 
            // movieRelYearTextBox
            // 
            movieRelYearTextBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            movieRelYearTextBox.Location = new Point(510, 111);
            movieRelYearTextBox.Name = "movieRelYearTextBox";
            movieRelYearTextBox.Size = new Size(147, 23);
            movieRelYearTextBox.TabIndex = 35;
            // 
            // removeMovieButton
            // 
            removeMovieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeMovieButton.Location = new Point(428, 172);
            removeMovieButton.Name = "removeMovieButton";
            removeMovieButton.Size = new Size(102, 41);
            removeMovieButton.TabIndex = 34;
            removeMovieButton.Text = "Delete Movie";
            removeMovieButton.UseVisualStyleBackColor = true;
            removeMovieButton.Click += removeMovieButton_Click;
            // 
            // editMovieButton
            // 
            editMovieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMovieButton.Location = new Point(494, 219);
            editMovieButton.Name = "editMovieButton";
            editMovieButton.Size = new Size(102, 33);
            editMovieButton.TabIndex = 16;
            editMovieButton.Text = "Edit Movie";
            editMovieButton.UseVisualStyleBackColor = true;
            editMovieButton.Click += editMovieButton_Click;
            // 
            // addMovieButton
            // 
            addMovieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addMovieButton.Location = new Point(547, 172);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(102, 41);
            addMovieButton.TabIndex = 15;
            addMovieButton.Text = "Add New Movie";
            addMovieButton.UseVisualStyleBackColor = true;
            addMovieButton.Click += addMovieButton_Click;
            // 
            // movieDescrTextBox
            // 
            movieDescrTextBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            movieDescrTextBox.Location = new Point(510, 77);
            movieDescrTextBox.Name = "movieDescrTextBox";
            movieDescrTextBox.Size = new Size(147, 23);
            movieDescrTextBox.TabIndex = 12;
            // 
            // movieGenreTextBox
            // 
            movieGenreTextBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            movieGenreTextBox.Location = new Point(510, 45);
            movieGenreTextBox.Name = "movieGenreTextBox";
            movieGenreTextBox.Size = new Size(147, 23);
            movieGenreTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(367, 142);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 10;
            label6.Text = "Length(Mins):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(374, 110);
            label5.Name = "label5";
            label5.Size = new Size(117, 19);
            label5.TabIndex = 9;
            label5.Text = "Release Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(382, 77);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 45);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 7;
            label3.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 6;
            label1.Text = "Title:";
            // 
            // movieTitleTextBox
            // 
            movieTitleTextBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold);
            movieTitleTextBox.Location = new Point(510, 14);
            movieTitleTextBox.Name = "movieTitleTextBox";
            movieTitleTextBox.Size = new Size(147, 23);
            movieTitleTextBox.TabIndex = 5;
            // 
            // editSelectedMovieButton
            // 
            editSelectedMovieButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSelectedMovieButton.Location = new Point(164, 114);
            editSelectedMovieButton.Name = "editSelectedMovieButton";
            editSelectedMovieButton.Size = new Size(102, 57);
            editSelectedMovieButton.TabIndex = 4;
            editSelectedMovieButton.Text = "Edit Selected Movie";
            editSelectedMovieButton.UseVisualStyleBackColor = true;
            editSelectedMovieButton.Click += editSelectedMovieButton_Click;
            // 
            // editMoviesListBox
            // 
            editMoviesListBox.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMoviesListBox.FormattingEnabled = true;
            editMoviesListBox.Location = new Point(3, 3);
            editMoviesListBox.Name = "editMoviesListBox";
            editMoviesListBox.Size = new Size(155, 276);
            editMoviesListBox.TabIndex = 0;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOutButton.Location = new Point(684, 400);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(102, 33);
            logOutButton.TabIndex = 17;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 445);
            Controls.Add(logOutButton);
            Controls.Add(editUsersButton);
            Controls.Add(editSeriesButton);
            Controls.Add(editMoviesButton);
            Controls.Add(label2);
            Controls.Add(editMoviesPanel);
            Controls.Add(editUsersPanel);
            Controls.Add(editSeriesPanel);
            Name = "AdminPage";
            Text = "AdminPage";
            editSeriesPanel.ResumeLayout(false);
            editSeriesPanel.PerformLayout();
            editUsersPanel.ResumeLayout(false);
            editUsersPanel.PerformLayout();
            editMoviesPanel.ResumeLayout(false);
            editMoviesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel editSeriesPanel;
        private Button editMoviesButton;
        private Button editSeriesButton;
        private Button editUsersButton;
        private Panel editUsersPanel;
        private Panel editMoviesPanel;
        private TextBox movieDescrTextBox;
        private TextBox movieGenreTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox movieTitleTextBox;
        private Button editSelectedMovieButton;
        private ListBox editMoviesListBox;
        private Button editMovieButton;
        private Button addMovieButton;
        private Button editSerieButton;
        private Button addSerieButton;
        private TextBox serieDescrTextBox;
        private Label seasonsLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox serieTitleTextbox;
        private Button editSelectedSerieButton;
        private ListBox editSeriesListBox;
        private Button removeSerieButton;
        private TextBox userLastNameTextBox;
        private TextBox userFirstNameTextBox;
        private Button removeUserButton;
        private Button editUserButton;
        private Button addUserButton;
        private TextBox userPasswordTextBox;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox userEmailTextBox;
        private Button editSelectedUser;
        private ListBox editUserListBox;
        private Button removeMovieButton;
        private TextBox movieLengthTextBox;
        private TextBox movieRelYearTextBox;
        private TextBox seasonsTextBox;
        private TextBox serieRelYearTextBox;
        private TextBox seireEpisodesTextBox;
        private Button logOutButton;
    }
}