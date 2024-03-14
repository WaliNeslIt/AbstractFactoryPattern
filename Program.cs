// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

BMWBikeFactory bMWBikeFactory = new BMWBikeFactory();
IEngine _bmwEngine = bMWBikeFactory.processEngine();
ITyres _bmwTyre = bMWBikeFactory.processTyre();

_bmwEngine.setEngine("Some BMW Bike Engine");
_bmwTyre.setTyreInches(29);


Console.WriteLine("BMW Bike had : "+_bmwEngine.getEngine()+ " Engine");
Console.WriteLine("BMW Bike had : " + _bmwTyre.getTyreInches() + " Inches of Tyres");

Console.ReadLine();