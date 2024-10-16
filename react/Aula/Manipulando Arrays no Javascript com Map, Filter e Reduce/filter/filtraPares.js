const numbers = [1,2,3,4,5,6,7,8,9];

const pairsNumbers = numbers.filter(number => number % 2 === 0);
const oddNumbers = numbers.filter(number => number % 2 !== 0);

console.log('numeros pares:');
pairsNumbers.forEach(n => {
    console.log(n)
});

console.log('numeros impares: ', oddNumbers);
