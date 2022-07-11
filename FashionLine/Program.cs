// See https://aka.ms/new-console-template for more information

using FashionLine.DB.Repositories;
using FashionLine.Domain;

var customer = new Customer { Name = "Jane Doe" };


var customerRepository = new CustomerRepository();


var fashLine = new FashionLine.Domain.FashionLine { Name = "Gwenyfar's Closet", Location = "South Korea" };
customer.FashionLine = fashLine;

var fashlineRepo = new FashionLineRepository();
fashlineRepo.Add(fashLine);

var customer1 = new Customer { Name = "John Doe", FashionLine = fashLine };
customerRepository.Add(customer1);
customerRepository.Update(customer);
