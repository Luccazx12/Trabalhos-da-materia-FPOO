// Entrada
l1 = parseInt(prompt("Lado 1: "))
l2 = parseInt(prompt("Lado 2: "))
l3 = parseInt(prompt("Lado 3: "))


//Processamento e Saída
if (l1 > (l2 + l3) || l2 > (l1 + l3) || l3 > (l1 + l2)) {
    alert('Não pode ser um triângulo') 
    }
else if (l1 == l2 == l3) {
    alert ("Equilatero")}
else if (l1 == l2 || l1 == l3 || l2 == l3) {
    alert ("Isósceles")}
else{
    alert ("Escaleno")}