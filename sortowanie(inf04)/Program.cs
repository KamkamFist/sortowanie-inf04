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
    /****************************************************
     * nazwa funkcji: sortujTablice
     * parametry wejściowe: brak - dziala w obrębie tablicy liczby
     * parametry wyjściowe: brak - sortuje tablice liczby rosnąco
     * autor: 28346237664
     * ****************************************************/
    public void sortujTablice()
    {
        for (int i = 0; i < liczby.Length; i++)
        {

            int min = WyszukajMaximum(i);


            int temp = liczby[i];
            liczby[i] = liczby[min];
            liczby[min] = temp;

        }
    }


    /***************************************************
    * nazwa funkcji: WyszukajMaximum
    * parametry wejściowe: int i - indeks od którego zaczynamy szukać
    * wartość zwracana: int - indeks najmniejszej wartości w tablicy od indeksu i do końca tablicy
    * autor: 28346237664
    * ***************************************************/
    private int WyszukajMaximum(int i)
    {

            int min = i;

            for (int j = i + 1; j < liczby.Length; j++)
            {
                if (liczby[j] < liczby[min])
                    min = j;
            }

        return min;
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