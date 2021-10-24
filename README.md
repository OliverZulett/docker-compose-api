# Docker Compose API

Docker compose example for a rest api built with .net core.

## Beginning 🚀

*These instructions will allow you to get a copy of the project running on your local machine for development and testing purposes.*

### Prerequisites 📋

*You need the following software installed on your local machine.*

* [.Net CORE 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
* [Docker](https://www.docker.com/products/docker-desktop)

### Installation 🔧

To build the application follow the steps below:

- *builds and executes the .net application with the following commands:*

```bash
dotnet restore
```

### Execution 💣

To run the application follow the steps below:

- *run the .net application:*

```bash
dotnet build
dotnet run
```

- *build the docker image and run the container:*

```bash
docker build -t dockercomposeapinetcore:latest .
docker run -p 8080:80 dockercomposeapinetcore
```

### Testing 🔋

An application is needed to test endpoints such as postman:

- *Local endpoint:*

```bash
http://localhost:5000/WeatherForecast
```

- *Docker container endpoint:*

```bash
http://localhost:8080/WeatherForecast
```

## Built with 🛠️

*This project was built with the following technologies.*

- [.Net CORE 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Docker](https://www.docker.com/products/docker-desktop)

## Autor ✒️

- **Joshua Zulett** - *Development*

## Licence 📄

This project is under the (MIT) License - see the [LICENSE.md]() file for details.

## Expressions of Gratitude 🎁

- Tell others about this project 📢
- Invite a beer 🍺 or a coffee ☕ to someone on the team.
- Say thank you publicly 🤓.

------

⌨️ with ❤️ by [Oliver zulett](https://github.com/OliverZulett) 😊