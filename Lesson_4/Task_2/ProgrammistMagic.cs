namespace Open_Closed;

public class ProgrammistMagic : MagicClass
{
    public override void CountYourMagic(int magic)
    {
        base.CountYourMagic(magic);
        if(magic == 0)
        {
            Console.WriteLine("Wow you are a real programmer, you have the magic to break everything!");
            return;
        }
    }
}