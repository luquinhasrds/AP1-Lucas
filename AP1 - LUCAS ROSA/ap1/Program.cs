do{ //SISTEMA DE REPETIÇÃO

    //PEDE O NOME
    Console.WriteLine("Digite o nome do aluno:");
    string nome = Console.ReadLine();

    //PEDE A IDADE
    Console.WriteLine("Digite a idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    //PEDE A ALTURA
    Console.WriteLine("Digite a altura: (0,00)");
    double altura = Convert.ToDouble(Console.ReadLine());

    //PEDE O PESO
    Console.WriteLine("Digite o peso: (00)");
    double peso = Convert.ToDouble(Console.ReadLine());

    //CALCULA O IMC 
    double imc = peso / (altura*altura);

    //VE EM QUAL CATEGORIA O IMC CALCULADO SE ENCAIXA
    string categoria_imc;
    if(imc <= 18){
        categoria_imc = "baixo peso";
    }else if(imc <= 24){
        categoria_imc = "peso normal";
    }else if(imc <= 29){
        categoria_imc = "sobrepeso";
    }else{
        categoria_imc = "obeso";
    }

    //VE A IDADE DA PESSOA E VE EM QUAL CATEGORIA SE ENCAIXA
    string faixa_etaria;
    if(idade <= 0){
        faixa_etaria = "IMPOSSIVEL";
    }else if(idade <= 12){
        faixa_etaria = "Criança";
    }else if(idade <= 18){
        faixa_etaria = "Adolecente";
    }else if(idade <= 59){
        faixa_etaria = "Adulto";
    }else{
        faixa_etaria = "Idoso";
    }
    
    Console.WriteLine($"{nome}, {idade}, {imc}, {faixa_etaria}, {categoria_imc}");
    //PERGUNTA AO USUARIO SE QUER REPETIR O CODIGO OU CONTINUAR
    Console.WriteLine("Quer calcular IMC de outra pessoa? (s/n)");
    string opcao = Console.ReadLine();
    if (opcao != "s"){
        Console.WriteLine("O programa sera fechado..............");
        break;
    }

}while(true); //SISTEMA DE REPETIÇÃO
