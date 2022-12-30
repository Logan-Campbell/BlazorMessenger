# LANMessenger

This is a basic chat messenger between users or into a group chat where everyone has access to 
even those not logged in.

Some of the features are:
- Group Chat for everyone
- Private chats between each user
- Persistent storage of messages into a database
- Realtime updates of new chat messages
- Login system (Although very simple implementation)

Some things that could be improved for the future
- Secure login/logout and server calls
- Signup (user creation)
- Delete messages
- Lazy loading/pagination of messages


Two example users are given\
username: 'John Doe' password: 'letmein'\
username: 'Jane Smith' password: 'letmein'\

### Technical
Built with:
 - Blazor WebAssembly
 - ASP.NET Core Hosted
 - Entity Framework
 - Docker

Development used Microsoft SQL Server as the database and connects localhost and the user:\
User ID=webuser Password=letmein
