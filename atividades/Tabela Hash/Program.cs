using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable cadastros = new Hashtable();
        while (true)
        {
            Console.WriteLine("Digite o nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            string CPF = Console.ReadLine();

            try
            {
                cadastros.Add(CPF, Nome);
            }

            catch(ArgumentException aex)
            {
                Console.WriteLine("(O CPF já está cadastrado no sistema ou a chave é inválida.)");
                Console.WriteLine($"Detalhes do erro: {aex.Message}");
            }

            catch(Exception ex)
            {
                Console.WriteLine("Erro genérico!");
                throw ex;
            }

            // Percorrendo a hash com foreach
            Console.WriteLine();
            foreach(DictionaryEntry de in cadastros){
                Console.WriteLine("[CPF: {0}] - [Nome: {1}]", de.Key, de.Value);
            }
        }
    }
}