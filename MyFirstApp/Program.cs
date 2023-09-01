var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    if (context.Request.Method == "GET")
    {
        var error = false;

        if (!context.Request.Query.ContainsKey("firstNumber"))
        {
            await context.Response.WriteAsync("Invalid input for 'firstNumber'\n");
            error = true;
        }

        if (!context.Request.Query.ContainsKey("secondNumber"))
        {
            await context.Response.WriteAsync("Invalid input for 'secondNumber'\n");
            error = true;
        }

        var operation = context.Request.Query["operation"];
        if (operation != "sum" && operation != "sub" && operation != "mul" && operation != "div" && operation != "rem")
        {
            await context.Response.WriteAsync("Invalid input for 'operation'\n");
            error = true;
        }

        if (error) return;

        var firstNumber = float.Parse(context.Request.Query["firstNumber"]);
        var secondNumber = float.Parse(context.Request.Query["secondNumber"]);
        var result = 0f;
        var divisionByZero = false;

        switch (operation.ToString())
        {
            case "sum":
                result = firstNumber + secondNumber;
                break;
            case "sub":
                result = firstNumber - secondNumber;
                break;
            case "mul":
                result = firstNumber * secondNumber;
                break;
            case "div":
                if (secondNumber != 0) result = firstNumber / secondNumber;
                else divisionByZero = true;
                break;
            case "rem":
                if (secondNumber != 0) result = firstNumber % secondNumber;
                else divisionByZero = true;
                break;
        }

        if (!divisionByZero) await context.Response.WriteAsync((result).ToString());
        else await context.Response.WriteAsync("Division by 0 is not possible");
    }
});

app.Run();
