using System;
class Program
{   //В упорядоченном массиве целых чисел найти номер элемента заданного числа бинарным поиском  (с применением рекурсии и без неё)
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, n = 0;
        System.Console.WriteLine("razmer massiva");
        N = System.Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        for(int i = 0; i < N; i++)
        {
            array[i] = i;
        }
        Console.WriteLine("Chislo c");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Rec(array, a,array.Length,0));
        
    }
    static int Norm(int[] a,int c)
    {
        int n = a.Length-1,l=0,mid=0;
        bool lol = false;
        while (l<=n&&!lol)
        {   mid = (l + n) / 2;
            if (c == a[mid]) lol = true;
            else if (c < a[mid]) n = mid - 1;
                else l = mid + 1;
        }
        if (lol) return mid;
        else return -1;

    }
    static int Rec(int[]a , int c,int n,int l)
    {  
        int mid=(l+n)/2;
        if (c == a[mid]) return mid;
            else if(c < a[mid]) return Rec(a,c,mid-1,l);
                else return Rec(a,c,n,mid+1);
    }
}
