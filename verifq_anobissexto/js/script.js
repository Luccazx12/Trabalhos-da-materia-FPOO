        // Entrada
        var ano = prompt("Digite o ano: ")

        // Processamento e saída
        if (ano%400 == 0)
        alert("É bissexto");
        else if(ano%4==0 && ano%100!=0)
         alert("É bissexto");
        else
         alert("Não é bissexto");