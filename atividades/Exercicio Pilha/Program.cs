using stringStackClass;

bool rodando = true;
stringStack stringStack = new stringStack();

while (rodando){
    Console.WriteLine("Qual a função desejada?");
    Console.WriteLine("[1]Adicionar\n[2]Remover topo\n[3]Espiar\n[4]Limpar\n[5]Imprimir\n[6]Sair");

    string? inputX = Console.ReadLine();
    if (inputX != null){
        if (int.TryParse(inputX, out int selectedOption))
        {
            switch(selectedOption){
                case 1:
                    Console.WriteLine("Digite:");
                    string? inputY = Console.ReadLine();
                    if (inputY != null){
                        stringStack.Push(inputY);
                    } else {
                        Console.WriteLine("Não pode ser uma string nula");
                    }
                    break;
                case 2:
                    string removido = stringStack.Pop();
                    Console.WriteLine($"Valor removido: {removido}");
                    break;
                case 3:
                    stringStack.Peek();
                    break;
                case 4:
                    stringStack.Clear();
                    break;
                case 5:
                    stringStack.printStack();
                    break;
                case 6:
                    rodando = false;
                    break;
                default:
                    Console.WriteLine("Utilize uma opção de 1 a 6!");
                    break;
            }
        } else {
            Console.WriteLine("Somente números.");
        }
    }
}