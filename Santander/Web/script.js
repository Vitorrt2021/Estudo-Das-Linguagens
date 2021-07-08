const subtrair = (a,b) => a-b;
const aplicaOperacao = (a,b,operacao) => operacao(a,b);

let resultado = aplicaOperacao(4,2,subtrair);

console.log(resultado)

const somarX = (x) => (y) => x+y;
const somar2 = somarX(2);
console.log(somar2(5));

const vetor= ["10","20","30"];
const stringToInt = (x) => parseInt(x);
const vetor2 = vetor.map(stringToInt);
const vetor3 = vetor2.map(x => x*x);

const letras = ["a","b","c"];
const toUpper = (str) => str.toUpperCase();
const maiusculas = letras.map(toUpper);
console.log(maiusculas);

console.log(vetor3);

console.log(vetor2);

const numero = [1,2,3,4,5,6,7,8,9,10];
const pares = numero.filter(x => x%2 ===0);
console.log(pares);

const valores = [1,2,3,4,5,6];
const somatorio = valores.reduce((estado, item) => estado + item);
//ou
const valores1 = [1,2,3,4,5,6];
const somatorio1 = valores1.reduce((estado, item) => estado + item, 0);
console.log(somatorio)

let alunos = [
    { nome : 'nome1', nota1 : 5, nota2 : 4 },
    { nome : 'nome2', nota1 : 4, nota2 : 3 },
    { nome : 'nome3', nota1 : 7, nota2 : 8 },
    { nome : 'nome4', nota1 : 2, nota2 : 7 },
    { nome : 'nome5', nota1 : 9, nota2 : 9 },
  ];

  const estadoInicial = { 
    somaNota1 : 0, 
    somaNota2 : 0, 
    qtdNota1 : 0, 
    qtdNota2 : 0,
  };
  const result = alunos.reduce((estado, valor) => {
    return {
        somaNota1 : estado.somaNota1 + valor.nota1,
        somaNota2 : estado.somaNota2 + valor.nota2,
        qtdNota1 : estado.qtdNota1 + 1,
        qtdNota2 : estado.qtdNota2 + 1
    };
  }, estadoInicial);
  console.log(result);