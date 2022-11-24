//-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- CODICE PRINCIPALE -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-


















//-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- FUNZIONE -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-

void StampaArrayInteri(int[] array)
{
    string stampaArray = "[";

    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
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

int Quadrato(int numero)
{
    double power = 2;
    Console.WriteLine("Il quaderato di " + numero + " è: " + Math.Pow(numero, power));
}