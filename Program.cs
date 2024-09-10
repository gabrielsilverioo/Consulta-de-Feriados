using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Feriado
{
    [JsonPropertyName("date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("localName")]
    public string LocalName { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; } = string.Empty;

    [JsonPropertyName("fixed")]
    public bool Fixed { get; set; }

    [JsonPropertyName("global")]
    public bool Global { get; set; }

    [JsonPropertyName("counties")]
    public List<string>? Counties { get; set; }

    [JsonPropertyName("launchYear")]
    public int? LaunchYear { get; set; }

    [JsonPropertyName("types")]
    public List<string>? Types { get; set; }
}

public class Program
{
    public static async Task Main(string[] args)
    {   
        System.Console.WriteLine("Informe o ano desejado: ");
        int ano = int.Parse(Console.ReadLine() ?? string.Empty);
        System.Console.WriteLine("Informe a sigla do país desejado: ");
        string pais = Console.ReadLine() ?? string.Empty;

        string url = $"https://date.nager.at/api/v3/PublicHolidays/{ano}/{pais.ToUpper()}";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Fazer a requisição HTTP GET e pegar a resposta
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Verificar se a resposta foi bem-sucedida

                // Ler o conteúdo da resposta como string
                string json = await response.Content.ReadAsStringAsync();

                // Deserializar o conteúdo JSON em uma lista de objetos Feriado
                List<Feriado>? feriados = JsonSerializer.Deserialize<List<Feriado>>(json);

                if (feriados != null)
                {
                    foreach (var feriado in feriados)
                    {
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine($" {feriado.LocalName} - {feriado.Date:dd-MM-yyyy}");
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar ou deserializar o JSON: {ex.Message}");
            }
        }
    }
}
