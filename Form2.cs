using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form2 : Form
    {
        private Label titleLabel;
        private Label subtitleLabel;
        private PictureBox profilePictureBox;
        private Label nameLabel;
        private Label roleLabel;
        private Panel bioPanel;
        private Panel detailsPanel;
        private Panel socialPanel;
        private Panel credentialsPanel;
        private Button logoutButton;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            // Form properties
            this.Text = "Profile";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(45, 45, 45);

            // Title
            titleLabel = new Label();
            titleLabel.Text = "My Profile";
            titleLabel.Font = new Font("Arial", 20, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(30, 20);
            titleLabel.Size = new Size(100, 30);

            // Profile Picture
            profilePictureBox = new PictureBox();
            profilePictureBox.Size = new Size(120, 120);
            profilePictureBox.Location = new Point(50, 100);
            profilePictureBox.BackColor = Color.FromArgb(70, 130, 180);
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.Image = Image.FromFile("C:\\Users\\milla\\OneDrive\\Desktop\\School Works\\CODES\\Integ_Prog\\Assignment\\Image\\profile.jpg");

            // Name
            nameLabel = new Label();
            nameLabel.Text = "Rudy Esperida Jr.";
            nameLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(50, 240);
            nameLabel.Size = new Size(200, 25);

            // Role
            roleLabel = new Label();
            roleLabel.Text = "Network Engineer";
            roleLabel.Font = new Font("Arial", 10);
            roleLabel.ForeColor = Color.Gray;
            roleLabel.Location = new Point(50, 270);
            roleLabel.Size = new Size(100, 20);

            // Bio & Other Details Panel
            bioPanel = new Panel();
            bioPanel.Location = new Point(300, 100);
            bioPanel.Size = new Size(450, 150);
            bioPanel.BackColor = Color.FromArgb(45, 45, 45);

            CreateBioSection();

            // Details Panel
            detailsPanel = new Panel();
            detailsPanel.Location = new Point(300, 270);
            detailsPanel.Size = new Size(450, 100);
            detailsPanel.BackColor = Color.FromArgb(45, 45, 45);

            CreateDetailsSection();

            // Social Media Panel
            socialPanel = new Panel();
            socialPanel.Location = new Point(50, 320);
            socialPanel.Size = new Size(200, 50);
            socialPanel.BackColor = Color.FromArgb(45, 45, 45);

            CreateSocialSection();

            // Sample Credentials Panel
            credentialsPanel = new Panel();
            credentialsPanel.Location = new Point(50, 390);
            credentialsPanel.Size = new Size(700, 120);
            credentialsPanel.BackColor = Color.FromArgb(55, 55, 55);
            credentialsPanel.BorderStyle = BorderStyle.FixedSingle;

            CreateCredentialsSection();

            // Logout button
            logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Font = new Font("Arial", 10, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.BackColor = Color.FromArgb(220, 53, 69);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.Location = new Point(650, 530);
            logoutButton.Size = new Size(100, 30);
            logoutButton.Click += LogoutButton_Click;

            // Add controls to form
            this.Controls.Add(titleLabel);
            this.Controls.Add(subtitleLabel);
            this.Controls.Add(profilePictureBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(roleLabel);
            this.Controls.Add(bioPanel);
            this.Controls.Add(detailsPanel);
            this.Controls.Add(socialPanel);
            this.Controls.Add(credentialsPanel);
            this.Controls.Add(logoutButton);

            this.ResumeLayout(false);
        }

        private void CreateBioSection()
        {
            Label bioTitleLabel = new Label();
            bioTitleLabel.Text = "Bio & other details";
            bioTitleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            bioTitleLabel.ForeColor = Color.White;
            bioTitleLabel.Location = new Point(0, 0);
            bioTitleLabel.Size = new Size(200, 20);

            Label bioTextLabel = new Label();
            bioTextLabel.Text = "I am an aspiring Network Engineer with a strong foundation in networking concepts and hands-on" +
                    " experience from academic and personal projects. I’m passionate about building secure, reliable" +
                    " networks and eager to grow in the IT infrastructure field.";
            bioTextLabel.Font = new Font("Arial", 9);
            bioTextLabel.ForeColor = Color.Gray;
            bioTextLabel.Location = new Point(0, 30);
            bioTextLabel.Size = new Size(400, 80);

            Label skillsLabel = new Label();
            skillsLabel.Text = "Skills: TCP/IP, Routing & Switching, Cisco IOS, VLANs, Subnetting,\n" +
                   "Wireshark, Network Troubleshooting, Linux Networking, CCNA Fundamentals";
            skillsLabel.Font = new Font("Arial", 9);
            skillsLabel.ForeColor = Color.FromArgb(100, 200, 100);
            skillsLabel.Location = new Point(0, 120);
            skillsLabel.Size = new Size(400, 20);

            bioPanel.Controls.Add(bioTitleLabel);
            bioPanel.Controls.Add(bioTextLabel);
            bioPanel.Controls.Add(skillsLabel);
        }

        private void CreateDetailsSection()
        {
            // Left column
            Label emailLabel = new Label();
            emailLabel.Text = "Email";
            emailLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            emailLabel.ForeColor = Color.Gray;
            emailLabel.Location = new Point(0, 0);
            emailLabel.Size = new Size(50, 15);

            Label emailValue = new Label();
            emailValue.Text = "rudyesperida@gmail.com";
            emailValue.Font = new Font("Arial", 9);
            emailValue.ForeColor = Color.White;
            emailValue.Location = new Point(0, 20);
            emailValue.Size = new Size(200, 15);

            Label locationLabel = new Label();
            locationLabel.Text = "Location";
            locationLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            locationLabel.ForeColor = Color.Gray;
            locationLabel.Location = new Point(0, 45);
            locationLabel.Size = new Size(60, 15);

            Label locationValue = new Label();
            locationValue.Text = "305, Bagong Pook Malvar, Batangas";
            locationValue.Font = new Font("Arial", 9);
            locationValue.ForeColor = Color.White;
            locationValue.Location = new Point(0, 65);
            locationValue.Size = new Size(100, 15);

            // Right column
            Label phoneLabel = new Label();
            phoneLabel.Text = "Phone";
            phoneLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            phoneLabel.ForeColor = Color.Gray;
            phoneLabel.Location = new Point(250, 0);
            phoneLabel.Size = new Size(50, 15);

            Label phoneValue = new Label();
            phoneValue.Text = "09776296352";
            phoneValue.Font = new Font("Arial", 9);
            phoneValue.ForeColor = Color.White;
            phoneValue.Location = new Point(250, 20);
            phoneValue.Size = new Size(150, 15);

            Label statusLabel = new Label();
            statusLabel.Text = "Status";
            statusLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            statusLabel.ForeColor = Color.Gray;
            statusLabel.Location = new Point(250, 45);
            statusLabel.Size = new Size(50, 15);

            Label statusValue = new Label();
            statusValue.Text = "Open to entry-level opportunities";
            statusValue.Font = new Font("Arial", 9);
            statusValue.ForeColor = Color.FromArgb(100, 200, 100);
            statusValue.Location = new Point(250, 65);
            statusValue.Size = new Size(150, 15);

            detailsPanel.Controls.Add(emailLabel);
            detailsPanel.Controls.Add(emailValue);
            detailsPanel.Controls.Add(locationLabel);
            detailsPanel.Controls.Add(locationValue);
            detailsPanel.Controls.Add(phoneLabel);
            detailsPanel.Controls.Add(phoneValue);
            detailsPanel.Controls.Add(statusLabel);
            detailsPanel.Controls.Add(statusValue);
        }

        private void CreateSocialSection()
        {
            Label socialLabel = new Label();
            socialLabel.Text = "Social Media";
            socialLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            socialLabel.ForeColor = Color.White;
            socialLabel.Location = new Point(0, 0);
            socialLabel.Size = new Size(100, 20);

            // Social media buttons (simplified as labels)
            Label githubLabel = new Label();
            githubLabel.Text = "GitHub";
            githubLabel.Font = new Font("Arial", 8);
            githubLabel.ForeColor = Color.Gray;
            githubLabel.BackColor = Color.FromArgb(30, 30, 30);
            githubLabel.TextAlign = ContentAlignment.MiddleCenter;
            githubLabel.Location = new Point(0, 25);
            githubLabel.Size = new Size(50, 20);

            Label linkedinLabel = new Label();
            linkedinLabel.Text = "LinkedIn";
            linkedinLabel.Font = new Font("Arial", 8);
            linkedinLabel.ForeColor = Color.Gray;
            linkedinLabel.BackColor = Color.FromArgb(30, 30, 30);
            linkedinLabel.TextAlign = ContentAlignment.MiddleCenter;
            linkedinLabel.Location = new Point(55, 25);
            linkedinLabel.Size = new Size(55, 20);

            Label twitterLabel = new Label();
            twitterLabel.Text = "Twitter";
            twitterLabel.Font = new Font("Arial", 8);
            twitterLabel.ForeColor = Color.Gray;
            twitterLabel.BackColor = Color.FromArgb(30, 30, 30);
            twitterLabel.TextAlign = ContentAlignment.MiddleCenter;
            twitterLabel.Location = new Point(115, 25);
            twitterLabel.Size = new Size(50, 20);

            socialPanel.Controls.Add(socialLabel);
            socialPanel.Controls.Add(githubLabel);
            socialPanel.Controls.Add(linkedinLabel);
            socialPanel.Controls.Add(twitterLabel);
        }

        private void CreateCredentialsSection()
        {
            // Title
            Label credTitleLabel = new Label();
            credTitleLabel.Text = "My Credentials – Journey to Network Engineer";
            credTitleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            credTitleLabel.ForeColor = Color.White;
            credTitleLabel.Location = new Point(20, 10);
            credTitleLabel.Size = new Size(400, 20);

            // Academic Background
            Label eduLabel = new Label();
            eduLabel.Text = "Education:";
            eduLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            eduLabel.ForeColor = Color.FromArgb(100, 200, 100);
            eduLabel.Location = new Point(20, 40);
            eduLabel.Size = new Size(80, 15);

            Label eduValue = new Label();
            eduValue.Text = "Bachelor of Science in Information Technology";
            eduValue.Font = new Font("Arial", 9);
            eduValue.ForeColor = Color.Gray;
            eduValue.Location = new Point(110, 40);
            eduValue.Size = new Size(300, 15);

            // Skills
            Label skillsLabel = new Label();
            skillsLabel.Text = "Core Skills:";
            skillsLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            skillsLabel.ForeColor = Color.FromArgb(100, 200, 100);
            skillsLabel.Location = new Point(20, 65);
            skillsLabel.Size = new Size(80, 15);

            Label skillsValue = new Label();
            skillsValue.Text = "TCP/IP, Subnetting, Cisco IOS, VLANs, Wireshark, Linux Basics";
            skillsValue.Font = new Font("Arial", 9);
            skillsValue.ForeColor = Color.Gray;
            skillsValue.Location = new Point(110, 65);
            skillsValue.Size = new Size(450, 15);

            // Projects
            Label projectsLabel = new Label();
            projectsLabel.Text = "Projects:";
            projectsLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            projectsLabel.ForeColor = Color.FromArgb(100, 200, 100);
            projectsLabel.Location = new Point(20, 90);
            projectsLabel.Size = new Size(80, 15);

            Label projectsValue = new Label();
            projectsValue.Text = "Smart Agri-Leafy Shield – IoT-based farm automation system";
            projectsValue.Font = new Font("Arial", 9);
            projectsValue.ForeColor = Color.Gray;
            projectsValue.Location = new Point(110, 90);
            projectsValue.Size = new Size(500, 15);

            // Status
            Label statusLabel = new Label();
            statusLabel.Text = "Current Status:";
            statusLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            statusLabel.ForeColor = Color.FromArgb(100, 200, 100);
            statusLabel.Location = new Point(20, 115);
            statusLabel.Size = new Size(100, 15);

            Label statusValue = new Label();
            statusValue.Text = "Actively seeking entry-level roles in networking";
            statusValue.Font = new Font("Arial", 9);
            statusValue.ForeColor = Color.Gray;
            statusValue.Location = new Point(130, 115);
            statusValue.Size = new Size(350, 15);

            // Add all to credentialsPanel
            credentialsPanel.Controls.Add(credTitleLabel);
            credentialsPanel.Controls.Add(eduLabel);
            credentialsPanel.Controls.Add(eduValue);
            credentialsPanel.Controls.Add(skillsLabel);
            credentialsPanel.Controls.Add(skillsValue);
            credentialsPanel.Controls.Add(projectsLabel);
            credentialsPanel.Controls.Add(projectsValue);
            credentialsPanel.Controls.Add(statusLabel);
            credentialsPanel.Controls.Add(statusValue);

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}