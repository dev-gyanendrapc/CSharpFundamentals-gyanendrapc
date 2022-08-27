class Methods
{
    internal (double, double) GetCircleArea(double r)
    {
        var PI = Math.PI;

        // double area = PI*(r*r);
        double area = PI * Math.Pow(r, 2);
        double perimeter = 2 * PI * r;

        return (area, perimeter);
    }
    internal (byte, byte) MinAndMax(params byte[] ages)
    {
        byte max = 0;
        byte min = 254;
        foreach(byte x in ages){
            if(x>max){
                max = x;
            }
            if(x<min){
                min = x;
            }
        }
        return (max, min);
        // for (byte i = 0; i < ages.Length; i++)
        // {
        //     if (ages[i] > ages[i + 1])
        //     {
        //         max = ages[i];
        //     }
        //     if (ages[i] < ages[i + 1])
        //     {
        //         min = ages[i];
        //     }
        // }
        // return (max, min);
    }
}