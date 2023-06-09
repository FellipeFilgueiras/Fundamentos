namespace Variaveis;
class Program
{
    static void Main(string[] args)
    {
        // Apenas declarando

        string nome; // texto
        int idade; // inteiro
        decimal altura; // decimais
        bool casado; // verdadeiro ou falso

        // Declarando e inicializando
        string sobrenome = "Filgueiras";
        int ano = 1991;
        decimal salario = 9.999m;
        bool solteiro = true;

        // Inferência de tipo, obrigatório a incialização
        // Já sabe o tipo da variável pelo que está sendo atribuído.
        var pai = "Sebastião";
        var dia = 12;
        var nota = 9.7;
        var divorciado = false;

    }
}
