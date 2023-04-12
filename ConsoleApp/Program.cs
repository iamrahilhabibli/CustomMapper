using ConsoleApp.DTOs.CustomerDTOs;
using ConsoleApp.Entities;
using ConsoleApp.Helpers;
using ConsoleApp.Services;




CustomerService customerService = new CustomerService();

Customer cs1 = new();

CustomerCreateDTO customerCreateDTO = new CustomerCreateDTO();
customerCreateDTO.Name = "Tahir";
customerCreateDTO.Email = "tahir2000@gmail.com";
customerCreateDTO.Surname = "Hisynv";
customerCreateDTO.Password = "123456";


customerService.Create(customerCreateDTO);

//var customerss = customerService.GetAll();

//foreach (var item in customerss)
//{
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Surname);
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Email);
//}

Mapper newMapper = new Mapper();

newMapper.map<Customer>(customerCreateDTO);
