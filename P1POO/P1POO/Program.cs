
using p1bpoo.MisClases;

Vehiculo miCarrito = new Vehiculo(2022, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(1950, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2024, "Amarillo", "BYD");

CarroDeCombustion miMustang = new CarroDeCombustion(2020, "Azul", "Ford Mustang");

Motocicleta miMoto = new Motocicleta(2021, "Negro", "Honda CBR");

Camion miCamion = new Camion(2015, "Gris", "Hino");


Console.WriteLine("CARRO ELECTRICO");

Console.WriteLine("\t");
miBYD.InformacionVehiculo();
miBYD.encender();
miBYD.cargarBateria(23);
Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());
miBYD.acelerar(50);
miBYD.frenar(20);
Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());
miBYD.apagar();
Console.WriteLine("\t");

Console.WriteLine("CARRO CONBUSTION");

Console.WriteLine("\t");
miMustang.InformacionVehiculo();
miMustang.encender();
miMustang.cargarGasolina(100);
Console.WriteLine("Cargaste de gasolina 100");
miMustang.NivelGasolina();
Console.WriteLine("El nivel de gasolina es: {0}", miMustang.NivelGasolina());

Console.WriteLine("\t");

Console.WriteLine("Moticicleta");

Console.WriteLine("\t");
miMoto.InformacionVehiculo();
miMoto.encender();
miMoto.acelerar(100);
miMoto.frenar(100);
miMoto.Apagar();

Console.WriteLine("\t");
Console.WriteLine("Camion");
Console.WriteLine("\t");
miCamion.InformacionVehiculo();
miCamion.encender();
miCamion.acelerar(35);
miCamion.frenar(35);
miCamion.cargarGasolina(100);
miCamion.NivelGasolina();
Console.WriteLine("El nivel de gasolina es: {0}", miCamion.NivelGasolina());