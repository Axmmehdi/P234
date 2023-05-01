
internal class Car
{
    private string _model;
    private int _topSpeed;
    private double _engine;
    private double _km;
    private int _hp;
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (value.Length < 0 || value.Length >= 10)
            {
                Console.WriteLine("Model adi duzgun formatda deyil");
            }
            else
            {
                _model = value;
            }

        }
    }
    public int TopSpeed
    {
        get
        {
            return _topSpeed;
        }
        set
        {
            if (value <= 10 || value >= 1000)
            {
                Console.WriteLine("Suret duzgun deyil");
            }
            else
            {
                _topSpeed = value;
            }
        }

    }
    public double Engine
    {
        get
        {
            return _engine;
        }
        set
        {
            if (value <= 0.3 || value >= 10)
            {
                Console.WriteLine("mator hecmi duzgun formatda deyil");
            }
            else
            {
                _engine = value;
            }
        }
    }




    public double Km
    {
        get
        {
            return _km;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("km duzgen formada deyil");
            }
            else
            {
                _km = value;
            }
        }
    }

    public int Hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value <= 50 || value >= 1000)
            {
                Console.WriteLine("At gucu duzgun deyil");
            }
            else
            {
                _hp = value;
            }
        }
    }


    public Car()
    {

    }


    public Car(string Model, int TopSpeed, double Engine, double Km, int Hp) : this()
    {
        this.Model = Model;
        this.TopSpeed = TopSpeed;
        this.Engine = Engine;
        this.Km = Km;
        this.Hp = Hp;

    }

    public void GetFullInfo()
    {
        Console.WriteLine(this.Model + " " + this.TopSpeed + " " + this.Engine + " " + this.Km + " " + this.Hp);













    }
}


