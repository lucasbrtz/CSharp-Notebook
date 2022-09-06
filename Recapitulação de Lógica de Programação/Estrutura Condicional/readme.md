
# Exercícios

## Exercício 1

Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $-10$ | NEGATIVO |
| $8$ | NÃO NEGATIVO |
| $0$ | NÃO NEGATIVO |

## Exercício 2

Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $12$ | PAR|
| $-27$ | IMPAR |
| $0$ | PAR |

## Exercício 3

Leia 2 valores inteiros $(A$ e $B)$. Após a leitura, o programa deve mostrar uma mensagem "São múltiplos" ou "Não são múltiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números podem ser digitados em ordem crescente ou decrescente.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $6 \quad 24$ | São múltiplos |
| $6 \quad 25$  | Não são múltiplos |
| $24 \quad 6$  | São múltiplos |

## Exercício 4

Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $16 \quad 2$ | O JOGO DUROU 10 HORA(S) |
| $0 \quad 0$  | O JOGO DUROU 24 HORA(S) |
| $2 \quad 16$ | O JOGO DUROU 14 HORA(S) |

## Exercício 5

Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

|                    CÓDIGO                     |                   ESPECIFICAÇÃO                   |                   PREÇO                   |
| :-------------------------------------------: | :-----------------------------------------------: | :---------------------------------------: |
| 1 | Cachorro Quente | R$4,00 |
| 2 | X-Salada | R$4,50 |
| 3 | X-Bacon | R$5,00 |
| 4 | Torrada Simples | R$2,00 |
| 5 | Refrigerante | R$1,50 |

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $3 \quad 2$  | Total: R$10,00 |
| $2 \quad 3$ | Total: R$13,50 |

## Exercício 6

Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos $([0,25]$, $(25,50]$, $(50,75]$, $(75,100])$ este valor se encontra. Obviamente, se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem "Fora de Intervalo".

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $25.01$  | Intervalo: $(25,50]$ |
| $25.00$ | Intervalo: $[0,25]$ |
| $100.00$  | Intervalo: $(75,100]$ |
| $-25.02$ | Fora de intervalo |

## Exercício 7

Leia 2 valores com uma casa decimal $(x$ e $y)$, que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem $(x = y = 0)$. Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $4.5 \quad -2.2$ | 4º Quadrante |
| $0.1 \quad 0.1$  | 1º Quadrante |
| $0.0 \quad 0.0$  | Origem |

## Exercício 8

Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

|                    Renda                     |                   Imposto de Renda                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| De R$0,00 a R$2.000,00  | Isento |
| De R$2.000,01 a R$3.000,00 | 8% |
| De R$2.000,01 a R$4.500,00  | 18% |
| Acima de R$4.500,00 | 28% |

Lembre que, se o salário for R$3002.00, a taxa que incide é de 8% apenas sobre R$1000.00, pois a faixa de salário que fica de R$0.00 até R$2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$1000.00 + 18% sobre R$2.00, o que resulta em R$80.36 no total. O valor deve ser impresso com duas casas decimais.

#### Exemplos

|                    Entradas:                     |                   Saídas:                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| $3002.00$  | R$80.36 |
| $1701.12$ | Isento |
| $4520.00$  | R$355.60 |
