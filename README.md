# Simple Static Login Form - WinForms C#

This project is a basic Windows Forms application built using C# that demonstrates:

- A **static login form** with hardcoded credentials.
- A transition to a **profile display form** upon successful login.
- Organized layout and styling using custom colors, fonts, and basic graphics.

## 🧩 Features

### 🔐 Login Form
- User-friendly login UI with:
  - Email and Password input
  - Hardcoded credential validation
  - Custom avatar graphic using `System.Drawing`
- Valid users are:
  - `admin` / `1234`
  - Additional mock users may be displayed (guest, manager, developer)

### 👤 My Profile Form
- Displays a simple profile interface:
  - Profile picture
  - Personal bio
  - Skill set related to **Network Engineering**
  - Status/availability

## 🖼️ UI Components
- `Panel` for layout grouping
- `PictureBox` for profile and avatar images
- `Label`, `TextBox`, and `Button` for interaction
- `Graphics` to render simple avatar art (in login)
- Responsive to different screen sizes (maximized window)

## 📂 Folder Structure
