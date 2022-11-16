using ConsultaCatalogoStreaming.Models;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsultaCatalogoStreaming.Services
{
    public class MovieServices
    {
        private List<string> _streamings = new List<string>();
        public MovieServices()
        {
            _streamings.Add("netflix");
            _streamings.Add("prime"); 
            _streamings.Add("disney"); 
            _streamings.Add("hbo"); 
            _streamings.Add("hulu"); 
            _streamings.Add("peacock"); 
            _streamings.Add("paramount"); 
            _streamings.Add("starz"); 
            _streamings.Add("showtime"); 
            _streamings.Add("apple");  
            _streamings.Add("mubi"); 
        }

        public async Task<MovieResponse> SerchForAMovieAsync(string movieName)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "1dd5235fc0msh5f27ce0820fed68p10fec2jsnf61fe5e443d1");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "streaming-availability.p.rapidapi.com");

            MovieResponse movieResponse = new MovieResponse();

            foreach (var item in _streamings)
            {
                string resposta = await client.GetStringAsync("https://streaming-availability.p.rapidapi.com/search/basic?country=us&service=" + item  +  "&type=movie&keyword=El%20Camino%20&page=1&output_language=en&language=en");
                Results filme = JsonConvert.DeserializeObject<Results>(resposta);

                if (filme != null)
                {
                    //adicionar o link 
                }
               // movieResponse.TemNaNetflix = 
            } //nome do filme
            return movieResponse;
           
        }


    }
}
