
# Challenge Churn Analytics Project

## Overview

This project integrates several advanced functionalities for analyzing and managing customer churn using RESTful APIs, xUnit testing, Clean Code principles, and ML.NET for sentiment analysis.

### Features

- **External API Integration**: Added an `AuthController` that integrates with an external authentication service to validate users via token-based authentication.
  - **Endpoint**: `POST /api/auth/authenticate`
  - **Description**: Authenticates a user by validating a provided token.

- **Sentiment Analysis with ML.NET**: Added a `SentimentController` for analyzing the sentiment of a given text using ML.NET.
  - **Endpoint**: `POST /api/sentiment/analyze`
  - **Description**: Analyzes the sentiment (positive or negative) of the provided text.

- **Testing with xUnit**: Comprehensive unit and integration tests were implemented using xUnit for key services, such as the `ExternalAuthService` and `SentimentAnalysisService`. This ensures that the application functions correctly in different scenarios.

- **Clean Code and SOLID Principles**: Refactored the codebase following Clean Code and SOLID principles:
  - **Single Responsibility**: Each service and class handles only one specific part of the application’s functionality.
  - **Dependency Injection**: Services are injected into controllers and classes, following the Dependency Inversion principle.
  - **Interface Segregation and Open-Closed Principles**: Code is designed to be extensible without modification and adheres to focused interfaces.

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

5. Access Swagger documentation:

    ```
    https://localhost:7280/swagger/index.html
    ```

### Future Enhancements

- Additional AI models for product recommendation based on user behavior.
- Enhanced unit testing coverage for other services.


## DevOps Pipeline Setup

This project includes configuration for a continuous integration and deployment pipeline (CI/CD) in Azure DevOps. Follow the instructions below to configure and run the pipeline.

1. **Build Pipeline Configuration**:
    - Create a new Build Pipeline in Azure DevOps and select the YAML configuration file (`azure-pipelines.yml`) located in the root of this project.
    - This pipeline will compile the code, run tests, and prepare for deployment.

2. **Release Pipeline Configuration**:
    - Create a new Release Pipeline in Azure DevOps and link it to the Build Pipeline's artifact.
    - Configure the deployment stage to push the application to Azure Web App or a VM, depending on your setup.

3. **Running the Pipeline**:
    - Trigger the pipeline from Azure DevOps, or use the following command from the command line:
    ```bash
    az pipelines run --name 'PipelineName'
    ```

4. **Testing the CRUD Operations**:
    - Use the JSON examples below with a tool like Postman to test the API's CRUD operations for the CadastroEmpresa entity.
    - Make sure the application is running and accessible.

For detailed JSON scripts to perform CRUD operations, see the section below.
