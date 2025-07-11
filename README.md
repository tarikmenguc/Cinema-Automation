🎬 Cinema Automation (C#)
🔹 Overview
A desktop-based application developed in C# to automate key processes at a movie theater, including film scheduling, ticket sales, seat assignment, and reporting.

📌 Features
Manage Movies: Add, edit, delete movie listings and showtimes.

Ticket Sales Workflow: Reserve seats, select showtimes, process transactions.

Seat Management: View current seat availability in real-time and assign seats automatically or manually.

Reports Module: Generate end-of-day reports for sales, occupancy, and revenue analysis.

🛠️ Technologies & Tools
Language: C# (.NET Framework or .NET Core)

UI Framework: Windows Forms (or WPF if applicable)

Data Storage: Local database (like SQL Server LocalDB or SQLite)

Architecture Patterns: Followed MVC or layered architecture for maintainability

🚀 Installation & Setup
Clone the repository:

bash
Kopyala
Düzenle
git clone https://github.com/tarikmenguc/Cinema-Automation.git
Open the solution file (.sln) in Visual Studio.

Restore any NuGet packages.

Ensure the database connection string is correctly set in app.config (or appsettings.json).

Build (F6) and Run (F5).

🧪 Usage Guide
Upon launch, you'll see the main dashboard with options: Movies, Showtimes, Seats, and Reports.

Navigate to Movies to add or modify film entries and schedules.

Go to Showtimes to assign film times to different halls.

Use Seat Selection to pick seats during ticket sale.

Visit Reports to export details such as:

Tickets sold (daily/monthly)

Revenue figures

Seat occupancy rates

🗂️ Project Structure
mathematica
Kopyala
Düzenle
/CinemaAutomation
  /UI               – Windows Forms or WPF screens
  /Models           – C# classes for Movie, Showtime, Ticket, Seat
  /DataAccess       – Database CRUD operations
  /Reports          – Report generation logic (e.g., CSV, PDF if implemented)
  Program.cs        – Entry point
  CinemaAutomation.sln
✅ How to Contribute
Contributions are welcome! Feel free to:

Add features (e.g., user authentication, seat map printing)

Improve error handling and data validation

Refactor code for better design (e.g., using MVVM)

Write unit tests
Fork the repo, create a feature branch, and submit a pull request.

