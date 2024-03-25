using Alura.Filmes;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine(@" _____             _             _            _         __ _ _                      
/  __ \           | |           | |          | |       / _(_) |                     
| /  \/ ___  _ __ | |_ _ __ ___ | | ___    __| | ___  | |_ _| |_ __ ___   ___  ___  
| |    / _ \| '_ \| __| '__/ _ \| |/ _ \  / _` |/ _ \ |  _| | | '_ ` _ \ / _ \/ __| 
| \__/\ (_) | | | | |_| | | (_) | |  __/ | (_| |  __/ | | | | | | | | | |  __/\__ \ 
 \____/\___/|_| |_|\__|_|  \___/|_|\___|  \__,_|\___| |_| |_|_|_| |_| |_|\___||___/ 
                                                                                    
                                                                                    ");
List<Filme> filmes = new List<Filme>();

MostrarMenu.Mostrar(filmes);

