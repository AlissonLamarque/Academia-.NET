﻿/*
LISTA DIRECIONADA PARA EXERCÍCIOS DE SELEÇÃO (IF ELSE)

1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero. 

2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
Mostrar na tela qual dos professores tem o maior salário total.

5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
se a média das duas notas for maior ou igual a 7,0. 

Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
é a média entre a nota do exame e a média das 2 notas. 
Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
escrever “Reprovado”.

6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério


7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 

9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.

10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.

11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário.

13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7

14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos).

15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).

18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#).

21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
valor para a unidade de saída selecionada.

 */