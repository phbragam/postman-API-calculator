# Postman API Calculator

This is a simple API for performing basic arithmetic operations. You can use Postman to test and interact with this API. The API supports the following operations: addition, subtraction, multiplication, division, and remainder. The API was developed using **.NET Core 6** in Visual Studio 2022.

## API Endpoint

The API has a single endpoint:

- **Endpoint:** `http://localhost:6734/`

## Request Parameters

To make a request to the API, you need to include the following parameters as query parameters:

- `firstNumber`: The first number for the operation (required).
- `secondNumber`: The second number for the operation (required).
- `operation`: The type of arithmetic operation to perform (required). Supported values are: "sum", "sub", "mul", "div", and "rem".

## Making Requests in Postman

Follow these steps to make requests using Postman after having the server running locally:

1. **Launch Postman**: If you haven't already, download and install [Postman](https://www.postman.com/) on your computer.

2. **Create a New Request**:
   - Open Postman.
   - Click the "New" button to create a new request.

3. **Configure the Request**:
   - Set the request type to `GET`.
   - Enter the API endpoint URL in the request URL field (e.g., `http://localhost:6734/`).

4. **Add Query Parameters**:
   - In the request, go to the "Params" tab.
   - Add the following query parameters:
     - `firstNumber`: Set the value to the first number you want to use in the operation.
     - `secondNumber`: Set the value to the second number you want to use in the operation.
     - `operation`: Set the value to one of the supported operations ("sum", "sub", "mul", "div", or "rem").
   - e.g., `http://localhost:6734/?firstNumber=4&secondNumber=2&operation=div`.

5. **Send the Request**:
   - Click the "Send" button to send the request to the API.

6. **View Response**:
   - The API's response will be displayed in the response panel below. You will see the result of the arithmetic operation or an error message if the input is invalid.

## Example Requests

Here are some example requests you can make using Postman:

### Addition
- `firstNumber`: 5
- `secondNumber`: 3
- `operation`: sum
- Expected result: 8

### Subtraction
- `firstNumber`: 10
- `secondNumber`: 7
- `operation`: sub
- Expected result: 3

### Multiplication
- `firstNumber`: 4
- `secondNumber`: 6
- `operation`: mul
- Expected result: 24

### Division
- `firstNumber`: 8
- `secondNumber`: 2
- `operation`: div
- Expected result: 4

### Remainder
- `firstNumber`: 15
- `secondNumber`: 7
- `operation`: rem
- Expected result: 1

Make sure to adjust the query parameters to perform the specific arithmetic operation you want to test.


