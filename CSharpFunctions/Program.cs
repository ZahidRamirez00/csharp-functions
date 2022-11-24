//-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- CODICE PRINCIPALE -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Stampo l'array: ");
StampaArrayInteri(arrayDiNumeri);
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-\n");

Console.WriteLine("Stampo l'array elevato al quadrato: ");
int[] arrayDiNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArrayInteri(arrayDiNumeriAlQuadrato);
Console.WriteLine("Stampo l'array originale: ");
StampaArrayInteri(arrayDiNumeri);
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-\n");

Console.Write("Stampo la somma degli elementi dell'array originale: ");
int sommaElementiArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine(sommaElementiArray);
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-\n");

Console.Write("Stampo la somma degli elementi dell'array elevato a quadrato: ");
int sommaElementiArrayQuadrato = SommaElementiArray(arrayDiNumeriAlQuadrato);
Console.WriteLine(sommaElementiArrayQuadrato);
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-\n");








//-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- FUNZIONE -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-

//preso un array di numeri interi, stampa a video il contenuto dell’array in 
//questa forma “[elemento 1, elemento 2, elemento 3, ...]”
void StampaArrayInteri (int[] array)
{
    string stampaArray = "[";

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stampaArray += array[i];
        }
        else
        {
            stampaArray+= array[i] + ", ";
        }
    }

    stampaArray+= "]";

    Console.WriteLine(stampaArray);
}

//preso un numero interto, restituisce un numero intero elevato al quadrato
int Quadrato (int numero)
{
    double power = 2;
    int numeroQuadrato = (int)Math.Pow(numero, power);

    return numeroQuadrato;
}

//prende un array di numeri interi, restituisce un nuovo array con tutti gli elementi elevati quadrato.
int[] ElevaArrayAlQuadrato (int[] array)
{
    double power = 2;
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = (int)Math.Pow(copiaArray[i], power);
    }

    return copiaArray;
}


//preso un array di numeri interi, restituisce la somma totale di tutti gli elementi dell’array
int SommaElementiArray(int[] array)
{
    int somma = 0;
    foreach (int numero in array)
    {
        somma += numero;
    }

    return somma;   
}