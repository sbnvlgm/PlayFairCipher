namespace Coursework_iss
{
    partial class FormMain
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
            encrypt_buttom = new Button();
            inputMessage = new TextBox();
            input = new Label();
            output = new Label();
            key = new Label();
            inputKey = new TextBox();
            textBoxKey = new TextBox();
            outputMessage = new TextBox();
            SaveEncrBut = new Button();
            EncrOpenBut = new Button();
            MainCancel = new Button();
            EncrSaveDi = new SaveFileDialog();
            EncrOpenDi = new OpenFileDialog();
            EncLabel = new Label();
            EncrFBox = new TextBox();
            checkMessage = new TextBox();
            check = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // encrypt_buttom
            // 
            encrypt_buttom.BackColor = SystemColors.ScrollBar;
            encrypt_buttom.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            encrypt_buttom.ForeColor = SystemColors.ControlText;
            encrypt_buttom.Image = Properties.Resources.pngegg__1_;
            encrypt_buttom.Location = new Point(40, 208);
            encrypt_buttom.Name = "encrypt_buttom";
            encrypt_buttom.Size = new Size(83, 80);
            encrypt_buttom.TabIndex = 0;
            encrypt_buttom.UseVisualStyleBackColor = false;
            encrypt_buttom.Click += encrypt_buttom_Click;
            encrypt_buttom.MouseHover += encrypt_buttom_MouseHover;
            // 
            // inputMessage
            // 
            inputMessage.BackColor = SystemColors.ScrollBar;
            inputMessage.BorderStyle = BorderStyle.None;
            inputMessage.CharacterCasing = CharacterCasing.Upper;
            inputMessage.Cursor = Cursors.IBeam;
            inputMessage.Font = new Font("Minecraft Rus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputMessage.Location = new Point(129, 36);
            inputMessage.Margin = new Padding(10, 20, 3, 30);
            inputMessage.MinimumSize = new Size(110, 110);
            inputMessage.Multiline = true;
            inputMessage.Name = "inputMessage";
            inputMessage.Size = new Size(263, 249);
            inputMessage.TabIndex = 2;
            // 
            // input
            // 
            input.AutoSize = true;
            input.BackColor = SystemColors.ScrollBar;
            input.Font = new Font("Minecraft Rus", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            input.Location = new Point(151, 297);
            input.Name = "input";
            input.Size = new Size(241, 19);
            input.TabIndex = 3;
            input.Text = "изначальный текст";
            // 
            // output
            // 
            output.AutoSize = true;
            output.BackColor = SystemColors.ScrollBar;
            output.Font = new Font("Minecraft Rus", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            output.Location = new Point(123, 715);
            output.MaximumSize = new Size(269, 100);
            output.MinimumSize = new Size(269, 25);
            output.Name = "output";
            output.Size = new Size(269, 25);
            output.TabIndex = 4;
            output.Text = "зашифрованный текст";
            // 
            // key
            // 
            key.AutoSize = true;
            key.BackColor = SystemColors.ScrollBar;
            key.Font = new Font("Minecraft Rus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            key.Location = new Point(785, 208);
            key.Name = "key";
            key.Size = new Size(57, 16);
            key.TabIndex = 5;
            key.Text = "ключ";
            // 
            // inputKey
            // 
            inputKey.BackColor = SystemColors.ScrollBar;
            inputKey.BorderStyle = BorderStyle.None;
            inputKey.CharacterCasing = CharacterCasing.Upper;
            inputKey.Cursor = Cursors.IBeam;
            inputKey.Font = new Font("Minecraft Rus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputKey.Location = new Point(723, 142);
            inputKey.Multiline = true;
            inputKey.Name = "inputKey";
            inputKey.Size = new Size(119, 61);
            inputKey.TabIndex = 6;
            inputKey.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxKey
            // 
            textBoxKey.BackColor = SystemColors.ScrollBar;
            textBoxKey.BorderStyle = BorderStyle.None;
            textBoxKey.Cursor = Cursors.IBeam;
            textBoxKey.Font = new Font("Minecraft Rus", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKey.Location = new Point(442, 85);
            textBoxKey.Margin = new Padding(10, 5, 3, 3);
            textBoxKey.MinimumSize = new Size(110, 110);
            textBoxKey.Multiline = true;
            textBoxKey.Name = "textBoxKey";
            textBoxKey.ReadOnly = true;
            textBoxKey.Size = new Size(173, 164);
            textBoxKey.TabIndex = 7;
            textBoxKey.TextAlign = HorizontalAlignment.Center;
            // 
            // outputMessage
            // 
            outputMessage.BackColor = SystemColors.ScrollBar;
            outputMessage.BorderStyle = BorderStyle.None;
            outputMessage.Font = new Font("Minecraft Rus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            outputMessage.Location = new Point(129, 501);
            outputMessage.Margin = new Padding(10, 20, 3, 3);
            outputMessage.MinimumSize = new Size(110, 110);
            outputMessage.Multiline = true;
            outputMessage.Name = "outputMessage";
            outputMessage.ReadOnly = true;
            outputMessage.Size = new Size(273, 198);
            outputMessage.TabIndex = 8;
            // 
            // SaveEncrBut
            // 
            SaveEncrBut.BackColor = SystemColors.ScrollBar;
            SaveEncrBut.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveEncrBut.Image = Properties.Resources.pngegg4;
            SaveEncrBut.Location = new Point(40, 122);
            SaveEncrBut.Name = "SaveEncrBut";
            SaveEncrBut.Size = new Size(83, 80);
            SaveEncrBut.TabIndex = 9;
            SaveEncrBut.UseVisualStyleBackColor = false;
            SaveEncrBut.Click += SaveEncrBut_Click;
            SaveEncrBut.MouseHover += SaveEncrBut_MouseHover;
            // 
            // EncrOpenBut
            // 
            EncrOpenBut.BackColor = SystemColors.ScrollBar;
            EncrOpenBut.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EncrOpenBut.Image = Properties.Resources.png_transparent_windows_95_windows_98_directory_computer_icons_aesthetic_estate_publicity_miscellaneous_rectangle_emulator2;
            EncrOpenBut.Location = new Point(40, 36);
            EncrOpenBut.Name = "EncrOpenBut";
            EncrOpenBut.Size = new Size(83, 80);
            EncrOpenBut.TabIndex = 10;
            EncrOpenBut.UseVisualStyleBackColor = false;
            EncrOpenBut.Click += EncrOpenBut_Click;
            EncrOpenBut.MouseMove += EncrOpenBut_MouseMove;
            // 
            // MainCancel
            // 
            MainCancel.BackColor = SystemColors.ScrollBar;
            MainCancel.Font = new Font("Minecraft Rus", 48F, FontStyle.Regular, GraphicsUnit.Point);
            MainCancel.Location = new Point(792, 12);
            MainCancel.Margin = new Padding(10, 13, 3, 3);
            MainCancel.Name = "MainCancel";
            MainCancel.Size = new Size(78, 80);
            MainCancel.TabIndex = 11;
            MainCancel.Text = "x";
            MainCancel.TextAlign = ContentAlignment.MiddleLeft;
            MainCancel.UseVisualStyleBackColor = false;
            MainCancel.Click += MainCancel_Click;
            // 
            // EncrSaveDi
            // 
            EncrSaveDi.DefaultExt = "PLFR";
            EncrSaveDi.Title = "Сохраняем шифровку:";
            // 
            // EncrOpenDi
            // 
            EncrOpenDi.DefaultExt = "PLFR";
            EncrOpenDi.FileName = "openFileDialog1";
            EncrOpenDi.Title = "Читаем шифровку:";
            // 
            // EncLabel
            // 
            EncLabel.AutoSize = true;
            EncLabel.BackColor = SystemColors.ScrollBar;
            EncLabel.Font = new Font("Minecraft Rus", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EncLabel.Location = new Point(692, 322);
            EncLabel.Margin = new Padding(3);
            EncLabel.MaximumSize = new Size(153, 57);
            EncLabel.MinimumSize = new Size(153, 57);
            EncLabel.Name = "EncLabel";
            EncLabel.Size = new Size(153, 57);
            EncLabel.TabIndex = 12;
            // 
            // EncrFBox
            // 
            EncrFBox.BackColor = SystemColors.ScrollBar;
            EncrFBox.BorderStyle = BorderStyle.None;
            EncrFBox.Font = new Font("Minecraft Rus", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EncrFBox.Location = new Point(692, 242);
            EncrFBox.MaximumSize = new Size(153, 57);
            EncrFBox.MinimumSize = new Size(153, 57);
            EncrFBox.Multiline = true;
            EncrFBox.Name = "EncrFBox";
            EncrFBox.Size = new Size(153, 57);
            EncrFBox.TabIndex = 13;
            // 
            // checkMessage
            // 
            checkMessage.BackColor = SystemColors.ScrollBar;
            checkMessage.BorderStyle = BorderStyle.None;
            checkMessage.Font = new Font("Minecraft Rus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkMessage.Location = new Point(485, 501);
            checkMessage.Margin = new Padding(10, 20, 3, 3);
            checkMessage.MinimumSize = new Size(110, 110);
            checkMessage.Multiline = true;
            checkMessage.Name = "checkMessage";
            checkMessage.ReadOnly = true;
            checkMessage.Size = new Size(265, 198);
            checkMessage.TabIndex = 14;
            // 
            // check
            // 
            check.AutoSize = true;
            check.BackColor = SystemColors.ScrollBar;
            check.Font = new Font("Minecraft Rus", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            check.Location = new Point(467, 715);
            check.Name = "check";
            check.Size = new Size(283, 19);
            check.TabIndex = 15;
            check.Text = "расшифрованный текст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Minecraft Rus", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(508, 256);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 16;
            label1.Text = "алфавит";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Minecraft Rus", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(222, 376);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 76);
            textBox1.TabIndex = 17;
            textBox1.Text = "шифр плейфера";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.minecraft_inventory_fmyuojmmrku9we1g1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 792);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(check);
            Controls.Add(checkMessage);
            Controls.Add(EncrFBox);
            Controls.Add(EncLabel);
            Controls.Add(MainCancel);
            Controls.Add(EncrOpenBut);
            Controls.Add(SaveEncrBut);
            Controls.Add(outputMessage);
            Controls.Add(textBoxKey);
            Controls.Add(inputKey);
            Controls.Add(key);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(inputMessage);
            Controls.Add(encrypt_buttom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encrypt_buttom;
        private TextBox inputMessage;
        private Label input;
        private Label output;
        private Label key;
        private TextBox inputKey;
        private TextBox textBoxKey;
        private TextBox outputMessage;
        private Button SaveEncrBut;
        private Button EncrOpenBut;
        private Button MainCancel;
        private SaveFileDialog EncrSaveDi;
        private OpenFileDialog EncrOpenDi;
        private Label EncLabel;
        private TextBox EncrFBox;
        private TextBox checkMessage;
        private Label check;
        private Label label1;
        private TextBox textBox1;
    }
}