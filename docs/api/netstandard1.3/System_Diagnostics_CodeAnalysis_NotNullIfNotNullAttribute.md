#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')
## NotNullIfNotNullAttribute Class
Specifies that the output will be non-[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') if the  
named parameter is non-[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
```csharp
internal sealed class NotNullIfNotNullAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; NotNullIfNotNullAttribute  
### Constructors

***
[NotNullIfNotNullAttribute(string)](System_Diagnostics_CodeAnalysis_NotNullIfNotNullAttribute_NotNullIfNotNullAttribute(string).md 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.NotNullIfNotNullAttribute(string)')

Initializes the attribute with the associated parameter name.  
### Properties

***
[ParameterName](System_Diagnostics_CodeAnalysis_NotNullIfNotNullAttribute_ParameterName.md 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName')

Gets the associated parameter name.  
The output will be non-[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') if the argument to the  
parameter specified is non-[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
