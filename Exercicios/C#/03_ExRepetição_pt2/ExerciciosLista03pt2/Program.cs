﻿/*
 LISTA DIRECIONADA PARA EXERCÍCIOS DE REPETIÇÃO (FOR WHILE) pt2
 
 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
  
2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 
Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
Deseja informar outro número (s/n)? N 
 
3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
 
4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. 
 
5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram.
 
6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.
 
7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.
 
8. Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos.

10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.

11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.

12. Apresentar o total da soma dos cem primeiros números inteiros.

13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500.

14. Mostrar as potências de 2 variando de 0 a 10.

15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação.

16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc).

17. Apresentar os quadrados dos números inteiros de 15 a 200.

18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM.

19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da  população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo.

20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
- sexo (masculino e feminino)
- cor dos olhos (azuis, verdes ou castanhos)
- cor dos cabelos ( louros, castanhos, pretos)
- idade 
 
Faça um algoritmo que determine e escreva: 
 
- a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos louros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

 */