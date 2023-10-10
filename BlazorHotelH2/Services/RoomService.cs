using BlazorHotelH2.Pages;
using DomainModels;
using Newtonsoft.Json;
using System.Text;

namespace BlazorHotelH2.Services
{
    public class RoomService
    {
        //remember to change the call method to the specified CRUD operation you want to use
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
        public async Task<bool> DeleteRoomAsync(Room room)
        {
            roomApi = $"https://localhost:7036/api/Rooms/{room.Id}";

            HttpClient customerClient = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();


            try
            {
                response = await customerClient.DeleteAsync(roomApi);

                return response.IsSuccessStatusCode;
            }

            catch (Exception)
            {
                return false;
            }
        }



    }
}
