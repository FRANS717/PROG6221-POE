# 🔐 Cybersecurity Awareness Chatbot

## 📌 Overview

The **Cybersecurity Awareness Chatbot** is a C# console-based application designed to educate users about online safety. It provides interactive responses on key cybersecurity topics such as phishing, password security, and safe browsing.

The chatbot is user-friendly, personalized, and includes optional audio greetings to enhance the user experience.

---

## 🚀 Features

### ✅ Core Functionality

* Interactive chatbot with menu-driven navigation
* Personalized user experience (asks for user name)
* Real-time responses with typing effect
* Console-based UI with colored text

### 🔒 Cybersecurity Topics Covered

* **Phishing Awareness**

  * What phishing is
  * How to detect phishing emails
  * What to do if attacked
* **Password Safety**

  * Strong password creation
  * Two-Factor Authentication (2FA)
  * Password managers
* **Safe Browsing**

  * Identifying secure websites
  * Avoiding fake websites
  * Public Wi-Fi safety

### 🔊 Additional Features

* Plays a **WAV audio greeting** on startup
* ASCII art welcome screen
* Error handling for missing audio files
* Cross-platform check for audio support

---

## 🛠️ Technologies Used

* **C# (.NET)**
* Console Application
* `System.Media.SoundPlayer` for audio playback
* Object-Oriented Programming (OOP)

---

## 📂 Project Structure

```
PROG6221_V1/
│
├── Program.cs        # Entry point of the application
├── Chatbot.cs        # Main chatbot logic and responses
├── AudioPlayer.cs    # Handles audio playback
├── (Helper Classes)  # ConsoleHelper, AsciiArt (if included)
```

---

## ▶️ How to Run

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/cybersecurity-chatbot.git
cd cybersecurity-chatbot
```

### 2. Open in IDE

* Open the project in **Visual Studio** or any C# compatible IDE

### 3. Add Audio File (Optional)

* Place a `.wav` file in your project directory
* Update the file path in `Program.cs`:

```csharp
string audioFilePath = @"C:\path\to\your\Audio.wav";
```

### 4. Run the Program

* Press **Start (F5)** in Visual Studio
  or

```bash
dotnet run
```

---

## 💡 Example Usage

```
Welcome back, John!
Please select an option:

1. Ask about Phishing
2. Ask about Password Safety
3. Ask about Safe Browsing
4. General Questions
5. Exit
```

---

## ⚠️ Notes

* Audio playback works **only on Windows**
* Ensure the `.wav` file exists, otherwise playback will be skipped
* The chatbot uses keyword matching (not AI-based NLP)

---

## 📈 Future Improvements

* Add GUI (Windows Forms or Web App)
* Integrate real AI/NLP (e.g., API-based chatbot)
* Store user interaction history
* Expand cybersecurity topics

---

## 👨‍💻 Author

Developed as part of a cybersecurity awareness project.

---

## 📜 License

This project is open-source and available under the **MIT License**.

---

## 🌍 Stay Safe Online!

> "Cybersecurity is not just about technology — it's about awareness."
