using Builder.DesignPattern.Abstraction;
using Builder.DesignPattern.Implementation;

ISmartphoneBuilder<ISmartphone<IFeature>, IFeature> builder = new BaseSmartphoneBuilder(
    new BaseSmartphone("OnePlus", "12"));

builder.AddFeature(new ComplexFeature("RAM", "512 GB"));
builder.AddFeature(new ComplexFeature("ROM", "16 GB"));
builder.AddFeature(new ComplexFeature("Processor", "Snapdragon 8 Gen 3"));
builder.AddFeature(new ComplexFeature("Battery", "5400 мАг"));
builder.AddFeature(new BaseFeature("AMOLED"));
builder.AddFeature(new BaseFeature("Green"));
builder.AddFeature(new BaseFeature("NFC"));

ISmartphone<IFeature> smartphone = builder.BuildSmartphone();
smartphone.DescribeModel();
