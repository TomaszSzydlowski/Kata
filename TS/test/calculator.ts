import { Calculator } from '../src/calculator';
import { expect } from 'chai';

describe('calculator', () => {
  it('should initialise with a calculated a value of 0', () => {
    let calculator = new Calculator();
    expect(calculator.value).to.equal(0);
  })
})