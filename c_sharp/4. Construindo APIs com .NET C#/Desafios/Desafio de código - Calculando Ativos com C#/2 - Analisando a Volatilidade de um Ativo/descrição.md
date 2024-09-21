# Cálculo de Volatilidade Histórica de um Ativo

## Descrição
Você foi contratado por uma empresa de análise financeira para desenvolver uma função que calcula a volatilidade histórica de um ativo. A volatilidade é uma medida da variação dos retornos de um ativo ao longo do tempo e é fundamental para avaliar o risco associado ao investimento.

O cálculo do desvio padrão, que mede essa volatilidade, envolve os seguintes passos:

1. **Calcular a Média**: Primeiramente, é necessário calcular a média dos preços de fechamento. A média é obtida somando todos os preços e dividindo pelo número de dias.
2. **Calcular as Diferenças Quadráticas**: Para cada preço de fechamento, calcular a diferença em relação à média e elevar ao quadrado.
3. **Calcular a Variância**: A variância é a média das diferenças quadráticas calculadas.
4. **Calcular o Desvio Padrão**: Finalmente, o desvio padrão é a raiz quadrada da variância.

## Entrada
A entrada consiste em uma string representando uma lista de preços de fechamento diários do ativo financeiro ao longo de um período. Os preços são separados por vírgula e espaço (, ).

## Saída
Deve-se retornar o desvio padrão dos preços de fechamento, que é utilizado como medida de volatilidade do ativo para o período fornecido.

## Exemplo de Entrada e Saída

| Entrada                                     | Saída  |
|---------------------------------------------|--------|
| 100.0, 102.5, 99.8, 101.2, 98.5             | 1.355  |
| 50.2, 51.0, 49.5, 52.1, 48.9, 50.8          | 1.041  |
| 200.5, 198.7, 203.1, 197.4, 201.9           | 2.069  |

### Observações
- O desvio padrão é uma medida estatística utilizada para quantificar a quantidade de variação ou dispersão de um conjunto de valores. Quanto maior o desvio padrão, maior a volatilidade do ativo.
- A precisão do resultado deve ser de três casas decimais.
