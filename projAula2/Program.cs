
using Controler;
using Models;
using System.ComponentModel.DataAnnotations;

//Console.WriteLine("Inicio do processamento");

    Car car = new Car
    {
      Id = 2,
      Name = "Carro Muito Legal",
      Color = "Vermelho",
      Year = 2925
    };

    Console.WriteLine(car);

    Console.WriteLine(new CarController().Insert(car) ? "Carro inserido com sucesso" : "Falha ao inserir carro");
        
    

