using System;

namespace CLASSES {
    
    // PARTE 1
    class Vetor {
        public int tamVetor;    // Tamanho do vetor
        public string[] itemsVetor;     // Itens do vetor
        public void addTamanho(int tamanho) {     // Leitura tamanho do vetor
            Console.Write("\nTamanho do vetor: ");
            tamVetor = int.Parse(Console.ReadLine());

            tamanho = tamVetor;
            itemsVetor = new string[tamanho];   // Atribuindo 'tamanho' como length do vetor
        }
        // PARTE 2
        public void addItems() {        // Método para adicionar os valores de acordo com o índice do vetor

            for(int i = 0; i < tamVetor; i++) {
                Console.WriteLine($"Digite o elemento: {i+1}");
                itemsVetor[i] = Console.ReadLine();
            }
        }
    }

    class Program {
        public static void Main(string[] args) {    // Método principal
             Vetor xVetor = new Vetor();    // Instância da classe

             xVetor.addTamanho(0);

             Console.WriteLine(xVetor.itemsVetor.Length);

             xVetor.addItems();

            // PARTE 3

             Random rnd = new Random();
             int rndResult = rnd.Next(xVetor.itemsVetor.Length);    // Aleatorizando o valor

             Console.WriteLine("\nValor sorteado: ");
             Console.WriteLine(xVetor.itemsVetor[rndResult]);

             Console.ReadKey();
        }
    }
}