﻿using BlazorHotelH2.Pages;
using DomainModels;
using Newtonsoft.Json;

namespace BlazorHotelH2.Services
{
    public class RoomService
    {
        string roomApi = "https://localhost:7036/api/Rooms";

        public async Task<List<Room>> GetAllRoomsAsync()
        {
            HttpClient roomClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            List<Room> allRooms = new List<Room>();

            string jsonData = "";

            try
            {
                response = await roomClient.GetAsync(roomApi);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                jsonData = await response.Content.ReadAsStringAsync();
                allRooms = JsonConvert.DeserializeObject<List<Room>>(jsonData);
                if (allRooms.Count > 0 )
                {
                    return allRooms;
                }
            }
            catch (Exception)
            {

                return null;
            }
            return null;
        }
    }
}