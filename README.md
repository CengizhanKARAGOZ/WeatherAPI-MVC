# Weather API Project

This project is a RESTful API built with ASP.NET Core that provides weather information for a specific city. Users can access the current temperature by providing the name of the city.

## Features

- Retrieve weather data by city name using RESTful endpoints
- Return only the temperature in Celsius

## Technologies

- ASP.NET Core
- C#
- RestAPI
- Newtonsoft.Json

## Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/your_username/weather-api.git
   cd weather-api

## Features

- Retrieve weather data by city name
- Return only the temperature in Celsius

## Technologies

- ASP.NET Core
- C#
- RestAPI
- Newtonsoft.Json

## Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/your_username/WeatherAPI-MVC.git
   cd WeatherAPI-MVC
   ```
2. **Restore NuGet Packages**:
   Open a terminal in the root directory of the project and run:
   ```bash
   dotnet restore
   ```
3. **Run the Application**:
   To start the application, use the following command:
   ```bash
   dotnet run
   ```

## Usage
### Retrieve Weather Data
You can use the following GET request to retrieve weather data for a specific city:
```bash
GET http://localhost:5000/weather/{city}
```
### Example Request
```bash
GET http://localhost:5000/weather/İstanbul
```
### Response Format
The response will return only the temperature in Celsius:
```bash
{
    "15.0"
}
```

## Contributing
If you would like to contribute, please open an issue or discuss a topic first. Then feel free to propose your changes.
