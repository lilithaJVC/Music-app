![wiz](https://github.com/user-attachments/assets/ec6a29ea-fcfd-4775-a31d-bc0d6e0fd34a)

<div style="text-align: center;">
    <h1>QuizWiz - A Quiz App with API Integration</h1>
</div>

<ul><li><strong>Description:</strong></li></ul>
<p>QuizWiz is a dynamic mobile quiz application that allows users to play quizzes across various categories. It utilizes an API to store user data, fetch questions, and track user performance in real-time. The app supports both single and group play modes, with the group play mode being implemented in the final POE. This application provides AI-generated explanations.</p>

<ul><li><strong style="font-size: 20px;">Functional Requirements:</strong></li></ul>
<p>The registration and login functionality in QuizWiz is powered by the Visual Studio API. The API handles user authentication, which allows users to securely create accounts, log in, and access their personalized data.</p>

<p>When users register, they are prompted to provide their name, email, and password, then click the signup button. Once the user is registered, they can log in to the application by providing their email and the registered password.</p>

<ul>
    ![playerselection](https://github.com/user-attachments/assets/0914cc6b-404c-4922-82c1-7e1c9035de86)

  <li>allow users to select between single-player and multi-player modes.</li>
  <li>allow users to select from 6 different categories from the dashboard: Animals, Disney, Music, History, Food, TV Shows.</li>
  <li>Our quiz templates include: multiple choice and true/false questions.</li>
  <li>Real-time quiz data fetching and submission using an API.</li>
  <li>We also implemented an app settings page.</li>
  <li>These settings include profile settings, game settings, help and support, as well as the "About" section.</li>
  <li>When the user clicks the help and support button, they will be redirected to a page where they can ask questions related to the app and provide feedback on their experience.</li>
  <li>When the user clicks the game settings button, they will be redirected to the game settings page where they can customize their game settings, including turning notifications on or off, toggling music and sound, and switching between light and dark modes.</li>
  <li>The game also has a results page where users can view their scores on the quizzes they have taken.</li>
  <li>We have integrated AI/Gemini, allowing users to ask questions and receive AI-generated answers displayed in the app.</li>
</ul>

<ul><li><strong style="font-size: 20px;">Non-Functional Requirements:</strong></li></ul>
<p>Security: We have implemented Single Sign-On (SSO) and used Firebase for authentication to secure the login process</p>
<p>security: we have Used JWT JSON web token for session management, with encrypted data storage and transmission.</p>
<p>Usability: our application Provides an intuitive and user-friendly interface.</p>
<p>Performance: we have ensured that the app is able Load quiz questions within 3 seconds.</p>

<ul><li><strong>Technology Used:</strong></li></ul>
<p>QuizWiz follows a client-server architecture where the Android app (client) communicates with the backend API (server) to fetch quiz data, manage user accounts, and store results. Here’s an overview of the architecture:</p>

<ul><strong>Frontend: Android Studio Application</strong></ul>
<ul>
  <li>Built with Android Studio using Java/Kotlin.</li>
  <li>The app provides a user interface to interact with quizzes, show questions, submit answers, and display performance.</li>
  <li>The app sends and receives data from the backend API using HTTP requests, handled through Retrofit.</li>
  <li>User interactions like registration, login, quiz selection, and quiz submission are facilitated by API requests.</li>
</ul>

<ul><strong>Backend: ASP.NET Core in Visual Studio</strong></ul>
<ul>
  <li>Provides RESTful API endpoints for user registration, login, and fetching quizzes.</li>
  <li>Handles user authentication, quiz logic, and secure communication between the app and the database.</li>
  <li>Uses JWT (JSON Web Token) for secure session management, allowing only authenticated users to interact with the quiz system.</li>
</ul>

<ul><strong>Database: Cloud Firestore</strong></ul>
<ul>
  <li>Cloud Firestore is the NoSQL database used to store and retrieve user data and quiz content.</li>
  <li>Cloud Firestore is integrated into the backend API, where the server communicates with the database to store and fetch data.</li>
</ul>

<ul><strong>Data Structure (Cloud Firestore):</strong></ul>
<ul>
  <li>Users Collection: Stores user profile information such as username, email, password.</li>
  <li>Quiz Collection: Stores quiz questions, options, answers, and categories.</li>
</ul>
