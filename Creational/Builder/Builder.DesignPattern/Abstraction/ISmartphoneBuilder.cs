namespace Builder.DesignPattern.Abstraction;

public interface ISmartphoneBuilder<TSmartphone, TFeature>
{
    public void ResetBuild(TSmartphone smartphone);
    
    public void AddFeature(TFeature feature);
    
    public TSmartphone BuildSmartphone();
}