using Builder.DesignPattern.Abstraction;

namespace Builder.DesignPattern.Implementation;

public class BaseSmartphoneBuilder(ISmartphone<IFeature> smartphone) : ISmartphoneBuilder<ISmartphone<IFeature>, IFeature>
{
    private ISmartphone<IFeature> Smartphone { get; set; } = smartphone;

    public void ResetBuild(ISmartphone<IFeature> smartphone)
    {
        this.Smartphone = smartphone;
    }

    public void AddFeature(IFeature feature)
    {
        this.Smartphone.AddFeature(feature);
    }

    public ISmartphone<IFeature> BuildSmartphone()
    {
        return this.Smartphone;
    }
}