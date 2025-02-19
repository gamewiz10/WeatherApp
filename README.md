﻿# WeatherApp - ASP.NET Core

A simple weather application built with C# and .NET Core to fetch real-time weather data.

---

## About the Project

This project was created to develop my C# and .NET Core skills by integrating an external API, handling HTTP requests, and displaying dynamic content. The application fetches real-time weather data using the OpenWeather API and presents it in a simple web interface.

---

## Features

- Fetches current weather based on city input
- Displays temperature, humidity, and weather condition
- Built with ASP.NET Core MVC
- Uses HttpClient for API calls
- Basic form validation for city input

---

## Tech Stack

- Language: C#
- Framework: ASP.NET Core MVC
- Frontend: Razor Pages, HTML, CSS (Bootstrap optional)
- API: OpenWeatherMap API
- Tools: Git, GitHub, .NET CLI

---

## Getting Started

### Prerequisites

Before running this project, ensure you have:

- .NET SDK installed → [Download Here](https://dotnet.microsoft.com/download/dotnet)
- Visual Studio / VS Code
- Git (optional, for version control)

---

### Installation

1. Clone the repository:
2. Install dependencies (if needed):
3. Run the application:

4. Open in browser:  
- Visit: `http://localhost:5083/weather`
- Enter a city and get real-time weather updates

---

## API Integration

This project uses the OpenWeather API to retrieve weather data.

### Setting Up Your API Key

1. Sign up at [OpenWeather](https://home.openweathermap.org/users/sign_up).
2. Get your API Key.
3. Replace `"YOUR_API_KEY"` in `WeatherService.cs` with your actual API key.

```csharp
private const string API_KEY = "YOUR_API_KEY";
