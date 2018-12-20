using System;

namespace Calculadora_Vetores
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            char repcomand;

            do
            {
                Console.WriteLine("[Calculadora de Vetores] </>");
                Console.WriteLine("Digite:");
                Console.WriteLine("[1]Produto Escalar.");
                Console.WriteLine("[2]Produto Vetorial.");
                Console.WriteLine("[3]Eq. Geral do Plano.");
                Console.WriteLine("[4]Eq. Vetorial do Plano.");
                Console.WriteLine("[5]Eq. Parametrica do Plano.");
                Console.WriteLine();

                int v, a, b, c, d, e, f, x, y, z, multi, eq;
                v = int.Parse(Console.ReadLine());

                if (v == 1)
                {
                        Console.WriteLine("Calculo do Produto Escalar de dois vetores. Digite os valores dos vetores v(a;b;c) e u(a';b';c').");
                        Console.WriteLine("Ex.: u=(a)i+(b)j+(c)k  v=(a')i+(b')j+(c')k");

                        string[] vet = Console.ReadLine().Split(' ');

                        a = int.Parse(vet[0]);
                        b = int.Parse(vet[1]);
                        c = int.Parse(vet[2]);
                        d = int.Parse(vet[3]);
                        e = int.Parse(vet[4]);
                        f = int.Parse(vet[5]);

                        multi = (a * d) + (b * e) + (c * f);

                        if (multi > 0)
                        {
                            Console.WriteLine("Produto Escalar entre u.v=" + multi + " Portanto possui angulo agudo entre os vetores.");
                        }
                        else if (multi < 0)
                        {
                            Console.WriteLine("Produto Escalar entre u.v=" + multi + " Portanto possui angulo obtuso entre os vetores.");
                        }
                        else
                        {
                            Console.WriteLine("Produto Escalar entre u.v=" + multi + " Portanto possui angulo reto entre os vetores.");
                        }

                        Console.WriteLine();
                }

                else if (v == 2) {

                        Console.WriteLine("Calculo do Produto vetorial para determinar um vetor 'n'. Digite o valor dos vetores u=(a;b;c) v(a',b',c').:");
                        Console.WriteLine("Ex.: u=(a)i+(b)j+(c)k  v=(a')i+(b')j+(c')k");

                        string[] vet = Console.ReadLine().Split(' ');

                        a = int.Parse(vet[0]);
                        b = int.Parse(vet[1]);
                        c = int.Parse(vet[2]);
                        d = int.Parse(vet[3]);
                        e = int.Parse(vet[4]);
                        f = int.Parse(vet[5]);

                        x = (b * f) - (c * e);
                        y = (c * d) - (a * f);
                        z = (a * e) - (b * d);

                        Console.WriteLine();
                        Console.WriteLine("n=(" + x + "i)" + "+(" + y + "j)+(" + z + "k)");
                        Console.WriteLine();
                    }

                else if (v == 3) {
                        Console.WriteLine("Calculo da Eq. Geral do plano. Digite as coordenadas do vetor n(a; b; c) e do ponto A(x0; y0; z0).");

                        string[] vet = Console.ReadLine().Split(' ');

                        a = int.Parse(vet[0]);
                        b = int.Parse(vet[1]);
                        c = int.Parse(vet[2]);
                        d = int.Parse(vet[3]);
                        e = int.Parse(vet[4]);
                        f = int.Parse(vet[5]);

                        eq = (-a * d - b * e - c * f);

                        Console.WriteLine();
                        Console.WriteLine("Eq Geral do plano:");
                        Console.WriteLine("(" + a + "x)" + "+(" + b + "y)" + "+(" + c + "z)" + "+(" + eq + ")" + "=0");

                        Console.WriteLine();
                }

                else if (v == 4) {
                    Console.WriteLine("Calculo da Eq. Vetorial do plano. Digite as coordenadas do ponto A(x0;y0;z0), do vetor u(a;b;c) e v(a';b';c').");
                    Console.WriteLine("Ex.: u=(a)i+(b)j+(c)k  v=(a')i+(b')j+(c')k");
                    Console.WriteLine();

                    string[] vet = Console.ReadLine().Split(' ');

                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                    z = int.Parse(vet[2]);
                    a = int.Parse(vet[3]);
                    b = int.Parse(vet[4]);
                    c = int.Parse(vet[5]);
                    d = int.Parse(vet[6]);
                    e = int.Parse(vet[7]);
                    f = int.Parse(vet[8]);

                    Console.WriteLine("(x; y; z)=(" + x + "; " + y + "; " + z + ")" + "+h(" + a + "; " + b + "; " + c + ")+" + "t(" + d + "; " + e + "; " + f + ")");
                    Console.WriteLine();
                }

                else {
                    Console.WriteLine("Calculo da Eq. Parametrica do plano. Digite as coordenadas do ponto A(x0;y0;z0), do vetor u(a;b;c) e v(a';b';c').");
                    Console.WriteLine("Ex.: u=(a)i+(b)j+(c)k  v=(a')i+(b')j+(c')k");
                    Console.WriteLine();

                    string[] vet = Console.ReadLine().Split(' ');

                    x = int.Parse(vet[0]);
                    y = int.Parse(vet[1]);
                    z = int.Parse(vet[2]);
                    a = int.Parse(vet[3]);
                    b = int.Parse(vet[4]);
                    c = int.Parse(vet[5]);
                    d = int.Parse(vet[6]);
                    e = int.Parse(vet[7]);
                    f = int.Parse(vet[8]);

                    Console.WriteLine();
                    Console.WriteLine(" |x=(" + x + ")+(" + a + ")h+(" + d + ")t");
                    Console.WriteLine(" |y=(" + y + ")+(" + b + ")h+(" + e + ")t");
                    Console.WriteLine(" |z=(" + z + ")+(" + c + ")h+(" + f + ")t");
                    Console.WriteLine();
                }

                Console.WriteLine("Deseja calcular outras Eq. vetoriais (s/n)?");
                        repcomand = char.Parse(Console.ReadLine());
            } while (repcomand == 's');

            Console.WriteLine("Fim");
        }
    }
}
