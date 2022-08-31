//Code Reusability
// Maintainability


namespace Inheritance;
interface IEngine
{
    public void ListParts();
    public void Start();
}

// A <- B - Single inheritance
// A <- B, B <- C - Multilevel inheritance
// A <- B, B <- C - Multiple inheritance