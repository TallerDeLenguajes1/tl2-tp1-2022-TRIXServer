using System.Text.Json;
using System.Net;

public class functions
{
    public rootProvincias ApiProvincias(rootProvincias dataProvincias) {

        rootProvincias provinciasDeserializado = new rootProvincias();

        string url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
        var request = (HttpWebRequest) WebRequest.Create(url);

        request.Method = "GET";
        request.Accept = "application/json";
        request.ContentType = "application/json";

        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream reader = response.GetResponseStream())
                {
                    if(reader != null){

                        using (StreamReader objectReader = new StreamReader(reader))
                        {
                            string body = objectReader.ReadToEnd();
                            provinciasDeserializado = JsonSerializer.Deserialize<rootProvincias>(body);
                        }
                    }
                }
            }
        }
        catch (WebException ex)
        {
            Console.WriteLine($"Error al conectar a {url}");
        }

        return provinciasDeserializado;
    }
}