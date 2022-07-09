class supplyControl
{
    static void Main()
    {
        // Variaveis
        double mediaConsumo = 3.6;
        int combMax = 26020;

        Console.WriteLine("Insira a distância:");
        string distTrecho = Console.ReadLine();
        int numDistTrecho = Int32.Parse(distTrecho);

        Console.WriteLine("Insira a quantidade de KM do trecho alternativo:");
        string altTrecho = Console.ReadLine();
        int numAltTrecho = Int32.Parse(altTrecho);

        Console.WriteLine("Insira a quantidade combustivel já na aeronave:");
        string aeroComb = Console.ReadLine();
        int numAeroComb = Int32.Parse(aeroComb);

        //Quantidade toal de combustivel necessaria:
        double totalDist = numDistTrecho + numAltTrecho;
        double totalComMargem = totalDist / 0.7;
        double totalComb = (totalComMargem * mediaConsumo) - numAeroComb;

        //Verificar se a quantidade de combustivel é comportada pela aeronave
        if (totalComb > combMax)
        {
            Console.WriteLine("Voo Reprovado, reveja seu planejamento!");

            Console.WriteLine("pressione ENTER para sair");
            Console.ReadLine();

            return;
        }
        else
        {
            Console.WriteLine("Voo Aprovado, bom voo!");

            Console.WriteLine("Trecho Principal: {0} KM", numDistTrecho);
            Console.WriteLine("Trecho Alternativo: {0} KM", numAltTrecho);
            Console.WriteLine(String.Format("Trecho total com margem de segurança: {0:0.00} KM", totalComMargem));
            Console.WriteLine(String.Format("Quantidade necessária de combustivel: {0:0.00} L", totalComb));
        }

        Console.WriteLine("pressione ENTER para sair");
        Console.ReadLine();

    }
}




