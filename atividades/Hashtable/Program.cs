using System.Collections;

// criar HashTable
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt","notepad.exe");
    openWith.Add("bmp","paint.exe");
    openWith.Add("dib","paint.exe");
    openWith.Add("rtf","wordpad.exe");

    openWith.Add("txt","notepad++.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("Oops, você tentou adicionar uma chave inválida");
    Console.WriteLine($"Detalhes:{aex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Erro genérico.");
}

//Acessando o conteúde a tabela hash
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"] );

//Alterando o conteudo da tabela hash 
openWith["rtf"] = "winword.exe";
Console.WriteLine(
    "Na chave = \"rtf\" é {0}"
, openWith["rtf"] 
);

//Testar se chave existe na hash
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

//Percorrendo hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith )
{
    Console.WriteLine(
        "Key = {0} - Value {1}"
        , de.Key
        , de.Value
    );
}

//obtendo apenas os valores do hash
ICollection valueCol = openWith.Values; 
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("Value = {0}" , s);
}




//openWith.Add("dib","paint.exe");
Console.WriteLine("Programa ainda em execução.");