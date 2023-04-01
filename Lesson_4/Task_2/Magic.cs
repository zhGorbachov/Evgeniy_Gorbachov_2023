namespace Open_Closed
{
    public class MagicClass
    {
        public virtual void CountYourMagic(int magic) 
        {
            if(magic == 150)
            {
                Console.WriteLine("Wow, your magic is fire magic!");
                return;
            }
            if(magic == 50000000)
            {
                Console.WriteLine("Incredible! You have 50 millions of power! It's water magic!");
                return;
            }
            Console.WriteLine("I understand you...");
        }
    }
}