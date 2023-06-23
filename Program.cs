using claseJson;
using System.Net;
using System.Text.Json;

public class Program
{

    static void Main(string[] args)
    {
        GetPrecios();
    }


    //Metodo
    private static void GetPrecios()
    {
        //Esta línea define la URL de la API de Coindesk a la que se realizará la solicitud. La URL especificada devuelve un objeto JSON con los precios actuales de Bitcoin en diferentes monedas.
        var url = $"https://api.coindesk.com/v1/bpi/currentprice.json";
        
        //Crea una instancia de HttpWebRequest utilizando la URL especificada.
        var request = (HttpWebRequest)WebRequest.Create(url);
        //Establece el método de solicitud HTTP como GET.
        request.Method = "GET";
        //Establece el tipo de contenido de la solicitud como JSON.
        request.ContentType = "application/json";
        // Establece el tipo de contenido que se acepta en la respuesta como JSON.
        request.Accept = "application/json";
        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) { return; }

                     //Estas líneas realizan la solicitud HTTP y obtienen la respuesta. Si la respuesta es exitosa, se lee el contenido de la respuesta y se deserializa en un objeto CambioBTC utilizando la clase JsonSerializer de System.Text.Json. Luego, se muestra el símbolo y el precio de Bitcoin en diferentes monedas en la consola.
                    
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        CambioBTC moneda = JsonSerializer.Deserialize<CambioBTC>(responseBody);
                        Console.WriteLine("Moneda: " + moneda.bpi.EUR.description + " - Precio: " + moneda.bpi.EUR.rate_float);
                        Console.WriteLine("Moneda: " + moneda.bpi.GBP.description + " - Precio: " + moneda.bpi.GBP.rate_float);
                        Console.WriteLine("Moneda: " + moneda.bpi.USD.description + " - Precio: " + moneda.bpi.USD.rate_float);

                    }
                }
            }
        }
        catch (WebException ex)
        {
            Console.WriteLine("Problemas de acceso a la API");
        }
    }    
}
