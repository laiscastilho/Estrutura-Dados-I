using System; // Importando a biblioteca system, onde contém classes previamente definidas/implementadas.

namespace QueueClass{

    public class Queue{
        static readonly int MAX = 1000;
        int actual = -1;
        int first = 0;
        int[] queue = new int[MAX];

        public bool isEmpty(){
            return (actual < 0);
        }

        public bool Enqueue(int data){
            if(actual >= MAX){
                Console.WriteLine("Queue limit reached.");
                return false;
            }
            actual += 1;
            queue[actual] = data;
            return true;
        }

        public int Dequeue(){
            if(actual < 0){
                Console.WriteLine("Queue is empty.");
                return 0;
            }
            int value = queue[first];
            first += 1;

            return value;
        }

        public void Peek(){
            if(actual < 0){
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine($"O primeiro item da fila é: {queue[first]}");
        }

        public void PrintQueue(){
            if(actual < 0){
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine($"Itens da fila:");
            for(int i = first; i < MAX; i++){
                
                if(i <= actual)
                    Console.WriteLine($"FILA [{queue[i]}]");
            }
        }
    }
}
/*


        public void PrintStack(){
            if(top < 0){
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"Itens da pilha:");
            for(int i = top; i >= 0; i--){
                string texto = $"Stack[{stack[i]}]";
                Console.WriteLine(texto);
            }
        }
    }
}
*/