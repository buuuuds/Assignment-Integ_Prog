using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        private Panel mainPanel;
        private PictureBox avatarPictureBox;
        private Label titleLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            // Form properties
            this.Text = "Login";
            this.Size = new Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.Black;

            mainPanel = new Panel();
            mainPanel.BackColor = Color.Black;
            mainPanel.Size = new Size(320, 400);
            mainPanel.Location = new Point(28, 40);
            mainPanel.BorderStyle = BorderStyle.None;

            // Avatar PictureBox
            avatarPictureBox = new PictureBox();
            avatarPictureBox.Size = new Size(80, 80);
            avatarPictureBox.Location = new Point(120, 30);
            avatarPictureBox.BackColor = Color.Green;
            avatarPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            
            // Create a simple avatar using graphics
            Bitmap avatarBitmap = new Bitmap(80, 80);
            using (Graphics g = Graphics.FromImage(avatarBitmap))
            {
                g.Clear(Color.FromArgb(255, 152, 0));
                g.FillEllipse(new SolidBrush(Color.FromArgb(139, 69, 19)), 20, 15, 40, 30); // Hair
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, 220, 177)), 25, 25, 30, 30); // Face
                g.FillEllipse(new SolidBrush(Color.Black), 30, 35, 4, 4); // Left eye
                g.FillEllipse(new SolidBrush(Color.Black), 46, 35, 4, 4); // Right eye
                g.FillRectangle(new SolidBrush(Color.FromArgb(139, 69, 19)), 25, 50, 30, 15); // Beard
            }
            avatarPictureBox.Image = avatarBitmap;

            // Title label
            titleLabel = new Label();
            titleLabel.Text = "Login";
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(139, 69, 19);
            titleLabel.Location = new Point(130, 120);
            titleLabel.Size = new Size(60, 30);

            // Email label
            emailLabel = new Label();
            emailLabel.Text = "Email";
            emailLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(40, 170);
            emailLabel.Size = new Size(50, 20);

            // Email textbox
            emailTextBox = new TextBox();
            emailTextBox.Font = new Font("Arial", 10);
            emailTextBox.Location = new Point(40, 195);
            emailTextBox.Size = new Size(240, 30);
            emailTextBox.BackColor = Color.White;
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Padding = new Padding(10);

            // Password label
            passwordLabel = new Label();
            passwordLabel.Text = "Pasword";
            passwordLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(40, 240);
            passwordLabel.Size = new Size(70, 20);

            // Password textbox
            passwordTextBox = new TextBox();
            passwordTextBox.Font = new Font("Arial", 10);
            passwordTextBox.Location = new Point(40, 265);
            passwordTextBox.Size = new Size(240, 30);
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Padding = new Padding(10);
            passwordTextBox.UseSystemPasswordChar = true;

            // Login button
            loginButton = new Button();
            loginButton.Text = "Log In";
            loginButton.Font = new Font("Arial", 12, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.BackColor = Color.Green;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Location = new Point(40, 320);
            loginButton.Size = new Size(240, 40);
            loginButton.Click += LoginButton_Click;

            // Add controls to main panel
            mainPanel.Controls.Add(avatarPictureBox);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(emailLabel);
            mainPanel.Controls.Add(emailTextBox);
            mainPanel.Controls.Add(passwordLabel);
            mainPanel.Controls.Add(passwordTextBox);
            mainPanel.Controls.Add(loginButton);

            // Add main panel to form
            this.Controls.Add(mainPanel);

            this.ResumeLayout(false);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Static validation
            if (username == "admin" && password == "1234")
            {
                // Hide current form and show Form2
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}