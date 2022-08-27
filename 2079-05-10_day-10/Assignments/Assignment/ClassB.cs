class ClassB{
    // class level visibility/accessibility (private)
    void ClassLvlVisibility(){
        System.Console.WriteLine("Visible inside class.");
    }
    // project level visibility (internal)
    internal void ProjectLvlVisibility(){
        System.Console.WriteLine("Visible inside project.");
    }
    // global level visibility (public)
    public void GlobalLvlVisibility(){
        System.Console.WriteLine("Visible at all projecta.");
    }
}