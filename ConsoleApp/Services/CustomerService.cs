using ConsoleApp.DataAccess;
using ConsoleApp.DTOs.CustomerDTOs;
using ConsoleApp.Entities;

namespace ConsoleApp.Services;

public class CustomerService
{
    public void Create(CustomerCreateDTO customerCreateDTO)
    {
        Customer customer = new Customer();
        customer.Name = customerCreateDTO.Name;
        customer.Surname = customerCreateDTO.Surname;
        customer.Email = customerCreateDTO.Email;
        customer.Password = customerCreateDTO.Password;



        AppDbContext.customers.Add(customer);
    }

    public List<CustomerDTO> GetAll()
    {
        List<CustomerDTO> customersDTO = new List<CustomerDTO>();
        List<Customer> customerList = AppDbContext.customers;



        foreach (var customer in customerList)
        {

            CustomerDTO customerDTO = new();
            customerDTO.Name = customer.Name;
            customerDTO.Surname = customer.Surname; 
            customerDTO.Email = customer.Email;
            customerDTO.Id = customer.Id;

            customersDTO.Add(customerDTO);

        }

        return customersDTO;
    }



}
