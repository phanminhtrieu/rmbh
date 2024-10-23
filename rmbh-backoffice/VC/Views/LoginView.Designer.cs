namespace rmbh_backoffice.VC.Views
{
    partial class LoginView
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
            label_Name = new Label();
            button_Login = new Button();
            textBox_Username = new TextBox();
            label_Login = new Label();
            label_Username = new Label();
            label_Password = new Label();
            textBox_Password = new TextBox();
            checkBox_Passwordshow = new CheckBox();
            button_CloseForm = new Button();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_Name.ForeColor = Color.OliveDrab;
            label_Name.Location = new Point(42, 66);
            label_Name.Margin = new Padding(4, 0, 4, 0);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(301, 36);
            label_Name.TabIndex = 0;
            label_Name.Text = "Remember Helper";
            label_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Login
            // 
            button_Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button_Login.BackColor = Color.OliveDrab;
            button_Login.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Login.ForeColor = Color.White;
            button_Login.Location = new Point(134, 371);
            button_Login.Margin = new Padding(4, 3, 4, 3);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(109, 40);
            button_Login.TabIndex = 1;
            button_Login.Text = "Log in";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // textBox_Username
            // 
            textBox_Username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_Username.Location = new Point(58, 220);
            textBox_Username.Margin = new Padding(4, 3, 4, 3);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(274, 27);
            textBox_Username.TabIndex = 2;
            // 
            // label_Login
            // 
            label_Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Login.AutoSize = true;
            label_Login.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Login.ForeColor = Color.Black;
            label_Login.Location = new Point(155, 138);
            label_Login.Margin = new Padding(4, 0, 4, 0);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(70, 23);
            label_Login.TabIndex = 3;
            label_Login.Text = "LOGIN";
            label_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Username
            // 
            label_Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label_Username.ForeColor = Color.Black;
            label_Username.Location = new Point(54, 200);
            label_Username.Margin = new Padding(4, 0, 4, 0);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(199, 19);
            label_Username.TabIndex = 4;
            label_Username.Text = "Enter your username";
            label_Username.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_Password
            // 
            label_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label_Password.ForeColor = Color.Black;
            label_Password.Location = new Point(54, 264);
            label_Password.Margin = new Padding(4, 0, 4, 0);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(199, 19);
            label_Password.TabIndex = 6;
            label_Password.Text = "Enter your password";
            label_Password.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_Password.Location = new Point(58, 284);
            textBox_Password.Margin = new Padding(4, 3, 4, 3);
            textBox_Password.MaxLength = 50;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(274, 27);
            textBox_Password.TabIndex = 5;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // checkBox_Passwordshow
            // 
            checkBox_Passwordshow.AutoSize = true;
            checkBox_Passwordshow.BackColor = Color.Transparent;
            checkBox_Passwordshow.Font = new Font("Lucida Sans Typewriter", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox_Passwordshow.Location = new Point(58, 314);
            checkBox_Passwordshow.Margin = new Padding(4, 3, 4, 3);
            checkBox_Passwordshow.Name = "checkBox_Passwordshow";
            checkBox_Passwordshow.Size = new Size(133, 20);
            checkBox_Passwordshow.TabIndex = 8;
            checkBox_Passwordshow.Text = "Show password";
            checkBox_Passwordshow.UseVisualStyleBackColor = false;
            checkBox_Passwordshow.CheckedChanged += checkBox_Passwordshow_CheckedChanged;
            // 
            // button_CloseForm
            // 
            button_CloseForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_CloseForm.BackColor = Color.Transparent;
            button_CloseForm.FlatStyle = FlatStyle.Flat;
            button_CloseForm.Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_CloseForm.ForeColor = Color.DarkRed;
            button_CloseForm.Location = new Point(352, 12);
            button_CloseForm.Margin = new Padding(4, 3, 4, 3);
            button_CloseForm.Name = "button_CloseForm";
            button_CloseForm.Size = new Size(32, 25);
            button_CloseForm.TabIndex = 9;
            button_CloseForm.Text = "X";
            button_CloseForm.UseVisualStyleBackColor = false;
            button_CloseForm.Click += button_CloseForm_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(398, 454);
            Controls.Add(button_CloseForm);
            Controls.Add(checkBox_Passwordshow);
            Controls.Add(label_Password);
            Controls.Add(textBox_Password);
            Controls.Add(label_Username);
            Controls.Add(label_Login);
            Controls.Add(textBox_Username);
            Controls.Add(button_Login);
            Controls.Add(label_Name);
            Font = new Font("Lucida Sans Typewriter", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private Button button_CloseForm;
        private Label label_Name;
        private Label label_Login;
        private Label label_Username;
        private Label label_Password;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private CheckBox checkBox_Passwordshow;
    }
}