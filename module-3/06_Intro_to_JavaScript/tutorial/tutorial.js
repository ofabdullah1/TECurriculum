// Step Two: Reassign a variable
function stepTwo() {
  let result = false;
  result = true;
  return result;
}

// Step Three: Add values to an array
function stepThree() {
  const values = [];
  values.push(false)
  values.push(5)
  values.push('yo')
  
  return values;
}

// Step Four: Round a number to two decimal places
function stepFour() {
  const twoThirds = 2 / 3;
  const roundedTwoThirds = Number.parseFloat(twoThirds.toFixed(2));
    return roundedTwoThirds;
}

// Step Five: Check for strict equality
function stepFive() {
  let answer;
  if (100 === '100') {
    answer = 'Yes';
  } else {
    answer = 'No';
  }
  return answer;
}

// Step Six: Iterate through an array
function stepSix() {
  const amounts = [10, 20, 30, 40];
  let sum = 0;

  for(let i = 0; i < amounts.length; i++){
    sum += amounts[i]
  }

  return sum;
}

// Step Seven: Add a property to an object
function stepSeven() {
  const iceCreamCone = {
    flavor: 'strawberry',
    coneType: 'waffle',
    numberOfScoops: 2
  }

  iceCreamCone.hasSprinkles = true;
  return iceCreamCone;
}