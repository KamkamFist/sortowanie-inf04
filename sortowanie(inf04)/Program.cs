class Program
{
    int[] liczby = new int[10];

    public void dodajLiczbe(int index, int liczba)
    {
        liczby[index] = liczba;
    }
    public void wyswietlTablice()
    {
        Console.Write("[ ");
        foreach (int i in liczby){
            Console.Write(i + " ");
        }
        Console.Write(" ]");
    }
    public void sortujTablice()
    {
        WyszukajMinimum();
    }
    private void WyszukajMinimum()
    {
        for(int i = 0; i < liczby.Length; i++)
        {
            int min = i;
            int obecnaLiczba = liczby[i];
            for(int j = i + 1; j < liczby.Length; j++){

                if (liczby[j] < obecnaLiczba)
                {
                    min = j;
                }

            }

            int temp = obecnaLiczba;
            liczby[i] = liczby[min];
            liczby[i] = temp;

        }

    }
}
class zadanie 
{
    public static void Main()
    {
        Program program = new Program();

        Console.WriteLine("wpisz dowolnych 10 liczb calkowitych");
        for (int i = 0; i < 10; i++)
        {
            int liczba = int.Parse(Console.ReadLine());
            program.dodajLiczbe(i, liczba);
            Console.WriteLine("dodano liczbe: " + liczba + " na miejscu " + i);  
        }

        program.wyswietlTablice();

        program.sortujTablice();

        program.wyswietlTablice();

    }
}