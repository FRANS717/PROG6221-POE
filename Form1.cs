using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROG6221_V1
{
    public partial class Form1 : Form
    {
        private ChatbotEngine? bot;

        private Label? lblTitle;
        private Label? lblSubtitle;
        private Label? lblName;
        private TextBox? txtName;
        private Button? btnStart;
        private RichTextBox? rtbChat;
        private TextBox? txtInput;
        private Button? btnSend;

        public Form1()
        {
            InitializeComponent();
            BuildInterface();
        }

        private void BuildInterface()
        {
            Text = "Cyber Shield - Matrix Mode";
            Size = new Size(940, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            lblTitle = new Label();
            lblTitle.Text = "CYBER SHIELD";
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Font = new Font("Consolas", 28, FontStyle.Bold);
            lblTitle.Location = new Point(35, 20);
            lblTitle.AutoSize = true;
            Controls.Add(lblTitle);

            lblSubtitle = new Label();
            lblSubtitle.Text = "Matrix Security Awareness Terminal";
            lblSubtitle.ForeColor = Color.FromArgb(80, 255, 120);
            lblSubtitle.Font = new Font("Consolas", 10, FontStyle.Regular);
            lblSubtitle.Location = new Point(40, 72);
            lblSubtitle.AutoSize = true;
            Controls.Add(lblSubtitle);

            lblName = new Label();
            lblName.Text = "USER";
            lblName.ForeColor = Color.Lime;
            lblName.Font = new Font("Consolas", 10, FontStyle.Bold);
            lblName.Location = new Point(40, 112);
            lblName.AutoSize = true;
            Controls.Add(lblName);

            txtName = new TextBox();
            txtName.Location = new Point(105, 108);
            txtName.Size = new Size(285, 35);
            txtName.Font = new Font("Consolas", 11);
            txtName.BackColor = Color.FromArgb(5, 20, 5);
            txtName.ForeColor = Color.Gray;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Text = "Enter your name...";

            txtName.Enter += (s, e) =>
            {
                if (txtName.Text == "Enter your name...")
                {
                    txtName.Text = "";
                    txtName.ForeColor = Color.Lime;
                }
            };

            txtName.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    txtName.Text = "Enter your name...";
                    txtName.ForeColor = Color.Gray;
                }
            };

            Controls.Add(txtName);

            btnStart = new Button();
            btnStart.Text = "INITIALIZE";
            btnStart.Location = new Point(410, 105);
            btnStart.Size = new Size(150, 42);
            btnStart.BackColor = Color.FromArgb(15, 45, 15);
            btnStart.ForeColor = Color.Lime;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderColor = Color.Lime;
            btnStart.FlatAppearance.BorderSize = 1;
            btnStart.Font = new Font("Consolas", 10, FontStyle.Bold);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Click += BtnStart_Click;
            Controls.Add(btnStart);

            rtbChat = new RichTextBox();
            rtbChat.Location = new Point(40, 170);
            rtbChat.Size = new Size(850, 390);
            rtbChat.ReadOnly = true;
            rtbChat.BackColor = Color.FromArgb(0, 10, 0);
            rtbChat.ForeColor = Color.Lime;
            rtbChat.BorderStyle = BorderStyle.FixedSingle;
            rtbChat.Font = new Font("Consolas", 10);
            Controls.Add(rtbChat);

            txtInput = new TextBox();
            txtInput.Location = new Point(40, 590);
            txtInput.Size = new Size(690, 40);
            txtInput.Font = new Font("Consolas", 11);
            txtInput.BackColor = Color.FromArgb(5, 20, 5);
            txtInput.ForeColor = Color.Lime;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Enabled = false;
            txtInput.KeyDown += TxtInput_KeyDown;
            Controls.Add(txtInput);

            btnSend = new Button();
            btnSend.Text = "SEND";
            btnSend.Location = new Point(750, 586);
            btnSend.Size = new Size(140, 42);
            btnSend.BackColor = Color.FromArgb(15, 45, 15);
            btnSend.ForeColor = Color.Lime;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.FlatAppearance.BorderColor = Color.Lime;
            btnSend.FlatAppearance.BorderSize = 1;
            btnSend.Font = new Font("Consolas", 10, FontStyle.Bold);
            btnSend.Cursor = Cursors.Hand;
            btnSend.Enabled = false;
            btnSend.Click += BtnSend_Click;
            Controls.Add(btnSend);
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            string name = txtName!.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || name == "Enter your name...")
                name = "Friend";

            bot = new ChatbotEngine(name);

            rtbChat!.Clear();

            AddBotMessage(bot.GetAsciiArt());
            AddBotMessage("Access granted. Welcome, " + name + ".");
            AddBotMessage("Ask about phishing, passwords, safe browsing, scams, privacy, or 2FA.");
            AddBotMessage("Try: 'I am worried about scams', 'I am interested in privacy', or 'tell me more'.");

            AudioPlayer.PlayGreeting("Audio.wav");

            txtInput!.Enabled = true;
            btnSend!.Enabled = true;
            txtInput.Focus();
        }

        private void BtnSend_Click(object? sender, EventArgs e)
        {
            ProcessUserInput();
        }

        private void TxtInput_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessUserInput();
                e.SuppressKeyPress = true;
            }
        }

        private void ProcessUserInput()
        {
            if (bot == null)
            {
                MessageBox.Show("Initialize the system first.");
                return;
            }

            string userInput = txtInput!.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                AddBotMessage("Input required.");
                return;
            }

            AddUserMessage(userInput);

            string response = bot.GetResponse(userInput);

            AddBotMessage(response);

            txtInput.Clear();
            txtInput.Focus();
        }

        private void AddUserMessage(string message)
        {
            rtbChat!.SelectionColor = Color.FromArgb(120, 255, 120);
            rtbChat.AppendText("USER > " + message + Environment.NewLine + Environment.NewLine);
            rtbChat.SelectionColor = Color.Lime;
        }

        private void AddBotMessage(string message)
        {
            rtbChat!.SelectionColor = Color.Lime;
            rtbChat.AppendText("SYSTEM > " + message + Environment.NewLine + Environment.NewLine);
            rtbChat.SelectionColor = Color.Lime;
            rtbChat.ScrollToCaret();
        }
    }
}