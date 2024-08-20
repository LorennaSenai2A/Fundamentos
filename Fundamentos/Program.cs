using Fundamentos;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        // Instanciar u objeto do Tipo Aluno
        Aluno aluno1 = new Aluno();
        // Preencher os atributos de objeto
        aluno1.Nome = "Cristiano de Paula";
        aluno1.RM = "1234TI";
        aluno1.Email = "cristiano.paula@sp.senai.br";
        aluno1.Nascimento = new DateOnly(1981, 07, 16);

        // Imprimir na Tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM:" + aluno1.RM);
        Console.WriteLine("E-mail: " + aluno1.Email);
        Console.WriteLine("Nascimento:" + aluno1.Nascimento);
        Console.WriteLine("========================");

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Lorena de Almeida Victor";
        aluno2.RM = "4495TI";
        aluno2.Email = "lorena.victor@aluno.senai.br";
        aluno2.Nascimento = new DateOnly(2008, 02, 12);

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM:" + aluno2.RM);
        Console.WriteLine("E-mail: " + aluno2.Email);
        Console.WriteLine("Nascimento:" + aluno2.Nascimento);
        Console.WriteLine("========================");

        Aluno aluno3 = new Aluno();

        aluno3.Nome = "Edilaine Zanon";
        aluno3.RM = "0501TI";
        aluno3.Email = "edilaine.zanon@aluno.senai.br";
        aluno3.Nascimento = new DateOnly(1964, 01, 05);


        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("RM:" + aluno3.RM);
        Console.WriteLine("E-mail: " + aluno3.Email);
        Console.WriteLine("Nascimento:" + aluno3.Nascimento);
        Console.WriteLine("========================");

        // Instanciar um Objeto do Tipo Produto
        Produto p1 = new Produto();
        p1.Codigo = 123456;
        p1.Nome = "Coca-cola 3 litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        //Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();
        //  {
        // Console.WriteLine("A quantidade em estoque é: " + this.Estoque);
        //}
        Console.WriteLine("========================");
        Console.WriteLine();

        //instanciar um objeto do tipo carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Console.WriteLine("========================");
        Console.WriteLine();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Lorena";
        pessoa1.Idade = 16;

        pessoa1.Envelhecer(5);
        pessoa1.Envelhecer(2);

        Console.WriteLine("========================");
        Console.WriteLine();

        Funcionario f1 = new Funcionario();
        f1.Nome = "Bruno";
        f1.Idade = 14;
        f1.Cargo = "aprendiz";
        f1.Salario = 1400.00;
        f1.ApresentarSe();

        Console.WriteLine("========================");
        Console.WriteLine();
        /*
        //Inserindo objeto
        Animal animal1 = new Animal();

        //Inserindo dados no atributo
        animal1.Especie = "cachorro";

        //Chamando o metodo do objeto
        animal1.emitirSom();

        //Imprimindo a informação na tela
        Console.WriteLine("O animal " + animal1.Especie + " emitiu um som.");
        */

        Gato gato = new Gato();
        gato.Nome = "Kaue";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Console.WriteLine("========================");
        Console.WriteLine();

        Porco porco = new Porco();
        porco.Nome = "Juju";
        Console.WriteLine(porco.Nome + " faz: ");
        porco.emitirSom();


        Console.WriteLine("========================");
        Console.WriteLine();

        Galinha galinha = new Galinha();
        galinha.Nome = "May";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();


        Console.WriteLine("========================");
        Console.WriteLine();

        Personagem personagem = new Personagem();

    }
}

// Exemplo de comentario em uma linha

/*
 * Comentario de bloco
 */

/*
Livro livro1 = new Livro();
livro1.Titulo = "Harry Pottter";
livro1.Editora = "Editora Abril";
livro1.Autor = "J.K.H";
livro1.AnoLancamento = 2001;

Livro livro2 = new Livro();
livro2.Titulo = "Programando em C#";
livro2.Editora = "Editora Nova";
livro2.Autor = "Gustavo Castello";
livro2.AnoLancamento = 1982;

Livro livro3 = new Livro();
livro3.Titulo = "Pai Rico e Pai Pobre";
livro3.Editora = "Minha Editora";
livro3.Autor = "Cristiano de Paula";
livro3.AnoLancamento = 2000;
*/
