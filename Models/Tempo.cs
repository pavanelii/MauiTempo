using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTempo.Models
{
    public class Tempo
    {
        public string? Title { get; set; }
        public string? Temperature { get; set; }
        public string? Wind { get; set; }
        public string? Humidity { get; set; }
        public string? Visibility { get; set; }
        public string? Sunrise { get; set; }
        public string? Sunset { get; set; }
        public string? Weather { get; set; }
        public string? WeatherDescription { get; set; }

        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public DateTime? HistoryDate { get; set; }
        public string Detalhes
        {
            get
            {
                return $"Humidade: {Humidity} \n" +
                       $"Nascer do Sol: {Sunrise} \n" +
                       $"Pôr do Sol: {Sunset} \n" +
                       $"Temperatura: {Temperature} \n" +
                       $"Título: {Title} \n" +
                       $"Visibilidade: {Visibility} \n" +
                       $"Vento: {Wind} \n" +
                       $"Previsão: {Weather} \n" +
                       $"Descrição: {WeatherDescription} \n" +
                       $"Latitude: {Latitude} \n" +
                       $"Longitude: {Longitude}";
            }
        }
    }

}
