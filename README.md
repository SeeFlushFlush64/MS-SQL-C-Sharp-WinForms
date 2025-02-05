# MS-SQL C# WinForms Projects

These are my Windows Forms apps that utilize Microsoft SQL.

## Projects

### 1. **Guess The Music Artist**  
Located in the `MyTodoListApp` folder, this project is a music artist guessing game where users input the artist's name for a displayed song title.

#### Features:
- Displays a song title and prompts the user to guess the music artist.
- Takes user input and compares it with the correct artist.
- Shows different responses based on whether the guess is correct or incorrect.

#### Screenshots:

- **Initial State (Directions)**  
  This is the state of the Windows Forms when the game begins. It displays instructions for the user on how to play.

  ![guess-the-music-artist](https://github.com/user-attachments/assets/aaa345db-cca6-42c1-b534-686062407ecf)

- **Input State (User Guess)**  
  When the user is prompted to input their guess for the artist, the form includes a text box for input and a submit button to check the answer.

  ![guess-the-music-artist-no-input](https://github.com/user-attachments/assets/94f2c28a-3657-4991-acb3-f2e112c28155)

- **Incorrect Guess**  
  If the user inputs an incorrect artist name, the form displays a message prompting them to try again.

  ![guess-the-music-artist-incorrect](https://github.com/user-attachments/assets/4d82dcbc-aa14-4e45-b0ef-ec6b3974d68b)

- **Correct Guess**  
  When the user inputs the correct artist name, the form displays a confirmation message and the next song title.

  ![guess-the-music-artist-correct](https://github.com/user-attachments/assets/69cdfd54-a2f4-4c32-98c2-a885630cf314)


#### How to Run:
1. Clone the repository.
2. Open the solution file in Visual Studio.
3. Ensure that your Microsoft SQL Server database is configured correctly for this project.
4. Run the application.

#### Technologies Used:
- C#
- Microsoft SQL Server
- Windows Forms

#### Future Updates:
- Add images related to the song or artist.
- Improve UI/UX design.
- Add more levels and song categories.
