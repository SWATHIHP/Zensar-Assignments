function check_numbers(x, y) 
  {
  if ((x >= 50 && x <= 99) || (y >= 50 && y <= 99))
  {
    return true;
  } 
  else 
  {
    return false;
  }
}
console.log(check_numbers(15, 222));
console.log(check_numbers(45, 80));
console.log(check_numbers(22, 99));
console.log(check_numbers(8, 8));
