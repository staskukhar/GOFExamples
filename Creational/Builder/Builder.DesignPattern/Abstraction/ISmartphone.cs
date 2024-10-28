namespace Builder.DesignPattern.Abstraction;

public interface ISmartphone<TFeature>
{
    public void AddFeature(TFeature feature);

    public void DescribeModel();
}