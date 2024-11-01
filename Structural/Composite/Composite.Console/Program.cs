using Composite.DesignPattern.Abstraction;
using Composite.DesignPattern.Implementation;


//                                 -- subTreeOfFirstSubTree(4, 2)
//                                / 
// cyberTree -> firstSubTree(5) --
//                                \
//                                 -- anotherSubTreeOfFirstSubTree(8, 6)
// total = 5 + (4 + 2) + (8 + 6)

CyberTree cyberTree = new CyberTree();

// Subtree - 1
CyberTree firstSubTree = new CyberTree();
firstSubTree.AddNestedComponent(new FruitBunch(5));
cyberTree.AddNestedComponent(firstSubTree);

// Subtree - 1.1
CyberTree subTreeOfFirstSubTree = new CyberTree();
subTreeOfFirstSubTree.AddNestedComponent(new FruitBunch(4));
subTreeOfFirstSubTree.AddNestedComponent(new FruitBunch(2));
firstSubTree.AddNestedComponent(subTreeOfFirstSubTree);

// Subtree - 1.2
CyberTree anotherSubTreeOfFirstSubTree = new CyberTree();
subTreeOfFirstSubTree.AddNestedComponent(new FruitBunch(8));
subTreeOfFirstSubTree.AddNestedComponent(new FruitBunch(6));
firstSubTree.AddNestedComponent(anotherSubTreeOfFirstSubTree);

Console.WriteLine($"Cyber tree has {cyberTree.GetNumberOfFruits()} fruits.");