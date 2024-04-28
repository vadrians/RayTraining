# RayTraining 
Create an API with 3 layer architecture:

- UI Presentation
- Business Logic
- Data Access

The Data Access layer will consume the movies.json file to simulate a MongoDB database.

The API will be able to

- Add new Movies
- Update Title, Year and if a movie won an Oscar.
- Delete Movies
- Get a Movie by Id
- Filter movies based on Title, Year, Actor Name or if it won an Oscar

- Add New Actors to a movie
- Delete an Actor from a Movie

- Get statistics with the following data:
	- The most awarded actors and actresses that participated in more than one movie that got an Oscar
	- The gender that was most prominent in movies that won the Oscar
	- The average age for the actors listed in the first bullet point.