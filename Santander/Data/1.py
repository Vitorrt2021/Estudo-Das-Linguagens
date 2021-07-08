import csv 
import requests

arquivo = open('texto1.txt', 'r')
texto = arquivo.read()
print(texto)
arquivo.close()

arquivo = open('texto1.txt', 'r')
linha = arquivo.readline()

while linha!='':
    print(linha +"\n", end='')
    linha = arquivo.readline()
arquivo.close()

with open('texto1.txt', 'w') as arquivo1:
    arquivo1.write('Escrevi isso na linha 15 \n')
arquivo1 = open('texto1.txt', 'r')
for linha in arquivo1:
    print(linha, end='')

with open('texto1.txt', 'r',) as arquivo1:
    texto = arquivo1.read()
    print(texto)


with open('covid.csv','w') as covid:
    escritor = csv.writer(covid)
    escritor.writerow(['nome','sobrenome','email','genero'])
    escritor.writerow(['Vitor','Ramos','email','masculino'])

with open('covid.csv', 'r') as covid1:
    reader = csv.reader(covid1,delimiter=',')
    for row in reader:
        print(row)

url = 'https://www.alphavantage.co/query'

req = requests.get(url)
print(req)