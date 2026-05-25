# Cybersecurity Awareness Chatbot

##  Project Overview

The **Cybersecurity Awareness Chatbot** is a C# application developed to educate users about cybersecurity threats and safe online practices. The chatbot provides interactive guidance on phishing, password protection, safe browsing, and general cybersecurity awareness.

The application includes:

* A console-based chatbot experience
* Audio greeting functionality
* Interactive menus and responses
* Typing effects and colored console UI
* Cybersecurity educational content
* Windows Forms integration

This project was developed using Object-Oriented Programming principles in C#.

---

# Features

## Cybersecurity Education

The chatbot helps users understand:

* Phishing attacks
* Password security
* Safe browsing practices
* Multi-factor authentication (MFA)
* Public Wi-Fi safety
* Fake websites and scams

---

## Interactive Chatbot

Users can:

* Ask cybersecurity-related questions
* Navigate through topic menus
* Receive instant responses
* Interact with a personalized chatbot experience

---

## Audio Greeting

The chatbot supports WAV audio playback:

* Plays a welcome greeting on startup
* Checks if the audio file exists
* Handles playback errors gracefully
* Supports Windows platforms

---

## User Interface Features

* ASCII Art welcome banner
* Colored console output
* Typing animation effect
* Easy-to-use menu navigation
* Windows Forms support

---

# Topics Covered

## Phishing Awareness

The chatbot explains:

* What phishing is
* How to spot phishing emails
* Phishing red flags
* Smishing and vishing
* What to do after clicking a phishing link

---

## Password Safety

Users can learn about:

* Creating strong passwords
* Password managers
* Two-factor authentication (2FA)
* Multi-factor authentication (MFA)
* Common password mistakes

---

## Safe Browsing

The chatbot teaches users:

* How to identify secure websites
* HTTPS security
* Public Wi-Fi safety
* Browser security practices
* How to avoid fake websites

---

# Technologies Used

* **C#**
* **.NET Framework / .NET**
* **Windows Forms**
* **Console Application Development**
* **Object-Oriented Programming (OOP)**
* `System.Media.SoundPlayer`

---

# Project Structure

```bash
PROG6221 V1/
│
├── Program.cs                # Main entry point
├── Chatbot.cs                # Chatbot interaction logic
├── ChatbotEngine.cs          # Chatbot processing engine
├── AudioPlayer.cs            # WAV audio playback
├── ConsoleHelper.cs          # Console styling utilities
├── Ascii.cs                  # ASCII art display
├── Form1.cs                  # Windows Forms UI
├── Form1.Designer.cs         # Windows Forms designer
├── Audio.wav                 # Greeting audio file
```

---

# How to Run the Project

## 1. Clone the Repository

```bash
git clone https:https://github.com/FRANS717/PROG6221-POE.git
```

---

## 2. Open the Project

Open the solution/project in:

* Visual Studio 2022 or later

---

## 3. Configure the Audio File

Ensure the `Audio.wav` file exists in the correct directory.

Example:

```csharp
string audioFilePath = @"C:\Users\YourName\Desktop\Audio.wav";
```

---

## 4. Run the Application

Press:

* `F5` in Visual Studio

OR run using:

```bash
dotnet run
```

---

# Example Menu

```text
1. Ask about Phishing
2. Ask about Password Safety
3. Ask about Safe Browsing
4. General Questions
5. Exit
```

---

# Important Notes

* Audio playback currently works on Windows systems.
* Ensure the WAV file path is correct.
* The chatbot uses keyword matching for responses.
* Internet access is not required to use the chatbot.

---

# Future Improvements

Possible future upgrades include:

* AI/NLP integration
* Database storage for conversations
* Web-based chatbot version
* More cybersecurity topics
* Voice recognition support
* Mobile application version

---

# Educational Purpose

This chatbot was developed as part of a cybersecurity awareness and programming project to promote safe online behavior and improve cybersecurity knowledge.

---

# Developer

Developed using C# and .NET technologies.

---

# License

This project is open-source and available under the MIT License.

---

# Cybersecurity Reminder

> “Think before you click. Stay safe online(# LIMIT).”
