#ENTRADA
print('Calculadora de 2º Grau')

a = int(input('Digite o valor de A: '))
b = int(input('Digite o valor de B: '))
c = int(input('Digite o valor de C: '))

# PROCESSAMENTO
delta = (b**2) - (4 * a * c)

if a == 0 or b == 0 or c == 0:
    print('Os valores não podem ser igual a 0')
    
elif delta < 0:
    print('Sua equação não tem raízes reais.')

else:
    print('Δ = ', delta)
    x1 = (-b + (delta ** (1/2))) / (2*a)
    x2 = (-b - (delta ** (1/2))) / (2*a)
    x3 = delta ** 1/2

    print('O resultado de x1 é {} e de x2 é {} ddc {}.' .format(x1 , x2 , x3))