
using ProjetoAPIAula1B;
using projetoAula_B;

namespace projetoAula_B
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lst = ReadFile.GetData("C:\\ADM\\motoristas-Habilitados.json");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}


