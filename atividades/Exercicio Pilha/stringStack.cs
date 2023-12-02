using System;

namespace stringStackClass{

    public class stringStack{
        static readonly int MAX = 1000;
        int topo = -1;
        string[] stringsOnStack = new string[MAX];

        public bool isEmpty(){
            return topo < 0;
        }

        public bool Push(string stringAdicionada){
            if(topo >= MAX){
                Console.WriteLine("Stack Overflow");
                return false;
            }
            topo += 1;
            stringsOnStack[topo] = stringAdicionada;
            return true;
        }

        public string Pop(){
            if(topo < 0){
                Console.WriteLine("Stack Underflow");
                return "Underflow";
            }
            string texto = stringsOnStack[topo];
            topo -= 1;

            return texto;
        }

        public void Peek(){
            if(topo < 0){
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"Último item (topo): {stringsOnStack[topo]}");
        }

        public void Clear(){
            if(topo >= 0){
                topo = -1;
            }
        }

        public void printStack(){
            if(topo < 0){
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"Pilha:");
            for(int i = topo; i >= 0; i--){
                Console.WriteLine($"Valor [{i}]: '{stringsOnStack[i]}'");
            }
        }
    }
}