namespace Open_Closed;

public class EarthMagic : MagicClass
{
    public override void CountYourMagic(int magic)
    {
        base.CountYourMagic(magic);
        if(magic == 500)
        {
            Console.WriteLine("It is cool, when you can throw stones in your enemies!");
            return;
        }
        
    }
}