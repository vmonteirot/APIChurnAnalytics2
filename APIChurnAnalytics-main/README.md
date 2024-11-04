
# Challenge Churn Analytics Project

## Overview

This project integrates several advanced functionalities for analyzing and managing customer churn using RESTful APIs, xUnit testing, Clean Code principles, and ML.NET for sentiment analysis.

### Features

- **External API Integration**: Added a new `ExternalAuthService` that integrates with an external authentication service to validate users via token-based authentication.

- **Testing with xUnit**: Comprehensive unit and integration tests were implemented using xUnit for key services, such as the `ExternalAuthService`. This ensures that the application functions correctly in different scenarios.

- **Clean Code and SOLID Principles**: Refactored the codebase following Clean Code and SOLID principles:
  - **Single Responsibility**: Each service and class handles only one specific part of the application’s functionality.
  - **Dependency Injection**: Services are injected into controllers and classes, following the Dependency Inversion principle.
  - **Interface Segregation and Open-Closed Principles**: Code is designed to be extensible without modification and adheres to focused interfaces.

- **ML.NET Integration**: Integrated a sentiment analysis feature using ML.NET in the `SentimentAnalysisService`. This model predicts whether a given input text has a positive or negative sentiment, adding value to customer feedback or churn analysis.

### Testing

The project includes unit and integration tests, which can be run with the following command:

```bash
dotnet test
```

### How to Run

1. Ensure you have `.NET Core SDK` installed.
2. Clone this repository.
3. Build the project:

    ```bash
    dotnet build
    ```

4. Run the API:

    ```bash
    dotnet run --project ChallengeChurnAnalytics
    ```

### Future Enhancements

- Additional AI models for product recommendation based on user behavior.
- Enhanced unit testing coverage for other services.

