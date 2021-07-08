
//Objeto
var person = {
    "name": "vitor",
    "age": 18,
    "live": true
}

//array
var students = ["Vitor", "Marcos", "Yara"]

function sum(a,b)
{
    return a+b;
}

typeof(students)

//se usar === compara o valor e o tipo

//e = &&
//ou = ||

class Book{
    constructor(title, author, pages){
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
    read(){
        return 'Estou lendo ${this.title}'
    }
}

let book = new Book("Rapido devagar", "Não sei",679);

console.log(book)
console.log(book.read())


class ITBook extends Book {
    constructor(title,author,pages,technology){
        super(title,author,pages)
        this.technology = technology
    }
}
let itBook = new ITBook("Codigo limpo","Uncle bob",406,"Codigo")
console.log(itBook)

class Person{
    constructor(name)
    {
        this._name = name;
    }
    get name()
    {
        return this._name;
    }
    set name(value){
        this._name = value;
    }
}

let vitor = new Person("Vitor")
vitor.name = "Vitor"
console.log(person.name);
console.log(typeof(3))
function fiiz(num)
{
    if(typeof(num) != "number")
    {
        console.log("não é um numero")
    }
    else if((num%3==0)&&(num%5==0))
    {
        console.log("FizzBuzz")
    }
    else if(num%3==0)
    {
        console.log("Fizz")
    }
    else if(num%5==0)
    {
        console.log("Buzz")
    }
    else{
        console.log(num)
    }
}
fiiz(15);
fiiz(7);
fiiz("n");