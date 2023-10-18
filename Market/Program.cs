namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zakaz n = new Zakaz();
            while (true) {

                n.Vivid();
                Menu menu = new Menu(0, 6);
                int pos = menu.Show();
                
                Harki harki = new Harki();
                menu = new Menu(1, harki.HAR_Menu(pos));

                int pol = menu.Show();
                if (harki.Price(pos, pol) < 10000) 
                    n.zak[n.m[pos]] = harki.Znch(pos, pol) + "  " + harki.Price(pos, pol) + " руб.";
                else
                    n.zak[n.m[pos]] = harki.Znch(pos, pol) + " " + harki.Price(pos, pol) + " руб.";

            }
            
        }
    }
}