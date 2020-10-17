using System;
namespace BaiThucHanh_2
//Bai2
class Phanso
{
    private int tu, mau;
    public Phanso()
    {
        tu = mau = 0;
    }
    public Phanso(int x, int y)
    {
        this.tu = tu;
        this.mau = mau;
    }
    public void nhap()
    {
        Console.WriteLine("nhap tu"); tu = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap mau"); mau = int.Parse(Console.ReadLine());
    }
    public void hien()
    {
        //Console.WriteLine("phan so co dang {0}/{1}", tu, mau);
        Console.WriteLine($"{tu}/{mau}");
    }
    public int Uscln(int x, int y)
    {
        x = Math.Abs(x); y = Math.Abs(y);
        while (x != y)
        {
            if (x > y) x = x - y;
            if (y > x) y = y - x;
        }
        return x;
    }
    public Phanso rutgon()
    {
        int uc = Uscln(this.tu, this.mau);
        this.tu = this.tu / uc;
        this.mau = this.mau / uc;
        return this;
    }
    public static Phanso operator +(Phanso t1, Phanso t2)
    {
        Phanso t = new Phanso();
        t.tu = t1.tu * t2.mau + t1.mau * t2.tu;
        t.mau = t1.mau * t2.mau;
        return t;
    }
    public static Phanso operator -(Phanso t1, Phanso t2)
    {
        Phanso t = new Phanso();
        t.tu = t1.tu * t2.mau - t1.mau * t2.tu;
        t.mau = t1.mau * t2.mau;
        return t;
    }
    public static Phanso operator /(Phanso t1, Phanso t2)
    {
        Phanso t = new Phanso();
        t.tu = t1.tu * t2.mau;
        t.mau = t1.mau * t2.tu;
        return t;
    }
    public static Phanso operator *(Phanso t1, Phanso t2)
    {
        Phanso t = new Phanso();
        t.tu = t1.tu * t2.tu;
        t.mau = t1.mau * t2.mau;
        return t;
    }
    public static bool operator >(Phanso t1, Phanso t2)
    {
        return t1.tu * t2.mau > t2.tu * t1.mau;
    }
    public static bool operator <(Phanso t1, Phanso t2)
    {
        return t1.tu * t2.mau < t2.tu * t1.mau;
    }
}
class test
{
    static void Main(string[] args)
    {
        Phanso t = new Phanso();
        t.nhap(); t.hien();
        Phanso t2 = new Phanso();
        t2.nhap(); t2.hien();
        Phanso t3 = t + t2; t3.hien();
        Phanso t4 = t * t2; t4.hien();
        if (t > t2)
        {
            Console.WriteLine("ps t1>t2");
        }
        else if (t < t2)
        {
            Console.WriteLine("ps t1<t2S");
        }
        else
            Console.WriteLine("hai ps = nhau");
        Console.ReadKey();
    }
}
//bai1
namespace baithuchanh01_bai1

{
    class Stack
    {
        private int top;
        private int[] a;
        public bool empty()
        {
            return (top == -1);
        }
        public bool full()
        {
            return (top >= a.Length);
        }
        public Stack()
        {
            a = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                a[top] = x;
            }
            else
                Console.Write("stack tran");
        }
        public int pop()
        {
            if (empty())
            {
                Console.Write("stack can");
                return 0;
            }
            else
                return a[top--];
        }
    }
    class hecoso
    {
        static void Main()
        {
            int n;
            Console.Write("Nhap vao so can doi:");
            n = int.Parse(Console.ReadLine());
            Stack T = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                T.push((int)st[n % 16]);
                n = n / 16;
            }
            Console.Write("Ket qua doi sang he 16 :");
            while (!T.empty())
            {
                Console.Write("{0}", (char)T.pop());
            }
            Console.ReadLine();
        }
    }
}