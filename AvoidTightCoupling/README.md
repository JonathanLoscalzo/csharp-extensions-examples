## USE
When an instance method would introduce a dependency on some type, but such a dependency would break dependency management rules. 

For example, a dependency from String to System.Uri is probably not desirable, and so String.ToUri() instance method returning System.Uri would be the wrong design from a dependency management perspective. A static extension method Uri.ToUri(this string str) returning System.Uri would be a much better design.

## Run
dotnet restore && dotnet run

## Example
We inject the use of "ExampleAuthentication" by "UserExtension".
In Program.Main we "adapt" the use from ExampleAuthentication. 
we can change the way authentication is implemented, and we should only change our extension method.