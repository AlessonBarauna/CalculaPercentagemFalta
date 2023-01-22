namespace PorcentagemFaltas
{
    class programa
    {
        static void Main(String[] args)
        {
            string nome;
            double mf = 0;
            double ad = 0;
            double qf = 0;
            double pf = 0;
            Console.WriteLine("Aprovação por média de faltas. ");
            Console.WriteLine();
            Console.Write("Nome do(a) aluno(a): ");
            nome = Console.ReadLine();
            Console.Write("Média final: ");
            mf = Convert.ToDouble(Console.ReadLine());
            Console.Write("Toral de aulas dadas: ");
            ad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Total de faltas: ");
            qf= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            pf = (qf * 100) / ad;
            if ((pf <= 25) && (mf > 6))
            {
                Console.WriteLine("Médial final: " + mf + ".");
                Console.WriteLine("Porcentagem de faltas: " + pf + "%.");
                Console.WriteLine( nome + ", Você foi aprovado(a). ");
            }
            else
            {
                Console.WriteLine("Médial final: " + mf + ".");
                Console.WriteLine("Porcentagem de faltas: " + pf + "%.");
                Console.WriteLine(nome + ", Você foi reprovado(a). ");
            }
            Console.ReadLine();
        }
    }
}