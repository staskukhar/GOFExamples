using Builder.DesignPattern.Abstraction;

namespace Builder.DesignPattern.Implementation;

public class ComplexFeature(string feature, string option) : IFeature
{
    public string Feature { get; set; } = feature;
    
    public string Option { get; set; } = option;
    
    public string GetDescription()
    {
        return $"{this.Feature}, {this.Option}";
    }
}