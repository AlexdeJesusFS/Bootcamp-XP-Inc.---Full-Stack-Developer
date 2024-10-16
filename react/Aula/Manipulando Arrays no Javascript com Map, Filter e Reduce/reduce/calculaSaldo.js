let saldo = 100;
let compras = [{'produto': 'sapatos', 'preco': 20}, {'produto': 'roupas', 'preco': 50}, {'produto': 'chapeus', 'preco': 15}];

function saldoFinal(saldo, compras) {
    return compras.reduce((acc, current) => acc-current.preco, saldo);
};

console.log('saldo final: ', saldoFinal(saldo, compras));
