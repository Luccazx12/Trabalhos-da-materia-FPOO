    //DECLARAÇÃO DE VARIÁVEIS
        var n

        //ENTRADA
        alert("Positivo, Negativo ou Neutro, Par ou Impar.")

        n = parseInt(prompt("Digite um valor: "))

        //Saídas e Processamento
        if (n > 0) {
            alert("Seu número é positivo.")
        }

        else if (n < 0) {
            alert("Seu número é negativo.")
        }

        else {
            alert("Seu número é neutro." )
        }

        if(n%2 == 0) {
            alert("O seu número é par!")
        }
        else {
            alert("O seu número é ímpar!")
        }
   