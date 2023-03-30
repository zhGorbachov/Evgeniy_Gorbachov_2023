namespace Open_Closed;

public class EarthMagic : MagicClass
{
    public override void CountYourMagic(int magic)
    {
        if(magic == 150)
        {
            Console.WriteLine("Wow, your magic is fire magic!");
            return;
        }
        
    }
}