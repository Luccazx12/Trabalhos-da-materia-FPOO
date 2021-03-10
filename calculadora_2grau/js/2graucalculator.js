            var a
            var b
            var c
            var delta
            var x1
            var x2

            alert("Calculadora de 2º Grau");

            a = parseInt(prompt("Digite o valor de A: "));

            b = parseInt(prompt("Digite o valor de B: "));

            c = parseInt(prompt("Digite o valor de C: "));

            //PROCESSAMENTO
            if (a == 0 || b == 0 || c == 0)
            {
                alert("Os valores não podem ser igual a 0");
            }

            delta = Math.pow(b , 2) - (4 * a * c);

            if (delta < 0)
            {
                alert("Sua equação não tem raízes reais.");
            }

            else {
            x1 = (-b + Math.sqrt(delta)) /(2*a);
            x2 = (-b - Math.sqrt(delta)) /(2*a);

            alert(`O resultado de x1 é ${x1} e de x2 é ${x2}.`);
            
            }
		