 {
        Console.WriteLine("Questão 1");
        Console.WriteLine(" ");
    int a = 876;
    float b = 6.8f;
    string c = "Julia";
    bool d = false;

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 2");
        Console.WriteLine(" ");

        Console.WriteLine("Digite dois números inteiros:");
        string[] vet = Console.ReadLine().Split(' ');
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);

        int soma = a+b;
        int sub = a-b;
        int multi = a*b;
        int divisao = a/b;

        Console.WriteLine($"A soma dos dois números: {soma}");
        Console.WriteLine($"A subtração dos dois números: {sub}");
        Console.WriteLine($"A multiplicação dos dois números: {multi}");
        Console.WriteLine($"A divisão dos dois números: {divisao}");
        Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 3");
        Console.WriteLine(" ");

        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine($"Olá, {nome} , você tem {idade} anos.");
        Console.WriteLine(" ");
        
    }

    {
        Console.WriteLine("Questão 4");
        Console.WriteLine(" ");
        Console.WriteLine("Digite um número:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        if(a>0.00){
            Console.WriteLine("Seu número é positivo");
        } 
        else if(a==0){
            Console.WriteLine("Seu número é zero");
        }else if(a<0.00){
            Console.WriteLine("Seu número é negativo");
        }else{}
        Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 5");
        Console.WriteLine(" ");
        for (int a = 1; a <= 10; a++){
            Console.WriteLine(a);
        }
        Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 6");
        Console.WriteLine(" ");
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        if(idade>=18){
            Console.WriteLine("Maior de idade. Está apta para votar e dirigir.");
        }else if(idade == 16 || idade == 17){
            Console.WriteLine("Menor de idade. Apta para votar. Não está apta para dirigir.");
        }else if(idade<16){
            Console.WriteLine("Menor de idade. Não está apta para votar e dirigir.");
        }else{}
        Console.WriteLine(" ");
    }
    
    {
        Console.WriteLine("Questão 7");
        Console.WriteLine(" ");
        Console.WriteLine("Digite sua primeira nota:");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota:");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua terceira nota:");
        float n3 = float.Parse(Console.ReadLine());
        float media = (n1+n2+n3)/3;
        Console.WriteLine($"Sua média é: {media:F2}");
        Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 8");
        Console.WriteLine(" ");
        Console.WriteLine("Digite três números:");
        string[] vet = Console.ReadLine().Split(' ');
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);
        Console.WriteLine(" ");

        if(a>b && a>c && b>c){
            Console.WriteLine($"{a} é o maior número e {c} é o menor número.");
        }else if(a>b && a>c && c>b){
            Console.WriteLine($"{a} é o maior número e {b} é o menor número.");
        }else if(b>a && b>c && a>c){
            Console.WriteLine($"{b} é o maior número e {c} é o menor número.");
        }else if(b>a && b>c && a>c){
            Console.WriteLine($"{b} é o maior número e {c} é o menor número.");
        }else if(c>a && c>b && a>b){
            Console.WriteLine($"{c} é o maior número e {b} é o menor número.");
        }else if(c>a && c>b && b>a){
            Console.WriteLine($"{c} é o maior número e {a} é o menor número.");
        }else{}
        Console.WriteLine(" ");
    }

    {
        Console.WriteLine("Questão 9");
        Console.WriteLine(" ");
        int soma = 0;
        int a;

        do{
        Console.WriteLine("Digite um número:");
        a = int.Parse(Console.ReadLine());
        
        soma += a;
       
        }while ( a != 0);
           
        Console.WriteLine($"A soma final dos números é: {soma}");
        Console.WriteLine(" ");
    
    }
    
    {
        Console.WriteLine("Questão 10");
        Console.WriteLine(" ");
        Console.WriteLine("Digite um valor em reais:");
        float reais = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a taxa de câmbio:");
        float cambio = float.Parse(Console.ReadLine());

        float total = reais/cambio;

        Console.WriteLine(" ");
        Console.WriteLine($"O valor em dólares é: {total:F2}");
    }


