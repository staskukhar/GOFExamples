using Builder.DesignPattern.Abstraction;

namespace Builder.DesignPattern.Implementation;

public class BaseSmartphone(string manufacturer, string model) : ISmartphone<IFeature>
{
    public string Manufacturer { get; set; } = manufacturer;

    public string Model { get; set; } = model;
    
    ICollection<IFeature> Features { get; init; } = new List<IFeature>();
    public void AddFeature(IFeature feature)
    {
        this.Features.Add(feature);
    }

    public void DescribeModel()
    {
        Console.WriteLine($"Smartphone: {this.Manufacturer} {this.Model}");
        Console.WriteLine("Features:");
        foreach (var f in Features)  
        {
            Console.WriteLine($"\t - {f.GetDescription()}");
        }
    }
}