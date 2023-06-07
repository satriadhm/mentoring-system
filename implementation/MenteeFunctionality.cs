using mentoring_system.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Protection.PlayReady;

namespace mentoring_system.Implementation
{
    internal class MenteeFunctionality
    {
        public static HttpClient client = new HttpClient();
        public static async Task AddMenteeData(string url, model.Mentee menteeData)
        {
            // Menambahkan data mentee baru ke server
            HttpResponseMessage response = await client.PostAsJsonAsync(url, menteeData);
            response.EnsureSuccessStatusCode();

            // Memastikan bahwa data mentee baru berhasil ditambahkan
            Debug.Assert(response.IsSuccessStatusCode, "Data mentee baru tidak berhasil ditambahkan");
        }


        public static async Task<Mentee> AuthenticateUser(string username, string password)
        {
            // Mengotentikasi pengguna dengan menggunakan username dan password
            var response = await client.GetAsync("http://178.128.215.35:5132/api/mentee");

            if (response != null && response.IsSuccessStatusCode)
            {
                var loggedInUser = default(Mentee);
                var result = await response.Content.ReadFromJsonAsync<Mentee[]>();

                foreach (var mentee in result)
                {
                    if (mentee.userName == username && mentee.password == password)
                    {
                        if (loggedInUser != null)
                        {
                            ShowMessageBox("Multiple users found with same credentials", "Login failed");
                            return null;
                        }
                        loggedInUser = mentee;
                    }
                }

                return loggedInUser;
            }

            return null;
        }


        private static void ShowMessageBox(string message, string title)
        {
            // Menampilkan dialog MessageBox dengan pesan dan judul tertentu
            MessageBox.Show(message, title);
        }
    }
}
