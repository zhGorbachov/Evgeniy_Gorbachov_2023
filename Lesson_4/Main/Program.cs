using SingleResponsibility;

var customer = new Customer(1, "ASD", 1000);

customer.GetBalance();

customer.UpdateBalance(1500);

customer.GetBalance();