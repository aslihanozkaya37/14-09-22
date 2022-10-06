using System.Runtime.CompilerServices;

internal class Program 
{
static void Main(string[] args)
    {
        //Bir sınıfta sanal yapı oluşturabilmek için ilgili memberın
        //public virtual ya da virtual public şeklinde oluşturacağız.
        //Oje ojenesne=new Oje();
        //ojenesne.Message();
        //Top topnesne=new Top();
        //topnesne.Message();

        //Memeli memeli=new Memeli();
        //memeli.Ozellik();
        //Balina balina=new Balina();
        //balina.Ozellik();
        //Yarasa yarasa=new Yarasa(); 
        //yarasa.Ozellik();

        //A nesne=new A();
        //nesne.SayClass();
        //B ne=new B();
        //ne.SayClass();

        Ucgen u = new Ucgen(3,4);
        Console.WriteLine(u.AlanHesap()); 
        Dortgen d = new Dortgen(4,5);
        Console.WriteLine(d.AlanHesap());






    }
    public class MyClass
    {
        public void MyNormalMethod()
        {


        }
        public virtual void MyVirtualMethod()
        {


        }
        public string MyNormalProp { get; set; }
        virtual public string MyVirtualProp { get; set; }//virtual sanal olduğunu gösterir.
    }

    //Sanal yapılar nasıl Ezilir???
    //Base class'ta ya da atalarda da virtual ile işiaretlenerek sanallaştırılmış herhangi bir memeber torunlarda illaki override ile ezilmek zorunda değildir.
    //Ama bir torun class base classtaki herhangi bir memberi ezecekse (override edecekse ) o memberin kesinlikle ve kesinlikle virtual ile işaretlenmiş olması lazım.
    public class MyClass2:MyClass
    {
        public override void MyVirtualMethod()
        {
        
        
        }
    }
}
class Object
{

    public virtual void Message()
    {
        Console.WriteLine("Ben bir objeyim.");
    }
}
class Oje:Object
{
    public override void Message()
    {

        Console.WriteLine("Ben bir ojeyim");
    }


}
class Top:Object
{
    public override void Message()
    {
        Console.WriteLine("Ben bir topum");
    }
    
}
class Memeli 
{
    public virtual void Ozellik()
    {
        Console.WriteLine("Ben bir memeliyim");
    }

}
class Balina:Memeli
{
    public override void Ozellik()
    {
        Console.WriteLine("Memeli sınıfından balina");
    }
}
class Yarasa : Memeli
{
    public override void Ozellik()
    {
        Console.WriteLine("Uçan memeli sınıfında yarasa");

    }
  

}
class A
{

    public virtual void SayClass()
    {
        Console.WriteLine("ben A class");

    }
}
class B : A
{


}
class C : B
{
    public override void SayClass()
    {
        Console.WriteLine("Ben C nesnesiyim"); ;
    }


}
class D : C
{


}
class E : D
{
    public override void SayClass()
    {

    }


}
#region Ornek 3
//protected ile işaretlenen herhangi member sadece ilgili clasta ve yahut o classtan kalıtım almış olan sınıfların içerisinden erişilebilir.fakat nesne üzerinden erişilemez.
class Sekil
{
    protected int _kenar1; //korumalı access modifier
    protected int _kenar2;

    public Sekil(int kenar1,int kenar2)
    {
        _kenar1 = kenar1;
        _kenar2 = kenar2;   


    }
    virtual public int AlanHesap()
    {

        return 0;
    }


}
class Ucgen:Sekil
{
    public Ucgen(int kenar1,int kenar2):base(kenar1,kenar2)
    {

    }
    public override int AlanHesap()
    {
        return _kenar1*_kenar2/2;    
    }

}
class Dortgen:Sekil
{
    public Dortgen(int kenar1, int kenar2) : base(kenar1, kenar2)
    {
       
    }
    public override int AlanHesap()
    {
        return _kenar1 * _kenar2 ;
    }
}



class Dikdortgen:Sekil
{
    public Dikdortgen(int kenar1, int kenar2) : base(kenar1, kenar2)
    {

    }
    public override int AlanHesap()
    {
        return _kenar1 * _kenar2;
    }

}
#endregion