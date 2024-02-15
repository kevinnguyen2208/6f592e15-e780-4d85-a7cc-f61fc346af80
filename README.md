[![Coverage Status](https://coveralls.io/repos/github/kevinnguyen2208/6f592e15-e780-4d85-a7cc-f61fc346af80/badge.svg)](https://coveralls.io/github/kevinnguyen2208/6f592e15-e780-4d85-a7cc-f61fc346af80)

**Purpose:** Given an array of numbers, output the earliest recognised longest increasing subsequence.

**Achieved Goals:**
- Github actions have been set up to test for successful build, code linting, code coverage and unit tests.
- Solution containerisation using Docker
- Code linting 
- Code coverage reporting - 66%, but the Service folder where the Longest Increasing Subsequence logic is contained is covered 100%.
![image](https://github.com/kevinnguyen2208/6f592e15-e780-4d85-a7cc-f61fc346af80/assets/54177223/6eaa9716-f691-435c-8ea3-7109e1c66044)

**Setup:**
 - Clone this repo
 - Run the project in Visual Studio by clicking the Start in Visual Studio or run the following command line
   `dotnet run`
 - Unit tests have been set up as required for the provided 11 test cases. An additional set of test cases (7 tests) is used to test input validation. Run these tests by clicking the Test button -> Run All Tests or run the following command line
   `dotnet test` 
 - Test using Swagger UI by clicking the GET /api -> Click Try it out button -> Enter an array of numbers into Input textbox -> Click Execute button. Result will be shown into the Response section.
   ![image](https://github.com/kevinnguyen2208/6f592e15-e780-4d85-a7cc-f61fc346af80/assets/54177223/acd56be3-d06e-405c-a60b-ba1b72291065)

**Docker containerisation setup:**
 - Run the following command line to build the Docker image
   `docker build -t app-image .`     

 - Run the following command line to run the Docker container
   `docker run -d -p 5011:80 --name app-container app-image`

 - After successful run, Swagger UI can be accessed via this link without needing to run the project in Visual Studio
   `http://localhost:5011/swagger/index.html`

