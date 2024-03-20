Microsoft has launched a property pattern in C# 8.0 version, which is an excellent way to compare object properties.

## Prerequisites

Please understand the new switch syntax introduced in C# 8.0, which helps to understand the current article example much better.
[New Switch syntax with C# 8.0](https://medium.com/@singhsukhpinder/new-switch-syntax-with-c-8-0-bfee2622de91)

## Getting Started

The **property pattern** permits you to match on properties of the object measured.

### Single property class
```
public class Calculate
{
    public string multiplyBy { get; set; }
}
```
### Basic property pattern syntax

The following example covers a new switch case with property class, where the property variable is accessed inside {} braces. So if the string property value is ten times, then multiply the price by ten, and return the price using lambda expressions.

The “_” symbol represents the default case. [**Refer new switch syntax](https://medium.com/@singhsukhpinder/new-switch-syntax-with-c-8-0-bfee2622de91)**
```
private static decimal ComputeOverallPrice(Calculate calculate, decimal price) =>

calculate switch
{

    { multiplyBy: "10 times" } => 10 * price,

    { multiplyBy: "5 times" } => 5 * price,

    { multiplyBy: "20 times" } => 20 * price,

    _ => 0M

};
```
### Multiple property class

Let us consider a class with multiple properties and utilize those in pattern matching.
```
public class CalculateMultipleProperty
{
    public string multiplyBy { get; set; }
    public bool isAdditionApplicable { get; set; }
}
```
### Multiple property pattern matching syntax

So basically, if the second property, i.e., “isAdditionApplicable,” is true, we add 100 more to result in price. The following example covers a new switch case with property class, where the property variable is accessed inside {} braces.

Multiple properties are accessed comma-separated inside the {} braces.

The “_” symbol represents the default case. [**Refer new switch syntax](https://medium.com/@singhsukhpinder/new-switch-syntax-with-c-8-0-bfee2622de91)**
```
private static decimal ComputeOverallPriceMultiple(CalculateMultipleProperty calculate, decimal price) =>
calculate switch
{
    {multiplyBy:"10 times",isAdditionApplicable:true}=>10*price + 100,

    {multiplyBy:"5 times",isAdditionApplicable:true}=>5*price + 50,

    {multiplyBy:"20 times",isAdditionApplicable:true}=>20*price + 70,

     _ => 0M
};
```
### Github Sample

The below sample contains an example of both single & multiple property pattern matching.
[PropertyPatternExample](https://github.com/ssukhpinder/PropertyPatternExample)

### Learn more - Advance Property Pattern
[Advance Property Pattern C# 8.0](https://medium.com/@singhsukhpinder/property-pattern-c-8-0-40925ae07b2c)

Thank you for reading. Keep visiting and share this in your network. Please put your thoughts and feedback in the comments section.

## Follow me on

[C# Publication](https://medium.com/c-sharp-progarmming), [LinkedIn](https://www.linkedin.com/in/sukhpinder-singh-532284a2/), [Instagram](https://www.instagram.com/sukhpindersukh/), [Twitter](https://twitter.com/sukhsukhpinder), [Dev.to](https://dev.to/ssukhpinder), [Pinterest](https://in.pinterest.com/ssukhpinder/_created/), [Substack](https://sukhpinder.substack.com/), [Wix](https://www.csharp-dotnet.com/).

<a href="https://www.buymeacoffee.com/sukhpindersingh" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

