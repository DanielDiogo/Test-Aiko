using Test_Aiko.Data;
using Test_Aiko.Models;

namespace Test_Aiko.DatabaseInitialization
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Verifica se já existem dados nas tabelas
            if (context.Lines.Any() || context.stops.Any() || context.vehicles.Any() || context.vehiclesPositions.Any())
            {
                return;
            }

            var lines = new List<Line>
            {
                new Line { Name = "Linha Centro-Aeroporto" },
                new Line { Name = "Linha Praça-Aeroporto" }
            };
            context.Lines.AddRange(lines);
            context.SaveChanges();


            var stops = new List<Stop>
            {
                // Paradas da Linha Centro-Aeroporto
                new Stop { Name = "Mercado Público de Porto Alegre", Latitude = -30.0291, Longitude = -51.2305 },
                new Stop { Name = "Praça da Matriz", Latitude = -30.0299, Longitude = -51.2296 },
                new Stop { Name = "Usina do Gasômetro", Latitude = -30.0334, Longitude = -51.2282 },
                new Stop { Name = "Cais do Porto", Latitude = -30.0333, Longitude = -51.2261 },
                new Stop { Name = "Centro Cultural Banco do Brasil (CCBB)", Latitude = -30.0295, Longitude = -51.2299 },
                new Stop { Name = "Parque da Redenção (Farroupilha)", Latitude = -30.0379, Longitude = -51.2123 },
                new Stop { Name = "Estádio Beira-Rio (Internacional)", Latitude = -30.0550, Longitude = -51.1757 },
                new Stop { Name = "Shopping Praia de Belas", Latitude = -30.0387, Longitude = -51.2284 },
                new Stop { Name = "PUCRS (Pontifícia Universidade Católica do RS)", Latitude = -30.0691, Longitude = -51.1196 },
                new Stop { Name = "Aeroporto Internacional Salgado Filho", Latitude = -29.9897, Longitude = -51.1719 },

                // Paradas da Linha Praça-Aeroporto
                new Stop { Name = "Mercado Público de Porto Alegre", Latitude = -30.0291, Longitude = -51.2305 },
                new Stop { Name = "Praça da Alfândega", Latitude = -30.0307, Longitude = -51.2321 },
                new Stop { Name = "Casa de Cultura Mario Quintana", Latitude = -30.0333, Longitude = -51.2289 },
                new Stop { Name = "Parque Marinha do Brasil", Latitude = -30.0402, Longitude = -51.2290 },
                new Stop { Name = "Hospital Mãe de Deus", Latitude = -30.0327, Longitude = -51.2039 },
                new Stop { Name = "Shopping Iguatemi Porto Alegre", Latitude = -30.0269, Longitude = -51.1676 },
                new Stop { Name = "Bourbon Shopping Country", Latitude = -30.0206, Longitude = -51.1837 },
                new Stop { Name = "Parque Germânia", Latitude = -30.0098, Longitude = -51.1521 },
                new Stop { Name = "PUCRS (Pontifícia Universidade Católica do RS)", Latitude = -30.0691, Longitude = -51.1196 },
                new Stop { Name = "Aeroporto Internacional Salgado Filho", Latitude = -29.9897, Longitude = -51.1719 }
            };
            context.stops.AddRange(stops);
            context.SaveChanges();


            var vehicles = new List<Vehicle>
            {
                new Vehicle { Name = "Ônibus 1", Model = "Comil Svelto", LineId = 1 },
                new Vehicle { Name = "Ônibus 2", Model = "Marcopolo Torino", LineId = 2 }
            };
            context.vehicles.AddRange(vehicles);
            context.SaveChanges();

            var vehiclePositions = new List<VehiclePosition>
            {
                new VehiclePosition { Latitude = -30.0291, Longitude = -51.2305, VehicleId = 1 },
                new VehiclePosition { Latitude = -30.0291, Longitude = -51.2305, VehicleId = 2 }
                // Adicione mais posições conforme necessário
            };
            context.vehiclesPositions.AddRange(vehiclePositions);
            context.SaveChanges();
        }
    }
}
