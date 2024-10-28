using Builder.DesignPattern.Abstraction;

namespace Builder.DesignPattern.Implementation;

public class BaseFeature(string feature) : IFeature
{
    public string Feature { get; set; } = feature;
    
    public string GetDescription()
    {
        return Feature;
    }
}