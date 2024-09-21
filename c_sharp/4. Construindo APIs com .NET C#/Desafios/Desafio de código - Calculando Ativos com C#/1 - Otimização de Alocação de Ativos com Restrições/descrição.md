# Otimização de Alocação de Ativos Financeiros

## Descrição
Você recebeu a tarefa de ajudar um cliente a otimizar a alocação de seus ativos financeiros. Além de calcular a alocação proporcional ao valor de mercado, você deve considerar várias restrições que o cliente impôs:

- Cada ativo deve ter uma alocação mínima e máxima.
- O valor total a ser investido deve ser respeitado.
- O número de ativos alocados deve ser igual ao número de ativos fornecido.

Seu desafio é criar um programa que receba a lista de valores de mercado dos ativos, o valor total a ser investido, e as restrições de alocação mínima e máxima para cada ativo. O programa deve então calcular a quantidade de dinheiro que deve ser alocada em cada ativo, respeitando as restrições fornecidas.

## Entrada
A entrada deve receber cinco strings, representando os seguintes valores:

1. Um número inteiro `N` representando o número de ativos.
2. `N` números reais representando os valores de mercado atuais de cada ativo.
3. Um número real representando o valor total a ser investido.
4. `N` números reais representando as alocações mínimas de cada ativo.
5. `N` números reais representando as alocações máximas de cada ativo.

## Saída
A saída deve retornar `N` números reais, cada um representando a quantidade de dinheiro a ser alocada em cada ativo. O valor deve ser proporcional ao valor de mercado do ativo em relação ao valor de mercado total de todos os ativos e deve respeitar as restrições de alocação mínima e máxima. Os valores devem ser arredondados para duas casas decimais.

## Exemplo de Entrada e Saída

| Entrada                         | Saída           |
|----------------------------------|-----------------|
| 2                                | 250.00          |
| 10.00, 30.00                     | 750.00          |
| 1000.00                          |                 |
| 200.00, 500.00                   |                 |
| 400.00, 800.00                   |                 |
|                                  |                 |
| 2                                | 150.00          |
| 10.00, 30.00                     | 200.00          |
| 800.00                           |                 |
| 30.00, 50.00                     |                 |
| 150.00, 200.00                   |                 |
|                                  |                 |
| 2                                | 300.00          |
| 20.00, 40.00                     | 600.00          |
| 1000.00                          |                 |
| 150.00, 250.00                   |                 |
| 300.00, 600.00                   |                 |

### Observações
- Os valores de alocação devem respeitar os limites mínimos e máximos estabelecidos.
- O valor total a ser investido deve ser distribuído proporcionalmente ao valor de mercado dos ativos.
