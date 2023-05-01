
internal class Mercedes : Car
{
    public bool IsAMG;



    public Mercedes(string Model, int TopSpeed, double Engine, double Km, int Hp, bool IsAMG) : base()
    {
        this.Model = Model;
        this.TopSpeed = TopSpeed;
        this.Engine = Engine;
        this.Km = Km;
        this.Hp = Hp;
        this.IsAMG = IsAMG;

    }






    public void GetFullInfo()
    {
        Console.WriteLine(this.Model + " " + this.TopSpeed + " " + this.Engine + " " + this.Km + " " + this.Hp + " " + this.IsAMG);
    }

}
