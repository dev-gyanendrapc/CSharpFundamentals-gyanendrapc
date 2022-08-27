class ClassA
{
    void HiddenFunction(){
        System.Console.WriteLine("I, Invisible");
    }

    internal (int, int, int) GetAge(DateTime dob)
    {
        DateTime cDate = DateTime.Today;
        DateTime dDate =dob;
        DateTime age = cDate.AddDays(-dob.Day);
        age = age.AddMonths(-dob.Month);
        age = age.AddYears(-dob.Year);

        return (age.Year, age.Month, age.Day);

    }

    internal (double, double) FindMeanMedian(double[] arr)
    {
        double mean = (arr.Sum()/arr.Length);
        double median;
        int arrLen = arr.Length;
        if(arrLen % 2 !=0 ){
            median = arr[arr.Length/2];
        }else{
            median = ((arr[(arrLen-1)/2])+(arr[(arrLen-1)/2]))/2;
        }
        return(mean,median);
       
    }
    internal (int[],int[]) FindMeanMedian(int[] arr1, int[] arr2)
    {
        int[] asc, desc;
        asc = arr1.Concat(arr2).ToArray();
        Array.Sort(asc);
        desc=(int[])asc.Clone();
        Array.Reverse(desc);
        return (asc, desc);
       
    }
}