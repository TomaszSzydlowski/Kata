import { digitalRoot } from '../src/digitalRoot';
import { expect } from 'chai';

describe('solution', () => {
  it('should work for basic tests', () => {
    expect(digitalRoot(16)).to.equal(7);
  });
});

describe('solution', () => {
  it('should work for normal tests', () => {
    expect(digitalRoot(456)).to.equal(6);
  });
});