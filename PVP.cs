using System;
//COmo proyecto programacion de computadores
class JuegoCombate
{
    static void Main()
    {
        // Estadísticas iniciales
        int saludJugador = 100;
        int saludEnemigo = 100;
        Random dado = new Random();

        Console.WriteLine("¡Un Goblin salvaje ha aparecido!");

        // El bucle continúa mientras ambos estén vivos
        while (saludJugador > 0 && saludEnemigo > 0)
        {
            Console.WriteLine($"\nTu HP: {saludJugador} | Enemigo HP: {saludEnemigo}");
            Console.WriteLine("Presiona ENTER para atacar...");
            Console.ReadLine();

            // Turno del Jugador
            int dañoJugador = dado.Next(10, 21); // Daño entre 10 y 20
            saludEnemigo -= dañoJugador;
            Console.WriteLine($"-> Atacaste al Goblin por {dañoJugador} de daño.");

            if (saludEnemigo <= 0) break; // Si el enemigo muere, salimos del bucle

            // Turno del Enemigo
            int dañoEnemigo = dado.Next(5, 16); // Daño entre 5 y 15
            saludJugador -= dañoEnemigo;
            Console.WriteLine($"-> El Goblin te golpeó por {dañoEnemigo} de daño.");
        }

        // Resultado final
        if (saludJugador > 0)
            Console.WriteLine("\n¡Victoria! El Goblin ha sido derrotado.");
        else
            Console.WriteLine("\nHas caído en batalla... GAME OVER.");
    }
}
