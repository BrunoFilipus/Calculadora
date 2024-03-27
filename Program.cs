namespace CalculadoraSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double segundoNumero;
            var simboloMatematico = "numero";
            var repetirCalculo = "sim";
            double produtoFinal;

            do
            {
                Console.WriteLine("+ para adicionar");
                Console.WriteLine("- para subtrair");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("= para finalizar");

                produtoFinal = Convert.ToDouble(Console.ReadLine());
                simboloMatematico = (Console.ReadLine());

                if (simboloMatematico != "=")
                {
                    do
                    {
                        if (simboloMatematico == "+")
                        {
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                            produtoFinal += segundoNumero;
                        }
                        else if (simboloMatematico == "-")
                        {
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                            produtoFinal -= segundoNumero;
                        }
                        else if (simboloMatematico == "*")
                        {
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                            produtoFinal *= segundoNumero;
                        }
                        else if (simboloMatematico == "/")
                        {
                            segundoNumero = Convert.ToDouble(Console.ReadLine());

                            if (segundoNumero == 0)
                            {
                                do
                                {
                                    Console.WriteLine("Proibido usar o zero como divisor, tente outro número.");
                                    segundoNumero = Convert.ToDouble(Console.ReadLine());
                                
                                } while (segundoNumero == 0);
                            }
                            produtoFinal /= segundoNumero;
                        }
                        else if (simboloMatematico != "=")
                        {
                            Console.WriteLine("Erro, tente novamente.");
                        }

                        simboloMatematico = Console.ReadLine();

                    } while (simboloMatematico != "=");
                }
                Console.WriteLine($"Resultado = {produtoFinal}.");
                Console.WriteLine("Deseja fazer outro cálculo? sim/nao");
                repetirCalculo = Console.ReadLine();

            } while (repetirCalculo != "nao" && repetirCalculo == "sim");
        }
    }
}
