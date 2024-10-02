//arrow functions
const sum = (n1, n2) => {
    return n1+n2;
};

console.log(sum(5, 5));


const numeros = [1, 2, 3, 4, 5];
//filtar valores que possuem resto de divisão = 0, numeros pares
const numerosPares = numeros.filter((numero) => numero % 2 === 0);
console.log(numerosPares); 

