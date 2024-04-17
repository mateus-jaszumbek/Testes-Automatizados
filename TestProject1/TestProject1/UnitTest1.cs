namespace TestProject1
{
    public class Tests
    {
        public int a, b, c, soma, multi, resultadoSoma, resultadoMulti;



        [SetUp]
        public void Soma()
        {
            a = 5; b = 7;

            soma = a + b;
            resultadoSoma = 12;

            Assert.That(soma, Is.EqualTo(resultadoSoma));
            Console.WriteLine("Teste 1 O resultado da Soma é " + resultadoSoma);
        }

        [Test]
        public void Multi()
        {
            a = 5; b = 7;

            multi = a * b;
            resultadoMulti = 35;

            Assert.That(multi, Is.EqualTo(resultadoMulti));
            Console.WriteLine("Teste 2 O resultado da Soma é " + resultadoMulti);
        }

        [TearDown]
        public void Resultado()
        {
            if (soma != resultadoSoma)
            {
                Console.WriteLine("O valor da soma deve ser " + soma);
                Console.WriteLine("O valor digitado foi " + resultadoSoma); Assert.Fail();
            }
            if (multi != resultadoMulti)
            {
                Console.WriteLine("O valor de ser " + multi);
                Console.WriteLine("O valor Digitado foi " + resultadoMulti); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Muito bem! você respondeu corretamente");
            }
        }

        //[TestCase(4, 5, 9)]
        //public void SomaEntreDoisNumeros(int x, int y, int resultado)
        //{
        //    // Ação
        //    soma = x + y;

        //    // Validação 
        //    Assert.That(soma, Is.EqualTo(resultado));
        //    Console.WriteLine("O resultado da soma é " + resultado);
        //}
    }
}