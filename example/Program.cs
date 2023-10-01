class DataModule
{
    public int x;
    public int y;

    public int b;
    public int c;

    public DataModule()
    {
        x = 4;
        y = 5;

        b = 7;
        c = 8;
    }

};

class addition:DataModule
{
    public int add(int x_, int y_)
    {
        return x_ + y_;
    }
}
class Subtraction:DataModule
{
    public int subtract(int b, int input_)
    {
         return b - input_;
    }
}
class Multiplication:DataModule
{
    public string multiply(int c, int input_)
    {
        c *= input_;
        return c.ToString();
    }
}
class printing : DataModule
{
    public void print(string input)
    {
        Console.WriteLine(input);
    }
}

class Processing
{
    addition adder = new addition();
    Subtraction subber = new Subtraction();
    Multiplication multer = new Multiplication();
    printing printer = new printing();

    DataModule dm = new DataModule();
    public void Process()
    {
        int temp = adder.add(dm.x, dm.y);
        int intttemp = subber.subtract(dm.b, temp);
        string multemp = multer.multiply(dm.c, intttemp);
        printer.print(multemp);
    }
}

class main
{
    static void Main(string[] args)
    {
        Processing p = new Processing();
        p.Process();
        alternate.Processing ap = new alternate.Processing();
        ap.Process();

    }
}