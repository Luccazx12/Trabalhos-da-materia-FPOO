#Entrada
ano = int(input('Digite o ano a ser analisado: '))

#Processamento e Saída
if ano % 4 == 0 and ano % 100 != 0 or ano % 400 == 0: 
    print('O ano é bissexto')

else:
    print('O ano não é bissexto')