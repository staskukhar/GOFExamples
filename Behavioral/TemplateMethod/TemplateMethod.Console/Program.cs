using TemplateMethod.DesignPattern.Abstraction;
using TemplateMethod.DesignPattern.Implementation;

Browser chrome = new Chrome();
Browser edge = new Edge();

chrome.Search("Template method design pattern");
Console.WriteLine();
edge.Search("Template method design pattern");