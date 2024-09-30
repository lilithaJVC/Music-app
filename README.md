![wiz](https://github.com/user-attachments/assets/ec6a29ea-fcfd-4775-a31d-bc0d6e0fd34a)

<div style="text-align: center;">
    <h1>QuizWiz - A Quiz App with API Integration</h1>
</div>

<ul><li><strong>Description:</strong></li></ul>
<p>QuizWiz is a dynamic mobile quiz application that allows users to play quizzes across various categories. It utilizes an API to store user data, fetch questions, and track user performance in real-time. The app supports both single and group play modes, with the group play mode being implemented in the final POE. This application provides AI-generated explanations.</p>

<ul><li><strong style="font-size: 20px;">Key Features:</strong></li></ul>
<p>Feature 1 - Our first key feature of the app is the creation of various categories along with several questions attached to each. We have selected 6 different categories to suit a range of users, each category has up to 10 questions which will be displayed to the user during the quiz. The question types range from Multiple Choice, with three options for each question, to True or False.</p>

<p>Feature 2 - The second feature is our Game Mode. The game mode entails the ability for the user to play our game. Once they select a category the user will be able to play the game by answering the multiple choice questions or the true or false questions. They will be answered with reactive emojis and correct or incorrect prompts.</p>

<p>Feature 2 - Our third feature is a Results page whereby the user is displayed their total along with a list of all the questions they were asked. They then can select a question and will be taken to a different page where the AI Gemini will give them an in-depth explanation of the questions answer.</p>

<ul><li><strong style="font-size: 20px;">Functional Requirements:</strong></li></ul>




<p>The registration and login functionality in QuizWiz is powered by Firebase Authentication. Firebase handles user authentication, which allows users to securely create accounts, log in, and access their personalized data.</p>

<p>When users register, they are prompted to provide their name, email, and password, then click the signup button. Once the user is registered, they can log in to the application by providing their email and the registered password.</p>



![login](https://github.com/user-attachments/assets/13e8e227-e253-4009-9ba4-a349b085c459)
![register1](https://github.com/user-attachments/assets/6c49e2bc-73f8-4274-9eff-abee873683f6)





 
  <li>allow users to select from 6 different categories from the dashboard: Animals, Disney, Music, History, Food, TV Shows.</li>

 
![dasgboard1](https://github.com/user-attachments/assets/baf8c3e9-11d8-4336-b69c-e30f0dce8a58)





  <li>Our quiz templates include: multiple choice and true/false questions.</li>
  
![trueorfalsetemplate1](https://github.com/user-attachments/assets/feb4bfae-5aae-4f38-82da-6b57ff68c256)
![mutlichoicetemplate1](https://github.com/user-attachments/assets/ac7bab55-fa77-4698-92c2-5bfea7e92d8e)

  
  <li>Real-time quiz data fetching and submission using an API.</li>
  <li>We also implemented an app settings page.</li>
  <li>These settings include profile settings, game settings, help and support, as well as the "About" section.</li>
  <li>When the user clicks the help and support button, they will be redirected to a page where they can ask questions related to the app and provide feedback on their experience.</li>
  <li>When the user clicks the game settings button, they will be redirected to the game settings page where they can customize their game settings, including turning notifications on or off, toggling music and sound, and switching between light and dark modes.</li>
  <li>when the user clicks on the about button  they wil be redirected to the about gage and read what this application is and its privacy policy. </li>

![about12](https://github.com/user-attachments/assets/823ff8c7-b654-4f24-869b-ae009b5d47cd)
![gamesettings1](https://github.com/user-attachments/assets/31019095-7c59-48f8-8bec-c01cfeb51098)
![helpandsupport1](https://github.com/user-attachments/assets/d8cc58cc-20f0-42f6-a229-22aab95dd0ab)
![settings1](https://github.com/user-attachments/assets/d16e8ba7-2b47-42a4-be08-72ac3b623452)



  
  <li>The game also has a results page where users can view their scores on the quizzes they have taken. As well as view all the questions of the quiz they just completed.</li>
  <li>We have integrated AI/Gemini, allowing users to select the  questions and receive AI-generated answers displayed in the app.</li>
  
  ![results1](https://github.com/user-attachments/assets/c53a47f0-10fe-4857-9f6c-0808211d9996)
![toolbarMenu1](https://github.com/user-attachments/assets/f661d8a2-3dc0-45ea-a08e-310d388a1bb0)

</ul>
<p> </p>
<ul><li><strong style="font-size: 20px;">Non-Functional Requirements:</strong></li></ul>
<p>Security: We have implemented Single Sign-On (SSO) and used Firebase for authentication to secure the login process</p>
<p>security: we have Used JWT JSON web token for session management, with encrypted data storage and transmission.</p>
<p>Usability: our application Provides an intuitive and user-friendly interface.</p>
<p>Usability: our application Provides instructions when the quiz loads on how to play the game.</p>
<p>Performance: we have ensured that the app is able Load quiz questions within 3 seconds.</p>

<ul><li><strong>Usage:</strong></li></ul>
<p>Upon opening the application you will briefly see a splash screen without apps logo, thereafter you will be taken to our Login page. If you do not already have an account simply click the signup button and you will be redirected to the signup page. Once in the signup page you will be required to enter information such as your name, email address and password. Alternatively, you can select the “Google” button and sign up using your google account. 

If you do already have an account you will remain on the Login and enter your email and password to login or alternatively, you can use the google button to login. 

Once logged in you will be redirected to our colourful Dashboard. This dashboard contains all the possible categories that you can select. Once you select a category you will be taken to the game. 

The game consists of either Multiple Choice or True or False questions. Regardless of your choice you will select the answer and then select the “next” button to proceed to the next question. You will also be told whether your selection is right or wrong.

Once the game is finished, you will be redirected to our Results page. This page will display your score as well as display all the questions you were asked throughout the quiz. If you select a question, you will be taken to a page that uses the AI Gemini to give you an in depth explanation of the question. 

Throughout the app you will see a menu located at the top of the screen, this menu has several options: 
•⁠  ⁠About: this will take you to a page that explains a little bit about our app.
•⁠  ⁠Settings: This will take you to the settings page which contains all the options mentioned in this list. 
•⁠  ⁠Help Support: This allows users to request help if they are having any issues related to the app or their account.
•⁠  Profile: This section displays your profile data such as name and email (icons to be developed in later release)
•⁠  Dashboard: This button will simply redirect you back to the dashboard.
•⁠  Logout: The ability to logout of the app.
</p>

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

<ul><strong>Hosting:</strong></ul>
<ul>
  <li>We hosted the application on azure .</li>
  <li>We created an API App on the azure platform, the API project (Visual Studio) is hosted in the API app on azure  </li>
     <li>we used the API app link in the retrofit client to connect the client to the API  </li>
</ul>

<ul><strong>Demonstration Video:</strong></ul>
<ul>
 
</ul>
