namespace nucleotide_count;

internal class Program
{
    static void Main(string[] args)
    {
       
        foreach(var item in NucleotideCount.Count("GATTACA"))
        {
            Console.Write( item.Key + " : "+ item.Value +",");
        }
       
    }
}
