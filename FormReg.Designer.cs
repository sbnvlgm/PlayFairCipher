namespace Coursework_iss
{
    partial class FormReg
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
            button_reg = new Button();
            login_reg = new TextBox();
            pass_reg = new TextBox();
            pass_again_reg = new TextBox();
            label_login = new Label();
            label_pass = new Label();
            label_pass_again = new Label();
            button_exit = new Button();
            reglabel = new Label();
            SuspendLayout();
            // 
            // button_reg
            // 
            button_reg.BackColor = Color.Silver;
            button_reg.BackgroundImageLayout = ImageLayout.None;
            button_reg.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_reg.ForeColor = SystemColors.ControlText;
            button_reg.Location = new Point(148, 274);
            button_reg.Margin = new Padding(4);
            button_reg.Name = "button_reg";
            button_reg.Size = new Size(360, 72);
            button_reg.TabIndex = 0;
            button_reg.Text = "зарегистрироваться";
            button_reg.UseVisualStyleBackColor = false;
            button_reg.Click += button_reg_Click;
            // 
            // login_reg
            // 
            login_reg.BackColor = Color.Silver;
            login_reg.BorderStyle = BorderStyle.None;
            login_reg.Cursor = Cursors.IBeam;
            login_reg.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            login_reg.Location = new Point(158, 56);
            login_reg.Margin = new Padding(4);
            login_reg.Multiline = true;
            login_reg.Name = "login_reg";
            login_reg.Size = new Size(344, 31);
            login_reg.TabIndex = 1;
            // 
            // pass_reg
            // 
            pass_reg.BackColor = Color.Silver;
            pass_reg.BorderStyle = BorderStyle.None;
            pass_reg.Cursor = Cursors.IBeam;
            pass_reg.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pass_reg.Location = new Point(158, 141);
            pass_reg.Margin = new Padding(4);
            pass_reg.Multiline = true;
            pass_reg.Name = "pass_reg";
            pass_reg.PasswordChar = '*';
            pass_reg.Size = new Size(344, 31);
            pass_reg.TabIndex = 2;
            // 
            // pass_again_reg
            // 
            pass_again_reg.BackColor = Color.Silver;
            pass_again_reg.BorderStyle = BorderStyle.None;
            pass_again_reg.Cursor = Cursors.IBeam;
            pass_again_reg.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pass_again_reg.Location = new Point(158, 226);
            pass_again_reg.Margin = new Padding(4);
            pass_again_reg.Multiline = true;
            pass_again_reg.Name = "pass_again_reg";
            pass_again_reg.PasswordChar = '*';
            pass_again_reg.Size = new Size(344, 31);
            pass_again_reg.TabIndex = 3;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = Color.Silver;
            label_login.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_login.Location = new Point(158, 20);
            label_login.Margin = new Padding(4, 0, 4, 0);
            label_login.Name = "label_login";
            label_login.Size = new Size(100, 24);
            label_login.TabIndex = 4;
            label_login.Text = "логин";
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.BackColor = Color.Silver;
            label_pass.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_pass.Location = new Point(158, 107);
            label_pass.Margin = new Padding(4, 0, 4, 0);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(118, 24);
            label_pass.TabIndex = 5;
            label_pass.Text = "пароль";
            // 
            // label_pass_again
            // 
            label_pass_again.AutoSize = true;
            label_pass_again.BackColor = Color.Silver;
            label_pass_again.Font = new Font("Minecraft Rus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_pass_again.Location = new Point(158, 191);
            label_pass_again.Margin = new Padding(4, 0, 4, 0);
            label_pass_again.Name = "label_pass_again";
            label_pass_again.Size = new Size(286, 24);
            label_pass_again.TabIndex = 6;
            label_pass_again.Text = "повторите пароль";
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Silver;
            button_exit.Font = new Font("Minecraft Rus", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.ForeColor = SystemColors.ControlText;
            button_exit.Location = new Point(531, 364);
            button_exit.Margin = new Padding(4);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(52, 55);
            button_exit.TabIndex = 7;
            button_exit.Text = "x";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // reglabel
            // 
            reglabel.AutoSize = true;
            reglabel.BackColor = Color.Silver;
            reglabel.Font = new Font("Minecraft Rus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            reglabel.Location = new Point(37, 375);
            reglabel.Margin = new Padding(4, 0, 4, 0);
            reglabel.Name = "reglabel";
            reglabel.Size = new Size(406, 37);
            reglabel.TabIndex = 11;
            reglabel.Text = "     регистрация    ";
            // 
            // FormReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_2_1__1_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(638, 440);
            ControlBox = false;
            Controls.Add(reglabel);
            Controls.Add(button_exit);
            Controls.Add(label_pass_again);
            Controls.Add(label_pass);
            Controls.Add(label_login);
            Controls.Add(pass_again_reg);
            Controls.Add(pass_reg);
            Controls.Add(login_reg);
            Controls.Add(button_reg);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReg";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_reg;
        private TextBox login_reg;
        private TextBox pass_reg;
        private TextBox pass_again_reg;
        private Label label_login;
        private Label label_pass;
        private Label label_pass_again;
        private Button button_exit;
        private Label reglabel;
    }
}