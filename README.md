# FinVizStockApi

FinVizStockApi is an API that can be queried to read stock data from the Finviz website.

## Prerequisites

- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) or later which has been configured for
  - ASP.NET and web development
  - Data storage and processing
- Cloned the repository to a local folder

## Installation

### Build (for development)

    To build this repo, from the code open the solution with Visual Studio

    On the toolbar click on Build->Build Solution

    this will build the project and produce a StockScreenerApi.exe under <repo-folder>\StockScraperApi\bin\Debug\netcoreapp3.1\

### Publish

    To publish this project, open Visual Studio

    On the toolbar click on Build->Publish StockScreenerApi

    Once in the publish window, select the Target as Folder

    Click Next

    Select a Folder location if needed, however you may keep the defaults.

    Click Finish

    Once a Publish configuration has been setup you may click Publish

    This will then publish the app to you selected folder location where it can be run

## Usage

Start the StockScreenerApi.exe

Then you may issue HTTP requests to the api:

- GET: http://localhost:5000/api/FinVizItems - get all previous recorded stock symbols
- GET: http://localhost:5000/api/FinVizItems/{id} - get specific stock record and store in database
- PUT: http://localhost:5000/api/FinVizItems/{id} - update a stock record in the database
- POST: http://localhost:5000/api/FinVizItems - add a new stock record to the database
- DELETE: http://localhost:5000/api/FinVizItems/{id} - delete a stock record from the database

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[GNU GPLv3](https://www.gnu.org/licenses/gpl-3.0.en.html)
