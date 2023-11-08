/*var n1 = 10;
var n2 = 10.5;
var n3 = 1.5e3;
var n4 = 0xff;

var s1 = "teste";
var s2 = 'teste';

var b1 = true;

var u = undefined;
var n = null;

var obj = 
{
   id: 30,
   nome: "Fabrício"
}

var array = ["string1", "string2", "string3", "string4", "string5"];

var funcao = function (x, y) {  return x + y; };

var numero = 1;

if(numero == "1")
{
    //alert("com == entrou aqui? SIM");
}

if(numero === "1")
{
    //alert("com === entrou aqui? Não");
}

var x = (numero === "1") ? "Nunca executa!" : "Numero é diferente de string, mesmo com o valor igual, ele da falso!";
//alert(x);*/

var pessoa = {nome: 'Alisson', sobrenome: 'Lamarque'}

for(x in pessoa){
    nome += pessoa[x] + ' '
}

//alert(nome)

var resultado = "";
var numero = 1;

while(numero <= 10){
    resultado += numero + " ";
    numero++;
}

alert(resultado);