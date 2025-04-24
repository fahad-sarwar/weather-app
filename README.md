# Weather Application

## Overview
This Weather Application is designed as an example of an application built using public APIs to demonstrate code building using AI (Copilot).

The completed example application will:
* take a place name
* determine its Latitude and Longitude
* get the weather
* determine the weather type from the weather type code
* display the weather in the terminal

This was built in JavaScript using NodeJS but could easily be reproduced in any language. The language choice is not important as this is a demonstration of using AI code generation tools and using it to consume real data from the web.

AI code generation was intended as an enabler for this Work Experience project to get around the differing skill levels that may stop candidates from seeing the benefits of their efforts.

## APIs

These APIs were chosen specifically because they do not require API keys or logins.

| Function | Name | URL |
|:---------|:-----|:----|
|Weather   |open meteo|https://open-meteo.com|
|Lat/Long | Open Streetmap|https://nominatim.openstreetmap.org|

## Copilot Prompts

The following prompts were use to generate the application and the code was manipulated to allow them to interact.

* How can I get data from open-meteo in javascript
  * How can I get data from open-meteo by using fetch in javascript
* Can I get the latitude and logitude of a place name in javascript?
  * Is there a way of getting this without using an api key?
* How do I get the name of the weather from the weathercode in open-meteo?
  * Could you give me some javascript to convert the number to the text?

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [Node.js](https://nodejs.org/) (which includes npm)
- [Yarn](https://yarnpkg.com/) (optional, but recommended)

### Installation

1. Clone the repository:
  ```sh
  git clone https://github.com/philwrenzen/workExperienceWeather
  cd workExperienceWeather
  ```

2. Install the dependencies:
  Using Yarn:
  ```sh
  yarn install
  ```
  or using npm:
  ```sh
  npm install
  ```
## Running Example

Using Yarn
```sh
yarn dev
```

or using NPM 
```sh
npm run dev
```

## Re-use

The `/html` folder has an example of this JavaScript being re-used on a simple web page. The code is far from ideal but is a simple demonstration of taking this code and presenting it to a wider audience.

The page was largely built and styled using Copilot in VS Code.

In the same way the example application used Copilot to get the weather, this page also used Copilot to get the code for adding a map to the page using [Leaflet](https://leafletjs.com/).


## Limitations and future enhancements

* The location is hardcoded in the `index.js` and would be better as a command line argument
* Failure to determine latitude and longitude from a place name should be detected and the process interrupted with a message
* Output is raw JSON and could be improved, coloured, use Unicode symbols (☀, 🌧, ❄), etc
* No error handling