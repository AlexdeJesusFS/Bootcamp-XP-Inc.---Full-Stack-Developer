const multiplier = {
    number: 3,
    multiply: function (array) {
        return array.map(num => num*this.number); 
    }
};

const numbers = [1,2,3,4,5,6,7,8,9];

console.log(multiplier.multiply(numbers));
