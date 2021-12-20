namespace Filmoteka
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Логин = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Passbutton = new System.Windows.Forms.Button();
            this.Registratebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(124, 137);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(295, 38);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(124, 238);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = 'Х';
            this.PasswordBox.Size = new System.Drawing.Size(295, 38);
            this.PasswordBox.TabIndex = 2;
            // 
            // Логин
            // 
            this.Логин.AutoSize = true;
            this.Логин.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.Location = new System.Drawing.Point(5, 137);
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(93, 32);
            this.Логин.TabIndex = 3;
            this.Логин.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Passbutton
            // 
            this.Passbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passbutton.Location = new System.Drawing.Point(103, 324);
            this.Passbutton.Name = "Passbutton";
            this.Passbutton.Size = new System.Drawing.Size(227, 57);
            this.Passbutton.TabIndex = 5;
            this.Passbutton.Text = "Войти";
            this.Passbutton.UseVisualStyleBackColor = true;
            this.Passbutton.Click += new System.EventHandler(this.Passbutton_Click);
            // 
            // Registratebutton
            // 
            this.Registratebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registratebutton.Location = new System.Drawing.Point(103, 399);
            this.Registratebutton.Name = "Registratebutton";
            this.Registratebutton.Size = new System.Drawing.Size(227, 39);
            this.Registratebutton.TabIndex = 6;
            this.Registratebutton.Text = "Регистрация";
            this.Registratebutton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.Registratebutton);
            this.Controls.Add(this.Passbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Логин);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Логин;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Passbutton;
        private System.Windows.Forms.Button Registratebutton;
    }
}