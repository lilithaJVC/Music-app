![WhatsApp_Image_2024-09-25_at_21 06 40-removebg-preview](https://github.com/user-attachments/assets/f1d6a640-60f3-47d6-8170-53345c14f2af)


<div style="text-align: center;">
    <h1>QuizWiz - A Quiz App with API Integration</h1>
</div>
<ul><li><strong>Description:</strong></li></ul>
<ul>QuizWiz is a dynamic mobile quiz  application that allows users to play quizzes across various categories. It utilizes an API to store user data, fetch questions, and track user performance in real-time. The app supports both single and group play modes,the group play mode will be later implemented in the final POE. this application provides AI-generated explanations .
</ul>

<ul>
  <li><strong style="font-size: 50px;">Functional Requirements:</strong></li>
</ul>


<ul>The registration and login functionality in QuizWiz is powered by the visual studio API. The API handles user authentication, which allows users to securely create accounts, log in, and access their personalized data.</ul>
<ul>when users register, they will be prompt to provide their name , email and password then clicking in the signup button 
<ul></ul>once the user is registered they can login to the application by providing their email and the registered password </ul>
</ul>
<ul>it allows users to select bewtween a single player and mutli-player mode 
</ul>
<ul>it allows user to select from 6 different categories, these categories inclide; Animals,Disney,Music,History,Food,TV Shows
</ul>
<ul>our quiz templates include: multiple choice and true or fasle 
</ul>
<ul>Real-time quiz data fetching and submission using API</ul>
<ul>we also implemented a app settings for the game </ul>
<ul> these settings include profile settings , game settings , help and support as well as the about </ul>
<ul>when the user clicks on the help and support button they will be redirected to the help and support page where they can ask any question related to the application and also provide feedback on their experience on using  the application  </ul>
<ul>when the user clicks on the game settings button they will be redirected to the game settings page where they can customise their game settngs by either turning  the notofication  alerts on or off, they can also turn msic and sound on or off, they also have the ability to change the theme to  light mode or dark mode </ul>
<ul>the game also have a results page where users can go and view their scores on the quizez that they took </ul>
<ul>we have also intergrated AI/Germini where users can ask the game question then the AI will generate the answers and siplay it to the user</ul>

<ul><li><strong>Non-Functional Requirements:</strong></li></ul>

<ul>security: we have implemeted SSO and used firebase for authentication to secure the login process  </ul>
<ul></ul>

<ul><li><strong>Technology used</strong> </li></ul>
<ul>QuizWiz follows a client-server architecture where the Android app (client) communicates with the backend API (server) to fetch quiz data, manage user accounts, and store results. Here’s an overview of the architecture:</ul>
<ul>Frintend: Android studio application  </ul>
<ul>-Built with **Android Studio** using **Java/Kotlin**.</ul>
<ul>-The app is responsible for providing a user interface to interact with quizzes, showing questions, submitting answers, and displaying performance.</ul>
<ul>-The app sends and receives data from the backend API using HTTP requests, handled through Retrofit.</ul>
<ul>- User interactions like registration, login, quiz selection, and quiz submission are facilitated by API requests.</ul>





