export const digitalRoot = (n: number): number => {
  let sum: number = 0;
  for (let i = 0; i < n.toString().length; i++) {
    sum += parseInt(n.toString()[i]);
  }
  if (sum.toString().length > 1) return digitalRoot(sum);
  return sum;
};

//Other way:
export function digitalRoot2(n: number): number {
  return (n - 1) % 9 + 1;
}

export const digitalRoot3 = (n: number): number => {
  while (n >= 10) {
    n = n.toString()
      .split('')
      .map(x => parseInt(x))
      .reduce((a, b) => a + b, 0)
  }
  return n
};


// In this kata, you must create a digital root function.

// A digital root is the recursive sum of all the digits in a number. 
// Given n, take the sum of the digits of n. If that value has more than one digit, 
// continue reducing in this way until a single-digit number is produced. This is only applicable to the natural numbers.

// Here's how it works:

// digitalRoot(16)
// => 1 + 6
// => 7

// digitalRoot(942)
// => 9 + 4 + 2
// => 15 ...
// => 1 + 5
// => 6

// digitalRoot(132189)
// => 1 + 3 + 2 + 1 + 8 + 9
// => 24 ...
// => 2 + 4
// => 6

// digitalRoot(493193)
// => 4 + 9 + 3 + 1 + 9 + 3
// => 29 ...
// => 2 + 9
// => 11 ...
// => 1 + 1
// => 2