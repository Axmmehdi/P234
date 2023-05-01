internal class Bmw:Car 
{
    public bool IsMPower;





    public Bmw(string Model, int TopSpeed, double Engine, double Km, int Hp, bool IsMPower ):base()
    {
        this.Model = Model;
        this.TopSpeed = TopSpeed;
        this.Engine = Engine;
        this.Km = Km;
        this.Hp = Hp;
        this.IsMPower = IsMPower;

    }



    
    
 
     public void GetFullInfo()
    {
        Console.WriteLine(this.Model + " " + this.TopSpeed + " " + this.Engine + " " + this.Km + " " + this.Hp + " " +this.IsMPower);
    }


}