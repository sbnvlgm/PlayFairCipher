namespace Coursework_iss
{
    partial class FormAuth
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
            pass_auth = new TextBox();
            log_in = new Button();
            login_auth = new TextBox();
            label_login_auth = new Label();
            label_pass_auth = new Label();
            sign_in = new Button();
            button_exit = new Button();
            authlabel = new Label();
            SuspendLayout();
            // 
            // pass_auth
            // 
            pass_auth.BackColor = Color.Silver;
            pass_auth.BorderStyle = BorderStyle.None;
            pass_auth.Cursor = Cursors.IBeam;
            pass_auth.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pass_auth.Location = new Point(107, 232);
            pass_auth.Margin = new Padding(4);
            pass_auth.Multiline = true;
            pass_auth.Name = "pass_auth";
            pass_auth.PasswordChar = '*';
            pass_auth.Size = new Size(424, 32);
            pass_auth.TabIndex = 0;
            // 
            // log_in
            // 
            log_in.BackColor = SystemColors.ControlLight;
            log_in.BackgroundImageLayout = ImageLayout.Stretch;
            log_in.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            log_in.Location = new Point(321, 289);
            log_in.Margin = new Padding(4);
            log_in.Name = "log_in";
            log_in.Size = new Size(210, 79);
            log_in.TabIndex = 1;
            log_in.Text = "войти";
            log_in.UseVisualStyleBackColor = false;
            log_in.Click += log_in_Click;
            // 
            // login_auth
            // 
            login_auth.BackColor = Color.Silver;
            login_auth.BorderStyle = BorderStyle.None;
            login_auth.Cursor = Cursors.IBeam;
            login_auth.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            login_auth.Location = new Point(107, 134);
            login_auth.Margin = new Padding(4);
            login_auth.Multiline = true;
            login_auth.Name = "login_auth";
            login_auth.Size = new Size(424, 32);
            login_auth.TabIndex = 3;
            // 
            // label_login_auth
            // 
            label_login_auth.AutoSize = true;
            label_login_auth.BackColor = Color.Silver;
            label_login_auth.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_login_auth.ForeColor = SystemColors.ActiveCaptionText;
            label_login_auth.Location = new Point(107, 98);
            label_login_auth.Margin = new Padding(4, 0, 4, 0);
            label_login_auth.Name = "label_login_auth";
            label_login_auth.Size = new Size(100, 24);
            label_login_auth.TabIndex = 4;
            label_login_auth.Text = "логин";
            // 
            // label_pass_auth
            // 
            label_pass_auth.AutoSize = true;
            label_pass_auth.BackColor = Color.Silver;
            label_pass_auth.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_pass_auth.Location = new Point(107, 196);
            label_pass_auth.Margin = new Padding(4, 0, 4, 0);
            label_pass_auth.Name = "label_pass_auth";
            label_pass_auth.Size = new Size(118, 24);
            label_pass_auth.TabIndex = 7;
            label_pass_auth.Text = "пароль";
            // 
            // sign_in
            // 
            sign_in.BackColor = SystemColors.ControlLight;
            sign_in.Font = new Font("Minecraft Rus", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            sign_in.Location = new Point(98, 289);
            sign_in.Margin = new Padding(4);
            sign_in.Name = "sign_in";
            sign_in.Size = new Size(209, 79);
            sign_in.TabIndex = 8;
            sign_in.Text = "регистрация";
            sign_in.UseVisualStyleBackColor = false;
            sign_in.Click += sign_in_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Silver;
            button_exit.BackgroundImageLayout = ImageLayout.Center;
            button_exit.Font = new Font("Minecraft Rus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_exit.Location = new Point(560, 378);
            button_exit.Margin = new Padding(4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(56, 51);
            button_exit.TabIndex = 9;
            button_exit.Text = "x";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // authlabel
            // 
            authlabel.AutoSize = true;
            authlabel.BackColor = Color.Silver;
            authlabel.Font = new Font("Minecraft Rus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            authlabel.Location = new Point(163, 29);
            authlabel.Margin = new Padding(4, 0, 4, 0);
            authlabel.Name = "authlabel";
            authlabel.Size = new Size(325, 37);
            authlabel.TabIndex = 10;
            authlabel.Text = "авторизация";
            // 
            // FormAuth
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_2_11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 440);
            ControlBox = false;
            Controls.Add(authlabel);
            Controls.Add(button_exit);
            Controls.Add(sign_in);
            Controls.Add(label_pass_auth);
            Controls.Add(label_login_auth);
            Controls.Add(login_auth);
            Controls.Add(log_in);
            Controls.Add(pass_auth);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAuth";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pass_auth;
        private Button log_in;
        private TextBox login_auth;
        private Label label_login_auth;
        private Label label_pass_auth;
        private Button sign_in;
        private Button button_exit;
        private Label authlabel;
    }
}